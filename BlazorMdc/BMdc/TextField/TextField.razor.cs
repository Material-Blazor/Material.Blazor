using BMdcBase;

using BMdcModel;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Threading.Tasks;

namespace BMdc
{
    /// <summary>
    /// A Material Theme text field.
    /// </summary>
    public partial class TextField : BMdcInputComponentBase<string>
    {
#nullable enable annotations
        /// <summary>
        /// The text input style.
        /// </summary>
        [Parameter] public TextInputStyle? TextInputStyle { get; set; }


        /// <summary>
        /// The text alignment style.
        /// </summary>
        [Parameter] public TextAlignStyle? TextAlignStyle { get; set; }


        /// <summary>
        /// Field label.
        /// </summary>
        [Parameter] public string Label { get; set; } = "";


        /// <summary>
        /// Hides the label if True. Defaults to False.
        /// </summary>
        [Parameter] public bool NoLabel { get; set; } = false;


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
        /// <para><c>IconFoundry="BMdcModel.IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="BMdcModel.IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="BMdcModel.IconHelper.OIIcon()"</c></para>
        /// </summary>
        [Parameter] public IIconFoundry? IconFoundry { get; set; }
#nullable restore annotations


        private BMdcModel.TextInputStyle AppliedTextInputStyle => CascadingDefaults.AppliedStyle(TextInputStyle);
        
        internal ElementReference TextFieldReference { get; set; }
        
        private ElementReference InputReference { get; set; }
        
        private string FloatingLabelClass { get; set; }

        
        private readonly string labelId = Utilities.GenerateUniqueElementName();
        

        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-text-field")
                .AddIf(FieldClass, () => !string.IsNullOrWhiteSpace(FieldClass))
                .AddIf("mdc-text-field--filled", () => AppliedTextInputStyle == BMdcModel.TextInputStyle.Filled)
                .AddIf("mdc-text-field--outlined", () => AppliedTextInputStyle == BMdcModel.TextInputStyle.Outlined)
                .AddIf("mdc-text-field--filled mdc-text-field--fullwidth", () => AppliedTextInputStyle == BMdcModel.TextInputStyle.FullWidth)
                .AddIf("mdc-text-field--no-label", () => NoLabel)
                .AddIf("mdc-text-field--disabled", () => Disabled)
                .AddIf("mdc-text-field--with-leading-icon", () => !(LeadingIcon is null))
                .AddIf("mdc-text-field--with-trailing-icon", () => !(TrailingIcon is null));


            if (!NoLabel && AppliedTextInputStyle != BMdcModel.TextInputStyle.FullWidth)
            {
                ComponentPureHtmlAttributes.Add("aria-labelledby", labelId);
            }
            else if (!string.IsNullOrWhiteSpace(Label))
            {
                ComponentPureHtmlAttributes.Add("aria-label", Label);
            }

            ForceShouldRenderToTrue = true;
        }


        /// <inheritdoc/>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            var leading = new IconHelper(CascadingDefaults, LeadingIcon, IconFoundry);
            var trailing = new IconHelper(CascadingDefaults, TrailingIcon, IconFoundry);

            FloatingLabelClass = string.IsNullOrEmpty(ReportingValue) ? "" : "mdc-floating-label--float-above";
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.textField.init", TextFieldReference);


        /// <summary>
        /// Selects the text field - used by <see cref="PMdcNumericDoubleField"/>.
        /// </summary>
        /// <returns></returns>
        internal async Task Select() => await JsRuntime.InvokeAsync<object>("BlazorMdc.textField.select", InputReference);
    }
}
