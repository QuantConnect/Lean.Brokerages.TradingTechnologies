/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using QuantConnect.Fix.TT.FIX44.Fields;

namespace QuantConnect.Brokerages.TradingTechnologies.TT
{
    public enum TTMarketDataType
    {
        Ask = MDEntryType.ASK,
        Bid = MDEntryType.BID,
        LastTraded = MDEntryType.LAST_TRADED,
        OpenInterest = MDEntryType.OPEN_INTEREST,
        Trade = MDEntryType.TRADE
    }

    public enum TTUpdateType
    {
        New = MDUpdateAction.NEW,
        Change = MDUpdateAction.CHANGE,
        Delete = MDUpdateAction.DELETE
    }
}