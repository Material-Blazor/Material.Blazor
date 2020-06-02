using System;
using System.Collections.Generic;
using System.Text;

namespace BMdcModel
{
    /// <summary>
    /// Font Awesome foundry details.
    /// </summary>
    public class IconFoundryFA : IIconFoundry
    {
        /// <inheritdoc/>
        eIconFoundryName IIconFoundry.FoundryName => eIconFoundryName.FontAwesome;

        
        /// <summary>
        /// The Font Awesome style.
        /// </summary>
        public eIconFAStyle? Style { get; }


        /// <summary>
        /// The Font Awesome relative size.
        /// </summary>
        public eIconFARelativeSize? RelativeSize { get; }


        public IconFoundryFA(eIconFAStyle? style = null, eIconFARelativeSize? relativesize = null)
        {
            Style = style;
            RelativeSize = relativesize;
        }
    }
}
