/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using QuantConnect.Algorithm;
using QuantConnect.Configuration;
using QuantConnect.Data;
using QuantConnect.Data.Market;
using QuantConnect.Lean.Engine.DataFeeds;
using QuantConnect.Logging;
using QuantConnect.Orders;
using QuantConnect.Packets;
using QuantConnect.TradingTechnologies;
using QuantConnect.TradingTechnologies.Fix;

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

        private readonly Symbol _symbolEs = Symbol.CreateFuture("ES", Market.CME, new DateTime(2021, 3, 19));
        private readonly Symbol _invalidSymbol = Symbol.CreateFuture("XY", Market.CME, new DateTime(2021, 3, 19));
        //private readonly Symbol _symbolGc = Symbol.CreateFuture("GC", Market.CME, new DateTime(2021, 1, 31));

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
                            Log.Trace("{0}: {1} - {2} / {3}", tick.Time.ToStringInvariant("yyyy-MM-dd HH:mm:ss.fff"), tick.Symbol, (tick as Tick)?.BidPrice, (tick as Tick)?.AskPrice);
                        }
                    });

                Thread.Sleep(20000);

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

        [TestCase(1)]
        [TestCase(-1)]
        public void SubmitsMarketOrder(int quantity)
        {
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var filledEvent = new ManualResetEvent(false);

                brokerage.OrderStatusChanged += (s, e) =>
                {
                    if (e.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Status == OrderStatus.Filled)
                    {
                        filledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var order = new MarketOrder(_symbolEs, quantity, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));
                Assert.IsTrue(filledEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [TestCaseSource(nameof(_limitOrderTestCases))]
        public void SubmitsLimitOrder(int quantity, decimal limitPrice, bool isMarketable)
        {
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var filledEvent = new ManualResetEvent(false);

                brokerage.OrderStatusChanged += (s, e) =>
                {
                    if (e.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Status == OrderStatus.Filled)
                    {
                        filledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var order = new LimitOrder(_symbolEs, quantity, limitPrice, DateTime.UtcNow);
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
        public void SubmitsStopMarketOrder(int quantity, decimal stopPrice, bool isValid, string errorText)
        {
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);

                brokerage.OrderStatusChanged += (s, e) =>
                {
                    if (e.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();

                        Assert.IsTrue(isValid);
                    }
                    else if (e.Status == OrderStatus.Invalid)
                    {
                        submittedEvent.Set();

                        Assert.IsFalse(isValid);
                        Assert.That(e.Message.Contains(errorText));
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var order = new StopMarketOrder(_symbolEs, quantity, stopPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [TestCaseSource(nameof(_stopLimitOrderTestCases))]
        public void SubmitsStopLimitOrder(int quantity, decimal stopPrice, decimal limitPrice, bool isValid, string errorText)
        {
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);

                brokerage.OrderStatusChanged += (s, e) =>
                {
                    if (e.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();

                        Assert.IsTrue(isValid);
                    }
                    else if (e.Status == OrderStatus.Invalid)
                    {
                        submittedEvent.Set();

                        Assert.IsFalse(isValid);
                        Assert.That(e.Message.Contains(errorText));
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var order = new StopLimitOrder(_symbolEs, quantity, stopPrice, limitPrice, DateTime.UtcNow);
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

                brokerage.OrderStatusChanged += (s, e) =>
                {
                    if (e.Status == OrderStatus.Canceled)
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
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var cancelledEvent = new ManualResetEvent(false);

                brokerage.OrderStatusChanged += (s, e) =>
                {
                    if (e.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Status == OrderStatus.Canceled)
                    {
                        cancelledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                const int quantity = 1;
                const decimal limitPrice = BidPrice - TickSize * OffsetTicks;

                var order = new LimitOrder(_symbolEs, quantity, limitPrice, DateTime.UtcNow);
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
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var updatedEvent = new ManualResetEvent(false);

                brokerage.OrderStatusChanged += (s, e) =>
                {
                    if (e.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Status == OrderStatus.UpdateSubmitted)
                    {
                        updatedEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                const int quantity = 1;
                const decimal limitPrice = BidPrice - TickSize * OffsetTicks;

                var order = new LimitOrder(_symbolEs, quantity, limitPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Thread.Sleep(5000);

                const decimal newLimitPrice = BidPrice - TickSize * (OffsetTicks + 2);
                var request = new UpdateOrderRequest(DateTime.UtcNow, order.Id, new UpdateOrderFields { LimitPrice = newLimitPrice });
                order.ApplyUpdateOrderRequest(request);
                Assert.IsTrue(brokerage.UpdateOrder(order));

                Assert.IsTrue(updatedEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [Test]
        public void SubmitsBuyLimitOrderAndMovesItDownAndCancelsIt()
        {
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var updatedEvent = new ManualResetEvent(false);
                var cancelledEvent = new ManualResetEvent(false);

                brokerage.OrderStatusChanged += (s, e) =>
                {
                    if (e.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Status == OrderStatus.UpdateSubmitted)
                    {
                        updatedEvent.Set();
                    }
                    else if (e.Status == OrderStatus.Canceled)
                    {
                        cancelledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                const int quantity = 1;
                const decimal limitPrice = BidPrice - TickSize * OffsetTicks;

                var order = new LimitOrder(_symbolEs, quantity, limitPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Thread.Sleep(5000);

                const decimal newLimitPrice = BidPrice - TickSize * (OffsetTicks + 2);
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
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var updatedEvent = new ManualResetEvent(false);
                var filledEvent = new ManualResetEvent(false);

                brokerage.OrderStatusChanged += (s, e) =>
                {
                    if (e.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Status == OrderStatus.UpdateSubmitted)
                    {
                        updatedEvent.Set();
                    }
                    else if (e.Status == OrderStatus.Filled)
                    {
                        filledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                const int quantity = 1;
                const decimal limitPrice = BidPrice - TickSize * OffsetTicks;

                var order = new LimitOrder(_symbolEs, quantity, limitPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Thread.Sleep(5000);

                const decimal newLimitPrice = BidPrice + TickSize * OffsetTicks;
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
            _fixConfiguration.AccountName = "XYZ";

            using (var brokerage = CreateBrokerage())
            {
                var invalidEvent = new ManualResetEvent(false);

                brokerage.OrderStatusChanged += (s, e) =>
                {
                    if (e.Status == OrderStatus.Invalid)
                    {
                        Assert.That(e.Message.EndsWith($"Invalid account {_fixConfiguration.AccountName}"));

                        invalidEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var order = new MarketOrder(_symbolEs, 1, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(invalidEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [Test]
        public void SubmitsMarketOrderForInvalidSymbol()
        {
            using (var brokerage = CreateBrokerage())
            {
                var invalidEvent = new ManualResetEvent(false);

                brokerage.OrderStatusChanged += (s, e) =>
                {
                    if (e.Status == OrderStatus.Invalid)
                    {
                        Assert.That(e.Message.Contains("Lookup by name failed"));

                        invalidEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var order = new MarketOrder(_invalidSymbol, 1, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(invalidEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [Test]
        public void SubmitsBuyLimitOrderAndWaitsForMultipleFills()
        {
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var filledEvent = new ManualResetEvent(false);

                brokerage.OrderStatusChanged += (s, e) =>
                {
                    if (e.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Status == OrderStatus.Filled)
                    {
                        filledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var order = new LimitOrder(_symbolEs, 10, BidPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Assert.IsTrue(filledEvent.WaitOne());
            }
        }

        [Test]
        public void SubmitsBuyLimitOrderAndWaitsForPartialFillAndCancelsIt()
        {
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var partiallyFilledEvent = new ManualResetEvent(false);
                var cancelledEvent = new ManualResetEvent(false);

                brokerage.OrderStatusChanged += (s, e) =>
                {
                    if (e.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Status == OrderStatus.PartiallyFilled)
                    {
                        partiallyFilledEvent.Set();
                    }
                    else if (e.Status == OrderStatus.Canceled)
                    {
                        cancelledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var order = new LimitOrder(_symbolEs, 10, BidPrice, DateTime.UtcNow);
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
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var partiallyFilledEvent = new ManualResetEvent(false);
                var updatedEvent = new ManualResetEvent(false);

                brokerage.OrderStatusChanged += (s, e) =>
                {
                    if (e.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Status == OrderStatus.PartiallyFilled)
                    {
                        partiallyFilledEvent.Set();
                    }
                    else if (e.Status == OrderStatus.UpdateSubmitted)
                    {
                        updatedEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var order = new LimitOrder(_symbolEs, 10, BidPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Assert.IsTrue(partiallyFilledEvent.WaitOne(TimeSpan.FromSeconds(60)));

                const decimal newLimitPrice = BidPrice - TickSize * OffsetTicks;
                var request = new UpdateOrderRequest(DateTime.UtcNow, order.Id, new UpdateOrderFields { LimitPrice = newLimitPrice });
                order.ApplyUpdateOrderRequest(request);
                Assert.IsTrue(brokerage.UpdateOrder(order));

                Assert.IsTrue(updatedEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [Test]
        public void SubmitsBuyLimitOrderAndWaitsForPartialFillAndMovesItUpToBeFilled()
        {
            using (var brokerage = CreateBrokerage())
            {
                var submittedEvent = new ManualResetEvent(false);
                var partiallyFilledEvent = new ManualResetEvent(false);
                var updatedEvent = new ManualResetEvent(false);
                var filledEvent = new ManualResetEvent(false);

                brokerage.OrderStatusChanged += (s, e) =>
                {
                    if (e.Status == OrderStatus.Submitted)
                    {
                        submittedEvent.Set();
                    }
                    else if (e.Status == OrderStatus.PartiallyFilled)
                    {
                        partiallyFilledEvent.Set();
                    }
                    else if (e.Status == OrderStatus.UpdateSubmitted)
                    {
                        updatedEvent.Set();
                    }
                    else if (e.Status == OrderStatus.Filled)
                    {
                        filledEvent.Set();
                    }
                };

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                var order = new LimitOrder(_symbolEs, 10, BidPrice, DateTime.UtcNow);
                _orderProvider.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Assert.IsTrue(partiallyFilledEvent.WaitOne(TimeSpan.FromSeconds(60)));

                const decimal newLimitPrice = BidPrice + TickSize * OffsetTicks;
                var request = new UpdateOrderRequest(DateTime.UtcNow, order.Id, new UpdateOrderFields { LimitPrice = newLimitPrice });
                order.ApplyUpdateOrderRequest(request);
                Assert.IsTrue(brokerage.UpdateOrder(order));

                Assert.IsTrue(updatedEvent.WaitOne(TimeSpan.FromSeconds(5)));

                Assert.IsTrue(filledEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        private const decimal BidPrice = 3785.25m;
        private const decimal TickSize = 0.25m;
        private const int OffsetTicks = 5;

        private static readonly object[] _limitOrderTestCases =
        {
            // Buy below market price
            new TestCaseData(1, BidPrice - TickSize * OffsetTicks, false),

            // Sell above market price
            new TestCaseData(-1, BidPrice + TickSize * OffsetTicks, false),

            // Buy above market price
            new TestCaseData(1, BidPrice + TickSize * OffsetTicks, true),

            // Sell below market price
            new TestCaseData(-1, BidPrice - TickSize * OffsetTicks, true)
        };

        private static readonly object[] _stopMarketOrderTestCases =
        {
            // Buy above market price
            new TestCaseData(1, BidPrice + TickSize * OffsetTicks, true, ""),

            // Sell below market price
            new TestCaseData(-1, BidPrice - TickSize * OffsetTicks, true, ""),

            // Buy below market price
            new TestCaseData(1, BidPrice - TickSize * OffsetTicks, false,
                "Buy order stop price must be above last trade price"),

            // Sell above market price
            new TestCaseData(-1, BidPrice + TickSize * OffsetTicks, false,
                "Sell order stop price must be below last trade price")
        };

        private static readonly object[] _stopLimitOrderTestCases =
        {
            // Buy above market price
            new TestCaseData(1, BidPrice + TickSize * OffsetTicks, BidPrice + TickSize * OffsetTicks * 2, true, ""),

            // Sell below market price
            new TestCaseData(-1, BidPrice - TickSize * OffsetTicks, BidPrice - TickSize * OffsetTicks * 2, true, ""),

            // Buy below market price
            new TestCaseData(1, BidPrice - TickSize * OffsetTicks * 2, BidPrice - TickSize * OffsetTicks, false,
                "Buy order stop price must be above last trade price"),

            // Sell above market price
            new TestCaseData(-1, BidPrice + TickSize * OffsetTicks * 2, BidPrice + TickSize * OffsetTicks, false,
                "Sell order stop price must be below last trade price"),

            // Buy below market price
            new TestCaseData(1, BidPrice - TickSize * OffsetTicks, BidPrice - TickSize * OffsetTicks * 2, false,
                "Stop price maxi-mini must be greater than or equal to trigger price"),

            // Sell above market price
            new TestCaseData(-1, BidPrice + TickSize * OffsetTicks, BidPrice + TickSize * OffsetTicks * 2, false,
                "Stop price maxi-mini must be smaller than or equal to trigger price")
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
