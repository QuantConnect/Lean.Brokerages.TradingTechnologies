/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using QuantConnect.Logging;
using QuantConnect.Securities;
using QuantConnect.Brokerages.TradingTechnologies.TT.Api;

namespace QuantConnect.Brokerages.TradingTechnologies
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
            { "CFE", Market.CFE },
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

        // LEAN symbol --> TT InstrumentId
        private readonly Dictionary<Symbol, string> _mapSymbolToInstrumentId = new Dictionary<Symbol, string>();

        // LEAN ticker --> TT ticker
        private readonly Dictionary<string, string> _tickerMappings = new Dictionary<string, string>
        {
            { "B", "BRN" }
        };

        public TradingTechnologiesSymbolMapper(TTApiClient apiClient)
        {
            _apiClient = apiClient;

            _mapLeanMarketToSecurityExchange = _mapSecurityExchangeToLeanMarket
                .ToDictionary(x => x.Value, x => x.Key);

            // Add CME Group mappings manually
            _mapLeanMarketToSecurityExchange.Add(Market.COMEX, "CME");
            _mapLeanMarketToSecurityExchange.Add(Market.NYMEX, "CME");
            _mapLeanMarketToSecurityExchange.Add(Market.CBOT, "CME");

            _mapLeanSecurityTypeToProductType = _mapProductTypeToLeanSecurityType
                .ToDictionary(x => x.Value, x => x.Key);

            LoadProductTypesMap();
            LoadMarketsMap();

            Log.Trace("TradingTechnologiesSymbolMapper(): LeanSecurityTypeToProductType: " +
                      $"{string.Join(",", _mapLeanSecurityTypeToProductType.Select(pair => $"{pair.Key}:{pair.Value}"))}");
            Log.Trace("TradingTechnologiesSymbolMapper(): SecurityExchangeToLeanMarket: " +
                      $"{string.Join(",", _mapSecurityExchangeToLeanMarket.Select(pair => $"{pair.Key}:{pair.Value}"))}");
            Log.Trace("TradingTechnologiesSymbolMapper(): LeanMarketToSecurityExchange: " +
                      $"{string.Join(",", _mapLeanMarketToSecurityExchange.Select(pair => $"{pair.Key}:{pair.Value}"))}");
            Log.Trace("TradingTechnologiesSymbolMapper(): Markets: " +
                      $"{string.Join(",", _mapMarkets.Select(pair => $"{pair.Key}:{pair.Value}"))}");
        }

        public string GetBrokerageSymbol(Symbol symbol)
        {
            // unused
            throw new NotSupportedException();
        }

        public Symbol GetLeanSymbol(string brokerageSymbol, SecurityType securityType, string market,
            DateTime expirationDate = default(DateTime), decimal strike = 0, OptionRight optionRight = OptionRight.Call)
        {
            // unused
            throw new NotSupportedException();
        }

        public Symbol GetLeanSymbol(string instrumentId)
        {
            var instrument = GetInstrument(instrumentId);

            var ticker = GetLeanTicker(instrument.ProductSymbol);
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

                // TODO: US Equities and Options not supported by TT for now
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

        public decimal GetDisplayFactor(Symbol symbol)
        {
            if (symbol.SecurityType == SecurityType.Future)
            {
                var instrumentId = GetInstrumentId(symbol);
                var instrument = GetInstrument(instrumentId);

                return instrument.DisplayFactor;
            }

            throw new NotSupportedException($"GetDisplayFactor(): Unsupported security type: {symbol.SecurityType}");
        }

        public string GetBrokerageTicker(Symbol symbol)
        {
            var ticker = symbol.ID.Symbol;

            if (_tickerMappings.TryGetValue(ticker, out var mappedTicker))
            {
                ticker = mappedTicker;
            }

            return ticker;
        }

        public string GetLeanTicker(string brokerageTicker)
        {
            var leanTicker = brokerageTicker;

            var mapping = _tickerMappings.FirstOrDefault(x => x.Value.Equals(brokerageTicker, StringComparison.InvariantCultureIgnoreCase));
            if (mapping.Key != null)
            {
                leanTicker = mapping.Key;
            }

            return leanTicker;
        }

        private string GetInstrumentId(Symbol symbol)
        {
            if (!_mapSymbolToInstrumentId.TryGetValue(symbol, out var instrumentId))
            {
                var marketId = GetMarketId(symbol.ID.Market);

                var products = _apiClient.GetProducts(marketId).SynchronouslyAwaitTaskResult();

                var productTypeId = GetProductTypeId(symbol.SecurityType);

                var ticker = GetBrokerageTicker(symbol);

                var product = products.FirstOrDefault(x => x.ProductTypeId.Equals(productTypeId, StringComparison.InvariantCultureIgnoreCase) && x.Symbol.Equals(ticker, StringComparison.InvariantCultureIgnoreCase));
                if (product == null)
                {
                    throw new NotSupportedException($"GetInstrumentId(): product not found - ProductTypeId: {productTypeId}, Symbol: {ticker}");
                }

                var instruments = _apiClient.GetInstruments(product.ProductTypeId, product.Id).SynchronouslyAwaitTaskResult();
                if (instruments.Count == 0)
                {
                    throw new NotSupportedException($"GetInstrumentId(): no instruments found - ProductTypeId: {product.ProductTypeId}, ProductId: {product.Id}");
                }

                var instrument = instruments.FirstOrDefault(x =>
                {
                    var date = (int) (x.ExpirationDate / 1000000);
                    var expirationDate = new DateTime(date / 10000, date / 100 % 100, date % 100);
                    return expirationDate == symbol.ID.Date.Date;
                });
                if (instrument == null)
                {
                    throw new NotSupportedException($"GetInstrumentId(): expiration date not found - ExpirationDate: {symbol.ID.Date}, Symbol: {ticker}");
                }

                if (!_instruments.ContainsKey(instrument.Id))
                {
                    _instruments.Add(instrument.Id, instrument);
                }

                instrumentId = instrument.Id;

                _mapSymbolToInstrumentId.Add(symbol, instrumentId);
            }

            return instrumentId;
        }

        private string GetMarketId(string market)
        {
            // TT groups all CME Group exchanges under the same security exchange
            if (market == Market.COMEX || market == Market.NYMEX || market == Market.CBOT)
            {
                market = Market.CME;
            }

            var entry = _mapMarkets.FirstOrDefault(x => x.Value.Equals(market, StringComparison.InvariantCultureIgnoreCase));
            if (entry.Value == null)
            {
                Log.Trace($"{nameof(TradingTechnologiesSymbolMapper)}.{nameof(GetMarketId)}.market: {market}," +
                    $"_mapMarkets: {string.Join(",", _mapMarkets.Values)}");
                throw new NotSupportedException($"GetMarketId(): unsupported Lean market: {market}");
            }

            return entry.Key.ToStringInvariant();
        }

        private string GetProductTypeId(SecurityType securityType)
        {
            var entry = _mapProductTypes.FirstOrDefault(x => x.Value == securityType);
            if (entry.Value == default)
            {
                throw new NotSupportedException($"GetProductTypeId(): unsupported Security type: {securityType}");
            }

            return entry.Key.ToStringInvariant();
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
                var id = Convert.ToInt32(market.Id, CultureInfo.InvariantCulture);
                var name = market.Name.ToUpperInvariant();
                if (_mapSecurityExchangeToLeanMarket.TryGetValue(name, out var leanMarket))
                {
                    _mapMarkets.Add(id, leanMarket);
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
