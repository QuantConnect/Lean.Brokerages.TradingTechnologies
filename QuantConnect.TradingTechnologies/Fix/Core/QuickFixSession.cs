/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using QuickFix;

namespace QuantConnect.Brokerages.TradingTechnologies.Fix.Core
{
    /// <summary>
    ///     Session that passes calls to a QuickFIXn <see cref="Session" />
    /// </summary>
    public class QuickFixSession : ISession
    {
        private readonly Session _session;

        public QuickFixSession(SessionID sessionId)
        {
            if (sessionId == null)
            {
                throw new ArgumentNullException(nameof(sessionId));
            }

            _session = Session.LookupSession(sessionId) ?? throw new SessionNotFound(sessionId);
        }

        public bool Send(Message message)
        {
            return _session.Send(message);
        }
    }
}