namespace Material.Blazor.Website
{
    public static class Utilities
    {
        public static MBAnimatedNavigationManagerServiceConfiguration GetDefaultAnimatedNavigationServiceConfiguration() =>
            new()
            {
                ApplyAnimation = true,
                AnimationTime = 300
            };


        public static MBToastServiceConfiguration GetDefaultToastServiceConfiguration() =>
            new()
            {
                Position = MBToastPosition.TopRight,
                CloseMethod = MBToastCloseMethod.Timeout,
            };


        public static MBSnackbarServiceConfiguration GetDefaultSnackbarServiceConfiguration() =>
            new()
            {
            };
    }
}
