using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// A date picker styled to match the Material Theme date picker specification, using
    /// a modfied Material Theme select input as also applied in <see cref="MBSelect{TItem}"/>.
    /// </summary>
    public partial class MBDatePicker : InputComponentFoundation<DateTime>
    {
        /// <summary>
        /// The select style.
        /// <para>Overrides <see cref="MBCascadingDefaults.SelectInputStyle"/></para>
        /// </summary>
        [Parameter] public MBSelectInputStyle? SelectInputStyle { get; set; }


        /// <summary>
        /// The label.
        /// </summary>
        [Parameter] public string Label { get; set; }


        /// <summary>
        /// Date selection criteria
        /// </summary>
        [Parameter] public MBDateSelectionCriteria? DateSelectionCriteria { get; set; }


        /// <summary>
        /// Minimum date set by the consumer
        /// </summary>
        [Parameter] public DateTime MinDate { get; set; } = DateTime.MinValue;


        /// <summary>
        /// Maximum date set by the consumer
        /// </summary>
        [Parameter] public DateTime MaxDate { get; set; } = DateTime.MaxValue;


        /// <summary>
        /// Specification for date format
        /// </summary>
        [Parameter] public string DateFormat { get; set; } = "D";


        /// <summary>
        /// The select's density.
        /// </summary>
        [Parameter] public MBDensity? Density { get; set; }


        private ElementReference ElementReference { get; set; }

        private InternalDatePickerPanel Panel { get; set; }

        private MBSelectInputStyle AppliedInputStyle => CascadingDefaults.AppliedStyle(SelectInputStyle);

        private MBDensity AppliedDensity => CascadingDefaults.AppliedSelectDensity(Density);

        private bool IsOpen { get; set; } = false;

        private string MenuClass => (Panel?.ShowYearPad ?? true) ? "mb-dp-menu__day-menu" : "mb-dp-menu__year-menu";

        private MBCascadingDefaults.DensityInfo DensityInfo
        {
            get
            {
                var d = CascadingDefaults.GetDensityCssClass(AppliedDensity);

                d.CssClassName += AppliedInputStyle == MBSelectInputStyle.Filled ? "--filled" : "--outlined";

                return d;
            }
        }


        private readonly string key = Utilities.GenerateUniqueElementName();

        private readonly string labelId = Utilities.GenerateUniqueElementName();

        private readonly string listboxId = Utilities.GenerateUniqueElementName();

        private readonly string selectedTextId = Utilities.GenerateUniqueElementName();


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-select")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
                .AddIf("mdc-select--filled", () => AppliedInputStyle == MBSelectInputStyle.Filled)
                .AddIf("mdc-select--outlined", () => AppliedInputStyle == MBSelectInputStyle.Outlined)
                .AddIf("mdc-select--no-label", () => string.IsNullOrWhiteSpace(Label))
                .AddIf("mdc-select--disabled", () => AppliedDisabled);

            SetComponentValue += OnValueSetCallback;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e)
        {
            Panel.SetParameters(true, Value);
            InvokeAsync(() => JsRuntime.InvokeVoidAsync("MaterialBlazor.MBDatePicker.listItemClick", Panel.ListItemReference, Utilities.DateToString(Value, DateFormat)).ConfigureAwait(false));
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBDatePicker.init", ElementReference);
    }
}
