using System.Threading.Tasks;

namespace BlazorMdc
{
    public interface IPMdcAnimatedNavigationManager
    {
        /// <summary>
        /// Determines whether animated navigation will happen (true) or default to standard Blazor non-animated (false).
        /// </summary>
        public bool ApplyAnimation { get; set; }

        /// <summary>
        /// Sets the animation sequence time in milliseconds (default 500).
        /// </summary>
        public int AnimationTime { get; set; }


        internal int FadeOutTime { get; }

        internal int FadeInTime { get; }



        /// <summary>
        /// Navigates to the specified URI. 
        /// </summary>
        /// <param name="uri">The destination URI. This can be absolute, or relative to the base URI (as returned by Microsoft.AspNetCore.Components.NavigationManager.BaseUri).</param>
        /// <param name="forceLoad">If true, bypasses client-side routing and forces the browser to load the new page from the server, whether or not the URI would normally be handled by the client-side router.</param>
        public Task NavigateToAsync(string uri, bool forceLoad = false);


        internal void RegisterNavigationComponent(PMdcAnimatedNavigation navigationComponent);

        internal void DeregisterNavigationComponent(PMdcAnimatedNavigation navigationComponent);
    }
}
