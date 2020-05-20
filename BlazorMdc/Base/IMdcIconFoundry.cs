using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMdc
{
    /// <summary>
    /// An interface for supplying icon foundry information to components.
    /// </summary>
    public interface IMdcIconFoundry
    {
        /// <summary>
        /// The foundry's name.
        /// </summary>
        internal MdcIconFoundryName FoundryName { get;}
    }
}
