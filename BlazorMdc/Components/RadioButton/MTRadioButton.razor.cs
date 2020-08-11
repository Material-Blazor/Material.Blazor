using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// This is a general purpose Material Theme radio button. Accepts a generic class TItem
    /// and displays as checked if <see cref="InputComponentFoundation{T}.Value"/> equals <see cref="TargetCheckedValue"/>.
    /// </summary>
    public partial class MTRadioButton<TItem> : InputComponentFoundation<TItem>
    {
        /// <summary>
        /// <see cref="InputComponentFoundation{T}.Value"/> is set to this when the 
        /// radio button is clicked. If the consumer sets <see cref="InputComponentFoundation{T}.Value"/>
        /// to this the radio state will change to checked, or cleared for any other value.
        /// </summary>
        [Parameter] public TItem TargetCheckedValue { get; set; }


        /// <summary>
        /// The radio button label.
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// The radio button's density.
        /// </summary>
        [Parameter] public MTDensity? Density { get; set; }


        /// <summary>
        /// Enables the Material Theme touch wrapper.
        /// </summary>
        [Parameter] public bool EnableTouchWrapper { get; set; } = true;


        /// <summary>
        /// The radio button group name. This is applied to a group of radio buttons
        /// so Material Theme can identify them as representing different values of the
        /// same property.
        /// </summary>
        [Parameter] public string RadioGroupName { get; set; }


        private readonly string radioId = Utilities.GenerateUniqueElementName();


        private ElementReference FormReference { get; set; }
        private ElementReference RadioButtonReference { get; set; }
        private string ButtonContainerClass { get; set; }
        private string DisabledClass { get; set; } = "";

        private MTCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityCssClass(CascadingDefaults.AppliedRadioButtonDensity(Density));


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ForceShouldRenderToTrue = true;

            ClassMapper
                .Add("mdc-form-field");

            OnValueSet += OnValueSetCallback;
        }


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            if (string.IsNullOrEmpty(RadioGroupName))
            {
                throw new ArgumentException("RadioGroupName is a required parameter in MTRadioButton.");
            }

            if (EnableTouchWrapper)
            {
                ButtonContainerClass = "mdc-radio mdc-radio--touch";
            }
            else
            {
                ButtonContainerClass = "mdc-radio";
            }

            if (DensityInfo.ApplyCssClass)
            {
                ButtonContainerClass += $" {DensityInfo.CssClassName}";
            }

            if (AppliedDisabled)
            {
                DisabledClass = "mdc-radio--disabled";
            }
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(() => JsRuntime.InvokeVoidAsync("BlazorMdc.radioButton.setChecked", RadioButtonReference, Value.Equals(TargetCheckedValue)).ConfigureAwait(false));


        private async Task OnInternalItemClickAsync()
        {
            ReportingValue = TargetCheckedValue;
            await Task.CompletedTask;
        }


        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeVoidAsync("BlazorMdc.radioButton.init", RadioButtonReference, FormReference, Value.Equals(TargetCheckedValue)).ConfigureAwait(false);
    }
}
