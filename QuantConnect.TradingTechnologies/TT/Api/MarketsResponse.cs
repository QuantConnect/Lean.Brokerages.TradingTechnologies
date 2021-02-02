/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System.Collections.Generic;
using Newtonsoft.Json;

namespace QuantConnect.TradingTechnologies.TT.Api
{
    [JsonObject]
    public class MarketsResponse
    {
        [JsonProperty]
        public string Status { get; set; }

        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }

        [JsonProperty]
        public int StatusCode { get; set; }

        [JsonProperty]
        public string NextPageKey { get; set; }

        [JsonProperty]
        public string LastPage { get; set; }

        [JsonProperty]
        public List<Market> Markets { get; set; }
    }

    [JsonObject]
    public class Market
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string Name { get; set; }
    }
}