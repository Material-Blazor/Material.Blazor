using Microsoft.Extensions.DependencyInjection;

namespace BlazorMdc
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPMdcToastService(this IServiceCollection services, PMdcToastServiceConfiguration configuration = null)
        {
            //return services.AddScoped<IPmdcToastService, PMdcToastService>(builder => new PMdcToastService();

            if (configuration == null)
            {
                configuration = new PMdcToastServiceConfiguration();
            }

            return services.AddScoped<IPmdcToastService, PMdcToastService>(builder => new PMdcToastService(configuration));
        }

        public static IServiceCollection AddPMdcAnimatedNavigationManager(this IServiceCollection services)
        {
            return services.AddScoped<IPMdcAnimatedNavigationManager, PMdcAnimatedNavigationManager>();
        }
    }
}
