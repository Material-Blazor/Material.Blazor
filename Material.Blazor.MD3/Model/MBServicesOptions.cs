using Microsoft.Extensions.DependencyInjection;

using Material.Blazor.MD2;
namespace Material.Blazor;


/// <summary>
/// Options for <see cref="ServiceCollectionExtensions.AddMBServices"/> following the ASP.Net Options Pattern.
/// </summary>
public class MBServicesOptions
{
    /// <summary>
    /// Logging service configuration.
    /// </summary>
    public MBLoggingServiceConfiguration LoggingServiceConfiguration { get; set; } = new();


    /// <summary>
    /// Toast service configuration.
    /// </summary>
    public MBToastServiceConfiguration ToastServiceConfiguration { get; set; } = new();
}
