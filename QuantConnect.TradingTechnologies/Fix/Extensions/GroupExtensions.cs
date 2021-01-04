/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Linq;
using QuickFix;
using QuickFix.Fields;

namespace QuantConnect.TradingTechnologies.Fix.Extensions
{
    public static class GroupExtensions
    {
        public static TGroup[] ReadGroups<TCount, TGroup>(this Message message) where TCount : IntField, new() where TGroup : Group, new()
        {
            if (message == null)
            {
                return new TGroup[0];
            }

            var count = message.GetField(new TCount()).getValue();
            if (count == 0)
            {
                return new TGroup[0];
            }

            var results = new TGroup[count];

            for (var i = 0; i < count; i++)
            {
                var group = new TGroup();
                // Groups start at index 1.
                message.GetGroup(i + 1, group);
                results[i] = group;
            }

            return results;
        }

        public static void AddGroup<TGroup, TField, TEnum>(this Message message) where TGroup : Group, new() where TField : CharField, new() where TEnum : Enum
        {
            message.AddGroup<TGroup, TField, TEnum, char>((f, v) => f.setValue(Convert.ToChar(v)));
        }

        private static void AddGroup<TGroup, TField, TEnum, TFieldValue>(this FieldMap message, Action<TField, TEnum> setterAction)
            where TGroup : Group, new() where TField : FieldBase<TFieldValue>, new() where TEnum : Enum
        {
            var items = Enum.GetValues(typeof(TEnum)).Cast<TEnum>().ToArray();

            foreach (var item in items)
            {
                var group = new TGroup();
                var field = new TField();
                setterAction(field, item);
                group.SetField(field);
                message.AddGroup(group);
            }
        }
    }
}