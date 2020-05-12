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
        /// <param name="closeMethod">close method</param>
        /// <param name="cssClass">additional css applied to toast</param>
        /// <param name="heading">Text used in the heading of the toast</param>
        /// <param name="icon">Icon name</param>
        /// <param name="level">Severity of the toast (info, error, etc)</param>
        /// <param name="message">Body text in the toast</param>
        /// <param name="showIcon">Show or hide icon</param>
        /// <param name="timeout">Length of time before autodismiss</param>
#nullable enable annotations
        void ShowToast(
            PMdcToastLevel level,
            string message,
            string heading = null,
            PMdcToastCloseMethod? closeMethod = null,
            string cssClass = null,
            string icon = null,
            IMdcIconFoundry? iconFoundry = null,
            bool? showIcon = null,
            uint? timeout = null);
#nullable restore annotations
    }
}
