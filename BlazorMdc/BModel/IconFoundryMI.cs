using System;
using System.Collections.Generic;
using System.Text;

namespace BModel
{
    /// <summary>
    /// Material Icons foundry details.
    /// </summary>
    internal class IconFoundryMI : IIconFoundry
    {
        /// <inheritdoc/>
        BEnum.IconFoundryName IIconFoundry.FoundryName => BEnum.IconFoundryName.MaterialIcons;

        
        /// <summary>
        /// The Material Icons theme.
        /// </summary>
        public BEnum.IconMITheme? Theme { get; }


        public IconFoundryMI(BEnum.IconMITheme? theme = null)
        {
            Theme = theme;
        }
    }
}
