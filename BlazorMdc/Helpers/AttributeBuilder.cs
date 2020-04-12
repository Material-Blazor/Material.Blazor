using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorMdc
{
    public class AttributeBuilder<T>
    {
        public static AttributeBuilder<T> Create()
        {
            return new AttributeBuilder<T>();
        }

        public AttributeBuilder<T> If(string name, object value, Func<T, bool> func)
        {
            Rules.Add(new AttributeBuilderRuleIf<T>(name, value, func));
            return this;
        }

        public AttributeBuilder<T> Get(Func<T, KeyValuePair<string, object>> func)
        {
            Rules.Add(new AttributeBuilderRuleGet<T>(func));
            return this;
        }

        public AttributeBuilder<T> Class(string name, object value)
        {
            Rules.Add(new AttributeBuilderRuleClass<T>(name, value));
            return this;
        }

        public AttributeBuilder<T> Dictionary<TK>(Func<T, TK> func, IDictionary<TK, KeyValuePair<string, object>> dictionary)
        {
            Rules.Add(new AttributeBuilderRuleDictionary<T, TK>(func, dictionary));
            return this;
        }


        private List<AttributeBuilderRule<T>> Rules = new List<AttributeBuilderRule<T>>();

        public string GetClasses(T data)
        {
            return string.Join(" ", Rules.Select(i => i.GetName(data)).Where(i => i != null));
        }
    }
}