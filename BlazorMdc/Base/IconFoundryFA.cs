using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMdc
{
    /// <summary>
    /// Font Awesome foundry details.
    /// </summary>
    public class IconFoundryFA : IMdcIconFoundry
    {
        /// <inheritdoc/>
        MdcIconFoundryName IMdcIconFoundry.FoundryName => MdcIconFoundryName.FontAwesome;

        
        /// <summary>
        /// The Font Awesome style.
        /// </summary>
        public MdcIconFAStyle? Style { get; }


        /// <summary>
        /// The Font Awesome relative size.
        /// </summary>
        public MdcIconFARelativeSize? RelativeSize { get; }


        public IconFoundryFA(MdcIconFAStyle? style = null, MdcIconFARelativeSize? relativesize = null)
        {
            Style = style;
            RelativeSize = relativesize;
        }
    }
}
