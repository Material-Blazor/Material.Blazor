using System.Collections.Generic;

namespace Material.Blazor
{
    /// <summary>
    /// Interface providing markup elements for an icon in a given foundry.
    /// </summary>
    public interface IMBIcon
    {
        /// <summary>
        /// Value applied to the icon <c>class</c> attribute.
        /// </summary>
        public string Class { get; }


        /// <summary>
        /// Text supplied inside the icon tag.
        /// </summary>
        public string Text { get; }


        /// <summary>
        /// Attributes to be splatted inside the icon tag.
        /// </summary>
        public IDictionary<string, object> Attributes { get; }


        /// <summary>
        /// The icon name for the relevant foundry (e.g. MI "alarm", FA "fa-arro-down" or OI "shield").
        /// </summary>
        public string IconName { get; }


        /// <summary>
        /// Determines whether color should be set via a filter in the case of Material Icons two-tone theme. Presently partly implemented in toasts only.
        /// </summary>
        public bool RequiresColorFilter { get; }
    }
}
