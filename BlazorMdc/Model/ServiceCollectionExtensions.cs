using BlazorMdc.Internal;

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
        public static IServiceCollection AddMTToastService(this IServiceCollection services, MTToastServiceConfiguration configuration = null)
        {
            if (configuration == null)
            {
                configuration = new MTToastServiceConfiguration();
            }

            return services.AddScoped<IMTToastService, ToastService>(serviceProvider => new ToastService(configuration));
        }


        /// <summary>
        /// Adds a BlazorMdc <see cref="IAnimatedNavigationManager"/> to the service collection to apply
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
        public static IServiceCollection AddMTAnimatedNavigationManager(this IServiceCollection services, MTAnimatedNaviationManagerConfiguration configuration = null)
        {
            if (configuration == null)
            {
                configuration = new MTAnimatedNaviationManagerConfiguration();
            }

            return services.AddScoped<IAnimatedNavigationManager, MTAnimatedNavigationManager>(serviceProvider => new MTAnimatedNavigationManager(serviceProvider.GetRequiredService<NavigationManager>(), configuration));
        }
    }
}
