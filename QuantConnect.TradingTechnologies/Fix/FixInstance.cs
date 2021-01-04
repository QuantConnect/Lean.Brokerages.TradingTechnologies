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
    // TODO: Decide on the name.
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

        public FixInstance(IFixProtocolDirector protocolDirector, FixConfiguration fixConfiguration)
        {
            _protocolDirector = protocolDirector ?? throw new ArgumentNullException(nameof(protocolDirector));

            var settings = fixConfiguration.GetSessionSettings();

            var storeFactory = new FileStoreFactory(settings);
            var logFactory = new QuickFixLogFactory();
            _acceptor = new SocketInitiator(this, storeFactory, settings, logFactory, protocolDirector.MessageFactory);
        }

        // TODO: Decide if the director should be passed in here instead, allowing QCQuickFix to have a parameter-less constructor.
        public void Initialise()
        {
            if (_acceptor.IsStopped)
            {
                _acceptor.Start();

                while (!IsConnected() || !_protocolDirector.AreSessionsReady())
                {
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