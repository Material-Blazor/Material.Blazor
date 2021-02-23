namespace Material.Blazor.Website
{
    public static class Utilities
    {
        public static MBAnimatedNavigationManagerServiceConfiguration GetDefaultAnimatedNavigationServiceConfiguration() => new()
        {
            ApplyAnimation = true,
            AnimationTime = 300
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
}
