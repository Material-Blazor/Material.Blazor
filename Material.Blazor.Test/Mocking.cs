using Bunit;
using Material.Blazor;
using Material.Blazor.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Material.Blazor.Test
{
    public class Mocking
    {
        private TestContext ctx;
        private void InjectMockedServices()
        {
            ctx = new();
            _ = ctx.Services
                .AddSingleton(new Mock<IMBLoggingService>().Object)
                .AddSingleton(new Mock<IMBTooltipService>().Object)
                .AddSingleton(new Mock<IMBToastService>().Object)
                .AddSingleton(new Mock<IMBSnackbarService>().Object)
                .AddSingleton(new Mock<ILogger<ComponentFoundation>>().Object)
                .AddSingleton(new Mock<IMBIcon>().Object)
                .AddSingleton(new Mock<IMBIconFoundry>().Object);
        }
        [Fact]
        public void TryRenderMBAnchor()
        {
            InjectMockedServices();
            var cut = ctx.RenderComponent<MBAnchor>();
            cut.MarkupMatches("");
        }

        [Fact]
        public void TryRenderMBAutocompleteTextField()
        {
            InjectMockedServices();
            string[] fruits = { "Avocado", "Banana", "Blackberry" };
            var cut = ctx.RenderComponent<MBAutocompleteTextField>
                ((nameof(MBAutocompleteTextField.AllowBlankResult), false),
                 (nameof(MBAutocompleteTextField.Label), "Hello button"),
                 (nameof(MBAutocompleteTextField.LeadingIcon), "alarm"),
                 (nameof(MBAutocompleteTextField.SelectItems), @fruits),
                 (nameof(MBAutocompleteTextField.TextInputStyle), MBTextInputStyle.Filled)
                 );
            cut.MarkupMatches(@"
<div class=""mb-autocomplete  "">
  <label class=""mdc-text-field   mdc-text-field--filled    mdc-text-field--with-leading-icon  "" >
    <span class=""mdc-text-field__ripple""></span>
    <span class=""mdc-floating-label"" for:ignore id:ignore>Hello button</span>
    <i class=""material-icons  mdc-text-field__icon mdc-text-field__icon--leading"" tabindex=""-1"" role=""button"">alarm</i>
    <input aria-label=""Hello button"" aria-labelledby:ignore id:ignore class=""mdc-text-field__input""  >
    <span class=""mdc-line-ripple""></span>
  </label>
  <div class=""mdc-menu-surface--anchor"">
    <div class=""mdc-menu mdc-menu-surface mdc-menu-surface--fixed""   tabindex=""-1"" >
      <ul class=""mdc-deprecated-list"" tabindex=""-1"">
        <li class=""mdc-deprecated-list-item"" data-value=""Avocado"" role=""option"" tabindex=""0"">
          <span class=""mdc-deprecated-list-item__ripple""></span>
          <span class=""mdc-deprecated-list-item__text mb-full-width"">Avocado</span>
        </li>
        <li class=""mdc-deprecated-list-item"" data-value=""Banana"" role=""option"" tabindex=""0"">
          <span class=""mdc-deprecated-list-item__ripple""></span>
          <span class=""mdc-deprecated-list-item__text mb-full-width"">Banana</span>
        </li>
        <li class=""mdc-deprecated-list-item"" data-value=""Blackberry"" role=""option"" tabindex=""0"">
          <span class=""mdc-deprecated-list-item__ripple""></span>
          <span class=""mdc-deprecated-list-item__text mb-full-width"">Blackberry</span>
        </li>
      </ul>
    </div>
  </div>
</div>"
            );
        }

        [Fact]
        public void TryRenderMBBadge()
        {
            InjectMockedServices();
            var cut = ctx.RenderComponent<MBBadge>();
            cut.MarkupMatches(@"
<span class=""mb-badge"">
  <span class=""mb-badge-value mdc-typography--caption""></span>
            ");
        }

        [Fact]
        public void TryRenderMBBladeSet()
        {
            InjectMockedServices();
            var cut = ctx.RenderComponent<MBBladeSet>();
            cut.MarkupMatches(@"
<mb-bladeset>
  <mb-bladeset-main-content></mb-bladeset-main-content>
</mb-bladeset>
            ");
        }

        [Fact]
        public void TryRenderMBButton()
        {
            InjectMockedServices();
            var cut = ctx.RenderComponent<MBButton>
                ((nameof(MBButton.Label), "Hello button"),
                 (nameof(MBButton.ButtonStyle), MBButtonStyle.ContainedRaised));
            cut.MarkupMatches(@"
<div class=""mdc-touch-target-wrapper"">
    <button class=""mdc-button mdc-button--raised  mdc-button--touch"">
        <span class=""mdc-button__ripple""></span>
        <span class=""mdc-button__touch""></span>
        <span class=""mdc-button__label"">Hello button</span>
    </button>
</div>"
            );
        }

        [Fact]
        public void TryRenderMBCard()
        {
            InjectMockedServices();
            var cut = ctx.RenderComponent<MBCard>();
            cut.MarkupMatches("<div class=\"mdc-card\"></div>");
        }

        [Fact]
        public void TryRenderMBCheckbox()
        {
            InjectMockedServices();
            var isChecked = true;
            var cut = ctx.RenderComponent<MBCheckbox>(
                (nameof(MBCheckbox.Label), "Checkbox"),
                (nameof(MBCheckbox.Value), @isChecked));
            cut.MarkupMatches(@"
<div class=""mdc-form-field "" >
  <div class=""mdc-touch-target-wrapper"">
    <div class=""mdc-checkbox mdc-checkbox--touch mdc-checkbox--selected "" >
      <input type = ""checkbox"" class=""mdc-checkbox__native-control"" id:ignore checked="""" >
      <div class=""mdc-checkbox__background"">
        <svg class=""mdc-checkbox__checkmark"" viewBox=""0 0 24 24"">
          <path class=""mdc-checkbox__checkmark-path"" fill=""none"" d=""M1.73,12.91 8.1,19.28 22.79,4.59""></path>
        </svg>
        <div class=""mdc-checkbox__mixedmark""></div>
      </div>
      <div class=""mdc-checkbox__ripple""></div>
    </div>
  </div>
  <label for:ignore>Checkbox</label>
</div>");
        }

        //        [Fact]
        //        public void TryRenderMBChipsSelectMulti()
        //        {
        //            InjectMockedServices();
        //            MBIconBearingSelectElement<string>[] KittenBreeds = new MBIconBearingSelectElement<string>[]
        //            {
        //                new MBIconBearingSelectElement<string> { SelectedValue = "brit-short", Label = "British Shorthair" },
        //                new MBIconBearingSelectElement<string> { SelectedValue = "russ-blue", Label = "Russian Blue", Icon="admin_panel_settings" },
        //                new MBIconBearingSelectElement<string> { SelectedValue = "ice-invis", Label = "Icelandic Invisible", Icon="card_membership" }
        //            };

        //            bool[] CheckboxValues;

        //            IList<string> sbvalues = new string[] { "brit-short", "ice-invis" };
        //            IList<string> SBValues
        //            {
        //                get
        //                {
        //                    return sbvalues;
        //                }
        //                set
        //                {
        //                    sbvalues = value;
        //                    CheckboxValues = KittenBreeds.Select(x => sbvalues.Contains(x.SelectedValue)).ToArray();
        //                }
        //            }

        //            var cut = ctx.RenderComponent<MBChipsSelectMulti<string>>(
        //                (nameof(MBChipsSelectMulti<string>.Items), @KittenBreeds),
        //                ("bind-Values", @SBValues));
        //            cut.MarkupMatches(@"
        //<div class=""mdc-dialog"">
        //    <div class=""mdc-dialog__container""></div>
        //    <div class=""mdc-dialog__scrim""></div>
        //</div>
        //            ");
        //        }

        //[Fact]
        //public void TryRenderMBChipsSelectSingle()
        //{
        //    InjectMockedServices();
        //    MBIconBearingSelectElement<string>[] KittenBreeds = new MBIconBearingSelectElement<string>[]
        //    {
        //                new MBIconBearingSelectElement<string> { SelectedValue = "brit-short", Label = "British Shorthair" },
        //                new MBIconBearingSelectElement<string> { SelectedValue = "russ-blue", Label = "Russian Blue", Icon="admin_panel_settings" },
        //                new MBIconBearingSelectElement<string> { SelectedValue = "ice-invis", Label = "Icelandic Invisible", Icon="card_membership" }
        //    };

        //    string selectedKitten = "russ-blue";

        //    var cut = ctx.RenderComponent<MBChipsSelectSingle<string>>(
        //        (nameof(MBChipsSelectSingle<string>.Items), @KittenBreeds));
        //    cut.MarkupMatches(@"
        //<div class=""mdc-dialog"">
        //    <div class=""mdc-dialog__container""></div>
        //    <div class=""mdc-dialog__scrim""></div>
        //</div>
        //            ");
        //}

        [Fact]
        public void TryRenderMBCircularProgress()
        {
            InjectMockedServices();
            var cut = ctx.RenderComponent<MBCircularProgress>();
            cut.MarkupMatches(@"
<div class=""mdc-circular-progress mdc-circular-progress--indeterminate"" style="" height: 48px; width: 48px; "" role=""progressbar"" aria-label="""" aria-valuemin=""0"" aria-valuemax=""1"" aria-valuenow=""0"" >
          <div class=""mdc-circular-progress__determinate-container"">
    <svg class=""mdc-circular-progress__determinate-circle-graphic"" viewBox=""0 0 48 48"" xmlns=""http://www.w3.org/2000/svg"">
      <circle class=""mdc-circular-progress__determinate-track"" cx=""24"" cy=""24"" r=""18"" stroke-width=""4""></circle>
      <circle class=""mdc-circular-progress__determinate-circle"" cx=""24"" cy=""24"" r=""18"" stroke-dasharray=""113.097"" stroke-dashoffset=""113.097"" stroke-width=""4""></circle>
    </svg>
  </div>
  <div class=""mdc-circular-progress__indeterminate-container"">
    <div class=""mdc-circular-progress__spinner-layer"">
      <div class=""mdc-circular-progress__circle-clipper mdc-circular-progress__circle-left"">
        <svg class=""mdc-circular-progress__indeterminate-circle-graphic"" viewBox=""0 0 48 48"" xmlns=""http://www.w3.org/2000/svg"">
          <circle cx = ""24"" cy=""24"" r=""18"" stroke-dasharray=""113.097"" stroke-dashoffset=""56.549"" stroke-width=""4""></circle>
        </svg>
      </div>
      <div class=""mdc-circular-progress__gap-patch"">
        <svg class=""mdc-circular-progress__indeterminate-circle-graphic"" viewBox=""0 0 48 48"" xmlns=""http://www.w3.org/2000/svg"">
          <circle cx = ""24"" cy=""24"" r=""18"" stroke-dasharray=""113.097"" stroke-dashoffset=""56.549"" stroke-width=""4""></circle>
        </svg>
      </div>
      <div class=""mdc-circular-progress__circle-clipper mdc-circular-progress__circle-right"">
        <svg class=""mdc-circular-progress__indeterminate-circle-graphic"" viewBox=""0 0 48 48"" xmlns=""http://www.w3.org/2000/svg"">
          <circle cx = ""24"" cy=""24"" r=""18"" stroke-dasharray=""113.097"" stroke-dashoffset=""56.549"" stroke-width=""4""></circle>
        </svg>
      </div>
    </div>
  </div>
</div>
            ");
        }

        [Fact]
        public void TryRenderMBConfirmationDialog()
        {
            InjectMockedServices();
            var cut = ctx.RenderComponent<MBConfirmationDialog>();
            cut.MarkupMatches(@"
<div class=""mdc-dialog"">
    <div class=""mdc-dialog__container""></div>
    <div class=""mdc-dialog__scrim""></div>
</div>
            ");
        }

        [Fact]
        public void TryRenderMBDialog()
        {
            InjectMockedServices();
            var cut = ctx.RenderComponent<MBDialog>();
            cut.MarkupMatches(@"
<div class=""mdc-dialog"">
    <div class=""mdc-dialog__container""></div>
    <div class=""mdc-dialog__scrim""></div>
</div>
            ");
        }

        [Fact]
        public void TryRenderMBIcon()
        {
            InjectMockedServices();
            var cut = ctx.RenderComponent<MBIcon>((nameof(MBIcon.IconName), "alarm"));
            cut.MarkupMatches("<i class=\"material-icons\">alarm</i>");
        }

    }
}
