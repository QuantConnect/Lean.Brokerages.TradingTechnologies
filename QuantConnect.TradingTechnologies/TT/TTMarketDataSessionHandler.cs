/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Threading;
using NodaTime;
using QuantConnect.Data.Market;
using QuantConnect.Fix.TT.FIX44.Fields;
using QuantConnect.Fix.TT.FIX44.Messages;
using QuantConnect.Securities;
using QuantConnect.TradingTechnologies.Fix.Core;
using QuantConnect.TradingTechnologies.Fix.Extensions;
using QuantConnect.TradingTechnologies.Fix.Protocol;
using QuantConnect.TradingTechnologies.Fix.Utils;
using QuantConnect.Util;
using QuickFix;
using SecurityExchange = QuantConnect.Fix.TT.FIX44.Fields.SecurityExchange;

namespace QuantConnect.TradingTechnologies.TT
{
    /// <summary>
    ///     Handler for TT Market Data FIX sessions.
    /// </summary>
    public class TTMarketDataSessionHandler : TTFixSessionHandlerBase, IFixOutboundMarketDataHandler
    {
        private readonly TradingTechnologiesSymbolMapper _symbolMapper;
        private readonly ISession _session;
        private readonly IFixMarketDataController _fixMarketDataController;
        private int _nextRequestId;

        private readonly ConcurrentDictionary<string, SubscriptionEntry> _subscriptions = new ConcurrentDictionary<string, SubscriptionEntry>();

        // exchange time zones by symbol
        private readonly Dictionary<Symbol, DateTimeZone> _symbolExchangeTimeZones = new Dictionary<Symbol, DateTimeZone>();

        public TTMarketDataSessionHandler(TradingTechnologiesSymbolMapper symbolMapper, ISession session, IFixMarketDataController fixMarketDataController)
        {
            _symbolMapper = symbolMapper;
            _session = session ?? throw new ArgumentNullException(nameof(session));
            _fixMarketDataController = fixMarketDataController ?? throw new ArgumentNullException(nameof(fixMarketDataController));
            _fixMarketDataController.Register(this);
        }

        protected override void OnRecoveryCompleted()
        {
            IsReady = true;
        }

        [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Used in cracking messages")]
        public void OnMessage(MarketDataSnapshot marketDataSnapshot, SessionID _)
        {
            var groups = marketDataSnapshot.ReadGroups<NoMDEntries, MarketDataSnapshot.NoMDEntriesGroup>();
            var requestId = marketDataSnapshot.MDReqID.getValue();

            try
            {
                foreach (var group in groups)
                {
                    var mdType = (TTMarketDataType) group.MDEntryType.getValue();

                    switch (mdType)
                    {
                        case TTMarketDataType.Ask:
                            {
                                if (_subscriptions.TryGetValue(requestId, out var entry))
                                {
                                    entry.AskPrice = group.MDEntryPx.getValue();
                                    entry.AskSize = group.MDEntrySize.getValue();
                                    EmitQuoteTick(entry);
                                }
                            }
                            break;

                        case TTMarketDataType.Bid:
                            {
                                if (_subscriptions.TryGetValue(requestId, out var entry))
                                {
                                    entry.BidPrice = group.MDEntryPx.getValue();
                                    entry.BidSize = group.MDEntrySize.getValue();
                                    EmitQuoteTick(entry);
                                }
                            }
                            break;

                        case TTMarketDataType.LastTraded:
                            break;

                        case TTMarketDataType.OpenInterest:
                            break;

                        case TTMarketDataType.Trade:
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(mdType), mdType, "Unhandled market data type: " + mdType);
                    }
                }

                // Data can then be sent into the main market data handler.
                if (_subscriptions.TryGetValue(requestId, out var subscriptionEntry))
                {
                    EmitQuoteTick(subscriptionEntry);
                }
            }
            catch (Exception e)
            {
                Logging.Log.Error(e, $"Unable to create ladder for {requestId}");
            }
        }

        [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Used in cracking messages")]
        public void OnMessage(MarketDataIncrementalRefresh incrementalRefresh, SessionID _)
        {
            try
            {
                var requestId = incrementalRefresh.MDReqID.getValue();

                var groups = incrementalRefresh.ReadGroups<NoMDEntries, MarketDataIncrementalRefresh.NoMDEntriesGroup>();
                foreach (var group in groups)
                {
                    try
                    {
                        ProcessUpdate(requestId, group);
                    }
                    catch (Exception e)
                    {
                        Logging.Log.Error(e, $"Unable to process group: {group}");
                    }
                }
            }
            catch (Exception e)
            {
                Logging.Log.Error(e, $"Unable to process message: {incrementalRefresh}");
            }
        }

        private void ProcessUpdate(string requestId, MarketDataIncrementalRefresh.NoMDEntriesGroup group)
        {
            var updateType = (TTUpdateType) group.MDUpdateAction.getValue();
            var mdType = (TTMarketDataType) group.MDEntryType.getValue();

            switch (updateType)
            {
                case TTUpdateType.New:
                case TTUpdateType.Change:
                    switch (mdType)
                    {
                        case TTMarketDataType.Ask:
                            if (group.IsSetSecurityType())
                            {
                                if (_subscriptions.TryGetValue(requestId, out var entry))
                                {
                                    entry.AskPrice = group.MDEntryPx.getValue();
                                    entry.AskSize = group.MDEntrySize.getValue();
                                    EmitQuoteTick(entry);
                                }
                            }
                            break;

                        case TTMarketDataType.Bid:
                            if (group.IsSetSecurityType())
                            {
                                if (_subscriptions.TryGetValue(requestId, out var entry))
                                {
                                    entry.BidPrice = group.MDEntryPx.getValue();
                                    entry.BidSize = group.MDEntrySize.getValue();
                                    EmitQuoteTick(entry);
                                }
                            }
                            break;

                        case TTMarketDataType.LastTraded:
                            break;

                        case TTMarketDataType.OpenInterest:
                            break;

                        case TTMarketDataType.Trade:
                            if (group.IsSetSecurityType())
                            {
                                if (_subscriptions.TryGetValue(requestId, out var entry))
                                {
                                    entry.LastPrice = group.MDEntryPx.getValue();
                                    entry.LastSize = group.MDEntrySize.getValue();
                                    EmitTradeTick(entry);
                                }
                            }
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(mdType), mdType, "Unhandled market data type: " + mdType);
                    }

                    break;
                case TTUpdateType.Delete:
                    switch (mdType)
                    {
                        case TTMarketDataType.Ask:
                            break;
                        case TTMarketDataType.Bid:
                            break;
                        case TTMarketDataType.LastTraded:
                            break;
                        case TTMarketDataType.OpenInterest:
                            break;
                        case TTMarketDataType.Trade:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(mdType), mdType, "Unhandled market data type: " + mdType);
                    }

                    break;
                default:
                    return;
            }
        }

        public bool SubscribeToSymbol(Symbol symbol)
        {
            var requestId = Interlocked.Increment(ref _nextRequestId).ToString(CultureInfo.InvariantCulture);

            var ticker = symbol.ID.Symbol;

            var securityType = new QuantConnect.Fix.TT.FIX44.Fields.SecurityType(_symbolMapper.GetBrokerageProductType(symbol.SecurityType));
            var securityExchange = new SecurityExchange(_symbolMapper.GetBrokerageMarket(symbol.ID.Market, symbol.SecurityType));

            Logging.Log.Trace($"Subscribing to: {ticker}-{symbol.Value}-{securityType.getValue()}-{securityExchange.getValue()}, RequestId: {requestId}");

            var marketDataRequest = new MarketDataRequest
            {
                MDReqID = new MDReqID(requestId),
                SubscriptionRequestType = new SubscriptionRequestType(SubscriptionRequestType.SNAPSHOT_PLUS_UPDATES),
                MDUpdateType = new MDUpdateType(MDUpdateType.INCREMENTAL_REFRESH),
                IncludeQuotes = new IncludeQuotes(true),
                IncludeNumberOfOrders = new IncludeNumberOfOrders(IncludeNumberOfOrders.YES),
                MarketDepth = new MarketDepth(MarketDepth.TOP_OF_BOOK)
            };

            // Add fields
            marketDataRequest.AddGroup<MarketDataRequest.NoMDEntryTypesGroup, MDEntryType, TTMarketDataType>();

            // Add symbols
            var symbolsGroup = new MarketDataRequest.NoRelatedSymGroup
            {
                Symbol = new QuantConnect.Fix.TT.FIX44.Fields.Symbol(ticker),
                SecurityType = securityType,
                SecurityExchange = securityExchange
            };

            if (symbol.SecurityType == SecurityType.Future)
            {
                // TODO: update when Market.CFE is added to LEAN
                if (symbol.ID.Market == Market.CBOE)
                {
                    symbolsGroup.MaturityDate = Utility.GetMaturityDate(symbol);
                }
                else
                {
                    symbolsGroup.MaturityMonthYear = Utility.GetMaturityMonthYear(symbol);
                }
            }

            marketDataRequest.AddGroup(symbolsGroup);

            _subscriptions.TryAdd(requestId, new SubscriptionEntry { Symbol = symbol });

            return _session.Send(marketDataRequest);
        }

        public bool UnsubscribeFromSymbol(Symbol symbol)
        {
            var requestId = Interlocked.Increment(ref _nextRequestId).ToString(CultureInfo.InvariantCulture);

            var ticker = symbol.ID.Symbol;

            var securityType = new QuantConnect.Fix.TT.FIX44.Fields.SecurityType(_symbolMapper.GetBrokerageProductType(symbol.SecurityType));
            var securityExchange = new SecurityExchange(_symbolMapper.GetBrokerageMarket(symbol.ID.Market, symbol.SecurityType));

            Logging.Log.Trace($"Unsubscribing from: {ticker}-{symbol.Value}-{securityType.getValue()}-{securityExchange.getValue()}, RequestId: {requestId}");

            var marketDataRequest = new MarketDataRequest
            {
                MDReqID = new MDReqID(requestId),
                SubscriptionRequestType = new SubscriptionRequestType(SubscriptionRequestType.DISABLE_PREVIOUS_SNAPSHOT_PLUS_UPDATE_REQUEST),
            };

            // Add fields
            marketDataRequest.AddGroup<MarketDataRequest.NoMDEntryTypesGroup, MDEntryType, TTMarketDataType>();

            // Add symbols
            var symbolsGroup = new MarketDataRequest.NoRelatedSymGroup
            {
                Symbol = new QuantConnect.Fix.TT.FIX44.Fields.Symbol(ticker),
                SecurityType = securityType,
                SecurityExchange = securityExchange
            };

            if (symbol.SecurityType == SecurityType.Future)
            {
                // TODO: update when Market.CFE is added to LEAN
                if (symbol.ID.Market == Market.CBOE)
                {
                    symbolsGroup.MaturityDate = Utility.GetMaturityDate(symbol);
                }
                else
                {
                    symbolsGroup.MaturityMonthYear = Utility.GetMaturityMonthYear(symbol);
                }
            }

            marketDataRequest.AddGroup(symbolsGroup);

            var subscribeRequestId = string.Empty;
            foreach (var kvp in _subscriptions)
            {
                if (kvp.Value.Symbol == symbol)
                {
                    subscribeRequestId = kvp.Key;
                    break;
                }
            }

            if (!subscribeRequestId.IsNullOrEmpty())
            {
                _subscriptions.TryRemove(subscribeRequestId, out _);
            }

            return _session.Send(marketDataRequest);
        }

        private void EmitQuoteTick(SubscriptionEntry subscriptionEntry)
        {
            if (subscriptionEntry.BidPrice > 0 && subscriptionEntry.BidSize > 0 &&
                subscriptionEntry.AskPrice > 0 && subscriptionEntry.AskSize > 0 &&
                subscriptionEntry.BidPrice < subscriptionEntry.AskPrice)
            {
                var displayFactor = _symbolMapper.GetDisplayFactor(subscriptionEntry.Symbol);

                var tick = new Tick
                {
                    TickType = TickType.Quote,
                    EndTime = GetTickTime(subscriptionEntry.Symbol, DateTime.UtcNow),
                    Symbol = subscriptionEntry.Symbol,
                    BidPrice = subscriptionEntry.BidPrice * displayFactor,
                    BidSize = subscriptionEntry.BidSize,
                    AskPrice = subscriptionEntry.AskPrice * displayFactor,
                    AskSize = subscriptionEntry.AskSize
                };

                _fixMarketDataController.Receive(tick);
            }
        }

        private void EmitTradeTick(SubscriptionEntry subscriptionEntry)
        {
            var displayFactor = _symbolMapper.GetDisplayFactor(subscriptionEntry.Symbol);

            var tick = new Tick
            {
                TickType = TickType.Trade,
                EndTime = GetTickTime(subscriptionEntry.Symbol, DateTime.UtcNow),
                Symbol = subscriptionEntry.Symbol,
                Value = subscriptionEntry.LastPrice * displayFactor,
                Quantity = subscriptionEntry.LastSize
            };

            _fixMarketDataController.Receive(tick);
        }

        /// <summary>
        /// Returns a timestamp for a tick converted to the exchange time zone
        /// </summary>
        private DateTime GetTickTime(Symbol symbol, DateTime time)
        {
            if (!_symbolExchangeTimeZones.TryGetValue(symbol, out var exchangeTimeZone))
            {
                // read the exchange time zone from market-hours-database
                exchangeTimeZone = MarketHoursDatabase.FromDataFolder().GetExchangeHours(symbol.ID.Market, symbol, symbol.SecurityType).TimeZone;
                _symbolExchangeTimeZones.Add(symbol, exchangeTimeZone);
            }

            return time.ConvertFromUtc(exchangeTimeZone);
        }

        private class SubscriptionEntry
        {
            public Symbol Symbol { get; set; }

            public decimal BidPrice { get; set; }
            public decimal BidSize { get; set; }

            public decimal AskPrice { get; set; }
            public decimal AskSize { get; set; }

            public decimal LastPrice { get; set; }
            public decimal LastSize { get; set; }
        }
    }
}