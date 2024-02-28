/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using NUnit.Framework;
using QuantConnect.Brokerages.TradingTechnologies.Fix.Utils;

namespace QuantConnect.Brokerages.TradingTechnologiesTests
{
    [TestFixture]
    public class UtilityTests
    {
        [TestCaseSource(nameof(_getMaturityMonthYear))]
        public void ReturnsCorrectMaturityMonthYear(Symbol symbol, string expectedMaturityMonthYear)
        {
            var maturityMonthYear = Utility.GetMaturityMonthYear(symbol).getValue();

            Assert.AreEqual(expectedMaturityMonthYear, maturityMonthYear);
        }

        [TestCaseSource(nameof(_getMaturityDate))]
        public void ReturnsCorrectMaturityDate(Symbol symbol, string expectedMaturityDate)
        {
            var maturityDate = Utility.GetMaturityDate(symbol).getValue();

            Assert.AreEqual(expectedMaturityDate, maturityDate);
        }

        private static readonly object[] _getMaturityMonthYear =
        {
            new TestCaseData(Symbol.CreateFuture("ES", Market.CME, new DateTime(2021, 3, 19)), "202103"),
            new TestCaseData(Symbol.CreateFuture("GC", Market.CME, new DateTime(2021, 3, 29)), "202103"),
            new TestCaseData(Symbol.CreateFuture("CL", Market.CME, new DateTime(2021, 2, 22)), "202103"),
            new TestCaseData(Symbol.CreateFuture("CL", Market.CME, new DateTime(2021, 3, 22)), "202104"),
        };

        private static readonly object[] _getMaturityDate =
        {
            new TestCaseData(Symbol.CreateFuture("VX", Market.CFE, new DateTime(2021, 3, 17)), "20210317")
        };
    }
}
