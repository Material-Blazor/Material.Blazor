using System;
using System.Collections.Generic;

namespace BlazorMdc
{
    public class AttributeMapper
    {
        public List<Func<KeyValuePair<string, object>>> Items = new List<Func<KeyValuePair<string, object>>>();
    }


    public static class AttributeMapperExtensions
    {
        public static T Add<T>(this T m, KeyValuePair<string, object> attribute) where T : AttributeMapper
        {
            m.Items.Add(() => attribute);
            return m;
        }


        public static T Get<T>(this T m, Func<KeyValuePair<string, object>> funcName) where T : AttributeMapper
        {
            m.Items.Add(funcName);
            return m;
        }

        public static T GetIf<T>(this T m, Func<KeyValuePair<string, object>?> funcName, Func<bool> func) where T : AttributeMapper
        {
            m.Items.Add(() => func() ? funcName() : null);
            return m;
        }

        public static T If<T>(this T m, KeyValuePair<string, object> attribute, Func<bool> func) where T : AttributeMapper
        {
            m.Items.Add(() => func() ? attribute : null);
            return m;
        }
    }
}