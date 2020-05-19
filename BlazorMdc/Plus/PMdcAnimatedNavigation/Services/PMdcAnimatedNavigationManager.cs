using Microsoft.AspNetCore.Components;
using System;

namespace BlazorMdc
{
    /// <inheritdoc/>
    public class PMdcAnimatedNavigationManager : IPMdcAnimatedNavigationManager
    {
        private readonly NavigationManager NavigationManager;


        /// <summary>
        /// A reference to the registered <see cref="PMdcAnimatedNavigation"/>.
        /// </summary>
        internal PMdcAnimatedNavigation NavigationComponent { get; set; } = null;
        

        /// <inheritdoc/>
        public PMdcAnimatedNaviationManagerConfiguration Configuration { get; set; } = new PMdcAnimatedNaviationManagerConfiguration();


        /// <inheritdoc/>
        int IPMdcAnimatedNavigationManager.FadeOutTime => Configuration.AnimationTime * 4 / 10;


        /// <inheritdoc/>
        int IPMdcAnimatedNavigationManager.FadeInTime => Configuration.AnimationTime * 6 / 10;


        public PMdcAnimatedNavigationManager(NavigationManager navigationManager, PMdcAnimatedNaviationManagerConfiguration configuration)
        {
            NavigationManager = navigationManager;
            Configuration = configuration;
        }


        /// <inheritdoc/>
        public void NavigateTo(string uri, bool forceLoad = false)
        {
            if (NavigationComponent is null)
            {
                throw new InvalidOperationException($"BlazorMdc: you have registered a {Utilities.GetTypeName(typeof(IPMdcAnimatedNavigationManager))} but have not placed a {Utilities.GetTypeName(typeof(PMdcAnimatedNavigation))} component around your markup in either App.razor or MainLayout.razor");
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
        void IPMdcAnimatedNavigationManager.RegisterNavigationComponent(PMdcAnimatedNavigation navigationComponent)
        {
            NavigationComponent = navigationComponent;
        }


        /// <inheritdoc/>
        void IPMdcAnimatedNavigationManager.DeregisterNavigationComponent(PMdcAnimatedNavigation navigationComponent)
        {
            if (navigationComponent.Equals(NavigationComponent))
            {
                NavigationComponent = null;
            }
        }
    }
}
