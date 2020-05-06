using Microsoft.AspNetCore.Components;

namespace BlazorMdc
{
    public class PMdcAnimatedNavigationManager : IPMdcAnimatedNavigationManager
    {
        private readonly NavigationManager NavigationManager;
        internal PMdcAnimatedNavigation NavigationComponent { get; set; } = null;
        

        /// <inheritdoc/>
        public PMdcAnimatedNaviationManagerConfiguration Configuration { get; set; } = new PMdcAnimatedNaviationManagerConfiguration();


        int IPMdcAnimatedNavigationManager.FadeOutTime => Configuration.AnimationTime * 4 / 10;
        int IPMdcAnimatedNavigationManager.FadeInTime => Configuration.AnimationTime * 6 / 10;


        public PMdcAnimatedNavigationManager(NavigationManager navigationManager, PMdcAnimatedNaviationManagerConfiguration configuration)
        {
            NavigationManager = navigationManager;
            Configuration = configuration;
        }


        /// <summary>
        /// Navigates to the specified URI. 
        /// </summary>
        /// <param name="uri">The destination URI. This can be absolute, or relative to the base URI (as returned by Microsoft.AspNetCore.Components.NavigationManager.BaseUri).</param>
        /// <param name="forceLoad">If true, bypasses client-side routing and forces the browser to load the new page from the server, whether or not the URI would normally be handled by the client-side router.</param>
        public void NavigateTo(string uri, bool forceLoad = false)
        {
            if (NavigationComponent is null || !Configuration.ApplyAnimation)
            {
                NavigationManager.NavigateTo(uri, forceLoad);
            }
            else
            {
                NavigationComponent.NavigateTo(uri, forceLoad);
            }
        }


        void IPMdcAnimatedNavigationManager.RegisterNavigationComponent(PMdcAnimatedNavigation navigationComponent)
        {
            NavigationComponent = navigationComponent;
        }


        void IPMdcAnimatedNavigationManager.DeregisterNavigationComponent(PMdcAnimatedNavigation navigationComponent)
        {
            if (navigationComponent.Equals(NavigationComponent))
            {
                NavigationComponent = null;
            }
        }
    }
}
