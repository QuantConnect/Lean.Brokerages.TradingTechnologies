/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using NUnit.Framework;
using QuantConnect.TradingTechnologies.Fix.Utils;

namespace QuantConnect.TradingTechnologiesTests
{
    [TestFixture]
    public class UtilityTests
    {
        [TestCaseSource(nameof(_getPriceMultiplierTestCases))]
        public void ReturnsCorrectFuturesPriceMultiplier(Symbol symbol, decimal expectedPriceMultiplier)
        {
            var priceMultiplier = Utility.GetPriceMultiplier(symbol);

            Assert.AreEqual(expectedPriceMultiplier, priceMultiplier);
        }

        [TestCaseSource(nameof(_getMaturityMonthYear))]
        public void ReturnsCorrectMaturityMonthYear(Symbol symbol, string expectedMaturityMonthYear)
        {
            var maturityMonthYear = Utility.GetMaturityMonthYear(symbol).getValue();

            Assert.AreEqual(expectedMaturityMonthYear, maturityMonthYear);
        }

        private static readonly object[] _getPriceMultiplierTestCases =
        {
            new TestCaseData(Symbol.CreateFuture("GC", Market.CME, new DateTime(2021, 1, 31)), 10m),

            new TestCaseData(Symbol.CreateFuture("ES", Market.CME, new DateTime(2021, 3, 19)), 100m),

            new TestCaseData(Symbol.CreateFuture("CSC", Market.CME, new DateTime(2021, 3, 19)), 1000m),

            new TestCaseData(Symbol.CreateFuture("6B", Market.CME, new DateTime(2021, 3, 19)), 10000m),

            new TestCaseData(Symbol.CreateFuture("6E", Market.CME, new DateTime(2021, 3, 19)), 100000m),

            new TestCaseData(Symbol.CreateFuture("6J", Market.CME, new DateTime(2021, 3, 19)), 10000000m)
        };

        private static readonly object[] _getMaturityMonthYear =
        {
            new TestCaseData(Symbol.CreateFuture("ES", Market.CME, new DateTime(2021, 3, 19)), "202103"),
            new TestCaseData(Symbol.CreateFuture("GC", Market.CME, new DateTime(2021, 3, 29)), "202103"),
            new TestCaseData(Symbol.CreateFuture("CL", Market.CME, new DateTime(2021, 2, 22)), "202103")
        };
    }
}
