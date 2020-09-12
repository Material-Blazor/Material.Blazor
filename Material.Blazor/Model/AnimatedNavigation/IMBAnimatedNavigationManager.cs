using Microsoft.AspNetCore.Components;

namespace Material.Blazor
{
    /// <summary>
    /// Interface for the animated navigation service. Animated navigations augment
    /// Blazor's NavigationManager with minor animation.
    /// <para>
    /// First the current page fades out for 40% of the animation period, followed by a call to
    /// NavigationManager.NavigateTo(string, bool)
    /// before the new page fades in for the remaining 60% of the animation period. The default
    /// animation period is 500ms (but seems faster due to the end of the fade in being imperceptible),
    /// and animation is disapplied by default.
    /// </para>
    /// <para>
    /// Throws a <see cref="System.InvalidOperationException"/> if <see cref="NavigateTo(string, bool)"/>
    /// is called without a <see cref="MBAnimatedNavigation"/> component used in the app.
    /// </para>
    /// <example>
    /// <para>You can optionally add configuration when you add this to the service collection:</para>
    /// <code>
    /// services.AddMBAnimatedNavigationService(new MBAnimatedNaviationManagerConfiguration()
    /// {
    ///     ApplyAnimation = true,
    ///     AnimationTime = 300
    /// });
    /// </code>
    /// </example>
    /// </summary>
    public interface IMBAnimatedNavigationManager
    {
        /// <summary>
        /// The Blazor <see cref="NavigationManager"/>.
        /// </summary>
        public NavigationManager NavigationManager { get; set; }


        /// <summary>
        /// Animated Navigation Service configuration.
        /// </summary>
        public MBAnimatedNavigationManagerServiceConfiguration Configuration { get; set; }


        /// <summary>
        /// The calculated fade out time in milliseconds.
        /// </summary>
        internal int FadeOutTime { get; }


        /// <summary>
        /// The calculated fade in time in milliseconds.
        /// </summary>
        internal int FadeInTime { get; }



        /// <summary>
        /// Navigates to the specified URI. 
        /// </summary>
        /// <param name="uri">The destination URI. This can be absolute, or relative to the base URI (as returned by Microsoft.AspNetCore.Components.NavigationManager.BaseUri).</param>
        /// <param name="forceLoad">If true, bypasses client-side routing and forces the browser to load the new page from the server, whether or not the URI would normally be handled by the client-side router.</param>
        public void NavigateTo(string uri, bool forceLoad = false);


        /// <summary>
        /// Called by <see cref="MBAnimatedNavigation"/> to register itself with the service.
        /// </summary>
        /// <param name="navigationComponent"></param>
        internal void RegisterNavigationComponent(MBAnimatedNavigation navigationComponent);


        /// <summary>
        /// Called by <see cref="MBAnimatedNavigation"/> to deregister itself with the service.
        /// </summary>
        /// <param name="navigationComponent"></param>
        internal void DeregisterNavigationComponent(MBAnimatedNavigation navigationComponent);
    }
}
