using Microsoft.JSInterop;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Material.Blazor.Internal
{
    internal sealed class DotNetObjectReferenceJsonConverterFactory : JsonConverterFactory
    {
        private readonly Type converter;
        public DotNetObjectReferenceJsonConverterFactory(IJSRuntime jsRuntime)
        {
            JSRuntime = jsRuntime;
            converter = typeof(DotNetObjectReference<>).Assembly.GetType("Microsoft.JSInterop.Infrastructure.DotNetObjectReferenceJsonConverter`1");
        }

        public IJSRuntime JSRuntime { get; }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(DotNetObjectReference<>);
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            // System.Text.Json handles caching the converters per type on our behalf. No caching is required here.
            var instanceType = typeToConvert.GetGenericArguments()[0];
            var converterType = converter.MakeGenericType(instanceType);

            return (JsonConverter)Activator.CreateInstance(converterType, JSRuntime)!;
        }
    }
}
