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
        private readonly TradingTechnologiesSymbolMapper _symbolMapper;
        private readonly FixConfiguration _fixConfiguration;
        private readonly IFixMarketDataController _fixMarketDataController;
        private readonly IFixBrokerageController _fixBrokerageController;

        private readonly ConcurrentDictionary<SessionID, ITTFixSessionHandler> _sessionHandlers = new ConcurrentDictionary<SessionID, ITTFixSessionHandler>();

        public TTFixProtocolDirector(
            TradingTechnologiesSymbolMapper symbolMapper,
            FixConfiguration fixConfiguration,
            IFixMarketDataController fixMarketDataController,
            IFixBrokerageController fixBrokerageController)
        {
            _symbolMapper = symbolMapper;
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
            Logging.Log.Trace($"OnLogon(): Adding handler for SessionId: {sessionId}");

            var session = new QuickFixSession(sessionId);
            var handler = CreateSessionHandler(sessionId.SenderCompID, sessionId.TargetCompID, session);
            _sessionHandlers[sessionId] = handler;
        }

        private ITTFixSessionHandler CreateSessionHandler(string senderCompId, string targetCompId, ISession session)
        {
            if (senderCompId == _fixConfiguration.MarketDataSenderCompId && targetCompId == _fixConfiguration.MarketDataTargetCompId)
            {
                return new TTMarketDataSessionHandler(_symbolMapper, session, _fixMarketDataController);
            }

            if (senderCompId == _fixConfiguration.OrderRoutingSenderCompId && targetCompId == _fixConfiguration.OrderRoutingTargetCompId)
            {
                return new TTOrderRoutingSessionHandler(_symbolMapper, session, _fixBrokerageController, _fixConfiguration.AccountName);
            }

            throw new Exception($"Unknown session senderCompId: '{senderCompId}'");
        }

        public void OnLogout(SessionID sessionId)
        {
            Logging.Log.Trace($"OnLogout(): Removing handler for SessionId: {sessionId}");

            if (_sessionHandlers.TryRemove(sessionId, out var handler))
            {
                if (sessionId.SenderCompID == _fixConfiguration.MarketDataSenderCompId && sessionId.TargetCompID == _fixConfiguration.MarketDataTargetCompId)
                {
                    _fixMarketDataController.Unregister((IFixOutboundMarketDataHandler)handler);
                }

                if (sessionId.SenderCompID == _fixConfiguration.OrderRoutingSenderCompId && sessionId.TargetCompID == _fixConfiguration.OrderRoutingTargetCompId)
                {
                    _fixBrokerageController.Unregister((IFixOutboundBrokerageHandler)handler);
                }
            }
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