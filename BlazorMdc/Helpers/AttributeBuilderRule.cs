namespace BlazorMdc
{
    public abstract class AttributeBuilderRule<T>
    {
        public abstract string GetName(T data);

        public abstract object GetValue(T data);
    }
}