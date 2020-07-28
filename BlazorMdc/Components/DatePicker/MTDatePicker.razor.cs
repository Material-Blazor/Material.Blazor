using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// A date picker styled to match the Material Theme date picker specification, using
    /// a modfied Material Theme select input as also applied in <see cref="MTSelect{TItem}"/>.
    /// </summary>
    public partial class MTDatePicker : InputComponentFoundation<DateTime>
    {
        /// <summary>
        /// The select style.
        /// <para>Overrides <see cref="MTCascadingDefaults.SelectInputStyle"/></para>
        /// </summary>
        [Parameter] public MTSelectInputStyle? SelectInputStyle { get; set; }


        /// <summary>
        /// The label.
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// Date selection criteria
        /// </summary>
        [Parameter] public MTDateSelectionCriteria? DateSelectionCriteria { get; set; }


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

        private MTSelectInputStyle AppliedInputStyle => CascadingDefaults.AppliedStyle(SelectInputStyle);

        private bool IsOpen { get; set; } = false;

        private string MenuClass => (Panel?.ShowYearPad ?? true) ? "bmdc-dp-menu__day-menu" : "bmdc-dp-menu__year-menu";


        private readonly string key = Utilities.GenerateUniqueElementName();

        private readonly string labelId = Utilities.GenerateUniqueElementName();

        private readonly string listboxId = Utilities.GenerateUniqueElementName();

        private readonly string selectedTextId = Utilities.GenerateUniqueElementName();


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-select")
                .AddIf("mdc-select--filled", () => AppliedInputStyle == MTSelectInputStyle.Filled)
                .AddIf("mdc-select--outlined", () => AppliedInputStyle == MTSelectInputStyle.Outlined)
                .AddIf("mdc-select--no-label", () => string.IsNullOrWhiteSpace(Label))
                .AddIf("mdc-select--disabled", () => AppliedDisabled);

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
            InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.datePicker.listItemClick", Panel.ListItemReference, Utilities.DateToString(Value, DateFormat)).ConfigureAwait(false));
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.datePicker.init", ElementReference);
    }
}
