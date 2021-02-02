/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Globalization;

namespace QuantConnect.TradingTechnologies.TT
{
    /// <summary>
    ///     Helper for TT order ids.  Generates unique ids per session.
    /// </summary>
    public static class TTOrderId
    {
        public static string GetNext()
        {
            return Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture);
        }
    }
}