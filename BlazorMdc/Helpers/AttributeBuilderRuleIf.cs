using System;

namespace BlazorMdc
{
    public class AttributeBuilderRuleIf<T> : AttributeBuilderRule<T>
    {
        public string Name { get; set; }

        public object Value { get; set; }

        public Func<T, bool> Func { get; set; }

        public AttributeBuilderRuleIf(string name, object value, Func<T, bool> func)
        {
            Name = name;
            Value = value;
            Func = func;
        }

        public override string GetName(T data)
        {
            if (Func(data))
            {
                return Name;
            }

            return null;
        }

        public override object GetValue(T data)
        {
            if (Func(data))
            {
                return Value;
            }

            return null;
        }
    }
}