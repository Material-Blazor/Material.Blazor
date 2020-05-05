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
        public event Action<PMdcToastServiceConfiguration, PMdcToastLevel, PMdcToastSettings> OnShow;


        public PMdcToastService(PMdcToastServiceConfiguration configuration)
        {
            Configuration = configuration;
        }

        ///<inheritdoc/>
        public void ShowToast(PMdcToastLevel level, PMdcToastSettings settings)
        {
            OnShow?.Invoke(Configuration, level, settings);
        }
    }
}
