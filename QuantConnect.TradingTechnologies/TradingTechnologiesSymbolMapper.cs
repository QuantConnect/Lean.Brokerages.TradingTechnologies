/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Globalization;
using QuantConnect.Brokerages;
using QuantConnect.TradingTechnologies.TT.Api;

namespace QuantConnect.TradingTechnologies
{
    public class TradingTechnologiesSymbolMapper : ISymbolMapper
    {
        private readonly TTApiClient _apiClient;

        public TradingTechnologiesSymbolMapper(TTApiClient apiClient)
        {
            _apiClient = apiClient;

            var currencies = _apiClient.GetCurrencies().SynchronouslyAwaitTaskResult();
            var productTypes = _apiClient.GetProductTypes().SynchronouslyAwaitTaskResult();
            var markets = _apiClient.GetMarkets().SynchronouslyAwaitTaskResult();


        }

        public string GetBrokerageSymbol(Symbol symbol)
        {
            throw new NotImplementedException();
        }

        public Symbol GetLeanSymbol(string brokerageSymbol, SecurityType securityType, string market,
            DateTime expirationDate = default(DateTime), decimal strike = 0, OptionRight optionRight = OptionRight.Call)
        {
            throw new NotImplementedException();
        }

        public Symbol GetLeanSymbol(string instrumentId)
        {
            // TODO: cache instruments in dictionary
            var instrument = _apiClient.GetInstrument(instrumentId).SynchronouslyAwaitTaskResult();

            var securityType = GetSecurityType(instrument.ProductTypeId);
            var market = GetMarket(instrument.MarketId);
            var ticker = instrument.ProductSymbol;

            switch (securityType)
            {
                case SecurityType.Future:
                    var expiryDate = GetFutureExpirationDate(instrument.ExpirationDate);
                    return Symbol.CreateFuture(ticker, market, expiryDate);

                default:
                    throw new NotSupportedException($"Unsupported security type: {securityType}");
            }
        }

        private SecurityType GetSecurityType(int productTypeId)
        {
            // TODO: map from productTypes dictionary

            return SecurityType.Future;
        }

        private string GetMarket(int marketId)
        {
            // TODO: map from markets dictionary

            return Market.CME;
        }

        private DateTime GetFutureExpirationDate(long expirationDate)
        {
            return DateTime.ParseExact(expirationDate.ToStringInvariant(), "yyyyMMdd", CultureInfo.InvariantCulture);
        }
    }
}
