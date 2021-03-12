/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using QuantConnect.Brokerages;
using QuantConnect.Securities;
using QuantConnect.TradingTechnologies.TT.Api;

namespace QuantConnect.TradingTechnologies
{
    public class TradingTechnologiesSymbolMapper : ISymbolMapper
    {
        private readonly TTApiClient _apiClient;
        private readonly SymbolPropertiesDatabase _symbolPropertiesDatabase = SymbolPropertiesDatabase.FromDataFolder();

        // TT SecurityExchange -> Lean market
        private readonly Dictionary<string, string> _mapSecurityExchangeToLeanMarket = new Dictionary<string, string>
        {
            { "CME", Market.CME },
            { "CBOE", Market.CBOE },
            { "ICE", Market.ICE }
        };

        // Lean market -> TT SecurityExchange
        private readonly Dictionary<string, string> _mapLeanMarketToSecurityExchange;

        // TT ProductType -> LEAN security type
        private readonly Dictionary<string, SecurityType> _mapProductTypeToLeanSecurityType = new Dictionary<string, SecurityType>
        {
            { QuantConnect.Fix.TT.FIX44.Fields.SecurityType.COMMON_STOCK, SecurityType.Equity },
            { QuantConnect.Fix.TT.FIX44.Fields.SecurityType.FUTURE, SecurityType.Future },
            { QuantConnect.Fix.TT.FIX44.Fields.SecurityType.OPTION, SecurityType.Option }
        };

        // LEAN security type -> TT ProductType
        private readonly Dictionary<SecurityType, string> _mapLeanSecurityTypeToProductType;

        // TT ProductTypeId -> LEAN security type
        private readonly Dictionary<int, SecurityType> _mapProductTypes = new Dictionary<int, SecurityType>();

        // TT MarketId -> LEAN market
        private readonly Dictionary<int, string> _mapMarkets = new Dictionary<int, string>();

        // TT InstrumentId -> TT Instrument
        private readonly Dictionary<string, Instrument> _instruments = new Dictionary<string, Instrument>();

        public TradingTechnologiesSymbolMapper(TTApiClient apiClient)
        {
            _apiClient = apiClient;

            _mapLeanMarketToSecurityExchange = _mapSecurityExchangeToLeanMarket
                .ToDictionary(x => x.Value, x => x.Key);

            // Add CME Group mappings manually
            _mapLeanMarketToSecurityExchange.Add(Market.COMEX, "CME");
            _mapLeanMarketToSecurityExchange.Add(Market.NYMEX, "CME");
            _mapLeanMarketToSecurityExchange.Add(Market.CBOT, "CME");

            // TODO: remove when Market.CFE is added to LEAN
            _mapSecurityExchangeToLeanMarket.Add("CFE", Market.CBOE);

            _mapLeanSecurityTypeToProductType = _mapProductTypeToLeanSecurityType
                .ToDictionary(x => x.Value, x => x.Key);

            LoadProductTypesMap();
            LoadMarketsMap();
        }

        public string GetBrokerageSymbol(Symbol symbol)
        {
            throw new NotSupportedException();
        }

        public Symbol GetLeanSymbol(string brokerageSymbol, SecurityType securityType, string market,
            DateTime expirationDate = default(DateTime), decimal strike = 0, OptionRight optionRight = OptionRight.Call)
        {
            throw new NotSupportedException();
        }

        public Symbol GetLeanSymbol(string instrumentId)
        {
            var instrument = GetInstrument(instrumentId);

            var ticker = instrument.ProductSymbol;
            var securityType = GetSecurityType(instrument.ProductTypeId);
            var market = GetMarket(instrument.MarketId);
            if (market == Market.CME)
            {
                market = GetLeanMarket(securityType, "CME", ticker);
            }

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

        public string GetBrokerageMarket(string leanMarket, SecurityType leanSecurityType)
        {
            if (!_mapLeanMarketToSecurityExchange.TryGetValue(leanMarket, out var market))
            {
                throw new NotSupportedException($"Unsupported LEAN Market: {leanMarket}");
            }

            // TODO: remove when Market.CFE is added to LEAN
            if (leanMarket == Market.CBOE && leanSecurityType == SecurityType.Future)
            {
                market = "CFE";
            }

            return market;
        }

        public string GetBrokerageProductType(SecurityType leanSecurityType)
        {
            if (!_mapLeanSecurityTypeToProductType.TryGetValue(leanSecurityType, out var productType))
            {
                throw new NotSupportedException($"Unsupported LEAN security type: {leanSecurityType}");
            }

            return productType;
        }

        public string GetLeanMarket(SecurityType securityType, string securityExchange, string ticker)
        {
            // TT groups all CME Group exchanges under the same security exchange,
            // so we use the symbol properties database to find the correct LEAN market
            if (securityExchange == "CME")
            {
                if (_symbolPropertiesDatabase.TryGetMarket(ticker, securityType, out var leanMarket))
                {
                    return leanMarket;
                }
            }

            if (!_mapSecurityExchangeToLeanMarket.TryGetValue(securityExchange, out var market))
            {
                throw new NotSupportedException($"Unsupported TT SecurityExchange: {securityExchange}");
            }

            return market;
        }

        public SecurityType GetLeanSecurityType(string productType)
        {
            if (!_mapProductTypeToLeanSecurityType.TryGetValue(productType, out var securityType))
            {
                throw new NotSupportedException($"Unsupported TT ProductType: {productType}");
            }

            return securityType;
        }

        private void LoadProductTypesMap()
        {
            var productTypes = _apiClient.GetProductTypes().SynchronouslyAwaitTaskResult();

            foreach (var productType in productTypes)
            {
                if (_mapProductTypeToLeanSecurityType.TryGetValue(productType.Name, out var securityType))
                {
                    _mapProductTypes.Add(Convert.ToInt32(productType.Id, CultureInfo.InvariantCulture), securityType);
                }
            }
        }

        private void LoadMarketsMap()
        {
            var markets = _apiClient.GetMarkets().SynchronouslyAwaitTaskResult();

            foreach (var market in markets)
            {
                if (_mapSecurityExchangeToLeanMarket.TryGetValue(market.Name, out var leanMarket))
                {
                    _mapMarkets.Add(Convert.ToInt32(market.Id, CultureInfo.InvariantCulture), leanMarket);
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
