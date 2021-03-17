/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using QuantConnect.Brokerages;
using QuantConnect.Data;
using QuantConnect.Fix.TT.FIX44.Messages;
using QuantConnect.Interfaces;
using QuantConnect.Logging;
using QuantConnect.Orders;
using QuantConnect.Orders.Fees;
using QuantConnect.Packets;
using QuantConnect.Securities;
using QuantConnect.TradingTechnologies.Fix;
using QuantConnect.TradingTechnologies.Fix.Core;
using QuantConnect.TradingTechnologies.Fix.Utils;
using QuantConnect.TradingTechnologies.TT;
using QuantConnect.TradingTechnologies.TT.Api;
using QuantConnect.Util;
using BaseData = QuantConnect.Data.BaseData;

namespace QuantConnect.TradingTechnologies
{
    public class TradingTechnologiesBrokerage : Brokerage, IDataQueueHandler, IDataQueueUniverseProvider
    {
        private readonly IAlgorithm _algorithm;
        private readonly LiveNodePacket _job;
        private readonly IOrderProvider _orderProvider;
        private readonly IDataAggregator _aggregator;

        private bool _cashInitialized;

        private readonly EventBasedDataQueueHandlerSubscriptionManager _subscriptionManager;
        private readonly IFixMarketDataController _fixMarketDataController;
        private readonly IFixBrokerageController _fixBrokerageController;
        private readonly FixInstance _fixInstance;

        private readonly TTApiClient _apiClient;
        private readonly TradingTechnologiesSymbolMapper _symbolMapper;
        private readonly SymbolPropertiesDatabase _symbolPropertiesDatabase = SymbolPropertiesDatabase.FromDataFolder();

        public TradingTechnologiesBrokerage(IAlgorithm algorithm, LiveNodePacket job, IOrderProvider orderProvider, IDataAggregator aggregator, FixConfiguration fixConfiguration, bool logFixMessages)
            : base("TradingTechnologies")
        {
            _algorithm = algorithm;
            _job = job;
            _orderProvider = orderProvider;
            _aggregator = aggregator;

            _subscriptionManager = new EventBasedDataQueueHandlerSubscriptionManager();
            _subscriptionManager.SubscribeImpl += (s, t) => Subscribe(s);
            _subscriptionManager.UnsubscribeImpl += (s, t) => Unsubscribe(s);

            _apiClient = new TTApiClient(fixConfiguration.RestAppKey, fixConfiguration.RestAppSecret, fixConfiguration.RestEnvironment);
            _symbolMapper = new TradingTechnologiesSymbolMapper(_apiClient);

            _fixMarketDataController = new FixMarketDataController();
            _fixMarketDataController.NewTick += OnNewTick;

            _fixBrokerageController = new FixBrokerageController(_symbolMapper);
            _fixBrokerageController.ExecutionReport += OnExecutionReport;

            var fixProtocolDirector = new TTFixProtocolDirector(_symbolMapper, fixConfiguration, _fixMarketDataController, _fixBrokerageController);

            _fixInstance = new FixInstance(fixProtocolDirector, fixConfiguration, logFixMessages);
        }

        /// <summary>
        /// Subscribe to the specified configuration
        /// </summary>
        /// <param name="dataConfig">defines the parameters to subscribe to a data feed</param>
        /// <param name="newDataAvailableHandler">handler to be fired on new data available</param>
        /// <returns>The new enumerator for this subscription request</returns>
        public IEnumerator<BaseData> Subscribe(SubscriptionDataConfig dataConfig, EventHandler newDataAvailableHandler)
        {
            if (!CanSubscribe(dataConfig.Symbol))
            {
                return Enumerable.Empty<BaseData>().GetEnumerator();
            }

            var enumerator = _aggregator.Add(dataConfig, newDataAvailableHandler);
            _subscriptionManager.Subscribe(dataConfig);

            return enumerator;
        }

        /// <summary>
        /// Removes the specified configuration
        /// </summary>
        /// <param name="dataConfig">Subscription config to be removed</param>
        public void Unsubscribe(SubscriptionDataConfig dataConfig)
        {
            _subscriptionManager.Unsubscribe(dataConfig);
            _aggregator.Remove(dataConfig);
        }

        private bool CanSubscribe(Symbol symbol)
        {
            if (symbol.IsCanonical() || symbol.SecurityType != SecurityType.Future)
            {
                return false;
            }

            return true;
        }

        private bool Subscribe(IEnumerable<Symbol> symbols)
        {
            foreach (var symbol in symbols)
            {
                _fixMarketDataController.Subscribe(symbol);
            }

            return true;
        }

        private bool Unsubscribe(IEnumerable<Symbol> symbols)
        {
            foreach (var symbol in symbols)
            {
                _fixMarketDataController.Unsubscribe(symbol);
            }

            return true;
        }

        public void SetJob(LiveNodePacket job)
        {
        }

        public override bool IsConnected => _fixInstance.IsConnected();

        public override List<Order> GetOpenOrders()
        {
            _fixBrokerageController.RequestOpenOrders();

            return _fixBrokerageController.GetOpenOrders();
        }

        public override List<Holding> GetAccountHoldings()
        {
            var holdings = new List<Holding>();

            var positions = _apiClient.GetPositions().SynchronouslyAwaitTaskResult();

            foreach (var position in positions)
            {
                if (!position.NetPosition.HasValue || position.NetPosition.Value == 0)
                {
                    continue;
                }

                var symbol = _symbolMapper.GetLeanSymbol(position.InstrumentId);

                var currencySymbol = Currencies.GetCurrencySymbol(
                    _symbolPropertiesDatabase.GetSymbolProperties(symbol.ID.Market, symbol, symbol.SecurityType, Currencies.USD).QuoteCurrency);

                var displayFactor = _symbolMapper.GetDisplayFactor(symbol);

                var holding = new Holding
                {
                    Symbol = symbol,
                    Type = symbol.SecurityType,
                    Quantity = position.NetPosition.Value,
                    AveragePrice = position.OpenAvgPrice * displayFactor ?? 0,
                    MarketPrice = position.PnlPrice * displayFactor ?? 0,
                    CurrencySymbol = currencySymbol
                };

                holdings.Add(holding);
            }

            return holdings;
        }

        public override List<CashAmount> GetCashBalance()
        {
            // TODO: waiting for TT feedback

            if (!_cashInitialized)
            {
                // really only want to return the value on the first request
                _cashInitialized = true;

                if (!_job.BrokerageData.TryGetValue("tt-initial-cash-amount", out var initialCashAmount) ||
                    string.IsNullOrWhiteSpace(initialCashAmount) ||
                    !_job.BrokerageData.TryGetValue("tt-initial-cash-currency", out var initialCashCurrency) ||
                    string.IsNullOrWhiteSpace(initialCashCurrency))
                {
                    throw new ArgumentException("Initial TradingTechnologies cash balance not defined.");
                }

                return new List<CashAmount> { new CashAmount(Parse.Decimal(initialCashAmount), initialCashCurrency) };
            }

            return _algorithm.Portfolio.CashBook.Select(x => new CashAmount(x.Value.Amount, x.Value.Symbol)).ToList();
        }

        public override bool PlaceOrder(Order order)
        {
            return _fixBrokerageController.PlaceOrder(order);
        }

        public override bool UpdateOrder(Order order)
        {
            return _fixBrokerageController.UpdateOrder(order);
        }

        public override bool CancelOrder(Order order)
        {
            return _fixBrokerageController.CancelOrder(order);
        }

        public override void Connect()
        {
            _fixInstance.Initialise();
        }

        public override void Disconnect()
        {
            _fixInstance.Terminate();
        }

        public override void Dispose()
        {
            _fixInstance.DisposeSafely();
        }

        public IEnumerable<Symbol> LookupSymbols(Symbol symbol, bool includeExpired, string securityCurrency = null)
        {
            if (symbol.SecurityType == SecurityType.Future)
            {
                // TODO: fetch from TT REST API

                //var productTypeId = _symbolMapper.GetBrokerageProductTypeId(symbol.SecurityType);
                //var marketId = _symbolMapper.GetBrokerageMarketId(symbol.ID.Market);

                //var products = _apiClient.GetProducts(marketId).SynchronouslyAwaitTaskResult();

                //var product = products
                //    .FirstOrDefault(x => x.Symbol == symbol.ID.Symbol && x.ProductTypeId == productTypeId);

                //if (product != null)
                //{
                //    var instruments = _apiClient.GetInstruments(product.ProductTypeId, product.Id).SynchronouslyAwaitTaskResult();

                //    foreach (var instrument in instruments)
                //    {
                //        var expiryDate = DateTime.ParseExact(
                //            instrument.ExpirationDate.ToString(CultureInfo.InvariantCulture),
                //            "yyyyMMddHHmmss",
                //            CultureInfo.InvariantCulture).Date;

                //        yield return Symbol.CreateFuture(symbol.ID.Symbol, symbol.ID.Market, expiryDate);
                //    }
                //}
            }

            return Enumerable.Empty<Symbol>();
        }

        public bool CanPerformSelection()
        {
            return true;
        }

        private void OnExecutionReport(object sender, ExecutionReport e)
        {
            var orderStatus = Utility.ConvertOrderStatus(e);

            var orderId = orderStatus == OrderStatus.Canceled || orderStatus == OrderStatus.UpdateSubmitted
                ? e.OrigClOrdID.getValue()
                : e.ClOrdID.getValue();
            var time = e.TransactTime.getValue();

            var order = _orderProvider.GetOrderByBrokerageId(orderId);
            if (order == null)
            {
                Log.Error($"TradingTechnologiesBrokerage.OnExecutionReport(): Unable to locate order with BrokerageId: {orderId}");
                return;
            }

            if (orderStatus == OrderStatus.UpdateSubmitted)
            {
                order.BrokerId[0] = e.ClOrdID.getValue();
            }

            var message = "Trading Technologies Order Event";
            if (e.IsSetText())
            {
                message += $" - {e.Text.getValue()}";
            }

            var orderEvent = new OrderEvent(order, time, OrderFee.Zero, message)
            {
                Status = orderStatus
            };

            if (orderStatus == OrderStatus.Filled || orderStatus == OrderStatus.PartiallyFilled)
            {
                var displayFactor = _symbolMapper.GetDisplayFactor(order.Symbol);

                var filledQuantity = e.LastShares.getValue();
                var remainingQuantity = order.AbsoluteQuantity - e.CumQty.getValue();

                orderEvent.FillQuantity = filledQuantity * (order.Direction == OrderDirection.Buy ? 1 : -1);
                orderEvent.FillPrice = e.LastPx.getValue() * displayFactor;

                if (remainingQuantity > 0)
                {
                    orderEvent.Message += " - " + remainingQuantity + " remaining";
                }
            }

            OnOrderEvent(orderEvent);
        }

        private void OnNewTick(object sender, Data.Market.Tick e)
        {
            _aggregator.Update(e);
        }
    }
}
