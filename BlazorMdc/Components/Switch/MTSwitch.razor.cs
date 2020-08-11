using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// This is a general purpose Material Theme switch.
    /// </summary>
    public partial class MTSwitch : InputComponentFoundation<bool>
    {
        /// <summary>
        /// The switch's label
        /// </summary>
        [Parameter] public string Label { get; set; } = "On/off";


        /// <summary>
        /// The switch's density.
        /// </summary>
        [Parameter] public MTDensity? Density { get; set; }


        private ElementReference ElementReference { get; set; }

        private MTCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityCssClass(CascadingDefaults.AppliedSwitchDensity(Density));


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();
            
            ClassMapper
                .Add("mdc-switch")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
                .AddIf("mdc-switch--disabled", () => AppliedDisabled)
                .AddIf("mdc-switch--checked", () => ReportingValue);

            OnValueSet += OnValueSetCallback;
            OnDisabledSet += OnDisabledSetCallback;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(() => JsRuntime.InvokeVoidAsync("BlazorMdc.switch.setChecked", ElementReference, Value));


        /// <summary>
        /// Callback for value the Disabled value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnDisabledSetCallback(object sender, EventArgs e) => InvokeAsync(() => JsRuntime.InvokeVoidAsync("BlazorMdc.switch.setDisabled", ElementReference, AppliedDisabled));


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeVoidAsync("BlazorMdc.switch.init", ElementReference, ReportingValue);
    }
}
