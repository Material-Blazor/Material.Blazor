using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMdc
{
    public class IconFoundryFA : IMdcIconFoundry
    {
        MdcIconFoundryName IMdcIconFoundry.FoundryName => MdcIconFoundryName.FontAwesome;

        public MdcIconFAStyle? Style { get; }

        public MdcIconFARelativeSize? RelativeSize { get; }


        public IconFoundryFA(MdcIconFAStyle? style = null, MdcIconFARelativeSize? relativesize = null)
        {
            Style = style;
            RelativeSize = relativesize;
        }
    }
}
