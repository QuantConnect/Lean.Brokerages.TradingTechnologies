/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Linq;
using System.Threading;
using QuantConnect.TradingTechnologies.Fix.LogFactory;
using QuantConnect.TradingTechnologies.Fix.Protocol;
using QuickFix;
using QuickFix.Transport;

namespace QuantConnect.TradingTechnologies.Fix
{
    /// <summary>
    ///     Essentially, an instance of a single QuickFIXn configuration.
    ///     This includes multiple sessions, such as in the case of TT requiring multiple for different functions.
    /// </summary>
    public class FixInstance : IApplication, IDisposable
    {
        private readonly IFixProtocolDirector _protocolDirector;
        private readonly SocketInitiator _acceptor;

        private bool _disposed;

        public bool IsConnected()
        {
            return !_acceptor.IsStopped &&
                   _acceptor.GetSessionIDs()
                        .Select(Session.LookupSession)
                        .All(session => session != null && session.IsLoggedOn);
        }

        public FixInstance(IFixProtocolDirector protocolDirector, FixConfiguration fixConfiguration, bool logFixMessages)
        {
            _protocolDirector = protocolDirector ?? throw new ArgumentNullException(nameof(protocolDirector));

            var settings = fixConfiguration.GetSessionSettings();

            var storeFactory = new FileStoreFactory(settings);
            var logFactory = new QuickFixLogFactory(logFixMessages);
            _acceptor = new SocketInitiator(this, storeFactory, settings, logFactory, protocolDirector.MessageFactory);
        }

        public void Initialise()
        {
            if (_acceptor.IsStopped)
            {
                _acceptor.Start();

                var start = DateTime.UtcNow;
                while (!IsConnected() || !_protocolDirector.AreSessionsReady())
                {
                    if (DateTime.UtcNow > start.AddSeconds(60))
                    {
                        throw new TimeoutException("Timeout initializing FIX sessions.");
                    }

                    Thread.Sleep(1000);
                }
            }
        }

        public void FromApp(Message msg, SessionID sessionId)
        {
            try
            {
                _protocolDirector.Handle(msg, sessionId);
            }
            catch (UnsupportedMessageType e)
            {
                Logging.Log.Error(e, $"[{sessionId}] Unknown message: {msg.GetType().Name}: {msg}");
            }
        }

        public void OnCreate(SessionID sessionId) { }

        public void OnLogout(SessionID sessionId)
        {
            _protocolDirector.OnLogout(sessionId);
        }

        public void OnLogon(SessionID sessionId)
        {
            _protocolDirector.OnLogon(sessionId);
        }

        public void FromAdmin(Message msg, SessionID sessionId) { }

        public void ToAdmin(Message msg, SessionID sessionId)
        {
            _protocolDirector.EnrichOutbound(msg);
        }

        public void ToApp(Message msg, SessionID sessionId) { }

        public void Terminate()
        {
            if (!_acceptor.IsStopped)
            {
                _acceptor.Stop();
            }
        }

        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }

            _disposed = true;
            _acceptor.Dispose();
        }
    }
}