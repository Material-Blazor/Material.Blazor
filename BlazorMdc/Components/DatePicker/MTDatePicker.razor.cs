using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// A date picker styled to match the Material Theme date picker specification, using
    /// a modfied Material Theme select input as also applied in <see cref="MdcSelect{TItem}"/>.
    /// </summary>
    public partial class MTDatePicker : MTInputComponentBase<DateTime>
    {
        /// <summary>
        /// The select style.
        /// </summary>
        [Parameter] public SelectInputStyleEnum? SelectInputStyle { get; set; }


        /// <summary>
        /// The label.
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// Date selection criteria
        /// </summary>
        [Parameter] public DateSelectionCriteria? DateSelectionCriteria { get; set; }


        /// <summary>
        /// Minimum date set by the consumer
        /// </summary>
        [Parameter] public DateTime MinDate { get; set; }


        /// <summary>
        /// Maximum date set by the consumer
        /// </summary>
        [Parameter] public DateTime MaxDate { get; set; }


        /// <summary>
        /// Specification for date format
        /// </summary>
        [Parameter] public string DateFormat { get; set; } = "D";


        private ElementReference ElementReference { get; set; }

        private InternalDatePickerPanel Panel { get; set; }

        private SelectInputStyleEnum AppliedInputStyle => CascadingDefaults.AppliedStyle(SelectInputStyle);

        private bool IsOpen { get; set; } = false;


        private readonly string key = MTUtilities.GenerateUniqueElementName();
        private readonly string labelId = MTUtilities.GenerateUniqueElementName();


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-select")
                .AddIf("mdc-select--outlined", () => AppliedInputStyle == SelectInputStyleEnum.Outlined)
                .AddIf("mdc-select--disabled", () => Disabled);

            OnValueSet += OnValueSetCallback;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e)
        {
            Panel.SetParameters(true, Value);
            InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.datePicker.listItemClick", Panel.ListItemReference, MTUtilities.DateToString(Value, DateFormat)).ConfigureAwait(false));
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.datePicker.init", ElementReference);
    }
}
