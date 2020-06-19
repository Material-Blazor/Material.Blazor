using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;

namespace BlazorMdc
{
    /// <summary>
    /// This is a general purpose Material Theme list item.
    /// </summary>
    public partial class MTListItem : MTComponentBase
    {
#nullable enable annotations
        /// <summary>
        /// The list item's text
        /// </summary>
        [Parameter] public string Text { get; set; }


        /// <summary>
        /// The navigation reference string to be returned by <see cref="OnClick"/>
        /// </summary>
        [Parameter] public string NavigationReference { get; set; } = "";


        /// <summary>
        /// The leading icon's name. No leading icon shown if not set.
        /// </summary>
        [Parameter] public string? LeadingIcon { get; set; }


        /// <summary>
        /// The foundry to use for both leading and trailing icons.
        /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
        /// </summary>
        [Parameter] public IMTIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// Callback returnng the <see cref="NavigationReference"/> when the
        /// list item receives an @onclick event.
        /// </summary>
        [Parameter] public EventCallback<string> OnClick { get; set; }
#nullable restore annotations


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-list-item")
                .AddIf("mdc-list-item--disabled bmdc-list-item--disabled", () => Disabled);
        }


        private void InternalClickHandler()
        {
            if (!Disabled)
            {
                OnClick.InvokeAsync(NavigationReference);
            }
        }
    }
}
