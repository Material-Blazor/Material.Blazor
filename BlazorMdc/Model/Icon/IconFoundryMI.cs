using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMdc
{
    /// <summary>
    /// Material Icons foundry details.
    /// </summary>
    internal class IconFoundryMI : IMTIconFoundry
    {
        /// <inheritdoc/>
        MTIconFoundryName IMTIconFoundry.FoundryName => MTIconFoundryName.MaterialIcons;

        
        /// <summary>
        /// The Material Icons theme.
        /// </summary>
        public MTIconMITheme? Theme { get; }


        public IconFoundryMI(MTIconMITheme? theme = null)
        {
            Theme = theme;
        }
    }
}
