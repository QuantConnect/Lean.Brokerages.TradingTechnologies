using System.Collections.Generic;
using Newtonsoft.Json;

namespace QuantConnect.Fix.TT.Position
{
    [JsonObject]
    public class PositionsResponse
    {
        [JsonProperty]
        public string Status { get; set; }

        [JsonProperty]
        public List<Position> Positions { get; set; }
    }

    [JsonObject]
    public class Position
    {
        [JsonProperty]
        public string InstrumentId { get; set; }

        [JsonProperty]
        public decimal? Pnl { get; set; }

        [JsonProperty]
        public decimal? PnlPrice { get; set; }

        [JsonProperty]
        public string PnlPriceType { get; set; }

        [JsonProperty]
        public decimal? RealizedPnl { get; set; }

        [JsonProperty]
        public decimal? BuyFillQty { get; set; }

        [JsonProperty]
        public decimal? SellFillQty { get; set; }

        [JsonProperty]
        public decimal? NetPosition { get; set; }

        [JsonProperty]
        public decimal? BuyWorkingQty { get; set; }

        [JsonProperty]
        public decimal? SellWorkingQty { get; set; }

        [JsonProperty]
        public decimal? AvgBuy { get; set; }

        [JsonProperty]
        public decimal? AvgSell { get; set; }

        [JsonProperty]
        public decimal? OpenAvgPrice { get; set; }

        [JsonProperty]
        public decimal? SodPrice { get; set; }

        [JsonProperty]
        public string SodPriceType { get; set; }

        [JsonProperty]
        public decimal? SodNetPos { get; set; }

        [JsonProperty]
        public decimal? AccountId { get; set; }
    }
}