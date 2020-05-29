using BMdcBase;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Threading.Tasks;

namespace BMdc
{
    /// <summary>
    /// This is a general purpose Material Theme check box accepting a boolean as a bound value. This
    /// check box does not implement indeteriminate state.
    /// </summary>
    public partial class Checkbox : BMdcInputComponentBase<bool>
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
        }


        /// <inheritdoc/>
        protected override void OnValueSet()
        {
            AllowNextRender = true;
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.checkBox.init", ElementReference, FormReference, ReportingValue, IsFormField);
    }
}
