namespace BlazorMdc
{
    /// <summary>
    /// Font Awesome foundry details.
    /// </summary>
    public class MTIconFoundryFA : IMTIconFoundry
    {
        /// <inheritdoc/>
        MTIconFoundryName IMTIconFoundry.FoundryName => MTIconFoundryName.FontAwesome;

        
        /// <summary>
        /// The Font Awesome style.
        /// </summary>
        public MTIconFAStyle? Style { get; }


        /// <summary>
        /// The Font Awesome relative size.
        /// </summary>
        public MTIconFARelativeSize? RelativeSize { get; }


        public MTIconFoundryFA(MTIconFAStyle? style = null, MTIconFARelativeSize? relativesize = null)
        {
            Style = style;
            RelativeSize = relativesize;
        }
    }
}
