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
        private readonly bool _logFixMessages;

        public QuickFixLogFactory(bool logFixMessages)
        {
            _logFixMessages = logFixMessages;
        }

        public ILog Create(SessionID sessionId)
        {
            return Loggers.GetOrAdd(sessionId, s => new QuickFixLogger(s, _logFixMessages));
        }
    }

    public class QuickFixLogger : ILog
    {
        private readonly bool _fixLoggingEnabled;

        public QuickFixLogger(SessionID sessionId, bool logFixMessages)
        {
            if (sessionId == null)
            {
                throw new ArgumentNullException(nameof(sessionId));
            }

            _fixLoggingEnabled = logFixMessages;
        }

        public void Clear() { }

        public void OnIncoming(string msg)
        {
            if (_fixLoggingEnabled)
            {
                Logging.Log.Trace($"[incoming] {msg.Replace('\x1', '|')}", true);
            }
        }

        public void OnOutgoing(string msg)
        {
            if (_fixLoggingEnabled)
            {
                Logging.Log.Trace($"[outgoing] {msg.Replace('\x1', '|')}", true);
            }
        }

        public void OnEvent(string s)
        {
            if (_fixLoggingEnabled)
            {
                Logging.Log.Trace($"[   event] {s.Replace('\x1', '|')}", true);
            }
        }

        public void Dispose()
        {
        }
    }
}