using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// A Material Theme date input field. This wraps <see cref="MBTextField"/> and normally
/// displays the numeric value as formatted text, but switches to a pure number on being selected.
/// </summary>

public sealed partial class MBDateTimeField : InputComponent<DateTime>
{
    #region members

#nullable enable annotations

    #region non-cascading parameters (MBTextField)

    /// <summary>
    /// The text field's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }

    /// <summary>
    /// Field label.
    /// </summary>
    [Parameter] public string? Label { get; set; }

    /// <summary>
    /// The leading icon's descriptor. No leading icon is shown if not set.
    /// </summary>
    [Parameter] public MBIconDescriptor? LeadingIcon { get; set; }

    /// <summary>
    /// Adding a toggleicon turns the leading icon into a toggleiconbutton.
    /// </summary>
    [Parameter] public MBIconDescriptor? LeadingToggleIcon { get; set; }

    /// <summary>
    /// The link for the iconbutton
    /// </summary>
    [Parameter] public string LeadingToggleIconButtonLink { get; set; }

    /// <summary>
    /// The link target for the iconbutton
    /// </summary>
    [Parameter] public string LeadingToggleIconButtonLinkTarget { get; set; }

    /// <summary>
    /// The toggle state of the icon button
    /// </summary>
    [Parameter] public bool LeadingToggleIconSelected { get; set; }

    /// <summary>
    /// Prefix text.
    /// </summary>
    [Parameter] public string? Prefix { get; set; }

    /// <summary>
    /// Suffix text.
    /// </summary>
    [Parameter] public string? Suffix { get; set; }

    /// <summary>
    /// Supporting text that is displayed either with focus or persistently with <see cref="SupportingTextPersistent"/>.
    /// </summary>
    [Parameter] public string SupportingText { get; set; } = "";

    /// <summary>
    /// Makes the <see cref="SupportingText"/> persistent if true.
    /// </summary>
    [Parameter] public bool SupportingTextPersistent { get; set; } = false;

    /// <summary>
    /// The text alignment style.
    /// <para>Overrides <see cref="MBCascadingDefaults.TextAlignStyle"/></para>
    /// </summary>
    [Parameter] public MBTextAlignStyle? TextAlignStyle { get; set; }

    /// <summary>
    /// The unique id for the text field; Used to locate the text field
    /// from JS interop methods.
    /// 
    /// In normal use there is no need to set this parameter in the calling component
    /// </summary>
    [Parameter] public string TextFieldId { get; set; } = "textfield-id-" + Guid.NewGuid().ToString().ToLower();

    /// <summary>
    /// The text input style.
    /// <para>Overrides <see cref="MBCascadingDefaults.TextInputStyle"/></para>
    /// </summary>
    [Parameter] public MBTextInputStyle TextInputStyle { get; set; } = MBTextInputStyle.Outlined;

    /// <summary>
    /// The trailing icon's descriptor. No trailing icon is shown if not set.
    /// </summary>
    [Parameter] public MBIconDescriptor? TrailingIcon { get; set; }

    /// <summary>
    /// Adding a toggleicon turns the trailing icon into a toggleiconbutton.
    /// </summary>
    [Parameter] public MBIconDescriptor? TrailingToggleIcon { get; set; }

    /// <summary>
    /// The link for the iconbutton
    /// </summary>
    [Parameter] public string TrailingToggleIconButtonLink { get; set; }

    /// <summary>
    /// The link target for the iconbutton
    /// </summary>
    [Parameter] public string TrailingToggleIconButtonLinkTarget { get; set; }

    /// <summary>
    /// The toggle state of the icon button
    /// </summary>
    [Parameter] public bool TrailingToggleIconSelected { get; set; }

    /// <summary>
    /// Delivers Material Theme validation methods from native Blazor validation. Either use this or
    /// the Blazor <code>ValidationMessage</code> component, but not both. This parameter takes the same input as
    /// <code>ValidationMessage</code>'s <code>For</code> parameter.
    /// </summary>
    [Parameter] public Expression<Func<object>> ValidationMessageFor { get; set; }

    #endregion (MBText

    #region non-cascading parameters (MBDateTimeField)

    /// <summary>
    /// The datetime can optionally suppress the time portion and just
    /// return dates (at midnight)
    /// </summary>
    [Parameter] public bool DateOnly { get; set; } = false;

    /// <summary>
    /// The maximum allowable value.
    /// </summary>
    [Parameter] public DateTime MaxDate { get; set; } = MaxAllowableDate;

    /// <summary>
    /// The minimum allowable value.
    /// </summary>
    [Parameter] public DateTime MinDate { get; set; } = MinAllowableDate;

    /// <summary>
    /// Set to indicate that if the value is default(DateTime) then no date is initially shown
    /// </summary>
    [Parameter] public bool SuppressDefaultDate { get; set; } = true;

    #endregion

#nullable restore annotations

    #region local members

    internal static string ErrorText { get; set; }
    private string FormattedValue { get; set; }
    internal string ItemType { get; set; }
    internal static DateTime MaxAllowableDate { get; set; } = DateTime.MaxValue;
    private string MaxDateAsString { get; set; }
    internal static DateTime MinAllowableDate { get; set; } = DateTime.MinValue;
    private string MinDateAsString { get; set; }
 
    #endregion

    #endregion

    #region BuildRenderTree

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToDictionary();
        attributesToSplat.Add("max", MaxDateAsString);
        attributesToSplat.Add("min", MinDateAsString);
        attributesToSplat.Add("type", ItemType);

        var rendSeq = 0;

        EventCallback focusOut =
            EventCallback.Factory.Create(this, () => OnFocusOut());

        EventCallback<string> valueChanged =
            EventCallback.Factory.Create(this, (string newValue) => FormattedValueChanged(newValue));

        RenderFragment renderFragment() => builder2 =>
        {
            InternalTextFieldRenderer.BuildTextFieldRenderTree(
                builder2,
                ref rendSeq,
                CascadingDefaults,
                @class,
                @style,
                AppliedDisabled,
                Density,
                attributesToSplat,
                FormattedValue,
                valueChanged,
                () => FormattedValue,
                null,
                focusOut,
                Label,
                Prefix,
                Suffix,
                SupportingText,
                TextAlignStyle,
                TextFieldId,
                TextInputStyle,
                ItemType,
                LeadingIcon,
                LeadingToggleIcon,
                LeadingToggleIconButtonLink,
                LeadingToggleIconButtonLinkTarget,
                LeadingToggleIconSelected,
                TrailingIcon,
                TrailingToggleIcon,
                TrailingToggleIconButtonLink,
                TrailingToggleIconButtonLinkTarget,
                TrailingToggleIconSelected,
                ValidationMessageFor);
        };

        // We now create a cascading value out of the the content in builder2

        builder.OpenComponent<CascadingValue<MBDateTimeField>>(0);
        {
            builder.AddComponentParameter(1, "Value", this);
            builder.AddComponentParameter(2, "ChildContent", renderFragment());
        }
        builder.CloseComponent();
    }

    #endregion

    #region FormattedValueChanged

    private void FormattedValueChanged(string newValue)
    {
        FormattedValue = newValue;
    }

    #endregion

    #region OnInitializedAsync

    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        //  Note the use of multiple parameters that presume invariance during the
        //  life of this component.
        //      DateOnly
        //      MaxDate
        //      MinDate
        //      SuppressDefaultDate

        await base.OnInitializedAsync();

        if (DateOnly)
        {
            ErrorText = "Invalid date, hover for more information";
            ItemType = "date";
            MaxDateAsString = MaxDate.ToString("yyyy-MM-dd");
            MinDateAsString = MinDate.ToString("yyyy-MM-dd");
        }
        else
        {
            ErrorText = "Invalid datetime, hover for more information";
            ItemType = "datetime-local";
            MaxDateAsString = MaxDate.ToString("yyyy-MM-ddTHH:mm");
            MinDateAsString = MinDate.ToString("yyyy-MM-ddTHH:mm");
        }
    }

    #endregion

    #region OnParametersSetAsync

    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        try
        {
            if ((ComponentValue == default) & SuppressDefaultDate)
            {
                FormattedValue = "";
            }
            else
            {
                // This is the required format for the string

                if (DateOnly)
                {
                    FormattedValue = ComponentValue.ToString("yyyy-MM-dd");
                }
                else
                {
                    FormattedValue = ComponentValue.ToString("yyyy-MM-ddTHH:mm");
                }
            }
        }
        catch { }
    }

    #endregion

    #region OnFocusOut

    private void OnFocusOut()
    {
        try
        {
            var potentialComponentValue = Convert.ToDateTime(FormattedValue);
            if (potentialComponentValue >= MinDate && potentialComponentValue <= MaxDate)
            {
                ComponentValue = potentialComponentValue;
            }
        }
        catch { }
    }

    #endregion
}
