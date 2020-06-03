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
        EIconFoundryName IIconFoundry.FoundryName => EIconFoundryName.FontAwesome;

        
        /// <summary>
        /// The Font Awesome style.
        /// </summary>
        public EIconFAStyle? Style { get; }


        /// <summary>
        /// The Font Awesome relative size.
        /// </summary>
        public EIconFARelativeSize? RelativeSize { get; }


        public IconFoundryFA(EIconFAStyle? style = null, EIconFARelativeSize? relativesize = null)
        {
            Style = style;
            RelativeSize = relativesize;
        }
    }
}
