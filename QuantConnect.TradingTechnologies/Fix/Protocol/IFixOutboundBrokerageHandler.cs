/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using QuantConnect.Orders;

namespace QuantConnect.Brokerages.TradingTechnologies.Fix.Protocol
{
    /// <summary>
    ///     Defines a class that can perform actions related to orders for a specific FIX version.
    /// </summary>
    public interface IFixOutboundBrokerageHandler
    {
        bool RequestOpenOrders();

        /// <summary>
        /// Places an order.
        /// </summary>
        /// <param name="order">Order to submit</param>
        /// <returns>Whether the request was sent</returns>
        bool PlaceOrder(Order order);

        /// <summary>
        /// Updates an order.
        /// </summary>
        /// <param name="order">Order to update</param>
        /// <returns>Whether the request was sent</returns>
        bool UpdateOrder(Order order);

        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="order">Order to cancel</param>
        /// <returns>Whether the request was sent</returns>
        bool CancelOrder(Order order);
    }
}