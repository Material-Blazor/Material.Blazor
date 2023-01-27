namespace Material.Blazor.Website.MD3;

public static class Utilities
{
    public static MBLoggingServiceConfiguration GetDefaultLoggingServiceConfiguration() => new()
    {
        LoggingLevel = MBLoggingLevel.Warning
    };


    public static MBToastServiceConfiguration GetDefaultToastServiceConfiguration() => new()
    {
        Position = MBToastPosition.TopRight,
        CloseMethod = MBNotifierCloseMethod.Timeout,
    };


    public static MBSnackbarServiceConfiguration GetDefaultSnackbarServiceConfiguration() => new()
    {
        CloseMethod = MBNotifierCloseMethod.TimeoutAndDismissButton,
        Leading = false,
        Stacked = false,
        Timeout = 5000
    };
}
