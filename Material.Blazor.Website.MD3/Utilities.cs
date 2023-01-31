using Material.Blazor;
using Material.Blazor.MD2;

namespace Material.Blazor.MD2;

public static class Utilities
{
    public static MBLoggingServiceConfiguration GetDefaultLoggingServiceConfiguration() => new()
    {
        LoggingLevel = (Blazor.MBLoggingLevel)MBLoggingLevel.Warning
    };


    public static MBToastServiceConfiguration GetDefaultToastServiceConfiguration() => new()
    {
        Position = (Blazor.MD2.MBToastPosition)MBToastPosition.TopRight,
        CloseMethod = (Blazor.MD2.MBNotifierCloseMethod)MBNotifierCloseMethod.Timeout,
    };


    public static MBSnackbarServiceConfiguration GetDefaultSnackbarServiceConfiguration() => new()
    {
        CloseMethod = (Blazor.MD2.MBNotifierCloseMethod)MBNotifierCloseMethod.TimeoutAndDismissButton,
        Leading = false,
        Stacked = false,
        Timeout = 5000
    };
}
