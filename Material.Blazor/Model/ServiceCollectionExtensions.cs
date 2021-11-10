using Material.Blazor.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace Material.Blazor
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds Snackbar, Logging, and Tooltip services for Material.Blazor. This is required for any app that uses one or more
        /// of these components. The configurations are optional.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="snackbarServiceConfiguration"></param>
        /// <param name="loggingServiceConfiguration"></param>
        /// <returns></returns>
        public static IServiceCollection AddMBServices(
            this IServiceCollection services,
            MBLoggingServiceConfiguration loggingServiceConfiguration = null,
            MBSnackbarServiceConfiguration snackbarServiceConfiguration = null) 
        {
            return services
                .AddMBLoggingService(loggingServiceConfiguration)
                .AddMBSnackbarService(snackbarServiceConfiguration)
                .AddMBTooltipService();
        }


        /// <summary>
        /// Adds a Material.Blazor <see cref="IMBLoggingService"/> to the service collection
        /// <example>
        /// <para>You can optionally add configuration:</para>
        /// <code>
        /// services.AddMBLoggingService(new MBLoggingServiceConfiguration()
        /// {
        ///     Level = Trace
        /// });
        /// </code>
        /// </example>
        /// </summary>
        private static IServiceCollection AddMBLoggingService(this IServiceCollection services, MBLoggingServiceConfiguration configuration = null)
        {
            if (configuration == null)
            {
                configuration = new MBLoggingServiceConfiguration();
            }

            return services.AddScoped<IMBLoggingService, LoggingService>(serviceProvider => new LoggingService(configuration));
        }


        /// <summary>
        /// Adds a Material.Blazor <see cref="IMBSnackbarService"/> to the service collection to manage snackbar messages.
        /// <example>
        /// <para>You can optionally add configuration:</para>
        /// <code>
        /// services.AddMBSnackbarService(new MBSnackbarServiceConfiguration()
        /// {
        ///     Postion = MBSnackbarPosition.TopRight,
        ///     CloseMethod = MBSnackbarCloseMethod.Timeout,
        ///     ... etc
        /// });
        /// </code>
        /// </example>
        /// </summary>
        private static IServiceCollection AddMBSnackbarService(this IServiceCollection services, MBSnackbarServiceConfiguration configuration = null)
        {
            if (configuration == null)
            {
                configuration = new MBSnackbarServiceConfiguration();
            }

            return services.AddScoped<IMBSnackbarService, SnackbarService>(serviceProvider => new SnackbarService(configuration));
        }


        /// <summary>
        /// Adds a Material.Blazor <see cref="IMBTooltipService"/> to the service collection to manage tooltips.
        /// </summary>
        private static IServiceCollection AddMBTooltipService(this IServiceCollection services)
        {
            return services.AddScoped<IMBTooltipService, TooltipService>(serviceProvider => new TooltipService());
        }
    }
}
