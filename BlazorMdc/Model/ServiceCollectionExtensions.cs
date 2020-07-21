using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorMdc
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a BlazorMdc <see cref="IMTToastService"/> to the service collection to manage toast messages.
        /// <example>
        /// <para>You can optionally add configuration:</para>
        /// <code>
        /// services.AddMTToastService(new MTToastServiceConfiguration()
        /// {
        ///     Postion = MTToastPosition.TopRight,
        ///     CloseMethod = MTToastCloseMethod.Timeout,
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
        /// Adds a BlazorMdc <see cref="IMTAnimatedNavigationManager"/> to the service collection to apply
        /// fade out/in animation to Blazor page navigation.
        /// <example>
        /// <para>You can optionally add configuration:</para>
        /// <code>
        /// services.AddMTAnimatedNavigationManager(new MTAnimatedNaviationManagerConfiguration()
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

            return services.AddScoped<IMTAnimatedNavigationManager, AnimatedNavigationManager>(serviceProvider => new AnimatedNavigationManager(serviceProvider.GetRequiredService<NavigationManager>(), configuration));
        }
    }
}
