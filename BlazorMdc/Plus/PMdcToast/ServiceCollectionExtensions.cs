using Microsoft.Extensions.DependencyInjection;

namespace BlazorMdc
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPMdcToast(this IServiceCollection services)
        {
            return services.AddScoped<IToastService, ToastService>();
        }
    }
}
