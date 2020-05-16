using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMdc
{
    internal class IconFoundryOI : IMdcIconFoundry
    {
        MdcIconFoundryName IMdcIconFoundry.FoundryName => MdcIconFoundryName.OpenIconic;
    }
}
