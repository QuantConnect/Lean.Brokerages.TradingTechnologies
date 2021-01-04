/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Concurrent;
using System.Linq;
using QuantConnect.Fix.TT.FIX44.Fields;
using QuantConnect.Fix.TT.FIX44.Messages;
using QuantConnect.TradingTechnologies.Fix;
using QuantConnect.TradingTechnologies.Fix.Core;
using QuantConnect.TradingTechnologies.Fix.Protocol;
using QuickFix;
using Message = QuickFix.Message;

namespace QuantConnect.TradingTechnologies.TT
{
    public class TTFixProtocolDirector : IFixProtocolDirector
    {
        // TODO: Decide whether SessionHandlers & management of sessions could move into QCQuickFix instead.
        private readonly ConcurrentDictionary<SessionID, ITTFixSessionHandler> _sessionHandlers = new ConcurrentDictionary<SessionID, ITTFixSessionHandler>();
        private readonly FixConfiguration _fixConfiguration;
        private readonly IFixMarketDataController _fixMarketDataController;
        private readonly IFixBrokerageController _fixBrokerageController;

        public TTFixProtocolDirector(FixConfiguration fixConfiguration, IFixMarketDataController fixMarketDataController, IFixBrokerageController fixBrokerageController)
        {
            _fixConfiguration = fixConfiguration;
            _fixMarketDataController = fixMarketDataController ?? throw new ArgumentNullException(nameof(fixMarketDataController));
            _fixBrokerageController = fixBrokerageController ?? throw new ArgumentNullException(nameof(fixBrokerageController));
        }

        public IMessageFactory MessageFactory { get; } = new MessageFactory();

        public bool AreSessionsReady()
        {
            return _sessionHandlers.Values.All(handler => handler.IsReady);
        }

        public void OnLogon(SessionID sessionId)
        {
            Console.WriteLine($"OnLogon(): SessionId: {sessionId}");

            var session = new QuickFixSession(sessionId);
            var handler = CreateSessionHandler(sessionId.SenderCompID, session);
            _sessionHandlers[sessionId] = handler;
        }

        private ITTFixSessionHandler CreateSessionHandler(string senderCompId, ISession session)
        {
            if (senderCompId == _fixConfiguration.MarketDataSenderCompId)
            {
                return new TTMarketDataSessionHandler(session, _fixMarketDataController);
            }

            if (senderCompId == _fixConfiguration.OrderRoutingSenderCompId)
            {
                return new TTOrderRoutingSessionHandler(session, _fixBrokerageController, _fixConfiguration.AccountName);
            }

            throw new Exception($"Unknown session senderCompId: '{senderCompId}'");
        }

        public void OnLogout(SessionID sessionId)
        {
            Console.WriteLine($"OnLogout(): SessionId: {sessionId}");

            Logging.Log.Trace("Removing handler for session: " + sessionId);
            _sessionHandlers.TryRemove(sessionId, out _);
        }

        public void Handle(Message msg, SessionID sessionId)
        {
            if (!_sessionHandlers.TryGetValue(sessionId, out var handler))
            {
                Logging.Log.Error("Unknown session: " + sessionId);
                return;
            }

            try
            {
                handler.Crack(msg, sessionId);
            }
            catch (Exception e)
            {
                Logging.Log.Error(e, $"[{sessionId}] Unable to process message {msg.GetType().Name}: {msg}");
            }
        }

        public void EnrichOutbound(Message msg)
        {
            switch (msg)
            {
                case Logon logon:
                    logon.SetField(new RawData(_fixConfiguration.SessionPassword));
                    logon.SetField(new ResetSeqNumFlag(ResetSeqNumFlag.YES));
                    logon.SetField(new MsgSeqNum(1));
                    logon.SetField(new EncryptMethod(EncryptMethod.NONE));
                    logon.SetField(new UserName(_fixConfiguration.UserName));
                    logon.SetField(new UserType(UserType.TRADING_FIRM));
                    break;
            }
        }
    }
}