/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using NUnit.Framework;
using QuantConnect.Configuration;
using QuantConnect.Brokerages.TradingTechnologies;
using QuantConnect.Brokerages.TradingTechnologies.TT.Api;

namespace QuantConnect.Brokerages.TradingTechnologiesTests
{
    [TestFixture]
    [Explicit("These tests require a valid TT configuration.")]
    public class TradingTechnologiesSymbolMapperTests
    {
        private readonly string _appKey = Config.Get("tt-rest-app-key");
        private readonly string _appSecret = Config.Get("tt-rest-app-secret");
        private readonly string _environment = Config.Get("tt-rest-environment");

        [TestCase(SecurityType.Equity, "CS")]
        [TestCase(SecurityType.Option, "OPT")]
        [TestCase(SecurityType.Future, "FUT")]
        public void GetBrokerageProductType(SecurityType securityType, string expectedProductType)
        {
            using (var apiClient = new TTApiClient(_appKey, _appSecret, _environment))
            {
                var symbolMapper = new TradingTechnologiesSymbolMapper(apiClient);

                var productType = symbolMapper.GetBrokerageProductType(securityType);

                Assert.AreEqual(expectedProductType, productType);
            }
        }

        [TestCase(Market.CME, SecurityType.Future, "CME")]
        [TestCase(Market.COMEX, SecurityType.Future, "CME")]
        [TestCase(Market.NYMEX, SecurityType.Future, "CME")]
        [TestCase(Market.CBOT, SecurityType.Future, "CME")]
        [TestCase(Market.CFE, SecurityType.Future, "CFE")]
        [TestCase(Market.ICE, SecurityType.Future, "ICE")]
        [TestCase(Market.CBOE, SecurityType.Option, "CBOE")]
        public void GetBrokerageMarket(string leanMarket, SecurityType leanSecurityType, string expectedMarket)
        {
            using (var apiClient = new TTApiClient(_appKey, _appSecret, _environment))
            {
                apiClient.Error += (object _, string error) =>
                {
                    Assert.Fail(error);
                };

                var symbolMapper = new TradingTechnologiesSymbolMapper(apiClient);

                var market = symbolMapper.GetBrokerageMarket(leanMarket, leanSecurityType);

                Assert.AreEqual(expectedMarket, market);
            }
        }

        [TestCase("CS", SecurityType.Equity)]
        [TestCase("OPT", SecurityType.Option)]
        [TestCase("FUT", SecurityType.Future)]
        public void GetLeanSecurityType(string productType, SecurityType expectedSecurityType)
        {
            using (var apiClient = new TTApiClient(_appKey, _appSecret, _environment))
            {
                var symbolMapper = new TradingTechnologiesSymbolMapper(apiClient);

                var securityType = symbolMapper.GetLeanSecurityType(productType);

                Assert.AreEqual(expectedSecurityType, securityType);
            }
        }

        [TestCase("CME", "ES", Market.CME)]
        [TestCase("CME", "GC", Market.COMEX)]
        [TestCase("CME", "CL", Market.NYMEX)]
        [TestCase("CME", "ZB", Market.CBOT)]
        [TestCase("CFE", "VX", Market.CFE)]
        [TestCase("ICE", "DX", Market.ICE)]
        public void GetLeanMarket(string securityExchange, string ticker, string expectedMarket)
        {
            using (var apiClient = new TTApiClient(_appKey, _appSecret, _environment))
            {
                var symbolMapper = new TradingTechnologiesSymbolMapper(apiClient);

                var market = symbolMapper.GetLeanMarket(SecurityType.Future, securityExchange, ticker);

                Assert.AreEqual(expectedMarket, market);
            }
        }

        [TestCaseSource(nameof(_getLeanSymbolTestCases))]
        public void GetLeanSymbol(string instrumentId, string ticker, string market, SecurityType securityType, string value, string expirationDate)
        {
            using (var apiClient = new TTApiClient(_appKey, _appSecret, _environment))
            {
                var symbolMapper = new TradingTechnologiesSymbolMapper(apiClient);

                var symbol = symbolMapper.GetLeanSymbol(instrumentId);

                Assert.AreEqual(ticker, symbol.ID.Symbol);
                Assert.AreEqual(market, symbol.ID.Market);
                Assert.AreEqual(securityType, symbol.SecurityType);
                Assert.AreEqual(value, symbol.Value);
                Assert.AreEqual(expirationDate, symbol.ID.Date.ToString("yyyyMMdd"));
            }
        }

        [TestCaseSource(nameof(_getDisplayFactorTestCases))]
        public void ReturnsCorrectFuturesDisplayFactor(Symbol symbol, decimal expectedDisplayFactor)
        {
            using (var apiClient = new TTApiClient(_appKey, _appSecret, _environment))
            {
                var symbolMapper = new TradingTechnologiesSymbolMapper(apiClient);

                var displayFactor = symbolMapper.GetDisplayFactor(symbol);

                Assert.AreEqual(expectedDisplayFactor, displayFactor);
            }
        }

        [TestCaseSource(nameof(_getBrokerageTickerTestCases))]
        public void GetBrokerageTicker(Symbol symbol, string expectedBrokerageTicker)
        {
            using (var apiClient = new TTApiClient(_appKey, _appSecret, _environment))
            {
                var symbolMapper = new TradingTechnologiesSymbolMapper(apiClient);

                var brokerageTicker = symbolMapper.GetBrokerageTicker(symbol);

                Assert.AreEqual(expectedBrokerageTicker, brokerageTicker);
            }
        }

        [TestCase("ES", "ES")]
        [TestCase("GC", "GC")]
        [TestCase("CL", "CL")]
        [TestCase("ZB", "ZB")]
        [TestCase("VX", "VX")]
        [TestCase("BRN", "B")]
        public void GetLeanTicker(string brokerageTicker, string expectedLeanTicker)
        {
            using (var apiClient = new TTApiClient(_appKey, _appSecret, _environment))
            {
                var symbolMapper = new TradingTechnologiesSymbolMapper(apiClient);

                var leanTicker = symbolMapper.GetLeanTicker(brokerageTicker);

                Assert.AreEqual(expectedLeanTicker, leanTicker);
            }
        }

        private static readonly object[] _getLeanSymbolTestCases =
        {
            new TestCaseData("2805180176927918494", "ES", Market.CME, SecurityType.Future, "ES19H21", "20210319"),

            new TestCaseData("1073353202605093065", "GC", Market.COMEX, SecurityType.Future, "GC29H21", "20210329"),

            new TestCaseData("18435539731961972115", "CL", Market.NYMEX, SecurityType.Future, "CL22H21", "20210222"),
            new TestCaseData("17384119438455857115", "CL", Market.NYMEX, SecurityType.Future, "CL22J21", "20210322"),

            new TestCaseData("17539691338672951049", "VX", Market.CFE, SecurityType.Future, "VX17H21", "20210317"),
            new TestCaseData("4240879582712226511", "VX", Market.CFE, SecurityType.Future, "VX21J21", "20210421"),

            new TestCaseData("16180764321245570431", "DX", Market.ICE, SecurityType.Future, "DX15H21", "20210315"),

            new TestCaseData("796129081275573355", "B", Market.ICE, SecurityType.Future, "B31K21", "20210331")
        };

        private static readonly object[] _getDisplayFactorTestCases =
        {
            new TestCaseData(Symbol.CreateFuture("ES", Market.CME, new DateTime(2022, 9, 16)), 0.01m),

            new TestCaseData(Symbol.CreateFuture("GC", Market.COMEX, new DateTime(2022, 12, 28)), 0.1m),

            new TestCaseData(Symbol.CreateFuture("CL", Market.NYMEX, new DateTime(2022, 11, 21)), 0.01m),

            new TestCaseData(Symbol.CreateFuture("CSC", Market.CME, new DateTime(2022, 10, 4)), 0.001m),

            new TestCaseData(Symbol.CreateFuture("6B", Market.CME, new DateTime(2022, 12, 19)), 0.0001m),

            new TestCaseData(Symbol.CreateFuture("6E", Market.CME, new DateTime(2022, 12, 19)), 0.0001m),

            new TestCaseData(Symbol.CreateFuture("6J", Market.CME, new DateTime(2022, 12, 19)), 0.000001m),

            new TestCaseData(Symbol.CreateFuture("VX", Market.CFE, new DateTime(2022, 5, 18)), 1m),

            new TestCaseData(Symbol.CreateFuture("B", Market.ICE, new DateTime(2022, 7, 29)), 1m)
        };

        private static readonly object[] _getBrokerageTickerTestCases =
        {
            new TestCaseData(Symbol.CreateFuture("ES", Market.CME, new DateTime(2021, 3, 19)), "ES"),

            new TestCaseData(Symbol.CreateFuture("GC", Market.COMEX, new DateTime(2021, 3, 29)), "GC"),

            new TestCaseData(Symbol.CreateFuture("CL", Market.NYMEX, new DateTime(2021, 3, 22)), "CL"),

            new TestCaseData(Symbol.CreateFuture("VX", Market.CFE, new DateTime(2021, 3, 17)), "VX"),

            new TestCaseData(Symbol.CreateFuture("B", Market.ICE, new DateTime(2021, 3, 31)), "BRN")
        };

    }
}
