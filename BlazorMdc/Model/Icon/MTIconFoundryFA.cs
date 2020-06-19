namespace BlazorMdc
{
    /// <summary>
    /// Font Awesome foundry details.
    /// </summary>
    public class MTIconFoundryFA : IMTIconFoundry
    {
        /// <inheritdoc/>
        IconFoundryName IMTIconFoundry.FoundryName => IconFoundryName.FontAwesome;

        
        /// <summary>
        /// The Font Awesome style.
        /// </summary>
        public IconFAStyle? Style { get; }


        /// <summary>
        /// The Font Awesome relative size.
        /// </summary>
        public IconFARelativeSize? RelativeSize { get; }


        public MTIconFoundryFA(IconFAStyle? style = null, IconFARelativeSize? relativesize = null)
        {
            Style = style;
            RelativeSize = relativesize;
        }
    }
}
