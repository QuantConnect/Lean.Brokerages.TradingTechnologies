/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Generic;
using QuantConnect.Fix.TT.FIX44.Messages;
using QuantConnect.Orders;
using QuantConnect.TradingTechnologies.Fix.Protocol;

namespace QuantConnect.TradingTechnologies.Fix.Core
{
    /// <summary>
    ///     Controls brokerage related communication between QC and a FIX protocol implementation.
    /// </summary>
    public interface IFixBrokerageController
    {
        event EventHandler<ExecutionReport> ExecutionReport;

        /// <summary>
        ///     Registers a brokerage handler to this controller.
        /// </summary>
        /// <param name="handler">Handler to register</param>
        void Register(IFixOutboundBrokerageHandler handler);

        /// <summary>
        ///     Receive an order status update.
        /// </summary>
        /// <param name="orderEvent">Order event</param>
        // TODO: Decide whether communication from a handler back to the controller should be done via an event.
        void Receive(ExecutionReport orderEvent);

        bool RequestOpenOrders();

        /// <summary>
        ///     Places an order.
        /// </summary>
        /// <param name="order">The order to submit.</param>
        bool PlaceOrder(Order order);

        /// <summary>
        ///     Updates an existing order.
        /// </summary>
        /// <param name="order">The order to update.</param>
        bool UpdateOrder(Order order);

        /// <summary>
        ///     Returns all orders the brokerage is aware of.
        /// </summary>
        /// <returns>All orders</returns>
        List<Order> GetOpenOrders();

        /// <summary>
        ///     Cancel an order.
        /// </summary>
        /// <param name="order">The order to cancel.</param>
        bool CancelOrder(Order order);

        /// <summary>
        ///     Flag when all open orders have been received.
        /// </summary>
        void OnOpenOrdersReceived();
    }
}