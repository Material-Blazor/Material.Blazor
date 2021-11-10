namespace Material.Blazor.Website
{
    public static class Utilities
    {
        public static MBLoggingServiceConfiguration GetDefaultLoggingServiceConfiguration() => new()
        {
            LoggingLevel = MBLoggingLevel.Warning
        };


        public static MBSnackbarServiceConfiguration GetDefaultSnackbarServiceConfiguration() => new()
        {
            CloseMethod = MBNotifierCloseMethod.TimeoutAndDismissButton,
            Leading = true,
            Stacked = false,
            Timeout = 2000
        };
    }
}
