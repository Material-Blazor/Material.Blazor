//
//  2020-04-10  Mark Stega
//              Created from github.com/ChrisSainty/Blazored.Toast by Chris Sainty
//

using System;
using Microsoft.AspNetCore.Components;

namespace BlazorMdc
{
    public class PMdcToastService : IPmdcToastService
    {
        /// <summary>
        /// A event that will be invoked when showing a toast
        /// </summary>
        public event Action<PMdcToastLevel, RenderFragment, string> OnShow;

        /// <summary>
        /// Shows a information toast 
        /// </summary>
        /// <param name="message">Text to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        public void ShowInfo(string message, string heading = "")
        {
            ShowToast(PMdcToastLevel.Info, message, heading);
        }

        /// <summary>
        /// Shows a information toast 
        /// </summary>
        /// <param name="message">RenderFragment to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        public void ShowInfo(RenderFragment message, string heading = "")
        {
            ShowToast(PMdcToastLevel.Info, message, heading);
        }

        /// <summary>
        /// Shows a success toast 
        /// </summary>
        /// <param name="message">Text to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        public void ShowSuccess(string message, string heading = "")
        {
            ShowToast(PMdcToastLevel.Success, message, heading);
        }

        /// <summary>
        /// Shows a success toast 
        /// </summary>
        /// <param name="message">RenderFragment to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        public void ShowSuccess(RenderFragment message, string heading = "")
        {
            ShowToast(PMdcToastLevel.Success, message, heading);
        }

        /// <summary>
        /// Shows a warning toast 
        /// </summary>
        /// <param name="message">Text to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        public void ShowWarning(string message, string heading = "")
        {
            ShowToast(PMdcToastLevel.Warning, message, heading);
        }

        /// <summary>
        /// Shows a warning toast 
        /// </summary>
        /// <param name="message">RenderFragment to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        public void ShowWarning(RenderFragment message, string heading = "")
        {
            ShowToast(PMdcToastLevel.Warning, message, heading);
        }

        /// <summary>
        /// Shows a error toast 
        /// </summary>
        /// <param name="message">Text to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        public void ShowError(string message, string heading = "")
        {
            ShowToast(PMdcToastLevel.Error, message, heading);
        }

        /// <summary>
        /// Shows a error toast 
        /// </summary>
        /// <param name="message">RenderFragment to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        public void ShowError(RenderFragment message, string heading = "")
        {
            ShowToast(PMdcToastLevel.Error, message, heading);
        }

        /// <summary>
        /// Shows a toast using the supplied settings
        /// </summary>
        /// <param name="level">Toast level to display</param>
        /// <param name="message">Text to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        public void ShowToast(PMdcToastLevel level, string message, string heading = "")
        {
            ShowToast(level, builder => builder.AddContent(0, message), heading);
        }


        /// <summary>
        /// Shows a toast using the supplied settings
        /// </summary>
        /// <param name="level">Toast level to display</param>
        /// <param name="message">RenderFragment to display on the toast</param>
        /// <param name="heading">The text to display as the toasts heading</param>
        public void ShowToast(PMdcToastLevel level, RenderFragment message, string heading = "")
        {
            OnShow?.Invoke(level, message, heading);
        }
    }
}
