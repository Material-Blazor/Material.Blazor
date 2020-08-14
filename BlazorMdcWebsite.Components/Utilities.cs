using BlazorMdc;

namespace BlazorMdcWebsite.Components
{
    public static class Utilities
    {
        public static MTAnimatedNaviationManagerConfiguration GetDefaultAnimatedNavigationManagerConfiguration()
        {
            return new MTAnimatedNaviationManagerConfiguration()
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
