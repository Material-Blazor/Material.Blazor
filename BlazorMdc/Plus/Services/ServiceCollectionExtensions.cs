using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorMdc
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPMdcToastService(this IServiceCollection services, PMdcToastServiceConfiguration configuration = null)
        {
            if (configuration == null)
            {
                configuration = new PMdcToastServiceConfiguration();
            }

            return services.AddScoped<IPmdcToastService, PMdcToastService>(serviceProvider => new PMdcToastService(configuration));
        }

        public static IServiceCollection AddPMdcAnimatedNavigationManager(this IServiceCollection services, PMdcAnimatedNaviationManagerConfiguration configuration = null)
        {
            if (configuration == null)
            {
                configuration = new PMdcAnimatedNaviationManagerConfiguration();
            }

            return services.AddScoped<IPMdcAnimatedNavigationManager, PMdcAnimatedNavigationManager>(serviceProvider => new PMdcAnimatedNavigationManager(serviceProvider.GetRequiredService<NavigationManager>(), configuration));
        }
    }
}
