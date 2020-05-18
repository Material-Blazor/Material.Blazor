using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// This is a general purpose Material Theme switch.
    /// </summary>
    public partial class MdcSwitch : MdcInputComponentBase<bool>
    {
        /// <summary>
        /// The switch's label
        /// </summary>
        [Parameter] public string Label { get; set; } = "On/off";


        private ElementReference ElementReference { get; set; }


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-switch")
                .AddIf("mdc-switch--disabled", () => Disabled)
                .AddIf("mdc-switch--checked", () => ReportingValue);

            ForceShouldRenderToTrue = true;
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.switch.setChecked", ElementReference, ReportingValue);
    }
}
