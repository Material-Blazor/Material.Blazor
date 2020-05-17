using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// This is a general purpose Material Theme button, with provision for standard MT styling, leading 
    /// and trailing icons and all standard Blazor events.
    /// </summary>
    /// <param>s</param>
    public partial class MdcButton : MdcComponentBase
    {
        [Inject] private IJSRuntime JSRuntime { get; set; }

        [CascadingParameter] private MdcCard Card { get; set; }

        [CascadingParameter] private MdcDialog Dialog { get; set; }


#nullable enable annotations
        /// <summary>
        /// The button's Material Theme style - see <see cref="MdcButtonStyle"/>
        /// </summary>
        [Parameter] public MdcButtonStyle? ButtonStyle { get; set; }


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
        /// </summary>
        /// <example>
        /// <code>IconFoundry="MdcIconHelper.MIIcon()"</code>
        /// <code>IconFoundry="MdcIconHelper.FAIcon()"</code>
        /// <code>IconFoundry="MdcIconHelper.OIIcon()"</code>
        /// </example>
        [Parameter] public IMdcIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// A string value to return from an <see cref="MdcDialog"/> when this button is pressed.
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
                .AddIf("mdc-button--raised", () => (CascadingDefaults.AppliedStyle(ButtonStyle, Card, Dialog) == MdcButtonStyle.ContainedRaised))
                .AddIf("mdc-button--unelevated", () => (CascadingDefaults.AppliedStyle(ButtonStyle, Card, Dialog) == MdcButtonStyle.ContainedUnelevated))
                .AddIf("mdc-button--outlined", () => (CascadingDefaults.AppliedStyle(ButtonStyle, Card, Dialog) == MdcButtonStyle.Outlined))
                .AddIf("mdc-card__action mdc-card__action--button", () => (Card != null));
        }


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JSRuntime.InvokeAsync<object>("BlazorMdc.button.init", ElementReference);
    }
}
