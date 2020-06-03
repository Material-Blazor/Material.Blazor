using System;
using System.Collections.Generic;
using System.Text;

namespace BMdcModel
{
    /// <summary>
    /// Open Iconic foundry details.
    /// </summary>
    internal class IconFoundryOI : IIconFoundry
    {
        /// <inheritdoc/>
        EIconFoundryName IIconFoundry.FoundryName => EIconFoundryName.OpenIconic;
    }
}
