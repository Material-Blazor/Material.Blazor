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
        ///<inheritdoc/>
        public PMdcToastServiceConfiguration Configuration { get; set; } = new PMdcToastServiceConfiguration();

        ///<inheritdoc/>
        public event Action<PMdcToastServiceConfiguration, PMdcToastLevel, string, string> OnShow;


        public PMdcToastService(PMdcToastServiceConfiguration configuration)
        {
            Configuration = configuration;
        }

        /////<inheritdoc/>
        //public void ShowInfo(string message, string heading = "")
        //{
        //    ShowToast(PMdcToastLevel.Info, message, heading);
        //}

        /////<inheritdoc/>
        //public void ShowSuccess(string message, string heading = "")
        //{
        //    ShowToast(PMdcToastLevel.Success, message, heading);
        //}

        /////<inheritdoc/>
        //public void ShowWarning(string message, string heading = "")
        //{
        //    ShowToast(PMdcToastLevel.Warning, message, heading);
        //}

        /////<inheritdoc/>
        //public void ShowError(string message, string heading = "")
        //{
        //    ShowToast(PMdcToastLevel.Error, message, heading);
        //}

        ///<inheritdoc/>
        public void ShowToast(PMdcToastLevel level, string message, string heading = "")
        {
            OnShow?.Invoke(Configuration, level, message, heading);
        }
    }
}
