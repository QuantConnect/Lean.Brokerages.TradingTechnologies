using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QuantConnect.Logging;

namespace QuantConnect.Fix.TT.Position
{
    /// <summary>
    ///     Utilises TT's REST API to retrieve positions from.
    /// </summary>
    public class TTPositionsProvider : IDisposable
    {
        // TODO: Move app keys into an external configuration file.
        private const string AppKey = ""; //TODO: ""de3f2502-c5bb-ff55-6487-923aa0780510";
        private const string Secret = ""; //TODO: AppKey + ":31e87f27-3246-d004-08f9-02cbe1566522";
        private const string BaseUrl = "https://apigateway.trade.tt";
        // TODO: Create a switch for the environment.
        private const string Environment = "ext_uat_cert";
        private static readonly JsonSerializer Serializer = new JsonSerializer();
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly SemaphoreSlim _tokenLock = new SemaphoreSlim(1);
        private readonly string _tokenFile = Path.Combine(System.Environment.CurrentDirectory, "token.json");
        private TokenResponse _token;
        private bool _disposed;

        public TTPositionsProvider()
        {
            _token = LoadToken(_tokenFile);
            if (_token != null) { }
        }

        public async Task<List<Position>> GetPositions()
        {
            var response = await RequestAsync<PositionsResponse>("monitor", "position", AddRequestId(), "scaleQty=0").ConfigureAwait(false);
            return response?.Positions ?? new List<Position>(0);
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

        private static string CreateUrl(string service, string function)
        {
            if (string.IsNullOrWhiteSpace(service))
            {
                throw new ArgumentNullException(nameof(service));
            }

            if (string.IsNullOrWhiteSpace(function))
            {
                throw new ArgumentNullException(nameof(function));
            }

            return $"{BaseUrl}/{service}/{Environment}/{function}";
        }

        private async Task<TokenResponse> GetNewToken()
        {
            using (var request = new HttpRequestMessage(HttpMethod.Post, CreateUrl("ttid", "token")))
            {
                request.Headers.Add("x-api-key", AppKey);
                request.Content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    ["grant_type"] = "user_app",
                    ["app_key"] = Secret
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
                request.Headers.Add("x-api-key", AppKey);
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