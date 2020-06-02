using BMdcModel;

using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;

namespace BMdcModel
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
        public static IServiceCollection AddToastService(this IServiceCollection services, ToastServiceConfiguration configuration = null)
        {
            if (configuration == null)
            {
                configuration = new ToastServiceConfiguration();
            }

            return services.AddScoped<IToastService, ToastService>(serviceProvider => new ToastService(configuration));
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
        public static IServiceCollection AddAnimatedNavigationManager(this IServiceCollection services, AnimatedNaviationManagerConfiguration configuration = null)
        {
            if (configuration == null)
            {
                configuration = new AnimatedNaviationManagerConfiguration();
            }

            return services.AddScoped<IAnimatedNavigationManager, AnimatedNavigationManager>(serviceProvider => new AnimatedNavigationManager(serviceProvider.GetRequiredService<NavigationManager>(), configuration));
        }
    }
}
