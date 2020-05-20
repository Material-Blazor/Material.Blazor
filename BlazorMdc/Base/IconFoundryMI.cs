using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMdc
{
    /// <summary>
    /// Material Icons foundry details.
    /// </summary>
    internal class IconFoundryMI : IMdcIconFoundry
    {
        /// <inheritdoc/>
        MdcIconFoundryName IMdcIconFoundry.FoundryName => MdcIconFoundryName.MaterialIcons;

        
        /// <summary>
        /// The Material Icons theme.
        /// </summary>
        public MdcIconMITheme? Theme { get; }


        public IconFoundryMI(MdcIconMITheme? theme = null)
        {
            Theme = theme;
        }
    }
}
