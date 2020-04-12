using System;
using System.Collections.Generic;

namespace BlazorMdc
{
    public class AttributeBuilderRuleDictionary<T, TK> : AttributeBuilderRule<T>
    {
        public IDictionary<TK, KeyValuePair<string, object>> Dictionary { get; set; }

        public Func<T, TK> Func { get; set; }

        public AttributeBuilderRuleDictionary(Func<T, TK> func, IDictionary<TK, KeyValuePair<string, object>> dictionary)
        {
            Func = func;
            Dictionary = dictionary;
        }

        public override string GetName(T data)
        {
            //var key = Func(data);

            //if (Dictionary.TryGetValue(key, out KeyValuePair<string, object> value))
            //{
            //    return value.Key;
            //}

            //return null;
            return GetDictionaryValue(data)?.Key;
        }

        public override object GetValue(T data)
        {
            //var key = Func(data);

            //if (Dictionary.TryGetValue(key, out KeyValuePair<string, object> value))
            //{
            //    return value.Value;
            //}

            //return null;
            return GetDictionaryValue(data)?.Value;
        }

        private KeyValuePair<string, object>? GetDictionaryValue(T data)
        {
            var key = Func(data);

            if (Dictionary.TryGetValue(key, out KeyValuePair<string, object> value))
            {
                return value;
            }

            return null;
        }
    }
}