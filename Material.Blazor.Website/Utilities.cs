namespace Material.Blazor.Website
{
    public static class Utilities
    {
        public static MBAnimatedNavigationManagerServiceConfiguration GetDefaultAnimatedNavigationServiceConfiguration()
        {
            return new MBAnimatedNavigationManagerServiceConfiguration()
            {
                ApplyAnimation = true,
                AnimationTime = 300
            };
        }


        public static MBToastServiceConfiguration GetDefaultToastServiceConfiguration()
        {
            return new MBToastServiceConfiguration()
            {
                Position = MBToastPosition.TopRight,
                CloseMethod = MBToastCloseMethod.Timeout,
            };
        }


        public static MBSnackbarServiceConfiguration GetDefaultSnackbarServiceConfiguration()
        {
            return new MBSnackbarServiceConfiguration()
            {
            };
        }
    }
}
