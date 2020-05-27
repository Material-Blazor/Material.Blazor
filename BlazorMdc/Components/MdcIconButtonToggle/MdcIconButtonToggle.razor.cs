using BBase;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BMdc
{
    /// <summary>
    /// This is a general purpose Material Theme icon button toggle, with provision for standard MT styling, leading 
    /// and trailing icons and all standard Blazor events. Adds the "mdc-card__action--icon" class when 
    /// placed inside an <see cref="MdcCard"/>.
    /// </summary>
    public partial class MdcIconButtonToggle : BBase.InputComponentBase<bool>
    {
        [CascadingParameter] private MdcCard Card { get; set; }


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
        /// <para><c>IconFoundry="BModel.IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="BModel.IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="BModel.IconHelper.OIIcon()"</c></para>
        /// </summary>
        [Parameter] public BModel.IIconFoundry? IconFoundry { get; set; }
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
