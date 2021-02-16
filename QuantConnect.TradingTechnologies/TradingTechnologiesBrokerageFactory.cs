/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Generic;
using QuantConnect.Brokerages;
using QuantConnect.Configuration;
using QuantConnect.Data;
using QuantConnect.Interfaces;
using QuantConnect.Packets;
using QuantConnect.Securities;
using QuantConnect.TradingTechnologies.Fix;
using QuantConnect.Util;

namespace QuantConnect.TradingTechnologies
{
    /// <summary>
    /// Provides an implementations of <see cref="IBrokerageFactory"/> that produces a <see cref="TradingTechnologiesBrokerage"/>
    /// </summary>
    public class TradingTechnologiesBrokerageFactory : BrokerageFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradingTechnologiesBrokerageFactory"/> class.
        /// </summary>
        public TradingTechnologiesBrokerageFactory()
            : base(typeof(TradingTechnologiesBrokerage))
        {
        }

        /// <summary>
        /// Gets the brokerage data required to run the brokerage from configuration/disk
        /// </summary>
        /// <remarks>
        /// The implementation of this property will create the brokerage data dictionary required for
        /// running live jobs. See <see cref="IJobQueueHandler.NextJob"/>
        /// </remarks>
        public override Dictionary<string, string> BrokerageData => new Dictionary<string, string>
        {
            { "tt-user-name", Config.Get("tt-user-name") },
            { "tt-session-password", Config.Get("tt-session-password") },
            { "tt-account-name", Config.Get("tt-account-name") },

            { "tt-rest-app-key", Config.Get("tt-rest-app-key") },
            { "tt-rest-app-secret", Config.Get("tt-rest-app-secret") },
            { "tt-rest-environment", Config.Get("tt-rest-environment") },

            { "tt-market-data-sender-comp-id", Config.Get("tt-market-data-sender-comp-id") },
            { "tt-market-data-target-comp-id", Config.Get("tt-market-data-target-comp-id") },
            { "tt-market-data-host", Config.Get("tt-market-data-host") },
            { "tt-market-data-port", Config.Get("tt-market-data-port") },

            { "tt-order-routing-sender-comp-id", Config.Get("tt-order-routing-sender-comp-id") },
            { "tt-order-routing-target-comp-id", Config.Get("tt-order-routing-target-comp-id") },
            { "tt-order-routing-host", Config.Get("tt-order-routing-host") },
            { "tt-order-routing-port", Config.Get("tt-order-routing-port") },

            { "tt-initial-cash-amount", Config.Get("tt-initial-cash-amount") },
            { "tt-initial-cash-currency", Config.Get("tt-initial-cash-currency") },

            { "tt-log-fix-messages", Config.Get("tt-log-fix-messages") }
        };

        /// <summary>
        /// Gets a new instance of the <see cref="DefaultBrokerageModel"/>
        /// </summary>
        /// <param name="orderProvider">The order provider</param>
        public override IBrokerageModel GetBrokerageModel(IOrderProvider orderProvider) => new DefaultBrokerageModel();

        /// <summary>
        /// Creates a new <see cref="IBrokerage"/> instance
        /// </summary>
        /// <param name="job">The job packet to create the brokerage for</param>
        /// <param name="algorithm">The algorithm instance</param>
        /// <returns>A new brokerage instance</returns>
        public override IBrokerage CreateBrokerage(LiveNodePacket job, IAlgorithm algorithm)
        {
            var errors = new List<string>();

            // read values from the brokerage data
            var fixConfiguration = new FixConfiguration
            {
                UserName = Read<string>(job.BrokerageData, "tt-user-name", errors),
                SessionPassword = Read<string>(job.BrokerageData, "tt-session-password", errors),
                AccountName = Read<string>(job.BrokerageData, "tt-account-name", errors),

                RestAppKey = Read<string>(job.BrokerageData, "tt-rest-app-key", errors),
                RestAppSecret = Read<string>(job.BrokerageData, "tt-rest-app-secret", errors),
                RestEnvironment = Read<string>(job.BrokerageData, "tt-rest-environment", errors),

                MarketDataSenderCompId = Read<string>(job.BrokerageData, "tt-market-data-sender-comp-id", errors),
                MarketDataTargetCompId = Read<string>(job.BrokerageData, "tt-market-data-target-comp-id", errors),
                MarketDataHost = Read<string>(job.BrokerageData, "tt-market-data-host", errors),
                MarketDataPort = Read<string>(job.BrokerageData, "tt-market-data-port", errors),

                OrderRoutingSenderCompId = Read<string>(job.BrokerageData, "tt-order-routing-sender-comp-id", errors),
                OrderRoutingTargetCompId = Read<string>(job.BrokerageData, "tt-order-routing-target-comp-id", errors),
                OrderRoutingHost = Read<string>(job.BrokerageData, "tt-order-routing-host", errors),
                OrderRoutingPort = Read<string>(job.BrokerageData, "tt-order-routing-port", errors)
            };

            var logFixMessages = Read<bool>(job.BrokerageData, "tt-log-fix-messages", errors);

            if (errors.Count != 0)
            {
                // if we had errors then we can't create the instance
                throw new Exception(string.Join(Environment.NewLine, errors));
            }

            var instance = new TradingTechnologiesBrokerage(
                algorithm,
                job,
                algorithm.Transactions,
                Composer.Instance.GetExportedValueByTypeName<IDataAggregator>(Config.Get("data-aggregator", "QuantConnect.Lean.Engine.DataFeeds.AggregationManager")),
                fixConfiguration,
                logFixMessages);

            Composer.Instance.AddPart<IDataQueueHandler>(instance);

            return instance;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public override void Dispose()
        {
        }
    }
}
