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
        IconFoundryName IMTIconFoundry.FoundryName => IconFoundryName.MaterialIcons;

        
        /// <summary>
        /// The Material Icons theme.
        /// </summary>
        public IconMITheme? Theme { get; }


        public IconFoundryMI(IconMITheme? theme = null)
        {
            Theme = theme;
        }
    }
}
