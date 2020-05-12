using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMdc
{
    internal class IconFoundryMI : IMdcIconFoundry
    {
        MdcIconFoundryName IMdcIconFoundry.FoundryName => MdcIconFoundryName.MaterialIcons;

        public MdcIconMITheme? Theme { get; }


        public IconFoundryMI(MdcIconMITheme? theme = null)
        {
            Theme = theme;
        }
    }
}
