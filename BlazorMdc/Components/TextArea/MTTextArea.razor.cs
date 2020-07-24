using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// A Material Theme text field.
    /// </summary>
    public partial class MTTextArea : InputComponentFoundation<string>
    {
        /// <summary>
        /// The text input style.
        /// </summary>
        [Parameter] public MTTextInputStyle? TextInputStyle { get; set; }


        /// <summary>
        /// The text alignment style.
        /// </summary>
        [Parameter] public MTTextAlignStyle? TextAlignStyle { get; set; }


        /// <summary>
        /// Field label.
        /// </summary>
        [Parameter] public string Label { get; set; } = "";


        /// <summary>
        /// The number of rows to show when first rendered.
        /// </summary>
        [Parameter] public int Rows { get; set; }


        /// <summary>
        /// The number of columns to show when first rendered.
        /// </summary>
        [Parameter] public int Cols { get; set; }


        /// <summary>
        /// The text area's density.
        /// </summary>
        [Parameter] public MTDensity? Density { get; set; }


        private ElementReference ElementReference { get; set; }
        private MTTextInputStyle AppliedTextInputStyle => CascadingDefaults.AppliedStyle(TextInputStyle);
        private string AppliedTextInputStyleClass => Utilities.GetTextAlignClass(CascadingDefaults.AppliedStyle(TextAlignStyle));
        private string FloatingLabelClass { get; set; }

        private readonly string id = Utilities.GenerateUniqueElementName();

        private readonly string labelId = Utilities.GenerateUniqueElementName();

        private MTCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityInfo(CascadingDefaults.AppliedTextFieldDensity(Density));


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-text-field mdc-text-field--textarea")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
                .AddIf(FieldClass, () => !string.IsNullOrWhiteSpace(FieldClass))
                .AddIf("mdc-text-field--filled", () => AppliedTextInputStyle == MTTextInputStyle.Filled)
                .AddIf("mdc-text-field--outlined", () => AppliedTextInputStyle == MTTextInputStyle.Outlined)
                .AddIf("mdc-text-field--no-label", () => string.IsNullOrWhiteSpace(Label))
                .AddIf("mdc-text-field--disabled", () => Disabled);

            if (!string.IsNullOrWhiteSpace(Label))
            {
                ComponentPureHtmlAttributes.Add("aria-label", Label);
            }

            FloatingLabelClass = string.IsNullOrEmpty(ReportingValue) ? "" : "mdc-floating-label--float-above";

            OnValueSet += OnValueSetCallback;
            OnDisabledSet += OnDisabledSetCallback;
        }


        /// <summary>
        /// Callback for value the value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.textField.setValue", ElementReference, Value));


        /// <summary>
        /// Callback for value the Disabled value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnDisabledSetCallback(object sender, EventArgs e) => InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.textField.setDisabled", ElementReference, Disabled));


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.textField.init", ElementReference);
    }
}
