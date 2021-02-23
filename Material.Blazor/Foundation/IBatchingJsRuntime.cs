using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    public interface IBatchingJsRuntime
    {
        Task<T> InvokeAsync<T>(string identifier, params object[] args);
        Task InvokeVoidAsync(string identifier, params object[] args);
    }
}
