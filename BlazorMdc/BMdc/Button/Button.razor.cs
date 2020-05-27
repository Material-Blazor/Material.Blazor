using BMdcBase;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BMdc
{
    /// <summary>
    /// This is a general purpose Material Theme button, with provision for standard MT styling, leading 
    /// and trailing icons and all standard Blazor events. Adds the "mdc-card__action--button" class when 
    /// placed inside an <see cref="BMdc.Card"/>.
    /// </summary>
    public partial class Button : BMdcBase.ComponentBase
    {
        [CascadingParameter] private Card Card { get; set; }

        [CascadingParameter] private Dialog Dialog { get; set; }


#nullable enable annotations
        /// <summary>
        /// The button's Material Theme style - see <see cref="BlazorMdc.ButtonStyle"/>.
        /// </summary>
        [Parameter] public BMdcModel.ButtonStyle? ButtonStyle { get; set; }


        /// <summary>
        /// The button's label.
        /// </summary>
        [Parameter] public string Label { get; set; }


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
        [Parameter] public BMdcModel.IIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// A string value to return from an <see cref="BMdc.Dialog"/> when this button is pressed.
        /// </summary>
        [Parameter] public string DialogAction { get; set; }
#nullable restore annotations


        private ElementReference ElementReference { get; set; }


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-button")
                .AddIf("mdc-button--raised", () => CascadingDefaults.AppliedStyle(ButtonStyle, Card, Dialog) == BMdcModel.ButtonStyle.ContainedRaised)
                .AddIf("mdc-button--unelevated", () => CascadingDefaults.AppliedStyle(ButtonStyle, Card, Dialog) == BMdcModel.ButtonStyle.ContainedUnelevated)
                .AddIf("mdc-button--outlined", () => CascadingDefaults.AppliedStyle(ButtonStyle, Card, Dialog) == BMdcModel.ButtonStyle.Outlined)
                .AddIf("mdc-card__action mdc-card__action--button", () => (Card != null));
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.button.init", ElementReference);
    }
}
