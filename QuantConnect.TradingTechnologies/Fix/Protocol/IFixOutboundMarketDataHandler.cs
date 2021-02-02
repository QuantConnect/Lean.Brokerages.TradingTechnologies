/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

namespace QuantConnect.TradingTechnologies.Fix.Protocol
{
    /// <summary>
    ///     Defines a class that can perform actions related to market data for a specific FIX version.
    /// </summary>
    public interface IFixOutboundMarketDataHandler
    {
        /// <summary>
        ///     Subscribes to a symbol for market data.
        /// </summary>
        /// <param name="symbol">Symbol to subscribe to</param>
        /// <returns>Whether the request was successful</returns>
        bool SubscribeToSymbol(Symbol symbol);

        /// <summary>
        ///     Unsubscribes from a symbol for market data.
        /// </summary>
        /// <param name="symbol">Symbol to unsubscribe from</param>
        /// <returns>Whether the request was successful</returns>
        bool UnsubscribeFromSymbol(Symbol symbol);
    }
}