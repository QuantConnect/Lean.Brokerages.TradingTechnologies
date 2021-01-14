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
using QuantConnect.TradingTechnologies.Fix.Protocol;
using QuantConnect.TradingTechnologies.Fix.Utils;
using QuantConnect.TradingTechnologies.TT;
using QuantConnect.TradingTechnologies.TT.Api;
using QuantConnect.Util;
using BaseData = QuantConnect.Data.BaseData;

namespace QuantConnect.TradingTechnologies
{
    public class TradingTechnologiesBrokerage : Brokerage, IDataQueueHandler
    {
        private readonly IOrderProvider _orderProvider;
        private readonly IDataAggregator _aggregator;
        private readonly FixConfiguration _fixConfiguration;

        private readonly EventBasedDataQueueHandlerSubscriptionManager _subscriptionManager;
        private readonly IFixMarketDataController _fixMarketDataController = new FixMarketDataController();
        private readonly IFixBrokerageController _fixBrokerageController = new FixBrokerageController();
        private readonly IFixProtocolDirector _fixProtocolDirector;
        private readonly FixInstance _fixInstance;

        private readonly TTApiClient _apiClient;
        private readonly TradingTechnologiesSymbolMapper _symbolMapper;

        public TradingTechnologiesBrokerage(IOrderProvider orderProvider, IDataAggregator aggregator, FixConfiguration fixConfiguration)
            : base("TradingTechnologies")
        {
            _orderProvider = orderProvider;
            _aggregator = aggregator;
            _fixConfiguration = fixConfiguration;

            _subscriptionManager = new EventBasedDataQueueHandlerSubscriptionManager();
            _subscriptionManager.SubscribeImpl += (s, t) => Subscribe(s);
            _subscriptionManager.UnsubscribeImpl += (s, t) => Unsubscribe(s);

            _fixBrokerageController.ExecutionReport += OnExecutionReport;
            _fixProtocolDirector = new TTFixProtocolDirector(_fixConfiguration, _fixMarketDataController, _fixBrokerageController);

            _fixInstance = new FixInstance(_fixProtocolDirector, fixConfiguration);

            _apiClient = new TTApiClient(fixConfiguration.RestAppKey, fixConfiguration.RestAppSecret, fixConfiguration.RestEnvironment);
            _symbolMapper = new TradingTechnologiesSymbolMapper(_apiClient);
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
            if (!symbol.IsCanonical() && symbol.SecurityType != SecurityType.Future)
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
                var symbol = _symbolMapper.GetLeanSymbol(position.InstrumentId);

                var holding = new Holding
                {
                    AveragePrice = position.OpenAvgPrice ?? 0,
                    ConversionRate = 0,
                    CurrencySymbol = "",
                    MarketPrice = 0,
                    MarketValue = 0,
                    Quantity = position.NetPosition ?? 0,
                    Symbol = symbol,
                    Type = symbol.SecurityType,
                    UnrealizedPnL = 0
                };

                holdings.Add(holding);
            }

            return holdings;
        }

        private Symbol GetSymbol(string instrumentId)
        {
            // TODO: cache instruments in dictionary
            var instrument = _apiClient.GetInstrument(instrumentId).SynchronouslyAwaitTaskResult();

            return Symbol.Empty;
        }

        public override List<CashAmount> GetCashBalance()
        {
            // TODO:

            return new List<CashAmount>();
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

        private void OnExecutionReport(object sender, ExecutionReport e)
        {
            var orderStatus = Utility.ConvertOrderStatus(e);

            var orderId = orderStatus == OrderStatus.Canceled ? e.OrigClOrdID.getValue() : e.ClOrdID.getValue();
            var time = e.TransactTime.getValue();

            var order = _orderProvider.GetOrderByBrokerageId(orderId);
            if (order == null)
            {
                Log.Error($"TradingTechnologiesBrokerage.OnExecutionReport(): Unable to locate order with BrokerageId: {orderId}");
                return;
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
                var filledQuantity = e.LastShares.getValue();
                var remainingQuantity = order.AbsoluteQuantity - filledQuantity;

                orderEvent.FillQuantity = filledQuantity * (order.Direction == OrderDirection.Buy ? 1 : -1);
                orderEvent.FillPrice = e.LastPx.getValue();

                if (remainingQuantity > 0)
                {
                    orderEvent.Message += " - " + remainingQuantity + " remaining";
                }
            }

            Log.Trace($"Order event: {orderEvent}");

            OnOrderEvent(orderEvent);
        }

    }
}
