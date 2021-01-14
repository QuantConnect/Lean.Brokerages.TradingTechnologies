/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QuantConnect.Logging;

namespace QuantConnect.TradingTechnologies.TT.Api
{
    /// <summary>
    /// Utilises TT's REST API to retrieve positions and other information.
    /// </summary>
    public class TTApiClient : IDisposable
    {
        private const string BaseUrl = "https://apigateway.trade.tt";

        private readonly string _appKey;
        private readonly string _appSecret;
        private readonly string _environment;

        private static readonly JsonSerializer Serializer = new JsonSerializer();
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly SemaphoreSlim _tokenLock = new SemaphoreSlim(1);
        private readonly string _tokenFile = Path.Combine(Environment.CurrentDirectory, "token.json");
        private TokenResponse _token;
        private bool _disposed;

        public TTApiClient(string appKey, string appSecret, string environment)
        {
            _appKey = appKey;
            _appSecret = appKey + ":" + appSecret;
            _environment = environment;

            _token = LoadToken(_tokenFile);
            if (_token != null) { }
        }

        public async Task<List<Position>> GetPositions()
        {
            var response = await RequestAsync<PositionsResponse>("ttmonitor", "position", AddRequestId(), "scaleQty=0").ConfigureAwait(false);
            return response?.Positions ?? new List<Position>(0);
        }

        public async Task<Instrument> GetInstrument(string instrumentId)
        {
            var response = await RequestAsync<InstrumentResponse>("ttpds", $"instrument/{instrumentId}", AddRequestId()).ConfigureAwait(false);
            return response?.Instrument.FirstOrDefault();
        }

        public async Task<List<Market>> GetMarkets()
        {
            var response = await RequestAsync<MarketsResponse>("ttpds", "markets", AddRequestId()).ConfigureAwait(false);
            return response?.Markets ?? new List<Market>(0);
        }

        public async Task<List<Currency>> GetCurrencies()
        {
            var response = await RequestAsync<ProductDataResponse>("ttpds", "productdata", AddRequestId()).ConfigureAwait(false);
            return response?.Currencies ?? new List<Currency>(0);
        }

        public async Task<List<ProductType>> GetProductTypes()
        {
            var response = await RequestAsync<ProductDataResponse>("ttpds", "productdata", AddRequestId()).ConfigureAwait(false);
            return response?.ProductTypes ?? new List<ProductType>(0);
        }

        /// <summary>
        ///     Verifies whether the current token is valid, or if another needs to be retrieved.
        /// </summary>
        /// <returns>If an API token is available.</returns>
        private async Task<bool> HasToken()
        {
            try
            {
                await _tokenLock.WaitAsync();
            }
            catch (ObjectDisposedException)
            {
                return false;
            }

            try
            {
                if (_token?.ExpiryTime != null && (_token.ExpiryTime.Value - DateTime.UtcNow).TotalMinutes >= 1)
                {
                    return true;
                }

                _token = await GetNewToken().ConfigureAwait(false);
                if (_token.ExpiryTime.HasValue)
                {
                    SaveToken(_token, _tokenFile);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Log.Error(e, "Unable to validate token.");
                return false;
            }
            finally
            {
                _tokenLock.Release();
            }
        }

        /// <summary>
        ///     Reads a token from disk.
        /// </summary>
        /// <param name="fileName">File to deserialize.</param>
        /// <returns>A deserialized token, or null.</returns>
        private static TokenResponse LoadToken(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Log.Trace("No cached token file exists: {0}", fileName);
                return null;
            }

            try
            {
                using (var fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (var stream = new StreamReader(fs))
                    {
                        using (var jsonStream = new JsonTextReader(stream))
                        {
                            var result = Serializer.Deserialize<TokenResponse>(jsonStream);
                            if (result?.ExpiryTime != null)
                            {
                                Log.Trace($"Loaded cached token - expiry: {result.ExpiryTime?.ToLocalTime()}");
                                return result;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error(e, $"Unable to deserialize file: {fileName}");
            }

            return null;
        }

        /// <summary>
        ///     Serializes a token to a file.
        /// </summary>
        /// <param name="token">Token to serialize</param>
        /// <param name="fileName">File to serialize to</param>
        private static void SaveToken(TokenResponse token, string fileName)
        {
            if (token == null)
            {
                return;
            }

            try
            {
                using (var fs = File.Open(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
                {
                    using (var stream = new StreamWriter(fs))
                    {
                        Serializer.Serialize(stream, token);
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error(e, $"Unable to serialize token to file: {fileName}");
            }
        }

        private string CreateUrl(string service, string function)
        {
            if (string.IsNullOrWhiteSpace(service))
            {
                throw new ArgumentNullException(nameof(service));
            }

            if (string.IsNullOrWhiteSpace(function))
            {
                throw new ArgumentNullException(nameof(function));
            }

            return $"{BaseUrl}/{service}/{_environment}/{function}";
        }

        private async Task<TokenResponse> GetNewToken()
        {
            using (var request = new HttpRequestMessage(HttpMethod.Post, CreateUrl("ttid", "token")))
            {
                request.Headers.Add("x-api-key", _appKey);
                request.Content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    ["grant_type"] = "user_app",
                    ["app_key"] = _appSecret
                });
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    return DeserializeJsonFromStream<TokenResponse>(stream);
                }
            }
        }

        private static string AddRequestId()
        {
            // Format: app-company--guid   (guid with hyphens).
            // TODO: Determine whether of 'app' and 'company' need to be valid for
            return "requestId=app-company--" + Guid.NewGuid().ToString("D");
        }

        private async Task<T> RequestAsync<T>(string service, string function, params string[] args) where T : class
        {
            if (!await HasToken().ConfigureAwait(false))
            {
                return null;
            }

            var url = $"{CreateUrl(service, function)}?{string.Join("&", args)}";
            using (var request = new HttpRequestMessage(HttpMethod.Get, url))
            {
                request.Headers.Add("x-api-key", _appKey);
                request.Headers.Add("Authorization", "Bearer " + _token.AccessToken);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    return DeserializeJsonFromStream<T>(stream);
                }
            }
        }

        private static T DeserializeJsonFromStream<T>(Stream stream)
        {
            if (stream == null || stream.CanRead == false)
            {
                return default;
            }

            using (var sr = new StreamReader(stream))
            using (var jtr = new JsonTextReader(sr))
            {
                // var json = sr.ReadToEnd();
                return Serializer.Deserialize<T>(jtr);
            }
        }

        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }

            _disposed = true;
            _tokenLock?.Dispose();
            _httpClient?.Dispose();
        }
    }
}