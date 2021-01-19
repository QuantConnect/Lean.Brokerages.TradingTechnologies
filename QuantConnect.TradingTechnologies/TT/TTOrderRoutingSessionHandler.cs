/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using QuantConnect.Fix.TT.FIX44.Fields;
using QuantConnect.Fix.TT.FIX44.Messages;
using QuantConnect.Orders;
using QuantConnect.TradingTechnologies.Fix.Core;
using QuantConnect.TradingTechnologies.Fix.Extensions;
using QuantConnect.TradingTechnologies.Fix.Protocol;
using QuantConnect.TradingTechnologies.Fix.Utils;
using QuantConnect.Util;
using QuickFix;

namespace QuantConnect.TradingTechnologies.TT
{
    /// <summary>
    ///     Handler for TT Order Routing FIX sessions.
    /// </summary>
    public class TTOrderRoutingSessionHandler : TTFixSessionHandlerBase, IFixOutboundBrokerageHandler
    {
        private readonly TradingTechnologiesSymbolMapper _symbolMapper;
        private readonly ISession _session;
        private readonly IFixBrokerageController _fixBrokerageController;
        private readonly string _account;
        private int _initialCount;

        public TTOrderRoutingSessionHandler(TradingTechnologiesSymbolMapper symbolMapper, ISession session, IFixBrokerageController fixBrokerageController, string account)
        {
            _symbolMapper = symbolMapper;
            _session = session ?? throw new ArgumentNullException(nameof(session));
            _fixBrokerageController = fixBrokerageController ?? throw new ArgumentNullException(nameof(fixBrokerageController));
            _account = account;

            fixBrokerageController.Register(this);
        }

        protected override void OnRecoveryCompleted()
        {
            IsReady = true;
        }

        public bool RequestOpenOrders()
        {
            return _session.Send(new OrderStatusRequest());
        }

        public bool PlaceOrder(Order order)
        {
            var side = new Side(order.Direction == OrderDirection.Buy ? Side.BUY : Side.SELL);

            var securityExchange = new SecurityExchange(_symbolMapper.GetBrokerageMarket(order.Symbol.ID.Market));
            var securityType = new QuantConnect.Fix.TT.FIX44.Fields.SecurityType(_symbolMapper.GetBrokerageProductType(order.Symbol.SecurityType));

            var maturity = order.Symbol.ID.Date.ToString("yyyyMM");

            var priceMultiplier = Utility.GetPriceMultiplier(order.Symbol);

            var ttOrder = new NewOrderSingle
            {
                ClOrdID = new ClOrdID(TTOrderId.GetNext()),

                // Instrument:
                SecurityExchange = securityExchange,
                Symbol = new QuantConnect.Fix.TT.FIX44.Fields.Symbol(order.Symbol.ID.Symbol),
                MaturityMonthYear = new MaturityMonthYear(maturity),
                SecurityType = securityType,

                // Order info:
                OrderQty = new OrderQty(order.AbsoluteQuantity),
                Side = side,
                OrdType = new OrdType(Utility.ConvertOrderType(order.Type)),
                TimeInForce = Utility.ConvertTimeInForce(order.TimeInForce),

                // Account details:
                Account = new Account(_account),
                CustOrderCapacity = new CustOrderCapacity(CustOrderCapacity.ALL_OTHER),
                CustOrderHandlingInst = new CustOrderHandlingInst(CustOrderHandlingInst.ELECTRONIC),
                OrderOrigination = new OrderOrigination(OrderOrigination.ORDER_RECEIVED_FROM_DIRECT_OR_SPONSORED_ACCESS_CUSTOMER)
            };

            switch (order.Type)
            {
                case OrderType.Limit:
                    ttOrder.Price = new Price(((LimitOrder)order).LimitPrice * priceMultiplier);
                    break;

                case OrderType.StopMarket:
                    ttOrder.StopPx = new StopPx(((StopMarketOrder)order).StopPrice * priceMultiplier);
                    break;

                case OrderType.StopLimit:
                    ttOrder.StopPx = new StopPx(((StopLimitOrder)order).StopPrice * priceMultiplier);
                    ttOrder.Price = new Price(((StopLimitOrder)order).LimitPrice * priceMultiplier);
                    break;
            }

            order.BrokerId.Add(ttOrder.ClOrdID.getValue());

            return _session.Send(ttOrder);
        }

        public bool UpdateOrder(Order order)
        {
            var request = new OrderCancelReplaceRequest
            {
                ClOrdID = new ClOrdID(TTOrderId.GetNext()),
                OrigClOrdID = new OrigClOrdID(order.BrokerId[0])
            };

            var priceMultiplier = Utility.GetPriceMultiplier(order.Symbol);

            switch (order.Type)
            {
                case OrderType.Limit:
                    request.OrderQty = new OrderQty(order.AbsoluteQuantity);
                    request.Price = new Price(((LimitOrder)order).LimitPrice * priceMultiplier);
                    break;

                case OrderType.StopMarket:
                    request.OrderQty = new OrderQty(order.AbsoluteQuantity);
                    request.StopPx = new StopPx(((StopMarketOrder)order).StopPrice * priceMultiplier);
                    break;

                case OrderType.StopLimit:
                    request.OrderQty = new OrderQty(order.AbsoluteQuantity);
                    request.StopPx = new StopPx(((StopLimitOrder)order).StopPrice * priceMultiplier);
                    request.Price = new Price(((StopLimitOrder)order).LimitPrice * priceMultiplier);
                    break;
            }

            return _session.Send(request);
        }

        public bool CancelOrder(Order order)
        {
            return _session.Send(new OrderCancelRequest
            {
                ClOrdID = new ClOrdID(TTOrderId.GetNext()),
                OrigClOrdID = new OrigClOrdID(order.BrokerId[0])
            });
        }

        public void OnMessage(OrderCancelReject rejection, SessionID _)
        {
            var reason = rejection.CxlRejReason.DescribeInt(rejection.IsSetCxlRejReason());
            var responseTo = rejection.CxlRejResponseTo.DescribeChar(rejection.IsSetCxlRejResponseTo());
            var text = rejection.IsSetText() ? rejection.Text.getValue() : "<no-text>";
            Logging.Log.Error($"Order cancellation failed: {reason}: {text} (response to:{responseTo})");
        }

        public void OnMessage(ExecutionReport execution, SessionID _)
        {
            var orderId = execution.OrderID.getValue();
            var clOrdId = execution.IsSetClOrdID() ? execution.ClOrdID.getValue() : string.Empty;
            var execType = execution.ExecType.getValue();

            var orderStatus = Utility.ConvertOrderStatus(execution);

            if (!clOrdId.IsNullOrEmpty())
            {
                if (orderStatus != OrderStatus.Invalid)
                {
                    Logging.Log.Trace($"ExecutionReport: Id: {orderId}, ClOrdId: {clOrdId}, ExecType: {execType}, OrderStatus: {orderStatus}");
                }
                else
                {
                    Logging.Log.Error($"ExecutionReport: Id: {orderId}, ClOrdId: {clOrdId}, ExecType: {execType}, OrderStatus: {orderStatus}");
                }
            }

            // Total num orders will be set and have a value of 0 when the reply to OrderStatusRequest is indicating no open orders.
            var isStatusRequest = execution.IsInitialStatusRequest();
            if (!isStatusRequest || execution.TotalNumOrders.getValue() > 0)
            {
                _fixBrokerageController.Receive(execution);

                if (isStatusRequest)
                {
                    _initialCount++;
                }
            }

            if (isStatusRequest && execution.TotalNumOrders.getValue() == _initialCount)
            {
                _fixBrokerageController.OnOpenOrdersReceived();
            }
        }

    }
}