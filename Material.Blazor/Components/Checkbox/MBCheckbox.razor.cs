using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// This is a general purpose Material Theme check box accepting a boolean as a bound value. This
    /// check box does not implement indeteriminate state.
    /// </summary>
    public partial class MBCheckbox : InputComponent<bool>
    {
        /// <summary>
        /// The check box label.
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// The checkbox's density.
        /// </summary>
        [Parameter] public MBDensity? Density { get; set; }


        private bool _isIndetermimate;
        /// <summary>
        /// Set to True if the checkbox is indeterminate.
        /// </summary>
        [Parameter]
        public bool IsIndeterminate
        {
            get => _isIndetermimate;
            set
            {
                if (value != _isIndetermimate)
                {
                    _isIndetermimate = value;
                    InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBCheckbox.setIndeterminate", ElementReference, _isIndetermimate));
                }
            }
        }

        /// <summary>
        /// Gets or sets a callback that updates the bound value.
        /// </summary>
        [Parameter] public EventCallback<bool> IsIndeterminateChanged { get; set; }


        private bool CheckedValue
        {
            get => ComponentValue;
            set
            {
                _isIndetermimate = false;
                IsIndeterminateChanged.InvokeAsync(false);
                ComponentValue = value;
            }
        }

        private ElementReference ElementReference { get; set; }
        private ElementReference FormReference { get; set; }

        private MBCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityCssClass(CascadingDefaults.AppliedCheckboxDensity(Density));


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapperInstance
                .Add("mdc-checkbox mdc-checkbox--touch")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
                .AddIf("mdc-checkbox--selected", () => Value)
                .AddIf("mdc-checkbox--disabled", () => AppliedDisabled);

            SetComponentValue += OnValueSetCallback;
            OnDisabledSet += OnDisabledSetCallback;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBCheckbox.setChecked", ElementReference, Value));


        /// <summary>
        /// Callback for value the Disabled value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnDisabledSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBCheckbox.setDisabled", ElementReference, AppliedDisabled));


        /// <inheritdoc/>
        private protected override async Task InstantiateMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBCheckbox.init", ElementReference, FormReference, ComponentValue, IsIndeterminate);


        /// <inheritdoc/>
        private protected override async Task DestroyMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBCheckbox.destroy", ElementReference);
    }
}
