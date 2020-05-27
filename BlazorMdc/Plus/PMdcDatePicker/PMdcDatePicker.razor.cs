using BBase;
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
    public partial class PMdcDatePicker : BBase.InputComponentBase<DateTime>
    {
        /// <summary>
        /// The select style.
        /// </summary>
        [Parameter] public BEnum.SelectInputStyle? SelectInputStyle { get; set; }


        /// <summary>
        /// The label.
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// Date selection criteria
        /// </summary>
        [Parameter] public BEnum.DateSelectionCriteria? DateSelectionCriteria { get; set; }


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

        private BEnum.SelectInputStyle AppliedInputStyle => CascadingDefaults.AppliedStyle(SelectInputStyle);

        private bool IsOpen { get; set; } = false;


        private readonly string key = BBase.Utilities.GenerateUniqueElementName();
        private readonly string labelId = BBase.Utilities.GenerateUniqueElementName();


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-select")
                .AddIf("mdc-select--outlined", () => (AppliedInputStyle == BEnum.SelectInputStyle.Outlined))
                .AddIf("mdc-select--disabled", () => Disabled);
        }


        /// <inheritdoc/>
        protected override void OnValueSet()
        {
            Panel.SetParameters(true, Value);
            InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.datePicker.listItemClick", Panel.ListItemReference, BBase.Utilities.DateToString(Value)).ConfigureAwait(false));
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.datePicker.init", ElementReference);
    }
}
