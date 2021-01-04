/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Concurrent;
using QuickFix;

namespace QuantConnect.TradingTechnologies.Fix.LogFactory
{
    public class QuickFixLogFactory : ILogFactory
    {
        private static readonly ConcurrentDictionary<SessionID, ILog> Loggers = new ConcurrentDictionary<SessionID, ILog>();

        public ILog Create(SessionID sessionId)
        {
            return Loggers.GetOrAdd(sessionId, s => new QuickFixLogger(s));
        }
    }

    public class QuickFixLogger : ILog
    {
        public QuickFixLogger(SessionID sessionId)
        {
            if (sessionId == null)
            {
                throw new ArgumentNullException(nameof(sessionId));
            }
        }

        public void Clear() { }

        public void OnIncoming(string msg)
        {
            Logging.Log.Trace("[incoming] {0}", msg);
        }

        public void OnOutgoing(string msg)
        {
            Logging.Log.Trace("[outgoing] {0}", msg);
        }

        public void OnEvent(string s)
        {
            Logging.Log.Trace("[   event] {0}", s);
        }

        public void Dispose()
        {
        }
    }
}