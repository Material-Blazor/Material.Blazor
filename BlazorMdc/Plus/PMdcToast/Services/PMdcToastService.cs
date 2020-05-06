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

        private event Action<PMdcToastLevel, PMdcToastSettings> OnAdd;
        ///<inheritdoc/>
        event Action<PMdcToastLevel, PMdcToastSettings> IPmdcToastService.OnAdd
        {
            add => OnAdd += value;
            remove => OnAdd -= value;
        }


        public PMdcToastService(PMdcToastServiceConfiguration configuration)
        {
            Configuration = configuration;
        }

        ///<inheritdoc/>
        public void ShowToast(PMdcToastLevel level, PMdcToastSettings settings)
        {
            OnAdd?.Invoke(level, settings);
        }
    }
}
