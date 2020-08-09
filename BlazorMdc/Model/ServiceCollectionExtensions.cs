﻿using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace BlazorMdc
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds Toast, Tooltip and Animated Navigation Manager services for Blazor MDC. This is required for any app that uses one or more
        /// of these components. The two configurations are optional.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="toastServiceConfiguration"></param>
        /// <param name="animatedNavigationManagerConfiguration"></param>
        /// <returns></returns>
        public static IServiceCollection AddMTServices(this IServiceCollection services, MTToastServiceConfiguration toastServiceConfiguration = null, MTAnimatedNaviationManagerConfiguration animatedNavigationManagerConfiguration = null)
        {
            return services
                .AddMTToastService( toastServiceConfiguration)
                .AddMTAnimatedNavigationManager(animatedNavigationManagerConfiguration)
                .AddMTTooltipService();
        }


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
        private static IServiceCollection AddMTToastService(this IServiceCollection services, MTToastServiceConfiguration configuration = null)
        {
            if (configuration == null)
            {
                configuration = new MTToastServiceConfiguration();
            }

            return services.AddScoped<IMTToastService, ToastService>(serviceProvider => new ToastService(configuration));
        }


        /// <summary>
        /// Adds a BlazorMdc <see cref="IMTTooltipService"/> to the service collection to manage tooltips.
        /// </summary>
        private static IServiceCollection AddMTTooltipService(this IServiceCollection services)
        {
            return services.AddScoped<IMTTooltipService, TooltipService>(serviceProvider => new TooltipService());
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
        private static IServiceCollection AddMTAnimatedNavigationManager(this IServiceCollection services, MTAnimatedNaviationManagerConfiguration configuration = null)
        {
            if (configuration == null)
            {
                configuration = new MTAnimatedNaviationManagerConfiguration();
            }

            return services.AddScoped<IMTAnimatedNavigationManager, AnimatedNavigationManager>(serviceProvider => new AnimatedNavigationManager(serviceProvider.GetRequiredService<NavigationManager>(), configuration));
        }
    }
}
