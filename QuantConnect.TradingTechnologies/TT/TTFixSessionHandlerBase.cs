/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Diagnostics.CodeAnalysis;
using QuantConnect.Fix.TT;
using QuantConnect.Fix.TT.FIX44.Messages;
using QuantConnect.TradingTechnologies.Fix.Utils;
using QuickFix;

namespace QuantConnect.TradingTechnologies.TT
{
    public abstract class TTFixSessionHandlerBase : MessageCracker, ITTFixSessionHandler
    {
        public bool IsReady { get; protected set; }

        [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Used in cracking messages")]
        public void OnMessage(News news, SessionID sessionId)
        {
            var headline = news.IsSetHeadline() ? news.Headline.getValue() : "<no-headline>";
            Logging.Log.Trace("[{0}] OnMessage: {1} = {2}: {3}", sessionId, news.GetType().Name, headline, news.IsSetText() ? news.Text.getValue() : "<no-text>");

            if (string.Equals(headline, "Recovery Complete", StringComparison.InvariantCultureIgnoreCase))
            {
                OnRecoveryCompleted();
            }
        }

        protected virtual void OnRecoveryCompleted() { }

        [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Used in cracking messages")]
        public void OnMessage(BusinessMessageReject msg, SessionID sessionId)
        {
            var reason = msg.BusinessRejectReason.DescribeInt(msg.IsSetBusinessRejectReason());
            Logging.Log.Error("[{0}] {1}: {2}: {3}", sessionId, msg.GetType().Name, reason, msg.IsSetText() ? msg.Text.getValue() : "<none>");
        }
    }
}