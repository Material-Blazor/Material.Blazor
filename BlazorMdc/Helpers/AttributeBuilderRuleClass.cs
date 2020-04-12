namespace BlazorMdc
{
    public class AttributeBuilderRuleClass<T> : AttributeBuilderRule<T>
    {
        public string Name { get; set; }

        public object Value { get; set; }


        public AttributeBuilderRuleClass(string name, object value)
        {
            Name = name;
            Value = value;
        }

        public override string GetName(T data)
        {
            return Name;
        }

        public override object GetValue(T data)
        {
            return Value;
        }
    }
}