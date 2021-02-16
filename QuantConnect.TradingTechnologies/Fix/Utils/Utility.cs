/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using QuantConnect.Fix.TT.FIX44.Fields;
using QuantConnect.Fix.TT.FIX44.Messages;
using QuantConnect.Orders;
using QuantConnect.Securities;
using TimeInForce = QuantConnect.Orders.TimeInForce;

namespace QuantConnect.TradingTechnologies.Fix.Utils
{
    public static class Utility
    {
        private static readonly SymbolPropertiesDatabase _symbolPropertiesDatabase = SymbolPropertiesDatabase.FromDataFolder();

        public static decimal GetPriceMultiplier(Symbol symbol)
        {
            if (symbol.SecurityType == SecurityType.Future)
            {
                if (_symbolPropertiesDatabase.TryGetMarket(symbol.ID.Symbol, symbol.SecurityType, out var market))
                {
                    var symbolProperties = _symbolPropertiesDatabase.GetSymbolProperties(market, symbol, symbol.SecurityType, Currencies.USD);
                    var decimalPlaces = (int)BitConverter.GetBytes(decimal.GetBits(symbolProperties.MinimumPriceVariation)[3])[2];

                    return (int)Math.Pow(10, decimalPlaces);
                }
            }

            return 100;
        }

        public static OrderStatus ConvertOrderStatus(ExecutionReport execution)
        {
            var execType = execution.ExecType.getValue();
            if (execType == ExecType.ORDER_STATUS)
            {
                execType = execution.OrdStatus.getValue();
            }

            switch (execType)
            {
                case ExecType.NEW:
                    return OrderStatus.Submitted;

                case ExecType.CANCELLED:
                    return OrderStatus.Canceled;

                case ExecType.REPLACED:
                    return OrderStatus.UpdateSubmitted;

                case ExecType.PARTIAL_FILL:
                    return OrderStatus.PartiallyFilled;

                case ExecType.FILL:
                    return OrderStatus.Filled;

                case ExecType.TRADE:
                    return execution.CumQty.getValue() < execution.OrderQty.getValue()
                        ? OrderStatus.PartiallyFilled
                        : OrderStatus.Filled;

                default:
                    return OrderStatus.Invalid;
            }
        }

        public static OrderType ConvertOrderType(char orderType)
        {
            switch (orderType)
            {
                case OrdType.MARKET:
                    return OrderType.Market;

                case OrdType.LIMIT:
                    return OrderType.Limit;

                case OrdType.STOP:
                    return OrderType.StopMarket;

                case OrdType.STOP_LIMIT:
                    return OrderType.StopLimit;

                default:
                    throw new NotSupportedException($"Unsupported order type: {orderType}");
            }
        }

        public static TimeInForce ConvertTimeInForce(char timeInForce)
        {
            switch (timeInForce)
            {
                case QuantConnect.Fix.TT.FIX44.Fields.TimeInForce.GOOD_TILL_CANCEL:
                    return TimeInForce.GoodTilCanceled;

                case QuantConnect.Fix.TT.FIX44.Fields.TimeInForce.DAY:
                    return TimeInForce.Day;

                default:
                    throw new NotSupportedException($"Unsupported TimeInForce: {timeInForce}");
            }
        }

        public static char ConvertOrderType(OrderType orderType)
        {
            switch (orderType)
            {
                case OrderType.Market:
                    return OrdType.MARKET;

                case OrderType.Limit:
                    return OrdType.LIMIT;

                case OrderType.StopMarket:
                    return OrdType.STOP;

                case OrderType.StopLimit:
                    return OrdType.STOP_LIMIT;

                default:
                    throw new NotSupportedException($"Unsupported order type: {orderType}");
            }
        }

        public static QuantConnect.Fix.TT.FIX44.Fields.TimeInForce ConvertTimeInForce(TimeInForce timeInForce)
        {
            if (timeInForce == TimeInForce.GoodTilCanceled)
            {
                return new QuantConnect.Fix.TT.FIX44.Fields.TimeInForce(QuantConnect.Fix.TT.FIX44.Fields.TimeInForce.GOOD_TILL_CANCEL);
            }

            if (timeInForce == TimeInForce.Day)
            {
                return new QuantConnect.Fix.TT.FIX44.Fields.TimeInForce(QuantConnect.Fix.TT.FIX44.Fields.TimeInForce.DAY);
            }

            throw new NotSupportedException($"Unsupported TimeInForce: {timeInForce.GetType().Name}");
        }

        public static MaturityMonthYear GetMaturityMonthYear(Symbol symbol)
        {
            if (symbol.SecurityType != SecurityType.Future)
            {
                throw new NotSupportedException("GetMaturityMonthYear() can only be called for the Future security type.");
            }

            var ticker = SymbolRepresentation.GenerateFutureTicker(symbol.ID.Symbol, symbol.ID.Date);
            var properties = SymbolRepresentation.ParseFutureTicker(ticker);

            var maturity = $"{2000 + properties.ExpirationYearShort:D4}{properties.ExpirationMonth:D2}";

            return new MaturityMonthYear(maturity);
        }
    }
}
