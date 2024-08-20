/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using Newtonsoft.Json;

namespace QuantConnect.Brokerages.TradingTechnologies.TT.Api
{
    public class TokenResponse
    {
        private int? _secondsUntilExpiry;

        [JsonProperty]
        public string Status { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("seconds_until_expiry")]
        public int? SecondsUntilExpiry
        {
            get => _secondsUntilExpiry;
            set
            {
                _secondsUntilExpiry = value;
                ExpiryTime = _secondsUntilExpiry.HasValue ? DateTime.UtcNow.AddSeconds(_secondsUntilExpiry.Value) : (DateTime?) null;
            }
        }

        [JsonIgnore]
        public DateTime? ExpiryTime { get; private set; }
    }
}