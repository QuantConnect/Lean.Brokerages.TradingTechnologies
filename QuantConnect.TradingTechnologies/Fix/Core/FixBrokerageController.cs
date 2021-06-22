/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using QuantConnect.Fix.TT.FIX44.Fields;
using QuantConnect.Fix.TT.FIX44.Messages;
using QuantConnect.Logging;
using QuantConnect.Orders;
using QuantConnect.TradingTechnologies.Fix.Extensions;
using QuantConnect.TradingTechnologies.Fix.Protocol;
using QuantConnect.TradingTechnologies.Fix.Utils;

namespace QuantConnect.TradingTechnologies.Fix.Core
{
    /// <summary>
    ///     Generic communication controller between Lean and a FIX session that can handle order-related tasks.
    /// </summary>
    public class FixBrokerageController : IFixBrokerageController, IDisposable
    {
        private readonly TradingTechnologiesSymbolMapper _symbolMapper;
        private readonly ConcurrentDictionary<string, ExecutionReport> _orders = new ConcurrentDictionary<string, ExecutionReport>();
        private readonly ManualResetEvent _getOpenOrdersResetEvent = new ManualResetEvent(false);
        private IFixOutboundBrokerageHandler _handler;

        public event EventHandler<ExecutionReport> ExecutionReport;

        public FixBrokerageController(TradingTechnologiesSymbolMapper symbolMapper)
        {
            _symbolMapper = symbolMapper;
        }

        public bool RequestOpenOrders()
        {
            _getOpenOrdersResetEvent.Reset();

            if (!_handler.RequestOpenOrders())
            {
                Log.Error("Failed to send a request for open orders.");
                return false;
            }

            if (!_getOpenOrdersResetEvent.WaitOne(TimeSpan.FromSeconds(5)))
            {
                Log.Error("Timeout waiting for open orders.");
                return false;
            }

            return true;
        }

        public bool PlaceOrder(Order order)
        {
            return _handler.PlaceOrder(order);
        }

        public bool UpdateOrder(Order order)
        {
            return _handler.UpdateOrder(order);
        }

        public List<Order> GetOpenOrders()
        {
            return _orders.Values
                .Select(ConvertOrder)
                .Where(x => x.Status.IsOpen())
                .ToList();
        }

        public bool CancelOrder(Order order)
        {
            return _handler.CancelOrder(order);
        }

        public void OnOpenOrdersReceived()
        {
            Log.Trace("All orders have been received.");

            _getOpenOrdersResetEvent.Set();
        }

        public void Register(IFixOutboundBrokerageHandler handler)
        {
            if (handler == null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            if (_handler != null)
            {
                throw new Exception(
                    $"A handler has already been registered: {_handler.GetType().FullName}#{_handler.GetHashCode()}, received: {handler.GetType().FullName}#{handler.GetHashCode()}");
            }

            _handler = handler;
        }

        public void Unregister(IFixOutboundBrokerageHandler handler)
        {
            if (handler == null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            if (_handler == null || handler != _handler)
            {
                throw new Exception(
                    $"The handler has not been registered: {handler.GetType().FullName}#{handler.GetHashCode()}");
            }

            _handler = null;
        }

        public void Receive(ExecutionReport execution)
        {
            if (execution == null)
            {
                throw new ArgumentNullException(nameof(execution));
            }

            var orderId = execution.ClOrdID.getValue();
            var orderStatus = execution.OrdStatus.getValue();
            if (orderStatus != OrdStatus.REJECTED)
            {
                _orders[orderId] = execution;
            }
            else
            {
                _orders.TryRemove(orderId, out _);
            }

            if (!execution.IsInitialStatusRequest())
            {
                ExecutionReport?.Invoke(this, execution);
            }
        }

        private Order ConvertOrder(ExecutionReport er)
        {
            if (er == null)
            {
                throw new ArgumentNullException(nameof(er));
            }

            var ticker = _symbolMapper.GetLeanTicker(er.Symbol.getValue());
            var securityType = _symbolMapper.GetLeanSecurityType(er.SecurityType.getValue());
            var market = _symbolMapper.GetLeanMarket(securityType, er.SecurityExchange.getValue(), ticker);

            Symbol symbol;
            if (securityType == SecurityType.Future)
            {
                var expiryDate = DateTime.ParseExact(er.MaturityDate.getValue(), "yyyyMMdd", CultureInfo.InvariantCulture);
                symbol = Symbol.CreateFuture(ticker, market, expiryDate);
            }
            else
            {
                // TODO: other security types
                throw new NotSupportedException($"Unsupported security type: {securityType}");
            }

            var displayFactor = _symbolMapper.GetDisplayFactor(symbol);

            var orderQuantity = er.OrderQty.getValue();
            var orderSide = er.Side.getValue();
            if (orderSide == Side.SELL)
            {
                orderQuantity = -orderQuantity;
            }

            var time = er.TransactTime.getValue();
            var orderType = Utility.ConvertOrderType(er.OrdType.getValue());
            var timeInForce = Utility.ConvertTimeInForce(er.TimeInForce.getValue());

            Order order;
            switch (orderType)
            {
                case OrderType.Market:
                    order = new MarketOrder();
                    break;

                case OrderType.Limit:
                    {
                        var limitPrice = er.Price.getValue() * displayFactor;
                        order = new LimitOrder(symbol, orderQuantity, limitPrice, time);
                    }
                    break;

                case OrderType.StopMarket:
                    {
                        var stopPrice = er.StopPx.getValue() * displayFactor;
                        order = new LimitOrder(symbol, orderQuantity, stopPrice, time);
                    }
                    break;

                case OrderType.StopLimit:
                    {
                        var limitPrice = er.Price.getValue() * displayFactor;
                        var stopPrice = er.StopPx.getValue() * displayFactor;
                        order = new StopLimitOrder(symbol, orderQuantity, stopPrice, limitPrice, time);
                    }
                    break;

                default:
                    throw new NotSupportedException($"Unsupported order type: {orderType}");
            }

            order.Properties.TimeInForce = timeInForce;

            order.BrokerId.Add(er.ClOrdID.getValue());

            return order;
        }

        public void Dispose()
        {
            _getOpenOrdersResetEvent.Dispose();
        }
    }
}