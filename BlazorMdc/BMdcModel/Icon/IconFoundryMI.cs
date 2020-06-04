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
        EIconFoundryName IIconFoundry.FoundryName => EIconFoundryName.MaterialIcons;

        
        /// <summary>
        /// The Material Icons theme.
        /// </summary>
        public EIconMITheme? Theme { get; }


        public IconFoundryMI(EIconMITheme? theme = null)
        {
            Theme = theme;
        }
    }
}
