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
        event Action<PMdcToastServiceConfiguration, PMdcToastLevel, string, string> OnShow;

        ///// <summary>
        ///// Shows a information toast 
        ///// </summary>
        ///// <param name="message">Text to display on the toast</param>
        ///// <param name="heading">The text to display as the toasts heading</param>
        //void ShowInfo(string message, string heading = "");

        ///// <summary>
        ///// Shows a success toast 
        ///// </summary>
        ///// <param name="message">Text to display on the toast</param>
        ///// <param name="heading">The text to display as the toasts heading</param>
        //void ShowSuccess(string message, string heading = "");

        ///// <summary>
        ///// Shows a warning toast 
        ///// </summary>
        ///// <param name="message">Text to display on the toast</param>
        ///// <param name="heading">The text to display as the toasts heading</param>
        //void ShowWarning(string message, string heading = "");

        ///// <summary>
        ///// Shows a error toast 
        ///// </summary>
        ///// <param name="message">Text to display on the toast</param>
        ///// <param name="heading">The text to display as the toasts heading</param>
        //void ShowError(string message, string heading = "");

        /// <summary>
        /// Shows a toast using the supplied settings
        /// </summary>
        /// <param name="level">Toast level to display</param>
        /// <param name="message">Text to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        void ShowToast(PMdcToastLevel level, string message, string heading = "");
    }
}
