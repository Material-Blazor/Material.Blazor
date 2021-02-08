namespace Material.Blazor
{
    /// <summary>
    /// Font Awesome foundry details.
    /// </summary>
    internal class IconFoundryFA : IMBIconFoundry
    {
        /// <inheritdoc/>
        MBIconFoundryName IMBIconFoundry.FoundryName => MBIconFoundryName.FontAwesome;


        /// <summary>
        /// The Font Awesome style.
        /// </summary>
        public MBIconFAStyle? Style { get; }


        /// <summary>
        /// The Font Awesome relative size.
        /// </summary>
        public MBIconFARelativeSize? RelativeSize { get; }


        public IconFoundryFA(MBIconFAStyle? style = null, MBIconFARelativeSize? relativesize = null)
        {
            Style = style;
            RelativeSize = relativesize;
        }
    }
}
