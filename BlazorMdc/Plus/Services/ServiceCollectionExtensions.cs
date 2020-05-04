using Microsoft.Extensions.DependencyInjection;

namespace BlazorMdc
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPMdcToastService(this IServiceCollection services)
        {
            return services.AddScoped<IPmdcToastService, PMdcToastService>();
        }

        public static IServiceCollection AddPMdcAnimatedNavigationManager(this IServiceCollection services)
        {
            return services.AddScoped<IPMdcAnimatedNavigationManager, PMdcAnimatedNavigationManager>();
        }
    }
}
