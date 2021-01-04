/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using QuantConnect.Configuration;
using QuantConnect.Data;
using QuantConnect.Data.Market;
using QuantConnect.Lean.Engine.DataFeeds;
using QuantConnect.Logging;
using QuantConnect.Orders;
using QuantConnect.TradingTechnologies;
using QuantConnect.TradingTechnologies.Fix;

namespace QuantConnect.TradingTechnologiesTests
{
    [TestFixture]
    [Explicit("These tests require a valid TT configuration.")]
    public class TradingTechnologiesBrokerageTests
    {
        private readonly List<Order> _orders = new List<Order>();
        private readonly AggregationManager _aggregationManager = new AggregationManager();

        private readonly FixConfiguration _fixConfiguration = new FixConfiguration
        {
            UserName = Config.Get("tt-user-name"),
            SessionPassword = Config.Get("tt-session-password"),
            AccountName = Config.Get("tt-account-name"),
            MarketDataSenderCompId = Config.Get("tt-market-data-sender-comp-id"),
            OrderRoutingSenderCompId = Config.Get("tt-order-routing-sender-comp-id")
        };

        private readonly Symbol _symbolEs = Symbol.CreateFuture("ES", Market.CME, new DateTime(2021, 3, 19));
        //private readonly Symbol _symbolGc = Symbol.CreateFuture("GC", Market.CME, new DateTime(2021, 1, 31));

        [Test]
        public void ClientConnects()
        {
            using (var brokerage = new TradingTechnologiesBrokerage(new OrderProvider(_orders), _aggregationManager, _fixConfiguration))
            {
                Assert.IsFalse(brokerage.IsConnected);

                brokerage.Connect();
                Assert.IsTrue(brokerage.IsConnected);

                brokerage.Disconnect();
                Assert.IsFalse(brokerage.IsConnected);
            }
        }

        [Test]
        public void ReceivesMarketData()
        {
            using (var brokerage = new TradingTechnologiesBrokerage(new OrderProvider(_orders), _aggregationManager, _fixConfiguration))
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
            using (var brokerage = new TradingTechnologiesBrokerage(new OrderProvider(_orders), _aggregationManager, _fixConfiguration))
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
            using (var brokerage = new TradingTechnologiesBrokerage(new OrderProvider(_orders), _aggregationManager, _fixConfiguration))
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
                _orders.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));
                Assert.IsTrue(filledEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [TestCaseSource(nameof(_limitOrderTestCases))]
        public void SubmitsLimitOrder(int quantity, decimal limitPrice, bool isMarketable)
        {
            using (var brokerage = new TradingTechnologiesBrokerage(new OrderProvider(_orders), _aggregationManager, _fixConfiguration))
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
                _orders.Add(order);

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
            using (var brokerage = new TradingTechnologiesBrokerage(new OrderProvider(_orders), _aggregationManager, _fixConfiguration))
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
                _orders.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [TestCaseSource(nameof(_stopLimitOrderTestCases))]
        public void SubmitsStopLimitOrder(int quantity, decimal stopPrice, decimal limitPrice, bool isValid, string errorText)
        {
            using (var brokerage = new TradingTechnologiesBrokerage(new OrderProvider(_orders), _aggregationManager, _fixConfiguration))
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
                _orders.Add(order);

                Assert.IsTrue(brokerage.PlaceOrder(order));

                Assert.IsTrue(submittedEvent.WaitOne(TimeSpan.FromSeconds(5)));
            }
        }

        [Test]
        public void CancelsAllOrders()
        {
            using (var brokerage = new TradingTechnologiesBrokerage(new OrderProvider(_orders), _aggregationManager, _fixConfiguration))
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
                    _orders.Add(order);

                    cancelEvent.Reset();

                    Assert.IsTrue(brokerage.CancelOrder(order));

                    Assert.IsTrue(cancelEvent.WaitOne(TimeSpan.FromSeconds(5)));
                }
            }
        }

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

        private const decimal BidPrice = 3738.75m;
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

    }
}
