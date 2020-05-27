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
        BMdcModel.IconFoundryName IIconFoundry.FoundryName => BMdcModel.IconFoundryName.MaterialIcons;

        
        /// <summary>
        /// The Material Icons theme.
        /// </summary>
        public BMdcModel.IconMITheme? Theme { get; }


        public IconFoundryMI(BMdcModel.IconMITheme? theme = null)
        {
            Theme = theme;
        }
    }
}
