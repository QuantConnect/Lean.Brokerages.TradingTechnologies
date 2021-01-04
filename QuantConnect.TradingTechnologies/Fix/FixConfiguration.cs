/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

namespace QuantConnect.TradingTechnologies.Fix
{
    public class FixConfiguration
    {
        public string UserName { get; set; }
        public string SessionPassword { get; set; }
        public string AccountName { get; set; }

        public string MarketDataSenderCompId { get; set; }
        public string OrderRoutingSenderCompId { get; set; }
    }
}
