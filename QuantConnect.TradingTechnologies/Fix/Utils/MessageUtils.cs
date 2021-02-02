/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using QuickFix.Fields;

namespace QuantConnect.TradingTechnologies.Fix.Utils
{
    public static class MessageUtils
    {
        private static readonly ConcurrentDictionary<Type, object> DataValues = new ConcurrentDictionary<Type, object>();

        /// <summary>
        ///     Provides a human-readable description of a field, instead of the FIX value.
        /// </summary>
        /// <typeparam name="T">Type of field</typeparam>
        /// <param name="field">Field to lookup (can be null)</param>
        /// <param name="isSet">Result of the IsSet() method for that field.</param>
        /// <returns>
        ///     Name the field's value has in the class, 'unknown:x' if the value did not match any valid values, or 'unset'
        ///     if the field was not set.
        /// </returns>
        public static string DescribeChar<T>(this T field, bool isSet) where T : CharField, new()
        {
            return field.Describe<T, char>(isSet);
        }

        /// <summary>
        ///     Provides a human-readable description of a field, instead of the FIX value.
        /// </summary>
        /// <typeparam name="T">Type of field</typeparam>
        /// <param name="field">Field to lookup (can be null)</param>
        /// <param name="isSet">Result of the IsSet() method for that field.</param>
        /// <returns>
        ///     Name the field's value has in the class, 'unknown:x' if the value did not match any valid values, or 'unset'
        ///     if the field was not set.
        /// </returns>
        public static string DescribeInt<T>(this T field, bool isSet) where T : IntField, new()
        {
            return field.Describe<T, int>(isSet);
        }

        /// <summary>
        ///     Provides a human-readable description of a field, instead of the FIX value.
        /// </summary>
        /// <typeparam name="T">Type of field</typeparam>
        /// <typeparam name="TBase">Data type of <typeparamref name="T" /></typeparam>
        /// <param name="field">Field to lookup (can be null)</param>
        /// <param name="isSet">Result of the IsSet() method for that field.</param>
        /// <returns>
        ///     Name the field's value has in the class, 'unknown:x' if the value did not match any valid values, or 'unset'
        ///     if the field was not set.
        /// </returns>
        private static string Describe<T, TBase>(this T field, bool isSet) where T : FieldBase<TBase>, new()
        {
            if (!isSet)
            {
                return "<unset>";
            }

            if (field == null)
            {
                throw new ArgumentNullException(nameof(field), $"Parameter '{nameof(field)}' was null, despite {nameof(isSet)} being true.");
            }

            IReadOnlyDictionary<T, string> values;
            if (DataValues.TryGetValue(typeof(T), out var v))
            {
                values = (IReadOnlyDictionary<T, string>) v;
            }
            else
            {
                values = GetFieldNames<T, TBase>();
                DataValues[typeof(T)] = values;
            }

            return values.TryGetValue(field, out var r) ? r : $"<unknown:{field.Obj}>";
        }

        /// <summary>
        ///     Obtains the names of the values for a FIX field.
        /// </summary>
        /// <typeparam name="T">FIX field that extends <see cref="FieldBase{TBase}" /></typeparam>
        /// <typeparam name="TBase">Value type of the field.</typeparam>
        /// <returns>
        ///     A dictionary of names of values this field can receive, keyed on the actual integer value the field will be
        ///     assigned.
        /// </returns>
        private static Dictionary<T, string> GetFieldNames<T, TBase>() where T : FieldBase<TBase>, new()
        {
            return typeof(T).GetFields(BindingFlags.Static ^ BindingFlags.Public)
                .Where(f => f.FieldType == typeof(TBase))
                .GroupBy(f => (TBase) f.GetValue(null))
                .ToDictionary(g => new T {Obj = g.Key}, g => string.Join("/", g.Select(f => f.Name)));
        }
    }
}