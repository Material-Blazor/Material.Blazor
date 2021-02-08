using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// This is a general purpose Material Theme switch.
    /// </summary>
    public partial class MBSwitch : InputComponent<bool>
    {
        /// <summary>
        /// The switch's label
        /// </summary>
        [Parameter] public string Label { get; set; } = "On/off";


        /// <summary>
        /// The switch's density.
        /// </summary>
        [Parameter] public MBDensity? Density { get; set; }


        private ElementReference ElementReference { get; set; }

        private MBCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityCssClass(CascadingDefaults.AppliedSwitchDensity(Density));


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapperInstance
                .Add("mdc-switch")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
                .AddIf("mdc-switch--disabled", () => AppliedDisabled)
                .AddIf("mdc-switch--checked", () => ComponentValue);

            SetComponentValue += OnValueSetCallback;
            OnDisabledSet += OnDisabledSetCallback;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSwitch.setChecked", ElementReference, Value));


        /// <summary>
        /// Callback for value the Disabled value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnDisabledSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSwitch.setDisabled", ElementReference, AppliedDisabled));


        /// <inheritdoc/>
        private protected override async Task InstantiateMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSwitch.init", ElementReference, ComponentValue);


        /// <inheritdoc/>
        private protected override async Task DestroyMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBSwitch.destroy", ElementReference);
    }
}
