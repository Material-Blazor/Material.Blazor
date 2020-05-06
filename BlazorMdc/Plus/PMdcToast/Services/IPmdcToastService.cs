//
//  2020-04-10  Mark Stega
//              Created from github.com/ChrisSainty/Blazored.Toast by Chris Sainty
//

using System;
using Microsoft.AspNetCore.Components;

namespace BlazorMdc
{
    public interface IPmdcToastService
    {
        /// <summary>
        /// Toast service configuration
        /// </summary>
        public PMdcToastServiceConfiguration Configuration { get; set; }

        /// <summary>
        /// A event that will be invoked when showing a toast
        /// </summary>
        internal event Action<PMdcToastLevel, PMdcToastSettings> OnAdd;

        /// <summary>
        /// Shows a toast using the supplied settings
        /// </summary>
        /// <param name="level">Toast level to display</param>
        /// <param name="settings">Settings including the heading and message</param>
        void ShowToast(PMdcToastLevel level, PMdcToastSettings settings);
    }
}
