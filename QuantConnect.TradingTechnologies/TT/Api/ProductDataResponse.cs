/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System.Collections.Generic;
using Newtonsoft.Json;

namespace QuantConnect.Brokerages.TradingTechnologies.TT.Api
{
    [JsonObject]
    public class ProductDataResponse
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
        public List<Currency> Currencies { get; set; }

        [JsonProperty]
        public List<ProductType> ProductTypes { get; set; }
    }

    [JsonObject]
    public class Currency
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string Desc { get; set; }
    }

    [JsonObject]
    public class ProductType
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string Desc { get; set; }
    }
}