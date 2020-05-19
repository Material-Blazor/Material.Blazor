using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorMdc
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a BlazorMdc <see cref="IPMdcToastService"/> to the service collection to manage toast messages.
        /// <example>
        /// <para>You can optionally add configuration:</para>
        /// <code>
        /// services.AddPMdcToastService(new PMdcToastServiceConfiguration()
        /// {
        ///     Postion = PMdcToastPosition.TopRight,
        ///     CloseMethod = PMdcToastCloseMethod.Timeout,
        ///     ... etc
        /// });
        /// </code>
        /// </example>
        /// </summary>
        public static IServiceCollection AddPMdcToastService(this IServiceCollection services, PMdcToastServiceConfiguration configuration = null)
        {
            if (configuration == null)
            {
                configuration = new PMdcToastServiceConfiguration();
            }

            return services.AddScoped<IPmdcToastService, PMdcToastService>(serviceProvider => new PMdcToastService(configuration));
        }


        /// <summary>
        /// Adds a BlazorMdc <see cref="IPMdcAnimatedNavigationManager"/> to the service collection to apply
        /// fade out/in animation to Blazor page navigation.
        /// <example>
        /// <para>You can optionally add configuration:</para>
        /// <code>
        /// services.AddPMdcAnimatedNavigationManager(new PMdcAnimatedNaviationManagerConfiguration()
        /// {
        ///     ApplyAnimation = true,
        ///     AnimationTime = 300   /* milliseconds */
        /// });
        /// </code>
        /// </example>
        /// </summary>
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
