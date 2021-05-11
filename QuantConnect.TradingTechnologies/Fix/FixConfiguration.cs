/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using QuickFix;

namespace QuantConnect.TradingTechnologies.Fix
{
    public class FixConfiguration
    {
        // credentials
        public string UserName { get; set; }
        public string SessionPassword { get; set; }
        public string AccountName { get; set; }

        public string RestAppKey { get; set; }
        public string RestAppSecret { get; set; }
        public string RestEnvironment { get; set; }

        // QuickFix settings

        public string FixVersionString { get; set; } = "FIX.4.4";

        // market data session
        public string MarketDataSenderCompId { get; set; }
        public string MarketDataTargetCompId { get; set; }
        public string MarketDataHost { get; set; }
        public string MarketDataPort { get; set; }

        // order routing session
        public string OrderRoutingSenderCompId { get; set; }
        public string OrderRoutingTargetCompId { get; set; }
        public string OrderRoutingHost { get; set; }
        public string OrderRoutingPort { get; set; }

        public SessionSettings GetDefaultSessionSettings()
        {
            // http://www.quickfixengine.org/quickfix/doc/html/configuration.html

            var settings = new SessionSettings();

            var defaultDic = new Dictionary();
            defaultDic.SetString("ConnectionType", "initiator");
            defaultDic.SetString("ReconnectInterval", "30");
            defaultDic.SetString("FileStorePath", @"store");
            defaultDic.SetString("FileLogPath", "log");
            defaultDic.SetString("StartTime", "00:00:00");
            defaultDic.SetString("EndTime", "00:00:00");
            defaultDic.SetBool("UseDataDictionary", true);
            defaultDic.SetString("DataDictionary", @"TT/TT-FIX44.xml");
            defaultDic.SetString("BeginString", FixVersionString);
            defaultDic.SetString("TimeZone", "UTC");
            defaultDic.SetBool("UseLocalTime", false);
            defaultDic.SetBool("SendLogoutBeforeDisconnectFromTimeout", false);
            defaultDic.SetString("HeartBtInt", "30");
            defaultDic.SetString("LogonTimeout", "30");

            settings.Set(defaultDic);

            var orderRoutingDic = new Dictionary();
            orderRoutingDic.SetString("SenderCompID", OrderRoutingSenderCompId);
            orderRoutingDic.SetString("TargetCompID", OrderRoutingTargetCompId);
            orderRoutingDic.SetString("SocketConnectHost", OrderRoutingHost);
            orderRoutingDic.SetString("SocketConnectPort", OrderRoutingPort);

            var orderRoutingSessionId = new SessionID(FixVersionString, OrderRoutingSenderCompId, OrderRoutingTargetCompId);
            settings.Set(orderRoutingSessionId, orderRoutingDic);

            return settings;
        }

        public Dictionary GetMarketDataSessionSettings()
        {
            var marketDataDic = new Dictionary();
            marketDataDic.SetString("SenderCompID", MarketDataSenderCompId);
            marketDataDic.SetString("TargetCompID", MarketDataTargetCompId);
            marketDataDic.SetString("SocketConnectHost", MarketDataHost);
            marketDataDic.SetString("SocketConnectPort", MarketDataPort);

            return marketDataDic;
        }
    }
}
