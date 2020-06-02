using BMdcFoundation;

using BMdcModel;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Threading.Tasks;

namespace BMdcPlus
{
    /// <summary>
    /// A date picker styled to match the Material Theme date picker specification, using
    /// a modfied Material Theme select input as also applied in <see cref="MdcSelect{TItem}"/>.
    /// </summary>
    public partial class DatePicker : InputComponentFoundation<DateTime>
    {
        /// <summary>
        /// The select style.
        /// </summary>
        [Parameter] public eSelectInputStyle? SelectInputStyle { get; set; }


        /// <summary>
        /// The label.
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// Date selection criteria
        /// </summary>
        [Parameter] public eDateSelectionCriteria? DateSelectionCriteria { get; set; }


        /// <summary>
        /// Minimum date set by the consumer
        /// </summary>
        [Parameter] public DateTime MinDate { get; set; }


        /// <summary>
        /// Maximum date set by the consumer
        /// </summary>
        [Parameter] public DateTime MaxDate { get; set; }


        private ElementReference ElementReference { get; set; }

        private InternalDatePickerPanel Panel { get; set; }

        private eSelectInputStyle AppliedInputStyle => CascadingDefaults.AppliedStyle(SelectInputStyle);

        private bool IsOpen { get; set; } = false;


        private readonly string key = Utilities.GenerateUniqueElementName();
        private readonly string labelId = Utilities.GenerateUniqueElementName();


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-select")
                .AddIf("mdc-select--outlined", () => AppliedInputStyle == eSelectInputStyle.Outlined)
                .AddIf("mdc-select--disabled", () => Disabled);
        }


        /// <inheritdoc/>
        protected override void OnValueSet()
        {
            Panel.SetParameters(true, Value);
            InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.datePicker.listItemClick", Panel.ListItemReference, Utilities.DateToString(Value)).ConfigureAwait(false));
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.datePicker.init", ElementReference);
    }
}
