using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMdc
{
    /// <summary>
    /// Open Iconic foundry details.
    /// </summary>
    internal class IconFoundryOI : IMdcIconFoundry
    {
        /// <inheritdoc/>
        MdcIconFoundryName IMdcIconFoundry.FoundryName => MdcIconFoundryName.OpenIconic;
    }
}
