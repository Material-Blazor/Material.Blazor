using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorMdc
{
    public class AttributeMapper
    {
        public List<Func<KeyValuePair<string, object>>> Items = new List<Func<KeyValuePair<string, object>>>();

        public IDictionary<string, object> ToDictionary()
        {
            return Items.Select(i => i()).Where(i => i.Key != null).ToDictionary(i => i.Key, i => i.Value);
        }
    }


    public static class AttributeMapperExtensions
    {
        public static T Clear<T>(this T m) where T : AttributeMapper
        {
            m.Items.Clear();
            return m;
        }

        public static T Add<T>(this T m, string name, object value) where T : AttributeMapper
        {
            m.Items.Add(() => new KeyValuePair<string, object>(name, value));
            return m;
        }

        public static T AddIf<T>(this T m, string name, object value, Func<bool> func) where T : AttributeMapper
        {
            m.Items.Add(() => func() ? new KeyValuePair<string, object>(name, value) : new KeyValuePair<string, object>(null, null));
            return m;
        }


        public static T Get<T>(this T m, Func<KeyValuePair<string, object>> funcName) where T : AttributeMapper
        {
            m.Items.Add(funcName);
            return m;
        }

        public static T GetIf<T>(this T m, Func<KeyValuePair<string, object>> funcName, Func<bool> func) where T : AttributeMapper
        {
            m.Items.Add(() => func() ? funcName() : new KeyValuePair<string, object>(null, null));
            return m;
        }
    }
}