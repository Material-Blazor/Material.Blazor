using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;

using System;

namespace BlazorMdc
{
    /// <summary>
    /// The internal implementation of <see cref="IAnimatedNavigationManager"/>.
    /// </summary>
    internal class MTAnimatedNavigationManager : IAnimatedNavigationManager
    {
        private readonly NavigationManager NavigationManager;


        /// <summary>
        /// A reference to the registered <see cref="PMdcAnimatedNavigation"/>.
        /// </summary>
        internal MTAnimatedNavigation NavigationComponent { get; set; } = null;
        

        /// <inheritdoc/>
        public MTAnimatedNaviationManagerConfiguration Configuration { get; set; } = new MTAnimatedNaviationManagerConfiguration();


        /// <inheritdoc/>
        int IAnimatedNavigationManager.FadeOutTime => Configuration.AnimationTime * 4 / 10;


        /// <inheritdoc/>
        int IAnimatedNavigationManager.FadeInTime => Configuration.AnimationTime * 6 / 10;


        public MTAnimatedNavigationManager(NavigationManager navigationManager, MTAnimatedNaviationManagerConfiguration configuration)
        {
            NavigationManager = navigationManager;
            Configuration = configuration;
        }


        /// <inheritdoc/>
        public void NavigateTo(string uri, bool forceLoad = false)
        {
            if (NavigationComponent is null)
            {
                throw new InvalidOperationException($"BlazorMdc: you have registered a {MTUtilities.GetTypeName(typeof(IAnimatedNavigationManager))} but have not placed a {MTUtilities.GetTypeName(typeof(MTAnimatedNavigation))} component around your markup in either App.razor or MainLayout.razor");
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
        void IAnimatedNavigationManager.RegisterNavigationComponent(MTAnimatedNavigation navigationComponent)
        {
            NavigationComponent = navigationComponent;
        }


        /// <inheritdoc/>
        void IAnimatedNavigationManager.DeregisterNavigationComponent(MTAnimatedNavigation navigationComponent)
        {
            if (navigationComponent.Equals(NavigationComponent))
            {
                NavigationComponent = null;
            }
        }
    }
}
