using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// A Material Theme text field.
    /// </summary>
    public partial class MTTextField : InputComponentFoundation<string>
    {
#nullable enable annotations
        /// <summary>
        /// The text input style.
        /// <para>Overrides <see cref="MTCascadingDefaults.TextInputStyle"/></para>
        /// </summary>
        [Parameter] public MTTextInputStyle? TextInputStyle { get; set; }


        /// <summary>
        /// The text alignment style.
        /// <para>Overrides <see cref="MTCascadingDefaults.TextAlignStyle"/></para>
        /// </summary>
        [Parameter] public MTTextAlignStyle? TextAlignStyle { get; set; }


        /// <summary>
        /// Field label.
        /// </summary>
        [Parameter] public string? Label { get; set; }


        /// <summary>
        /// Prefix text.
        /// </summary>
        [Parameter] public string? Prefix { get; set; }


        /// <summary>
        /// Suffix text.
        /// </summary>
        [Parameter] public string? Suffix { get; set; }


        /// <summary>
        /// The leading icon's name. No leading icon shown if not set.
        /// </summary>
        [Parameter] public string? LeadingIcon { get; set; }


        /// <summary>
        /// The trailing icon's name. No leading icon shown if not set.
        /// </summary>
        [Parameter] public string? TrailingIcon { get; set; }


        /// <summary>
        /// The foundry to use for both leading and trailing icons.
        /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
        /// <para>Overrides <see cref="MTCascadingDefaults.IconFoundryName"/></para>
        /// </summary>
        [Parameter] public IMTIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// The text field's density.
        /// </summary>
        [Parameter] public MTDensity? Density { get; set; }
#nullable restore annotations


        private MTTextInputStyle AppliedInputStyle => CascadingDefaults.AppliedStyle(TextInputStyle);

        private string AppliedTextInputStyleClass => Utilities.GetTextAlignClass(CascadingDefaults.AppliedStyle(TextAlignStyle));
        
        private MTDensity AppliedDensity => CascadingDefaults.AppliedTextFieldDensity(Density);

        internal ElementReference ElementReference { get; set; }
        
        private ElementReference InputReference { get; set; }
        
        private string FloatingLabelClass { get; set; }

        
        private readonly string labelId = Utilities.GenerateUniqueElementName();

        private MTCascadingDefaults.DensityInfo DensityInfo
        {
            get
            {
                var d = CascadingDefaults.GetDensityCssClass(AppliedDensity);

                var suffix = AppliedInputStyle == MTTextInputStyle.Filled ? "--tf--filled" : "--tf--outlined";
                suffix += string.IsNullOrWhiteSpace(LeadingIcon) ? "" : "-with-leading-icon";

                d.CssClassName += suffix;

                return d;
            }
        }

        private bool ShowLabel => !string.IsNullOrWhiteSpace(Label);


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-text-field")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass)
                .AddIf(FieldClass, () => !string.IsNullOrWhiteSpace(FieldClass))
                .AddIf("mdc-text-field--filled", () => AppliedInputStyle == MTTextInputStyle.Filled)
                .AddIf("mdc-text-field--outlined", () => AppliedInputStyle == MTTextInputStyle.Outlined)
                .AddIf("mdc-text-field--no-label", () => !ShowLabel)
                .AddIf("mdc-text-field--disabled", () => AppliedDisabled)
                .AddIf("mdc-text-field--with-leading-icon", () => !(LeadingIcon is null))
                .AddIf("mdc-text-field--with-trailing-icon", () => !(TrailingIcon is null));

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
        protected void OnValueSetCallback(object sender, EventArgs e) => InvokeAsync(() => JsRuntime.InvokeVoidAsync("BlazorMdc.textField.setValue", ElementReference, Value));


        /// <summary>
        /// Callback for value the Disabled value setter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnDisabledSetCallback(object sender, EventArgs e) => InvokeAsync(() => JsRuntime.InvokeVoidAsync("BlazorMdc.textField.setDisabled", ElementReference, AppliedDisabled));


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeVoidAsync("BlazorMdc.textField.init", ElementReference);


        /// <summary>
        /// Selects the text field - used by <see cref="MTNumericDoubleField"/>.
        /// </summary>
        /// <returns></returns>
        internal async Task Select() => await JsRuntime.InvokeVoidAsync("BlazorMdc.textField.select", InputReference);
    }
}
