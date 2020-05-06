namespace BlazorMdc
{
    public class PMdcAnimatedNaviationManagerConfiguration
    {
        public const bool DefaultApplyAnimation = false;
        public const int DefaultAnimationTime = 500;

        internal PMdcAnimatedNavigationManager AnimatedNavigationManager { get; set; }


        private bool _applyAnimation = DefaultApplyAnimation;
        /// <summary>
        /// Determines whether animated navigation will happen (true) or default to standard Blazor non-animated (false).
        /// </summary>
        public bool ApplyAnimation
        {
            get => _applyAnimation;
            set
            {
                if (value != _applyAnimation)
                {
                    _applyAnimation = value;

                    if (!_applyAnimation)
                    {
                        AnimatedNavigationManager?.NavigationComponent?.UnanimatePage();
                    }
                }
            }
        }


        /// <summary>
        /// Sets the animation sequence time in milliseconds (default 500).
        /// </summary>
        public int AnimationTime { get; set; }
    }
}
