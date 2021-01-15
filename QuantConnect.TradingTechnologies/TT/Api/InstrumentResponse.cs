/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System.Collections.Generic;
using Newtonsoft.Json;

namespace QuantConnect.TradingTechnologies.TT.Api
{
    [JsonObject]
    public class InstrumentResponse
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
        public List<Instrument> Instrument { get; set; }
    }

    [JsonObject]
    public class Instrument
    {
        [JsonProperty]
        public int RoundLotQty { get; set; }

        [JsonProperty]
        public string Term { get; set; }

        [JsonProperty]
        public int LastTradeDate { get; set; }

        [JsonProperty]
        public int MarketDepth { get; set; }

        [JsonProperty]
        public string ProductId { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string SecurityId { get; set; }

        [JsonProperty]
        public string Alias { get; set; }

        [JsonProperty]
        public int MarketId { get; set; }

        [JsonProperty]
        public string ProductSymbol { get; set; }

        [JsonProperty]
        public string ProductFamilyId { get; set; }

        [JsonProperty]
        public int ProductTypeId { get; set; }

        [JsonProperty]
        public decimal TickSize { get; set; }

        [JsonProperty]
        public long ExpirationDate { get; set; }

        [JsonProperty]
        public decimal PointValue { get; set; }

        [JsonProperty]
        public int SeriesTermId { get; set; }

        [JsonProperty]
        public string RicCode { get; set; }

        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public decimal DisplayFactor { get; set; }

        [JsonProperty]
        public decimal TickValue { get; set; }
    }
}