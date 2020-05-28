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
        BMdcModel.IconFoundryName IIconFoundry.FoundryName => BMdcModel.IconFoundryName.FontAwesome;

        
        /// <summary>
        /// The Font Awesome style.
        /// </summary>
        public BMdcModel.IconFAStyle? Style { get; }


        /// <summary>
        /// The Font Awesome relative size.
        /// </summary>
        public BMdcModel.IconFARelativeSize? RelativeSize { get; }


        public IconFoundryFA(BMdcModel.IconFAStyle? style = null, BMdcModel.IconFARelativeSize? relativesize = null)
        {
            Style = style;
            RelativeSize = relativesize;
        }
    }
}
