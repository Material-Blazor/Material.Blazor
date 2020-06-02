using System;
using System.Collections.Generic;
using System.Text;

namespace BMdcModel
{
    /// <summary>
    /// Material Icons foundry details.
    /// </summary>
    internal class IconFoundryMI : IIconFoundry
    {
        /// <inheritdoc/>
        eIconFoundryName IIconFoundry.FoundryName => eIconFoundryName.MaterialIcons;

        
        /// <summary>
        /// The Material Icons theme.
        /// </summary>
        public eIconMITheme? Theme { get; }


        public IconFoundryMI(eIconMITheme? theme = null)
        {
            Theme = theme;
        }
    }
}
