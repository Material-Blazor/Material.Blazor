using Material.Blazor;
using Material.Blazor.MD2;

namespace Material.Blazor;

public static class Utilities
{
    public static MBLoggingServiceConfiguration GetDefaultLoggingServiceConfiguration() => new()
    {
        LoggingLevel = (MBLoggingLevel)MBLoggingLevel.Warning
    };


    public static MBToastServiceConfiguration GetDefaultToastServiceConfiguration() => new()
    {
        Position = (MBToastPosition)MBToastPosition.TopRight,
        CloseMethod = (MBNotifierCloseMethod)MBNotifierCloseMethod.Timeout,
    };


    public static MBSnackbarServiceConfiguration GetDefaultSnackbarServiceConfiguration() => new()
    {
        CloseMethod = (MD2.MBNotifierCloseMethod)MBNotifierCloseMethod.TimeoutAndDismissButton,
        Leading = false,
        Stacked = false,
        Timeout = 5000
    };
}
