namespace Material.Blazor.Internal
{
    public interface INoThrowDotNetObjectReferenceFactory
    {
        NoThrowDotNetObjectReference<TValue> Create<TValue>(TValue value) where TValue : class;
    }
}