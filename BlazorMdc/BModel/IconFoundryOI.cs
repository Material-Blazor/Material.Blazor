using System;
using System.Collections.Generic;
using System.Text;

namespace BModel
{
    /// <summary>
    /// Open Iconic foundry details.
    /// </summary>
    internal class IconFoundryOI : IIconFoundry
    {
        /// <inheritdoc/>
        BEnum.IconFoundryName IIconFoundry.FoundryName => BEnum.IconFoundryName.OpenIconic;
    }
}
