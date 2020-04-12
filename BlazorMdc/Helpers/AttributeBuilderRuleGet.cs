using System;
using System.Collections.Generic;

namespace BlazorMdc
{
    public class AttributeBuilderRuleGet<T> : AttributeBuilderRule<T>
    {
        public Func<T, KeyValuePair<string, object>> Func { get; set; }

        public AttributeBuilderRuleGet(Func<T, KeyValuePair<string, object>> func)
        {
            Func = func;
        }

        public override string GetName(T data)
        {
            return Func(data).Key;
        }

        public override object GetValue(T data)
        {
            return Func(data).Value;
        }
    }
}