/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using QuickFix;

namespace QuantConnect.TradingTechnologies.TT
{
    internal interface ITTFixSessionHandler
    {
        bool IsReady { get; }

        void Crack(Message message, SessionID sessionId);
    }
}