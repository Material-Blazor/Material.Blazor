using BMdcBase;

using BMdcPlus;

using Microsoft.AspNetCore.Components;

using System;

namespace BMdcModel
{
    /// <summary>
    /// The internal implementation of <see cref="IAnimatedNavigationManager"/>.
    /// </summary>
    internal class AnimatedNavigationManager : IAnimatedNavigationManager
    {
        private readonly NavigationManager NavigationManager;


        /// <summary>
        /// A reference to the registered <see cref="PMdcAnimatedNavigation"/>.
        /// </summary>
        internal AnimatedNavigation NavigationComponent { get; set; } = null;
        

        /// <inheritdoc/>
        public AnimatedNaviationManagerConfiguration Configuration { get; set; } = new AnimatedNaviationManagerConfiguration();


        /// <inheritdoc/>
        int IAnimatedNavigationManager.FadeOutTime => Configuration.AnimationTime * 4 / 10;


        /// <inheritdoc/>
        int IAnimatedNavigationManager.FadeInTime => Configuration.AnimationTime * 6 / 10;


        public AnimatedNavigationManager(NavigationManager navigationManager, AnimatedNaviationManagerConfiguration configuration)
        {
            NavigationManager = navigationManager;
            Configuration = configuration;
        }


        /// <inheritdoc/>
        public void NavigateTo(string uri, bool forceLoad = false)
        {
            if (NavigationComponent is null)
            {
                throw new InvalidOperationException($"BlazorMdc: you have registered a {Utilities.GetTypeName(typeof(IAnimatedNavigationManager))} but have not placed a {Utilities.GetTypeName(typeof(AnimatedNavigation))} component around your markup in either App.razor or MainLayout.razor");
            }

            if (!Configuration.ApplyAnimation)
            {
                NavigationManager.NavigateTo(uri, forceLoad);
            }
            else
            {
                NavigationComponent.NavigateTo(uri, forceLoad);
            }
        }


        /// <inheritdoc/>
        void IAnimatedNavigationManager.RegisterNavigationComponent(AnimatedNavigation navigationComponent)
        {
            NavigationComponent = navigationComponent;
        }


        /// <inheritdoc/>
        void IAnimatedNavigationManager.DeregisterNavigationComponent(AnimatedNavigation navigationComponent)
        {
            if (navigationComponent.Equals(NavigationComponent))
            {
                NavigationComponent = null;
            }
        }
    }
}
