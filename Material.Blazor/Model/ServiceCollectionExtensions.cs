using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Threading;

namespace Material.Blazor;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds Snackbar, Toast, and Logging services for Material.Blazor. This is required for any app that uses one or more
    /// of these components.
    /// </summary>
    /// <param name="serviceCollection"></param>
    /// <returns></returns>
    public static IServiceCollection AddMBServices(this IServiceCollection serviceCollection)
    {
        if (serviceCollection == null)
        {
            throw new ArgumentNullException(nameof(serviceCollection));
        }

        return
            serviceCollection
            .AddScoped<IMBLoggingService>(serviceProvider => ActivatorUtilities.CreateInstance<LoggingService>(serviceProvider, serviceProvider.GetRequiredService<IOptions<MBServicesOptions>>()))
            .AddScoped<IMBSnackbarService>(serviceProvider => ActivatorUtilities.CreateInstance<SnackbarService>(serviceProvider, serviceProvider.GetRequiredService<IOptions<MBServicesOptions>>()))
            .AddScoped<IMBToastService>(serviceProvider => ActivatorUtilities.CreateInstance<ToastService>(serviceProvider, serviceProvider.GetRequiredService<IOptions<MBServicesOptions>>()))
            .AddScoped<IMBTooltipService>(serviceProvider => new TooltipService());
    }


    /// <summary>
    /// Adds Snackbar, Toast, and Logging services for Material.Blazor. This is required for any app that uses one or more
    /// of these components.
    /// </summary>
    /// <param name="serviceCollection"></param>
    /// <param name="configureOptions"></param>
    /// <returns></returns>
    public static IServiceCollection AddMBServices(this IServiceCollection serviceCollection, Action<MBServicesOptions> configureOptions)
    {
        if (serviceCollection == null)
        {
            throw new ArgumentNullException(nameof(serviceCollection));
        }

        if (configureOptions == null)
        {
            throw new ArgumentNullException(nameof(configureOptions));
        }

        MBServicesOptions options = new();

        configureOptions.Invoke(options);

        return
            serviceCollection
            .AddScoped<IMBLoggingService>(serviceProvider => new LoggingService(options))
            .AddScoped<IMBSnackbarService>(serviceProvider => new SnackbarService(options))
            .AddScoped<IMBToastService>(serviceProvider => new ToastService(options))
            .AddScoped<IMBTooltipService>(serviceProvider => new TooltipService());
    }
}
