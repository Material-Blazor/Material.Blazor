using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorMdc
{
    public class PMdcAnimatedNavigationManager : IPMdcAnimatedNavigationManager
    {
        private readonly NavigationManager NavigationManager;
        private PMdcAnimatedNavigation NavigationComponent { get; set; } = null;
        

        private bool _applyAnimation = true;
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
                        NavigationComponent.UnanimatePage();
                    }
                }
            }
        }


        /// <summary>
        /// Sets the animation sequence time in milliseconds (default 500).
        /// </summary>
        public int AnimationTime { get; set; } = 500;

        int IPMdcAnimatedNavigationManager.FadeOutTime => AnimationTime * 4 / 10;
        int IPMdcAnimatedNavigationManager.FadeInTime => AnimationTime * 6 / 10;


        public PMdcAnimatedNavigationManager(NavigationManager navigationManager)
        {
            NavigationManager = navigationManager;
        }


        /// <summary>
        /// Navigates to the specified URI. 
        /// </summary>
        /// <param name="uri">The destination URI. This can be absolute, or relative to the base URI (as returned by Microsoft.AspNetCore.Components.NavigationManager.BaseUri).</param>
        /// <param name="forceLoad">If true, bypasses client-side routing and forces the browser to load the new page from the server, whether or not the URI would normally be handled by the client-side router.</param>
        public async Task NavigateToAsync(string uri, bool forceLoad = false)
        {
            if (NavigationComponent is null || !ApplyAnimation)
            {
                NavigationManager.NavigateTo(uri, forceLoad);
            }
            else
            {
                _ = await NavigationComponent.FadePageOutAsync().ConfigureAwait(false);
                
                NavigationManager.NavigateTo(uri, forceLoad);
                
                _ = await NavigationComponent.FadePageInAsync().ConfigureAwait(false);
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
