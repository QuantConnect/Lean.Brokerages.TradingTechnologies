/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QuantConnect.Logging;
using QuantConnect.Util;

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

        private readonly RateGate _rateLimiter = new RateGate(3, TimeSpan.FromSeconds(1));

        private static readonly JsonSerializer Serializer = new JsonSerializer();
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly SemaphoreSlim _tokenLock = new SemaphoreSlim(1);
        private TokenResponse _token;
        private bool _disposed;

        public TTApiClient(string appKey, string appSecret, string environment)
        {
            _appKey = appKey;
            _appSecret = appKey + ":" + appSecret;
            _environment = environment;
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

        public async Task<List<Product>> GetProducts(string marketId)
        {
            var response = await RequestAsync<ProductsResponse>("ttpds", "products", AddRequestId(), $"marketId={marketId}").ConfigureAwait(false);
            return response?.Products ?? new List<Product>(0);
        }

        public async Task<List<Instrument>> GetInstruments(string productTypeId, string productId)
        {
            var response = await RequestAsync<InstrumentsResponse>("ttpds", "instruments", AddRequestId(), $"productTypeId={productTypeId}", $"productId={productId}").ConfigureAwait(false);
            return response?.Instruments ?? new List<Instrument>(0);
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
                return _token.ExpiryTime.HasValue;
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
            CheckRateLimiting();

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
            return "requestId=app-company--" + Guid.NewGuid().ToString("D", CultureInfo.InvariantCulture);
        }

        private async Task<T> RequestAsync<T>(string service, string function, params string[] args) where T : class
        {
            if (!await HasToken().ConfigureAwait(false))
            {
                Log.Error($"RequestAsync({service}, {function}): failed because no token is available");
                return null;
            }

            CheckRateLimiting();

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
                return Serializer.Deserialize<T>(jtr);
            }
        }

        private void CheckRateLimiting()
        {
            if (!_rateLimiter.WaitToProceed(TimeSpan.Zero))
            {
                _rateLimiter.WaitToProceed();
            }
        }
    }
}