using BlazorMdc;

namespace BlazorMdcWebsite.Components
{
    public static class Utilities
    {
        public static MTAnimatedNavigationServiceConfiguration GetDefaultAnimatedNavigationServiceConfiguration()
        {
            return new MTAnimatedNavigationServiceConfiguration()
            {
                ApplyAnimation = true,
                AnimationTime = 300
            };
        }


        public static MTToastServiceConfiguration GetDefaultToastServiceConfiguration()
        {
            return new MTToastServiceConfiguration()
            {
                Position = MTToastPosition.TopRight,
                CloseMethod = MTToastCloseMethod.Timeout,
            };
        }
    }
}
