using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// A Material Theme text field.
    /// </summary>
    public partial class MdcTextField : MdcInputComponentBase<string>
    {
#nullable enable annotations
        /// <summary>
        /// The text input style.
        /// </summary>
        [Parameter] public BEnum.TextInputStyle? TextInputStyle { get; set; }


        /// <summary>
        /// The text alignment style.
        /// </summary>
        [Parameter] public BEnum.TextAlignStyle? TextAlignStyle { get; set; }


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
        /// <para><c>IconFoundry="BModel.IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="BModel.IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="BModel.IconHelper.OIIcon()"</c></para>
        /// </summary>
        [Parameter] public BModel.IIconFoundry? IconFoundry { get; set; }
#nullable restore annotations


        private BEnum.TextInputStyle AppliedTextInputStyle => CascadingDefaults.AppliedStyle(TextInputStyle);
        
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
                .AddIf("mdc-text-field--filled", () => AppliedTextInputStyle == BEnum.TextInputStyle.Filled)
                .AddIf("mdc-text-field--outlined", () => AppliedTextInputStyle == BEnum.TextInputStyle.Outlined)
                .AddIf("mdc-text-field--filled mdc-text-field--fullwidth", () => AppliedTextInputStyle == BEnum.TextInputStyle.FullWidth)
                .AddIf("mdc-text-field--no-label", () => NoLabel)
                .AddIf("mdc-text-field--disabled", () => Disabled)
                .AddIf("mdc-text-field--with-leading-icon", () => !(LeadingIcon is null))
                .AddIf("mdc-text-field--with-trailing-icon", () => !(TrailingIcon is null));


            if (!NoLabel && AppliedTextInputStyle != BEnum.TextInputStyle.FullWidth)
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

            var leading = new BModel.IconHelper(CascadingDefaults, LeadingIcon, IconFoundry);
            var trailing = new BModel.IconHelper(CascadingDefaults, TrailingIcon, IconFoundry);

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
