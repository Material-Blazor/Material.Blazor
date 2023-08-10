using Bunit;
using Material.Blazor;
using Material.Blazor.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moq;
using System.Globalization;
using Xunit;

namespace Material.Blazor.Test;

public class Mocking
{
    private TestContext ctx;
    private void InjectMockedServices()
    {
        var cultureInfo = new CultureInfo("en-US");

        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

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
    <button class=""mdc-button mdc-button--raised  mdc-button--touch"" type=""button"">
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
    public void TryRenderMBDataTable()
    {
        InjectMockedServices();
        var cut = ctx.RenderComponent<MBDataTable<string>>();
        cut.MarkupMatches(@"
<div class=""mdc-data-table"" >
  <div class=""mdc-data-table__table-container"">
    <table class=""mdc-data-table__table"">
      <tbody class=""mdc-data-table__content""></tbody>
    </table>
  </div>
</div>
        ");
    }

    [Fact]
    public void TryRenderMBDatePicker()
    {
        InjectMockedServices();
        var cut = ctx.RenderComponent<MBDatePicker>();
        cut.MarkupMatches(@"
<div class=""mdc-select   mdc-select--outlined mdc-select--no-label  "" >
  <div class=""mdc-select__anchor"" role=""button"" aria-haspopup:ignore aria-expanded=""false"" aria-labelledby:ignore>
    <span class=""mdc-notched-outline"">
      <span class=""mdc-notched-outline__leading""></span>
      <span class=""mdc-notched-outline__trailing""></span>
    </span>
    <span class=""mdc-select__selected-text-container"">
      <span id:ignore class=""mdc-select__selected-text"" style=""""></span>
    </span>
    <span class=""mdc-select__dropdown-icon"">
      <svg class=""mdc-select__dropdown-icon-graphic"" viewBox=""7 10 10 5"" focusable=""false"">
        <polygon class=""mdc-select__dropdown-icon-inactive"" stroke=""none"" fill-rule=""evenodd"" points=""7 10 12 15 17 10""></polygon>
        <polygon class=""mdc-select__dropdown-icon-active"" stroke=""none"" fill-rule=""evenodd"" points=""7 15 12 10 17 15""></polygon>
      </svg>
    </span>
  </div>
  <div id:ignore class=""mdc-select__menu mdc-menu mdc-menu-surface mb-dp-menu__surface-adjust  mb-dp-menu__day-menu"" >
    <div class=""mdc-typography--body2 mb-dp-container"">
      <ul class=""mdc-deprecated-list mb-dp-list"">
        <li class=""mdc-deprecated-list-item mdc-deprecated-list-item--selected mb-dp-list-item"" data-value=""Monday, January 1, 0001"" aria-selected=""true"" role=""option"">
          <span class=""mdc-deprecated-list-item__ripple""></span>
          <span class=""mdc-deprecated-list-item__text mb-dp-list-item__text"" >Monday, January 1, 0001</span>
        </li>
      </ul>
      <div class=""mb-dp-blank-filler""></div>
    </div>
  </div>
</div>
        ");
    }

    [Fact]
    public void TryRenderMBDebouncedTextField()
    {
        InjectMockedServices();
        var cut = ctx.RenderComponent<MBDebouncedTextField>();
        cut.MarkupMatches(@"
<label class=""mdc-text-field    mdc-text-field--outlined mdc-text-field--no-label     "" >
  <span class=""mdc-notched-outline"">
    <span class=""mdc-notched-outline__leading""></span>
    <span class=""mdc-notched-outline__trailing""></span>
  </span>
  <input  id:ignore class=""mdc-text-field__input  ""  >
</label>
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
    public void TryRenderMBDrawer()
    {
        InjectMockedServices();
        var cut = ctx.RenderComponent<MBDrawer>();
        cut.MarkupMatches(@"
<aside class=""mdc-drawer mdc-drawer--dismissible"" >
  <div class=""mdc-drawer__content""></div>
</aside>
            ");
    }

    [Fact]
    public void TryRenderMBFloatingActionButton()
    {
        InjectMockedServices();
        var cut = ctx.RenderComponent<MBFloatingActionButton>();
        cut.MarkupMatches(@"
<button class=""mdc-fab"" >
  <div class=""mdc-fab__ripple""></div>
</button>
            ");
    }

    [Fact]
    public void TryRenderMBIcon()
    {
        InjectMockedServices();
        var cut = ctx.RenderComponent<MBIcon>((nameof(MBIcon.IconName), "alarm"));
        cut.MarkupMatches(@"
<i class=""material-icons"">alarm</i>
            ");
    }

    [Fact]
    public void TryRenderMBIconButton()
    {
        InjectMockedServices();
        var cut = ctx.RenderComponent<MBIconButton>((nameof(MBIcon.IconName), "alarm"));
        cut.MarkupMatches(@"
<div class=""mdc-touch-target-wrapper"">
  <button class=""mdc-icon-button  mdc-button--touch  "" iconname=""alarm"" type=""button"">
    <div class=""mdc-icon-button__ripple""></div>
  </button>
</div>
            ");
    }

    [Fact]
    public void TryRenderMBIconButtonToggle()
    {
        InjectMockedServices();
        var cut = ctx.RenderComponent<MBIconButtonToggle>(
            (nameof(MBIconButtonToggle.IconOn), "alarm"),
            (nameof(MBIconButtonToggle.IconOff), "touch_app"));
        cut.MarkupMatches(@"
<div class=""mdc-touch-target-wrapper"">
  <button class=""mdc-icon-button    mdc-button--touch "" type=""button"">
    <div class=""mdc-icon-button__ripple""></div>
    <i class=""material-icons  mdc-icon-button__icon mdc-icon-button__icon--on mb-dp-menu__icon-button"">alarm</i>
    <i class=""material-icons  mdc-icon-button__icon mb-dp-menu__icon-button"">touch_app</i>
  </button>
</div>
            ");
    }

    [Fact]
    public void TryRenderMBLinearProgress()
    {
        InjectMockedServices();
        var cut = ctx.RenderComponent<MBLinearProgress>();
        cut.MarkupMatches(@"
<div class=""mdc-linear-progress mdc-linear-progress--indeterminate   "" role=""progressbar"" aria-label="""" aria-valuemin=""0"" aria-valuemax=""1"" aria-valuenow=""0"" >
  <div class=""mdc-linear-progress__buffer"">
    <div class=""mdc-linear-progress__buffer-bar""></div>
    <div class=""mdc-linear-progress__buffer-dots""></div>
  </div>
  <div class=""mdc-linear-progress__bar mdc-linear-progress__primary-bar"">
    <span class=""mdc-linear-progress__bar-inner""></span>
  </div>
  <div class=""mdc-linear-progress__bar mdc-linear-progress__secondary-bar"">
    <span class=""mdc-linear-progress__bar-inner""></span>
  </div>
</div>
            ");
    }

    [Fact]
    public void TryRenderMBNumericDecimalField()
    {
        InjectMockedServices();
        var cut = ctx.RenderComponent<MBNumericDecimalField>();
        cut.MarkupMatches(@"
<label class=""mdc-text-field    mdc-text-field--outlined mdc-text-field--no-label     "" >
  <span class=""mdc-notched-outline"">
    <span class=""mdc-notched-outline__leading""></span>
    <span class=""mdc-notched-outline__trailing""></span>
  </span>
  <input   step=""0.01"" id:ignore class=""mdc-text-field__input  mb-align-right "" value=""0""  >
</label>
            ");
    }

    [Fact]
    public void TryRenderMBRadioButton()
    {
        InjectMockedServices();
        var cut = ctx.RenderComponent<MBRadioButton<bool>>((nameof(MBRadioButton<bool>.RadioGroupName),"group"));
        cut.MarkupMatches(@"
<div class=""mdc-touch-target-wrapper"">
  <div class=""mdc-form-field"" >
    <div class=""mdc-radio mdc-radio--touch   "" >
      <input class=""mdc-radio__native-control"" checked="""" id:ignore name=""group"" type=""radio"" >
      <div class=""mdc-radio__background"">
        <div class=""mdc-radio__outer-circle""></div>
        <div class=""mdc-radio__inner-circle""></div>
      </div>
      <div class=""mdc-radio__ripple""></div>
    </div>
    <label for:ignore></label>
  </div>
</div>
            ");
    }

    [Fact]
    public void TryRenderMBSelect()
    {
        InjectMockedServices(); 
        MBSelectElement<string>[] KittenBreeds = new MBSelectElement<string>[]
        {
            new MBSelectElement<string> { SelectedValue = "brit-short", Label = "British Shorthair" },
            new MBSelectElement<string> { SelectedValue = "russ-blue", Label = "Russian Blue" },
            new MBSelectElement<string> { SelectedValue = "ice-invis", Label = "Icelandic Invisible" }
        };

        var cut = ctx.RenderComponent<MBSelect<string>>(
            (nameof(MBSelect<string>.Items),@KittenBreeds),
            (nameof(MBSelect<string>.ItemValidation), MBItemValidation.NoSelection));
        cut.MarkupMatches(@"
<div class=""mdc-select   mdc-select--outlined mdc-select--no-label   "" >
  <div class=""mdc-select__anchor"" role=""button"" aria-haspopup:ignore aria-expanded=""false"" aria-labelledby:ignore>
    <span class=""mdc-notched-outline"">
      <span class=""mdc-notched-outline__leading""></span>
      <span class=""mdc-notched-outline__trailing""></span>
    </span>
    <span class=""mdc-select__selected-text-container"">
      <span id:ignore class=""mdc-select__selected-text""></span>
    </span>
    <span class=""mdc-select__dropdown-icon"">
      <svg class=""mdc-select__dropdown-icon-graphic"" viewBox=""7 10 10 5"" focusable=""false"">
        <polygon class=""mdc-select__dropdown-icon-inactive"" stroke=""none"" fill-rule=""evenodd"" points=""7 10 12 15 17 10""></polygon>
        <polygon class=""mdc-select__dropdown-icon-active"" stroke=""none"" fill-rule=""evenodd"" points=""7 15 12 10 17 15""></polygon>
      </svg>
    </span>
  </div>
  <div id:ignore class=""mdc-select__menu mdc-menu mdc-menu-surface "">
    <ul class=""mdc-deprecated-list"">
      <li class=""mdc-deprecated-list-item "" data-value=""British Shorthair"" role=""option"">
        <span class=""mdc-deprecated-list-item__ripple""></span>
        <span class=""mdc-deprecated-list-item__text mb-full-width"">British Shorthair</span>
      </li>
      <li class=""mdc-deprecated-list-item "" data-value=""Russian Blue"" role=""option"">
        <span class=""mdc-deprecated-list-item__ripple""></span>
        <span class=""mdc-deprecated-list-item__text mb-full-width"">Russian Blue</span>
      </li>
      <li class=""mdc-deprecated-list-item "" data-value=""Icelandic Invisible"" role=""option"">
        <span class=""mdc-deprecated-list-item__ripple""></span>
        <span class=""mdc-deprecated-list-item__text mb-full-width"">Icelandic Invisible</span>
      </li>
    </ul>
  </div>
</div>
            ");
    }

    [Fact]
    public void TryRenderMBShield()
    {
        InjectMockedServices();
        var cut = ctx.RenderComponent<MBShield>(
            (nameof(MBShield.Label),"label"),
            (nameof(MBShield.Tooltip), "tooltip"),
            (nameof(MBShield.Value), "value"),
            (nameof(MBShield.ValueIcon), "edit"));
        cut.MarkupMatches(@"
<span class=""mb-shield"" aria-describedby=""mb-tooltip-1"">
  <span class=""mb-shield--label "" style="""">
    <span>label</span>
  </span>
  <span class=""mb-shield--value "" style="""">
    <span>
      <i class=""material-icons  "">edit</i>
    </span>
    <span>value</span>
  </span>
</span>
            ");
    }

    [Fact]
    public void TryRenderMBSlider()
    {
        InjectMockedServices();
        var cut = ctx.RenderComponent<MBSlider>();
        cut.MarkupMatches(@"
<div class=""mdc-slider"" >
  <input class=""mdc-slider__input"" type=""range"" value=""0"" step=""1"" min=""0"" max=""100"" name=""volume"" aria-label=""Slider"">
  <div class=""mdc-slider__track"">
    <div class=""mdc-slider__track--inactive""></div>
    <div class=""mdc-slider__track--active"">
      <div class=""mdc-slider__track--active_fill"" style=""transform: scaleX(0)""></div>
    </div>
  </div>
  <div class=""mdc-slider__thumb"" style=""left: calc(0% - 24px)"">
    <div class=""mdc-slider__thumb-knob""></div>
  </div>
</div>
            ");
    }

}
