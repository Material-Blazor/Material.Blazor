using BMdcFoundation;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Threading.Tasks;

namespace BMdc
{
    /// <summary>
    /// This is a general purpose Material Theme radio button. Accepts a generic class TItem
    /// and displays as checked if <see cref="InputComponentFoundation{T}.Value"/> equals <see cref="TargetCheckedValue"/>.
    /// </summary>
    public partial class RadioButton<TItem> : InputComponentFoundation<TItem>
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
        /// Class of the radio button's <c>&lt;div&gt;</c> container.
        /// </summary>
        [Parameter] public string ButtonContainerClass { get; set; }



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
        private string MyButtonContainerClass { get; set; }
        private string DisabledClass { get; set; } = "";


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ForceShouldRenderToTrue = true;

            ClassMapper
                .Add("mdc-form-field");
        }


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            if (string.IsNullOrEmpty(RadioGroupName))
            {
                throw new ArgumentException("RadioGroupName is a required parameter in MdcRadioButton.");
            }

            if (EnableTouchWrapper)
            {
                MyButtonContainerClass = "mdc-radio mdc-radio--touch";
            }
            else
            {
                MyButtonContainerClass = "mdc-radio";
            }

            if (!string.IsNullOrWhiteSpace(ButtonContainerClass))
            {
                MyButtonContainerClass += " " + ButtonContainerClass;
            }

            if (Disabled)
            {
                DisabledClass = "mdc-radio--disabled";
            }
        }


        /// <inheritdoc/>
        protected override void OnValueSet()
        {
            InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.radioButton.setChecked", RadioButtonReference, Value.Equals(TargetCheckedValue)).ConfigureAwait(false));
        }


        private async Task OnInternalItemClickAsync()
        {
            ReportingValue = TargetCheckedValue;
            await Task.CompletedTask;
        }


        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.radioButton.init", RadioButtonReference, FormReference, Value.Equals(TargetCheckedValue)).ConfigureAwait(false);
    }
}
