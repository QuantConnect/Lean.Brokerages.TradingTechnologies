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

        public static bool TryParseMaturityMonthYear(string value, out string result)
        {
            switch (value.Length)
            {
                case 2:
                    value = "2020" + value;
                    break;
                case 4:
                    value = "20" + value;
                    break;
            }

            if (value.Length == 6 && int.TryParse(value, out _))
            {
                result = value;
                return true;
            }

            result = null;
            return false;
        }

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

                case ExecType.PARTIAL_FILL:
                    return OrderStatus.PartiallyFilled;

                case ExecType.FILL:
                case ExecType.TRADE:
                    return OrderStatus.Filled;

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

        public static SecurityType ConvertSecurityType(string securityType)
        {
            switch (securityType)
            {
                case QuantConnect.Fix.TT.FIX44.Fields.SecurityType.FUTURE:
                    return SecurityType.Future;

                case QuantConnect.Fix.TT.FIX44.Fields.SecurityType.OPTION:
                    return SecurityType.Option;

                case QuantConnect.Fix.TT.FIX44.Fields.SecurityType.OPTIONS_ON_FUTURES:
                    return SecurityType.FutureOption;

                case QuantConnect.Fix.TT.FIX44.Fields.SecurityType.COMMON_STOCK:
                    return SecurityType.Equity;

                default:
                    throw new NotSupportedException($"Unsupported security type: {securityType}");
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

    }
}
