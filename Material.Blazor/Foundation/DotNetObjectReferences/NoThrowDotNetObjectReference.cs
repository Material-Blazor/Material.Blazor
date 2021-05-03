using Microsoft.JSInterop;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Material.Blazor.Internal
{
    public class NoThrowDotNetObjectReference<TValue> : IDisposable where TValue : class
    {
        public long __dotNetObject { get; set; }
        private readonly DotNetObjectReference<TValue> dotNetObjectReference;
        [JsonConstructor]
        public NoThrowDotNetObjectReference()
        {

        }
        public NoThrowDotNetObjectReference(JsonSerializerOptions options, DotNetObjectReference<TValue> dotNetObjectReference)
        {
            this.dotNetObjectReference = dotNetObjectReference;
            var serialized = JsonSerializer.Serialize(dotNetObjectReference, options);
            __dotNetObject = JsonSerializer.Deserialize<NoThrowDotNetObjectReference<TValue>>(serialized).__dotNetObject;

        }
        public void Dispose()
        {
            dotNetObjectReference.Dispose();
        }
    }
}
