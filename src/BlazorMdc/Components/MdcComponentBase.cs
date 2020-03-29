using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMdc.Components
{
    public abstract class MdcComponentBase : ComponentBase
    {
        [CascadingParameter]
        private MdcpCascadingDefaults CascadingDefaults { get; set; }

        protected MdcpCascadingDefaults AppliedDefaults => (CascadingDefaults == null) ? new MdcpCascadingDefaults() : CascadingDefaults;

        /// <summary>
        /// Gets a value for the component's 'class' attribute.
        /// </summary>
        [Parameter] public string Class { get; set; }

        /// <summary>
        /// Gets whether the component is disabled.
        /// </summary>
        [Parameter] public bool Disabled { get; set; } = false;


        protected override Task OnAfterRenderAsync(bool isFirstRender)
        {
            if (isFirstRender)
            {
                return OnAfterFirstRenderAsync();
            }
            else
            {
                return Task.CompletedTask;
            }
        }

        protected virtual Task OnAfterFirstRenderAsync()
            => Task.CompletedTask;
    }
}
