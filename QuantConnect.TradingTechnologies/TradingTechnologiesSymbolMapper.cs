/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using QuantConnect.Brokerages;
using QuantConnect.TradingTechnologies.TT.Api;

namespace QuantConnect.TradingTechnologies
{
    public class TradingTechnologiesSymbolMapper : ISymbolMapper
    {
        private readonly TTApiClient _apiClient;

        // TT ProductTypeId -> LEAN security type
        private readonly Dictionary<int, SecurityType> _mapProductTypes = new Dictionary<int, SecurityType>();

        // TT MarketId -> LEAN market
        private readonly Dictionary<int, string> _mapMarkets = new Dictionary<int, string>();

        // TT InstrumentId -> TT Instrument
        private readonly Dictionary<string, Instrument> _instruments = new Dictionary<string, Instrument>();

        public TradingTechnologiesSymbolMapper(TTApiClient apiClient)
        {
            _apiClient = apiClient;

            LoadProductTypesMap();
            LoadMarketsMap();
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
            var instrument = GetInstrument(instrumentId);

            var securityType = GetSecurityType(instrument.ProductTypeId);
            var market = GetMarket(instrument.MarketId);
            var ticker = instrument.ProductSymbol;

            switch (securityType)
            {
                case SecurityType.Future:
                    var expiryDate = GetFutureExpirationDate(instrument.ExpirationDate);
                    return Symbol.CreateFuture(ticker, market, expiryDate);

                // TODO: add support for US Equities and Options (when testing environment available)
                case SecurityType.Equity:
                case SecurityType.Option:
                default:
                    throw new NotSupportedException($"Unsupported security type: {securityType}");
            }
        }

        private void LoadProductTypesMap()
        {
            var productTypes = _apiClient.GetProductTypes().SynchronouslyAwaitTaskResult();

            var supportedProductTypes = new Dictionary<string, SecurityType>
            {
                { "CS", SecurityType.Equity },
                { "FUT", SecurityType.Future },
                { "OPT", SecurityType.Option }
            };

            foreach (var productType in productTypes)
            {
                if (supportedProductTypes.TryGetValue(productType.Name, out var securityType))
                {
                    _mapProductTypes.Add(Convert.ToInt32(productType.Id), securityType);
                }
            }
        }

        private void LoadMarketsMap()
        {
            var markets = _apiClient.GetMarkets().SynchronouslyAwaitTaskResult();

            var supportedMarkets = new Dictionary<string, string>
            {
                { "CME", Market.CME },
                { "CBOE", Market.CBOE },
                { "ICE", Market.ICE }
            };

            foreach (var market in markets)
            {
                if (supportedMarkets.TryGetValue(market.Name, out var leanMarket))
                {
                    _mapMarkets.Add(Convert.ToInt32(market.Id), leanMarket);
                }
            }
        }

        private SecurityType GetSecurityType(int productTypeId)
        {
            if (!_mapProductTypes.TryGetValue(productTypeId, out var securityType))
            {
                throw new NotSupportedException($"Unsupported TT ProductTypeId: {productTypeId}");
            }

            return securityType;
        }

        private string GetMarket(int marketId)
        {
            if (!_mapMarkets.TryGetValue(marketId, out var market))
            {
                throw new NotSupportedException($"Unsupported TT MarketId: {marketId}");
            }

            return market;
        }

        private static DateTime GetFutureExpirationDate(long expirationDate)
        {
            return DateTime.ParseExact(expirationDate.ToStringInvariant(), "yyyyMMddHHmmss", CultureInfo.InvariantCulture).Date;
        }

        private Instrument GetInstrument(string instrumentId)
        {
            if (!_instruments.TryGetValue(instrumentId, out var instrument))
            {
                instrument = _apiClient.GetInstrument(instrumentId).SynchronouslyAwaitTaskResult();

                _instruments.Add(instrumentId, instrument);
            }

            return instrument;
        }
    }
}
