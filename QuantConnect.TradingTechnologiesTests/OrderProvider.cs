/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using QuantConnect.Orders;
using QuantConnect.Securities;

namespace QuantConnect.TradingTechnologiesTests
{
    /// <summary>
    /// Provides a test implementation of order mapping
    /// </summary>
    public class OrderProvider : IOrderProvider
    {
        private static int _orderID;
        private readonly IList<Order> _orders;

        public OrderProvider(IList<Order> orders)
        {
            _orders = orders;
        }

        public OrderProvider()
        {
            _orders = new List<Order>();
        }

        public void Add(Order order)
        {
            var orderId = Interlocked.Increment(ref _orderID);

            // TODO:
            // order.Id = orderId;

            _orders.Add(order);
        }

        public int OrdersCount
        {
            get { return _orders.Count; }
        }

        public Order GetOrderById(int orderId)
        {
            return _orders.FirstOrDefault(x => x.Id == orderId);
        }

        public Order GetOrderByBrokerageId(string brokerageId)
        {
            return _orders.FirstOrDefault(x => x.BrokerId.Contains(brokerageId));
        }

        public IEnumerable<OrderTicket> GetOrderTickets(Func<OrderTicket, bool> filter = null)
        {
            throw new NotImplementedException("This method has not been implemented");
        }

        public IEnumerable<OrderTicket> GetOpenOrderTickets(Func<OrderTicket, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public OrderTicket GetOrderTicket(int orderId)
        {
            throw new NotImplementedException("This method has not been implemented");
        }

        public IEnumerable<Order> GetOrders(Func<Order, bool> filter)
        {
            return _orders.Where(filter);
        }

        public List<Order> GetOpenOrders(Func<Order, bool> filter = null)
        {
            return _orders.Where(x => x.Status.IsOpen() && (filter == null || filter(x))).ToList();
        }
    }
}
