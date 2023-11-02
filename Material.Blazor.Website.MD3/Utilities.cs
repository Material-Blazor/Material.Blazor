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
        CloseMethod = (MBNotifierCloseMethod)MBNotifierCloseMethod.Timeout,
        Position = (MBToastPosition)MBToastPosition.TopRight,
    };

}
