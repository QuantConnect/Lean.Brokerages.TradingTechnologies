/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using NUnit.Framework;
using QuantConnect.Configuration;
using QuantConnect.TradingTechnologies;
using QuantConnect.TradingTechnologies.TT.Api;

namespace QuantConnect.TradingTechnologiesTests
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
        // TODO: update when Market.CFE is added to LEAN
        [TestCase(Market.CBOE, SecurityType.Future, "CFE")]
        [TestCase(Market.ICE, SecurityType.Future, "ICE")]
        [TestCase(Market.CBOE, SecurityType.Option, "CBOE")]
        public void GetBrokerageMarket(string leanMarket, SecurityType leanSecurityType, string expectedMarket)
        {
            using (var apiClient = new TTApiClient(_appKey, _appSecret, _environment))
            {
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
        // TODO: update when Market.CFE is added to LEAN
        [TestCase("CFE", "VX", Market.CBOE)]
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
        public void GetLeanSymbol(string instrumentId, string ticker, string market, SecurityType securityType, string value)
        {
            using (var apiClient = new TTApiClient(_appKey, _appSecret, _environment))
            {
                var symbolMapper = new TradingTechnologiesSymbolMapper(apiClient);

                var symbol = symbolMapper.GetLeanSymbol(instrumentId);

                Assert.AreEqual(ticker, symbol.ID.Symbol);
                Assert.AreEqual(market, symbol.ID.Market);
                Assert.AreEqual(securityType, symbol.SecurityType);
                Assert.AreEqual(value, symbol.Value);
            }
        }

        private static readonly object[] _getLeanSymbolTestCases =
        {
            new TestCaseData("2805180176927918494", "ES", Market.CME, SecurityType.Future, "ES19H21"),

            new TestCaseData("1073353202605093065", "GC", Market.COMEX, SecurityType.Future, "GC29H21"),

            new TestCaseData("18435539731961972115", "CL", Market.NYMEX, SecurityType.Future, "CL22H21"),

            // TODO: update when Market.CFE is added to LEAN
            new TestCaseData("17539691338672951049", "VX", Market.CBOE, SecurityType.Future, "VX17H21"),

            new TestCaseData("16180764321245570431", "DX", Market.ICE, SecurityType.Future, "DX15H21"),
        };


    }
}
