/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using QuantConnect.Data.Market;
using QuantConnect.Brokerages.TradingTechnologies.Fix.Protocol;

namespace QuantConnect.Brokerages.TradingTechnologies.Fix.Core
{
    /// <summary>
    ///     Controls market-data related communication between QC and a FIX protocol implementation.
    /// </summary>
    public interface IFixMarketDataController
    {
        event EventHandler<Tick> NewTick;

        /// <summary>
        ///     Registers a market data handler to this controller.
        /// </summary>
        /// <param name="handler">Handler to register</param>
        void Register(IFixOutboundMarketDataHandler handler);

        /// <summary>
        ///     Unregisters a market data handler from this controller.
        /// </summary>
        /// <param name="handler">Handler to register</param>
        void Unregister(IFixOutboundMarketDataHandler handler);

        /// <summary>
        ///     Subscribe to market data for a symbol.
        /// </summary>
        /// <param name="input">(Demonstrative).  Console input. Will be replaced by QC objects.</param>
        void Subscribe(Symbol symbol);

        /// <summary>
        ///     Unsubscribe to market data for a symbol.
        /// </summary>
        /// <param name="input">(Demonstrative).  Console input. Will be replaced by QC objects.</param>
        void Unsubscribe(Symbol symbol);

        /// <summary>
        ///     Receives market data.
        /// </summary>
        /// <param name="dataSet">Parsed market data</param>
        // TODO: Decide whether communication from a handler back to the controller should be done via an event.
        void Receive(Tick tick);
    }
}