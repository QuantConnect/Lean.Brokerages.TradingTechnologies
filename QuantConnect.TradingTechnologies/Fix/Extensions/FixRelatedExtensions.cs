/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using QuantConnect.Fix.TT.FIX44.Fields;
using QuantConnect.Fix.TT.FIX44.Messages;

namespace QuantConnect.TradingTechnologies.Fix.Extensions
{
    public static class FixRelatedExtensions
    {
        public static bool IsInitialStatusRequest(this ExecutionReport er)
        {
            return er.IsSetTotalNumOrders() || er.IsSetExecTransType() && er.ExecTransType.getValue() == ExecTransType.STATUS;
        }

        public static string ToUtcTimestamp(this DateTime dateTime)
        {
            // See: https://fixwiki.org/fixwiki/UTCTimestampDataType
            return dateTime.ToString("yyyyMMdd-HH:mm:ss.fff");
        }
    }
}