/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using QuantConnect.Algorithm;
using QuantConnect.Configuration;
using QuantConnect.Data;
using QuantConnect.Data.Market;
using QuantConnect.Fix.TT.FIX44.Fields;
using QuantConnect.Fix.TT.FIX44.Messages;
using QuantConnect.Lean.Engine.DataFeeds;
using QuantConnect.Logging;
using QuantConnect.Orders;
using QuantConnect.Packets;
using QuantConnect.TradingTechnologies;
using QuantConnect.TradingTechnologies.Fix;
using QuantConnect.TradingTechnologies.Fix.Core;
using QuantConnect.TradingTechnologies.TT;
using QuantConnect.TradingTechnologies.TT.Api;
using QuickFix;
using Log = QuantConnect.Logging.Log;

namespace QuantConnect.TradingTechnologiesTests
{
    [TestFixture]
    [Explicit("These tests require a valid TT configuration.")]
    public class TradingTechnologiesBrokerageTests
    {
        private readonly QCAlgorithm _algorithm = new QCAlgorithm();
        private readonly LiveNodePacket _job = new LiveNodePacket();

        private readonly OrderProvider _orderProvider = new OrderProvider(new List<Order>());
        private readonly AggregationManager _aggregationManager = new AggregationManager();

        private readonly FixConfiguration _fixConfiguration = new FixConfiguration
        {
            UserName = Config.Get("tt-user-name"),
            SessionPassword = Config.Get("tt-session-password"),
            AccountName = Config.Get("tt-account-name"),

            RestAppKey = Config.Get("tt-rest-app-key"),
            RestAppSecret = Config.Get("tt-rest-app-secret"),
            RestEnvironment = Config.Get("tt-rest-environment"),

            MarketDataSenderCompId = Config.Get("tt-market-data-sender-comp-id"),
            MarketDataTargetCompId = Config.Get("tt-market-data-target-comp-id"),
            MarketDataHost = Config.Get("tt-market-data-host"),
            MarketDataPort = Config.Get("tt-market-data-port"),

            OrderRoutingSenderCompId = Config.Get("tt-order-routing-sender-comp-id"),
            OrderRoutingTargetCompId = Config.Get("tt-order-routing-target-comp-id"),
            OrderRoutingHost = Config.Get("tt-order-routing-host"),
            OrderRoutingPort = Config.Get("tt-order-routing-port")
        };

        private static readonly Symbol _invalidSymbol = Symbol.CreateFuture("XY", Market.CME, new DateTime(2021, 9, 17));

        private static readonly Symbol _symbolEs = Symbol.CreateFuture("ES", Market.CME, new DateTime(2023, 12, 15));
        private static readonly Symbol _symbolCl = Symbol.CreateFuture("CL", Market.NYMEX, new DateTime(2023, 10, 20));
        private static readonly Symbol _symbolVx = Symbol.CreateFuture("VX", Market.CFE, new DateTime(2021, 10, 20));
        private static readonly Symbol _symbolB = Symbol.CreateFuture("B", Market.ICE, new DateTime(2021, 9, 30));

        [SetUp]
        public void Setup()
        {
            Log.LogHandler = new NUnitLogHandler();
        }

        [Test]
        public void ClientConnects()
        {
            using (var brokerage = CreateBrokerage())
            {
                Assert.IsFalse(brokerage.IsConnected);

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                brokerage.Disconnect();
                Assert.IsFalse(brokerage.IsConnected);
            }
        }

        [Test]
        public void GetsAccountHoldings()
        {
            using (var brokerage = CreateBrokerage())
            {
                Assert.IsFalse(brokerage.IsConnected);

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var holdings = brokerage.GetAccountHoldings();
                foreach (var holding in holdings)
                {
                    Log.Trace($"Holding: {holding}");
                }
                Log.Trace($"Holdings: {holdings.Count}");

                brokerage.Disconnect();
                Assert.IsFalse(brokerage.IsConnected);
            }
        }

        [Test]
        public void ReceivesMarketData()
        {
            using (var brokerage = CreateBrokerage())
            {
                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var dataConfig = new SubscriptionDataConfig(
                    typeof(Tick),
                    _symbolEs,
                    Resolution.Tick,
                    TimeZones.Utc,
                    TimeZones.Utc,
                    true,
                    true,
                    false);

                var cts = new CancellationTokenSource();
                ProcessFeed(
                    brokerage.Subscribe(dataConfig, (s, e) => { }),
                    cts,
                    (tick) => {
                        if (tick != null)
                        {
                            Log.Trace("{0}: {1} - Bid:{2} / Ask:{3} - Last:{4} Qty:{5}", tick.Time.ToStringInvariant("yyyy-MM-dd HH:mm:ss.fff"), tick.Symbol, (tick as Tick)?.BidPrice, (tick as Tick)?.AskPrice, (tick as Tick)?.Value, (tick as Tick)?.Quantity);
                        }
                    });

                Thread.Sleep(60000);

                brokerage.Unsubscribe(dataConfig);

                Thread.Sleep(5000);

                cts.Cancel();

                brokerage.Disconnect();
                Assert.IsFalse(brokerage.IsConnected);
            }
        }

        [Test]
        public void GetsOpenOrders()
        {
            using (var brokerage = CreateBrokerage())
            {
                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var orders = brokerage.GetOpenOrders();

                Log.Trace($"Open orders: {orders.Count}");
            }
        }

        [Test]
        public void SubmitsManualMarketOrder()
        {
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var filledEvent = new ManualResetEvent(false);

                brokerage.OrdersStatusChanged += (s, e) =>
                {
                    var orderEvent = e.Single();
                    if (orderEvent.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (orderEvent.Status == OrderStatus.Filled)
                    {
                        filledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var symbol = Symbol.CreateFuture("CL", Market.NYMEX, new DateTime(2023, 10, 20));
                var order = new MarketOrder(symbol, 1, DateTime.UtcNow, properties: new TradingTechnologiesOrderProperties { HandleInstruction = FixOrderProperites.ManualOrder });
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));
                Assert.IsFalse(filledEvent.WaitOne(TimeSpan.FromSeconds(10)));
            }
        }

        [TestCaseSource(nameof(_marketOrderTestCases))]
        public void SubmitsMarketOrder(Symbol symbol, int quantity)
        {
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var filledEvent = new ManualResetEvent(false);

                brokerage.OrdersStatusChanged += (s, e) =>
                {
                    var orderEvent = e.Single();
                    if (orderEvent.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (orderEvent.Status == OrderStatus.Filled && orderEvent.FillQuantity == quantity)
                    {
                        filledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var order = new MarketOrder(symbol, quantity, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));
                Assert.IsTrue(filledEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [TestCaseSource(nameof(_limitOrderTestCases))]
        public void SubmitsLimitOrder(Symbol symbol, int quantity, int limitPriceOffsetTicks, bool isMarketable)
        {
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var filledEvent = new ManualResetEvent(false);

                brokerage.OrdersStatusChanged += (s, e) =>
                {
                    var orderEvent = e.Single();
                    if (orderEvent.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (orderEvent.Status == OrderStatus.Filled)
                    {
                        filledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var limitPrice = _bidPrices[symbol] + _tickSizes[symbol] * limitPriceOffsetTicks;

                var order = new LimitOrder(symbol, quantity, limitPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                if (isMarketable)
                {
                    Assert.IsTrue(filledEvent.WaitOne(TimeSpan.FromSeconds(5)));
                }
            }
        }

        [TestCaseSource(nameof(_stopMarketOrderTestCases))]
        public void SubmitsStopMarketOrder(Symbol symbol, int quantity, int stopPriceOffsetTicks, bool isValid, string errorText)
        {
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);

                brokerage.OrdersStatusChanged += (s, e) =>
                {
                    var orderEvent = e.Single();
                    if (orderEvent.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();

                        Assert.IsTrue(isValid);
                    }
                    else if (orderEvent.Status == OrderStatus.Invalid)
                    {
                        submittedEvent.Set();

                        Assert.IsFalse(isValid);
                        Assert.That(orderEvent.Message.Contains(errorText));
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var stopPrice = _bidPrices[symbol] + _tickSizes[symbol] * stopPriceOffsetTicks;

                var order = new StopMarketOrder(symbol, quantity, stopPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [TestCaseSource(nameof(_stopLimitOrderTestCases))]
        public void SubmitsStopLimitOrder(Symbol symbol, int quantity, int stopPriceOffsetTicks, int limitPriceOffsetTicks, bool isValid, string errorText)
        {
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);

                brokerage.OrdersStatusChanged += (s, e) =>
                {
                    var orderEvent = e.Single();
                    if (orderEvent.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();

                        Assert.IsTrue(isValid);
                    }
                    else if (orderEvent.Status == OrderStatus.Invalid)
                    {
                        submittedEvent.Set();

                        Assert.IsFalse(isValid);
                        Assert.That(orderEvent.Message.Contains(errorText));
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var stopPrice = _bidPrices[symbol] + _tickSizes[symbol] * stopPriceOffsetTicks;
                var limitPrice = _bidPrices[symbol] + _tickSizes[symbol] * limitPriceOffsetTicks;

                var order = new StopLimitOrder(symbol, quantity, stopPrice, limitPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [Test]
        public void CancelsAllOrders()
        {
            using (var brokerage = CreateBrokerage())
            {
                var cancelEvent = new ManualResetEvent(false);

                brokerage.OrdersStatusChanged += (s, e) =>
                {
                    if (e.Single().Status == OrderStatus.Canceled)
                    {
                        cancelEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var orders = brokerage.GetOpenOrders();
                foreach (var order in orders)
                {
                    _orderProvider.Add(order);

                    cancelEvent.Reset();

                    Assert.IsTrue(brokerage.CancelOrder(order));

                    Assert.IsTrue(cancelEvent.WaitOne(TimeSpan.FromSeconds(5)));
                }
            }
        }

        [Test]
        public void SubmitsBuyLimitOrderAndCancelsIt()
        {
            var symbol = _symbolEs;

            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var cancelledEvent = new ManualResetEvent(false);

                brokerage.OrdersStatusChanged += (s, e) =>
                {
                    if (e.Single().Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Single().Status == OrderStatus.Canceled)
                    {
                        cancelledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                const int quantity = 1;
                var limitPrice = _bidPrices[symbol] - _tickSizes[symbol] * OffsetTicks;

                var order = new LimitOrder(symbol, quantity, limitPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Thread.Sleep(5000);

                Assert.IsTrue(brokerage.CancelOrder(order));

                Assert.IsTrue(cancelledEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [Test]
        public void SubmitsBuyLimitOrderAndMovesItDown()
        {
            var symbol = _symbolEs;

            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var updatedEvent = new ManualResetEvent(false);

                brokerage.OrdersStatusChanged += (s, e) =>
                {
                    if (e.Single().Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Single().Status == OrderStatus.UpdateSubmitted)
                    {
                        updatedEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                const int quantity = 1;
                var limitPrice = _bidPrices[symbol] - _tickSizes[symbol] * OffsetTicks;

                var order = new LimitOrder(symbol, quantity, limitPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Thread.Sleep(5000);

                var newLimitPrice = _bidPrices[symbol] - _tickSizes[symbol] * (OffsetTicks + 2);
                var request = new UpdateOrderRequest(DateTime.UtcNow, order.Id, new UpdateOrderFields { LimitPrice = newLimitPrice });
                order.ApplyUpdateOrderRequest(request);
                Assert.IsTrue(brokerage.UpdateOrder(order));

                Assert.IsTrue(updatedEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [Test]
        public void SubmitsBuyLimitOrderAndMovesItDownAndCancelsIt()
        {
            var symbol = _symbolEs;

            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var updatedEvent = new ManualResetEvent(false);
                var cancelledEvent = new ManualResetEvent(false);

                brokerage.OrdersStatusChanged += (s, e) =>
                {
                    if (e.Single().Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Single().Status == OrderStatus.UpdateSubmitted)
                    {
                        updatedEvent.Set();
                    }
                    else if (e.Single().Status == OrderStatus.Canceled)
                    {
                        cancelledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                const int quantity = 1;
                var limitPrice = _bidPrices[symbol] - _tickSizes[symbol] * OffsetTicks;

                var order = new LimitOrder(symbol, quantity, limitPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Thread.Sleep(5000);

                var newLimitPrice = _bidPrices[symbol] - _tickSizes[symbol] * (OffsetTicks + 2);
                var request = new UpdateOrderRequest(DateTime.UtcNow, order.Id, new UpdateOrderFields { LimitPrice = newLimitPrice });
                order.ApplyUpdateOrderRequest(request);
                Assert.IsTrue(brokerage.UpdateOrder(order));

                Assert.IsTrue(updatedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Thread.Sleep(5000);

                Assert.IsTrue(brokerage.CancelOrder(order));

                Assert.IsTrue(cancelledEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [Test]
        public void SubmitsBuyLimitOrderAndMovesItUpToBeFilled()
        {
            var symbol = _symbolEs;

            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var updatedEvent = new ManualResetEvent(false);
                var filledEvent = new ManualResetEvent(false);

                brokerage.OrdersStatusChanged += (s, e) =>
                {
                    if (e.Single().Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Single().Status == OrderStatus.UpdateSubmitted)
                    {
                        updatedEvent.Set();
                    }
                    else if (e.Single().Status == OrderStatus.Filled)
                    {
                        filledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                const int quantity = 1;
                var limitPrice = _bidPrices[symbol] - _tickSizes[symbol] * OffsetTicks;

                var order = new LimitOrder(symbol, quantity, limitPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Thread.Sleep(5000);

                var newLimitPrice = _bidPrices[symbol] + _tickSizes[symbol] * OffsetTicks;
                var request = new UpdateOrderRequest(DateTime.UtcNow, order.Id, new UpdateOrderFields { LimitPrice = newLimitPrice });
                order.ApplyUpdateOrderRequest(request);
                Assert.IsTrue(brokerage.UpdateOrder(order));

                Assert.IsTrue(updatedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Assert.IsTrue(filledEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [Test]
        public void SubmitsMarketOrderForInvalidAccount()
        {
            var symbol = _symbolEs;

            _fixConfiguration.AccountName = "XYZ";

            using (var brokerage = CreateBrokerage())
            {
                var invalidEvent = new ManualResetEvent(false);

                brokerage.OrdersStatusChanged += (s, e) =>
                {
                    var orderEvent = e.Single();
                    if (orderEvent.Status == OrderStatus.Invalid)
                    {
                        Assert.That(orderEvent.Message.Contains($"Invalid account {_fixConfiguration.AccountName}") ||
                                    orderEvent.Message.Contains("Account does not exist"));

                        invalidEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var order = new MarketOrder(symbol, 1, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(invalidEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [Test]
        public void SubmitsMarketOrderForInvalidSymbol()
        {
            var symbol = _invalidSymbol;

            using (var brokerage = CreateBrokerage())
            {
                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var order = new MarketOrder(symbol, 1, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.Throws<NotSupportedException>(() => brokerage.PlaceOrder(order));
            }
        }

        [Test]
        public void SubmitsBuyLimitOrderAndWaitsForMultipleFills()
        {
            var symbol = _symbolEs;

            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var filledEvent = new ManualResetEvent(false);

                brokerage.OrdersStatusChanged += (s, e) =>
                {
                    if (e.Single().Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Single().Status == OrderStatus.Filled)
                    {
                        filledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var limitPrice = _bidPrices[symbol];
                var order = new LimitOrder(symbol, 10, limitPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Assert.IsTrue(filledEvent.WaitOne());
            }
        }

        [Test]
        public void SubmitsBuyLimitOrderAndWaitsForPartialFillAndCancelsIt()
        {
            var symbol = _symbolEs;

            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var partiallyFilledEvent = new ManualResetEvent(false);
                var cancelledEvent = new ManualResetEvent(false);

                brokerage.OrdersStatusChanged += (s, e) =>
                {
                    if (e.Single().Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Single().Status == OrderStatus.PartiallyFilled)
                    {
                        partiallyFilledEvent.Set();
                    }
                    else if (e.Single().Status == OrderStatus.Canceled)
                    {
                        cancelledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var limitPrice = _bidPrices[symbol];
                var order = new LimitOrder(symbol, 10, limitPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Assert.IsTrue(partiallyFilledEvent.WaitOne(TimeSpan.FromSeconds(60)));

                Assert.IsTrue(brokerage.CancelOrder(order));

                Assert.IsTrue(cancelledEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [Test]
        public void SubmitsBuyLimitOrderAndWaitsForPartialFillAndMovesItDown()
        {
            var symbol = _symbolEs;

            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var partiallyFilledEvent = new ManualResetEvent(false);
                var updatedEvent = new ManualResetEvent(false);

                brokerage.OrdersStatusChanged += (s, e) =>
                {
                    if (e.Single().Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Single().Status == OrderStatus.PartiallyFilled)
                    {
                        partiallyFilledEvent.Set();
                    }
                    else if (e.Single().Status == OrderStatus.UpdateSubmitted)
                    {
                        updatedEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var limitPrice = _bidPrices[symbol];
                var order = new LimitOrder(symbol, 10, limitPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Assert.IsTrue(partiallyFilledEvent.WaitOne(TimeSpan.FromSeconds(60)));

                var newLimitPrice = limitPrice - _tickSizes[symbol] * OffsetTicks;
                var request = new UpdateOrderRequest(DateTime.UtcNow, order.Id, new UpdateOrderFields { LimitPrice = newLimitPrice });
                order.ApplyUpdateOrderRequest(request);
                Assert.IsTrue(brokerage.UpdateOrder(order));

                Assert.IsTrue(updatedEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [Test]
        public void SubmitsBuyLimitOrderAndWaitsForPartialFillAndMovesItUpToBeFilled()
        {
            var symbol = _symbolEs;

            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var partiallyFilledEvent = new ManualResetEvent(false);
                var updatedEvent = new ManualResetEvent(false);
                var filledEvent = new ManualResetEvent(false);

                brokerage.OrdersStatusChanged += (s, e) =>
                {
                    var orderEvents = e.Single();
                    if (orderEvents.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (orderEvents.Status == OrderStatus.PartiallyFilled)
                    {
                        partiallyFilledEvent.Set();
                    }
                    else if (orderEvents.Status == OrderStatus.UpdateSubmitted)
                    {
                        updatedEvent.Set();
                    }
                    else if (orderEvents.Status == OrderStatus.Filled)
                    {
                        filledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var limitPrice = _bidPrices[symbol];
                var order = new LimitOrder(symbol, 10, limitPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Assert.IsTrue(partiallyFilledEvent.WaitOne(TimeSpan.FromSeconds(60)));

                var newLimitPrice = limitPrice + _tickSizes[symbol] * OffsetTicks;
                var request = new UpdateOrderRequest(DateTime.UtcNow, order.Id, new UpdateOrderFields { LimitPrice = newLimitPrice });
                order.ApplyUpdateOrderRequest(request);
                Assert.IsTrue(brokerage.UpdateOrder(order));

                Assert.IsTrue(updatedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Assert.IsTrue(filledEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [Test]
        public void CanLogonAfterLogout()
        {
            using var apiClient = new TTApiClient(_fixConfiguration.RestAppKey, _fixConfiguration.RestAppSecret, _fixConfiguration.RestEnvironment);
            var symbolMapper = new TradingTechnologiesSymbolMapper(apiClient);

            var marketDataController = new FixMarketDataController();
            using var brokerageController = new FixBrokerageController(symbolMapper);
            var fixProtocolDirector = new TTFixProtocolDirector(symbolMapper, _fixConfiguration, marketDataController, brokerageController);

            using var fixInstance = new FixInstance(fixProtocolDirector, _fixConfiguration, true);
            fixInstance.Initialise();

            var sessionId = new SessionID(_fixConfiguration.FixVersionString, _fixConfiguration.OrderRoutingSenderCompId, _fixConfiguration.OrderRoutingTargetCompId);

            fixInstance.OnLogout(sessionId);

            fixInstance.OnLogon(sessionId);

            fixInstance.Terminate();
        }

        [TestCase(TradingTechnologiesOrderProperties.AutomatedExecutionOrderPrivate)]
        [TestCase(TradingTechnologiesOrderProperties.AutomatedExecutionOrderPublic)]
        [TestCase(TradingTechnologiesOrderProperties.ManualOrder)]
        public void OrderCanDefineHandleInstruction(char handleInstruction)
        {
            var ttOrderProperties = new TradingTechnologiesOrderProperties() { HandleInstruction = handleInstruction };
            var ttOrder = new NewOrderSingle() { HandlInst = new HandlInst((char)ttOrderProperties.HandleInstruction) };
            Assert.AreEqual(handleInstruction, ttOrder.HandlInst.getValue());
        }

        [TestCase("Example text")]
        [TestCase("")]
        [TestCase(null)]
        public void OrderCanDefineNotes(string notes)
        {
            var ttOrderProperties = new TradingTechnologiesOrderProperties() { Notes = notes };
            var ttOrder = new NewOrderSingle() { Text = new Text(ttOrderProperties.Notes) };
            Assert.AreEqual(notes, ttOrder.Text.getValue());
        }

        private readonly Dictionary<Symbol, decimal> _bidPrices = new Dictionary<Symbol, decimal>
        {
            { _symbolEs, 4470m },
            { _symbolCl, 91.73m },
            { _symbolVx, 29.45m },
            { _symbolB, 68.24m },
        };

        private static readonly Dictionary<Symbol, decimal> _tickSizes = new Dictionary<Symbol, decimal>
        {
            { _symbolEs, 0.25m },
            { _symbolCl, 0.01m },
            { _symbolVx, 0.05m },
            { _symbolB, 0.01m }
        };

        private const int OffsetTicks = 10;

        private static object[] _marketOrderTestCases =
        {
            // Buy
            new TestCaseData(_symbolEs, 1),
            new TestCaseData(_symbolCl, 1),
            new TestCaseData(_symbolVx, 1),
            new TestCaseData(_symbolB, 1),

            // Sell
            new TestCaseData(_symbolEs, -1),
            new TestCaseData(_symbolCl, -1),
            new TestCaseData(_symbolVx, -1),
            new TestCaseData(_symbolB, -1)
        };

        private static readonly object[] _limitOrderTestCases =
        {
            // Buy below market price
            new TestCaseData(_symbolEs, 1, -OffsetTicks, false),
            new TestCaseData(_symbolCl, 1, -OffsetTicks, false),
            new TestCaseData(_symbolVx, 1, -OffsetTicks, false),

            // Sell above market price
            new TestCaseData(_symbolEs, -1, OffsetTicks, false),
            new TestCaseData(_symbolCl, -1, OffsetTicks, false),
            new TestCaseData(_symbolVx, -1, OffsetTicks, false),

            // Buy above market price
            new TestCaseData(_symbolEs, 1, OffsetTicks, true),
            new TestCaseData(_symbolCl, 1, OffsetTicks, true),
            new TestCaseData(_symbolVx, 1, OffsetTicks, true),

            // Sell below market price
            new TestCaseData(_symbolEs, -1, -OffsetTicks, true),
            new TestCaseData(_symbolCl, -1, -OffsetTicks, true),
            new TestCaseData(_symbolVx, -1, -OffsetTicks, true)
        };

        private static readonly object[] _stopMarketOrderTestCases =
        {
            // Buy above market price
            new TestCaseData(_symbolEs, 1, OffsetTicks, true, ""),
            new TestCaseData(_symbolVx, 1, OffsetTicks, false, "Unsupported order type."),

            // Sell below market price
            new TestCaseData(_symbolEs, -1, -OffsetTicks, true, ""),
            new TestCaseData(_symbolVx, -1, -OffsetTicks, false, "Unsupported order type."),

            // Buy below market price
            new TestCaseData(_symbolEs, 1, -OffsetTicks, false,
                "Buy order stop price must be above last trade price"),
            new TestCaseData(_symbolVx, 1, -OffsetTicks, false, "Unsupported order type."),

            // Sell above market price
            new TestCaseData(_symbolEs, -1, OffsetTicks, false,
                "Sell order stop price must be below last trade price"),
            new TestCaseData(_symbolVx, -1, OffsetTicks, false, "Unsupported order type.")
        };

        private static readonly object[] _stopLimitOrderTestCases =
        {
            // Buy above market price
            new TestCaseData(_symbolEs, 1, OffsetTicks, OffsetTicks * 2, true, ""),
            new TestCaseData(_symbolVx, 1, OffsetTicks, OffsetTicks * 2, true, ""),

            // Buy above market price
            new TestCaseData(_symbolEs, 1, OffsetTicks * 2, OffsetTicks, false,
                "Stop price maxi-mini must be greater than or equal to trigger price"),
            new TestCaseData(_symbolVx, 1, OffsetTicks * 2, OffsetTicks, true, ""),

            // Sell below market price
            new TestCaseData(_symbolEs, -1, -OffsetTicks, -OffsetTicks * 2, true, ""),
            new TestCaseData(_symbolVx, -1, -OffsetTicks, -OffsetTicks * 2, true, ""),

            // Sell below market price
            new TestCaseData(_symbolEs, -1, -OffsetTicks * 2, -OffsetTicks, false,
                "Stop price maxi-mini must be smaller than or equal to trigger price"),
            new TestCaseData(_symbolVx, -1, -OffsetTicks * 2, -OffsetTicks, true, ""),

            // Buy below market price
            new TestCaseData(_symbolEs, 1, -OffsetTicks * 2, -OffsetTicks, false,
                "Buy order stop price must be above last trade price"),
            new TestCaseData(_symbolVx, 1, -OffsetTicks * 2, -OffsetTicks, true, ""),

            // Sell above market price
            new TestCaseData(_symbolEs, -1, OffsetTicks * 2, OffsetTicks, false,
                "Sell order stop price must be below last trade price"),
            new TestCaseData(_symbolVx, -1, OffsetTicks * 2, OffsetTicks, true, ""),

            // Buy below market price
            new TestCaseData(_symbolEs, 1, -OffsetTicks, -OffsetTicks * 2, false,
                "Stop price maxi-mini must be greater than or equal to trigger price"),
            new TestCaseData(_symbolVx, 1, -OffsetTicks, -OffsetTicks * 2, true, ""),

            // Sell above market price
            new TestCaseData(_symbolEs, -1, OffsetTicks, OffsetTicks * 2, false,
                "Stop price maxi-mini must be smaller than or equal to trigger price"),
            new TestCaseData(_symbolVx, -1, OffsetTicks, OffsetTicks * 2, true, "")
        };

        private static void ProcessFeed(IEnumerator<BaseData> enumerator, CancellationTokenSource cts, Action<BaseData> callback = null)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    while (enumerator.MoveNext() && !cts.IsCancellationRequested)
                    {
                        var tick = enumerator.Current;
                        callback?.Invoke(tick);
                    }
                }
                catch (AssertionException)
                {
                    throw;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }, cts.Token);
        }

        private TradingTechnologiesBrokerage CreateBrokerage()
        {
            return new TradingTechnologiesBrokerage(_algorithm, _job, _orderProvider, _aggregationManager, _fixConfiguration, true);
        }
    }
}

