/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using QuickFix;

namespace QuantConnect.Brokerages.TradingTechnologies.Fix.Protocol
{
    /// <summary>
    ///     Applies protocol specific customizations, and helps direct FIX messages to specific handlers.
    /// </summary>
    public interface IFixProtocolDirector
    {
        /// <summary>
        ///     Returns true if all sessions are logged in and ready to accept order routing requests.
        /// </summary>
        bool AreSessionsReady();

        /// <summary>
        ///     Defines the FIX protocol being used.
        /// </summary>
        IMessageFactory MessageFactory { get; }

        /// <summary>
        ///     Pass a message to the director to be handled.
        /// </summary>
        /// <param name="msg">Message to process</param>
        /// <param name="sessionId">Session the message is from</param>
        void Handle(Message msg, SessionID sessionId);

        /// <summary>
        ///     Allow for enrichment / customization of any outgoing messages (such as logon).
        /// </summary>
        /// <param name="msg">Message to customize.</param>
        void EnrichOutbound(Message msg);

        /// <summary>
        ///     Called when a session logs on.
        /// </summary>
        /// <param name="sessionId"></param>
        void OnLogon(SessionID sessionId);

        /// <summary>
        ///     Called when a session logs out.
        /// </summary>
        /// <param name="sessionId"></param>
        void OnLogout(SessionID sessionId);
    }
}