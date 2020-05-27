using BMdcBase;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BMdc
{
    /// <summary>
    /// This is a general purpose Material Theme icon button toggle, with provision for standard MT styling, leading 
    /// and trailing icons and all standard Blazor events. Adds the "mdc-card__action--icon" class when 
    /// placed inside an <see cref="BMdc.Card"/>.
    /// </summary>
    public partial class IconButtonToggle : BMdcBase.InputComponentBase<bool>
    {
        [CascadingParameter] private Card Card { get; set; }


#nullable enable annotations
        /// <summary>
        /// The on-state icon's name.
        /// </summary>
        [Parameter] public string IconOn { get; set; }


        /// <summary>
        /// The off-state icon's name.
        /// </summary>
        [Parameter] public string IconOff { get; set; }


        /// <summary>
        /// The foundry to use for both leading and trailing icons.
        /// <para><c>IconFoundry="BMdcModel.IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="BMdcModel.IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="BMdcModel.IconHelper.OIIcon()"</c></para>
        /// </summary>
        [Parameter] public BMdcModel.IIconFoundry? IconFoundry { get; set; }
#nullable restore annotations


        private ElementReference ElementReference { get; set; }


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Clear()
                .Add("mdc-icon-button")
                .AddIf("mdc-card__action mdc-card__action--icon", () => (Card != null))
                .AddIf("mdc-icon-button--on", () => Value);
        }            


        /// <summary>
        /// Toggles Value when the button is clicked.
        /// </summary>
        private void ToggleOnClick()
        {
            ReportingValue = !ReportingValue;
        }


        /// <inheritdoc/>
        protected override void OnValueSet() => InvokeAsync(async () => await JsRuntime.InvokeAsync<object>("BlazorMdc.iconButtonToggle.setOn", ElementReference, Value));


        /// <inheritdoc/>
        private protected override async Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.iconButtonToggle.init", ElementReference);
    }
}
