﻿using BMdcFoundation;

using BMdcModel;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Threading.Tasks;

namespace BMdc
{
    /// <summary>
    /// A Material Theme text field.
    /// </summary>
    public partial class TextArea : InputComponentFoundation<string>
    {
        /// <summary>
        /// The text input style.
        /// </summary>
        [Parameter] public ETextInputStyle? TextInputStyle { get; set; }


        /// <summary>
        /// The text alignment style.
        /// </summary>
        [Parameter] public ETextAlignStyle? TextAlignStyle { get; set; }


        /// <summary>
        /// Field label.
        /// </summary>
        [Parameter] public string Label { get; set; } = "";


        /// <summary>
        /// Hides the label if True. Defaults to False.
        /// </summary>
        [Parameter] public bool NoLabel { get; set; } = false;


        /// <summary>
        /// The number of rows to show when first rendered.
        /// </summary>
        [Parameter] public int Rows { get; set; }


        /// <summary>
        /// The number of columns to show when first rendered.
        /// </summary>
        [Parameter] public int Cols { get; set; }


        private ElementReference ElementReference { get; set; }
        private ETextInputStyle AppliedTextInputStyle => CascadingDefaults.AppliedStyle(TextInputStyle);
        private string AppliedTextInputStyleClass => BMdcFoundation.Utilities.GetTextAlignClass(CascadingDefaults.AppliedStyle(TextAlignStyle));
        private string FloatingLabelClass { get; set; }

        private readonly string id = BMdcFoundation.Utilities.GenerateUniqueElementName();
        private readonly string labelId = BMdcFoundation.Utilities.GenerateUniqueElementName();


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-text-field mdc-text-field--textarea")
                .AddIf(FieldClass, () => !string.IsNullOrWhiteSpace(FieldClass))
                .AddIf("mdc-text-field--outlined", () => AppliedTextInputStyle == ETextInputStyle.Outlined)
                .AddIf("mdc-text-field--fullwidth", () => (AppliedTextInputStyle == ETextInputStyle.FullWidth))
                .AddIf("mdc-text-field--no-label", () => NoLabel)
                .AddIf("mdc-text-field--disabled", () => Disabled);

            ForceShouldRenderToTrue = true;
        }


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            FloatingLabelClass = string.IsNullOrEmpty(ReportingValue) ? "" : "mdc-floating-label--float-above";
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.textField.init", ElementReference);
    }
}
