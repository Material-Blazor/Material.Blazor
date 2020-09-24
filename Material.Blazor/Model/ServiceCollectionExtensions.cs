using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;

namespace Material.Blazor
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds Toast, Tooltip and Animated Navigation services for Material.Blazor. This is required for any app that uses one or more
        /// of these components. The two configurations are optional.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="toastServiceConfiguration"></param>
        /// <param name="animatedNavigationManagerServiceConfiguration"></param>
        /// <returns></returns>
        public static IServiceCollection AddMBServices(this IServiceCollection services, MBToastServiceConfiguration toastServiceConfiguration = null, MBAnimatedNavigationManagerServiceConfiguration animatedNavigationManagerServiceConfiguration = null)
        {
            return services
                .AddMBToastService( toastServiceConfiguration)
                .AddMBAnimatedNavigationService(animatedNavigationManagerServiceConfiguration)
                .AddMBTooltipService();
        }


        /// <summary>
        /// Adds a Material.Blazor <see cref="IMBToastService"/> to the service collection to manage toast messages.
        /// <example>
        /// <para>You can optionally add configuration:</para>
        /// <code>
        /// services.AddMBToastService(new MBToastServiceConfiguration()
        /// {
        ///     Postion = MBToastPosition.TopRight,
        ///     CloseMethod = MBToastCloseMethod.Timeout,
        ///     ... etc
        /// });
        /// </code>
        /// </example>
        /// </summary>
        private static IServiceCollection AddMBToastService(this IServiceCollection services, MBToastServiceConfiguration configuration = null)
        {
            if (configuration == null)
            {
                configuration = new MBToastServiceConfiguration();
            }

            return services.AddScoped<IMBToastService, ToastService>(serviceProvider => new ToastService(configuration));
        }


        /// <summary>
        /// Adds a Material.Blazor <see cref="IMBTooltipService"/> to the service collection to manage tooltips.
        /// </summary>
        private static IServiceCollection AddMBTooltipService(this IServiceCollection services)
        {
            return services.AddScoped<IMBTooltipService, TooltipService>(serviceProvider => new TooltipService());
        }


        /// <summary>
        /// Adds a Material.Blazor <see cref="IMBAnimatedNavigationManager"/> to the service collection to apply
        /// fade out/in animation to Blazor page navigation.
        /// <example>
        /// <para>You can optionally add configuration:</para>
        /// <code>
        /// services.AddMBAnimatedNavigationService(new MBAnimatedNaviationServiceConfiguration()
        /// {
        ///     ApplyAnimation = true,
        ///     AnimationTime = 300   /* milliseconds */
        /// });
        /// </code>
        /// </example>
        /// </summary>
        private static IServiceCollection AddMBAnimatedNavigationService(this IServiceCollection services, MBAnimatedNavigationManagerServiceConfiguration configuration = null)
        {
            if (configuration == null)
            {
                configuration = new MBAnimatedNavigationManagerServiceConfiguration();
            }

            return services.AddScoped<IMBAnimatedNavigationManager, AnimatedNavigationManagerService>(serviceProvider => new AnimatedNavigationManagerService(serviceProvider.GetRequiredService<NavigationManager>(), configuration));
        }
    }
}
