using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// A thin wrapper around <see cref="Microsoft.JSInterop.IJSRuntime"/>
    /// </summary>
    public interface IBatchingJsRuntime
    {
        /// <summary>
        /// Same as <see cref="Microsoft.JSInterop.JSRuntimeExtensions.InvokeAsync{TValue}(Microsoft.JSInterop.IJSRuntime, string, object?[]?)"/>.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="identifier"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        ValueTask<TValue> InvokeAsync<TValue>(string identifier, params object[] args);
        /// <summary>
        /// Has the same effect as <see cref="Microsoft.JSInterop.JSRuntimeExtensions.InvokeVoidAsync(Microsoft.JSInterop.IJSRuntime, string, object[])"/>.
        /// However, calls may be slightly deferred and batched with other calls to this method.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        Task InvokeVoidAsync(string identifier, params object[] args);
    }
}
