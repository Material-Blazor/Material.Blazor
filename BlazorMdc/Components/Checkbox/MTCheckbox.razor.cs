using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// This is a general purpose Material Theme check box accepting a boolean as a bound value. This
    /// check box does not implement indeteriminate state.
    /// </summary>
    public partial class MTCheckbox : InputComponentFoundation<bool>
    {
        // <summary>
        /// The check box label.
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// Set to True if this is in a form.
        /// </summary>
        [Parameter] public bool IsFormField { get; set; }


        private string FormFieldClass => (IsFormField || !(string.IsNullOrWhiteSpace(Label))) ? "mdc-form-field" : "";
        private ElementReference ElementReference { get; set; }
        private ElementReference FormReference { get; set; }


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-checkbox mdc-checkbox--touch")
                .AddIf("mdc-checkbox--disabled", () => Disabled);

            OnValueSet += OnValueSetCallback;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => AllowNextRender = true;


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.checkBox.init", ElementReference, FormReference, ReportingValue, IsFormField);
    }
}
