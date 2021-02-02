/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using QuickFix;

namespace QuantConnect.TradingTechnologies.Fix.Core
{
    /// <summary>
    ///     Interface for a FIX session.
    ///     Classes that use sessions should always utilise this interface, so-as to avoid a coupling to the main QuickFIXn
    ///     <see cref="Session" />.
    /// </summary>
    public interface ISession
    {
        bool Send(Message message);
    }
}