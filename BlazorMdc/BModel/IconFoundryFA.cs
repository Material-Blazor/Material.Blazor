using System;
using System.Collections.Generic;
using System.Text;

namespace BModel
{
    /// <summary>
    /// Font Awesome foundry details.
    /// </summary>
    public class IconFoundryFA : IIconFoundry
    {
        /// <inheritdoc/>
        BEnum.IconFoundryName IIconFoundry.FoundryName => BEnum.IconFoundryName.FontAwesome;

        
        /// <summary>
        /// The Font Awesome style.
        /// </summary>
        public BEnum.IconFAStyle? Style { get; }


        /// <summary>
        /// The Font Awesome relative size.
        /// </summary>
        public BEnum.IconFARelativeSize? RelativeSize { get; }


        public IconFoundryFA(BEnum.IconFAStyle? style = null, BEnum.IconFARelativeSize? relativesize = null)
        {
            Style = style;
            RelativeSize = relativesize;
        }
    }
}
