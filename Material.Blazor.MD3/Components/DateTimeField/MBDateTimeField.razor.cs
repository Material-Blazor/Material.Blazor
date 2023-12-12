using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.CompilerServices;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using RuntimeHelpers = Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers;

namespace Material.Blazor;

/// <summary>
/// A Material Theme date input field. This wraps <see cref="MBTextField"/> and normally
/// displays the numeric value as formatted text, but switches to a pure number on being selected.
/// </summary>

/*
    <MBTextField >>>class="@(@class)"
                 >>>style="@style"
                 >>>id="@id"
                 >>>@attributes="@AttributesToSplat()"
                 >>>@bind-Value="@FormattedValue"
                 >>>Density="@Density"
                 >>>Disabled="@AppliedDisabled"
                 >>>HelperText="@HelperText"
                 >>>HelperTextPersistent="@HelperTextPersistent"
                 ---IconFoundry="@IconFoundry"
                 >>>Label="@Label"
                 >>>LeadingIcon="@LeadingIcon"
                 >>>min="@MinDateString"
                 >>>max="@MaxDateString"
                 >>>@onfocusout="@OnFocusOutAsync"
                 >>>Prefix="@Prefix"
                 @ref="@TextField"
                 >>>Suffix="@Suffix"
                 >>>TextInputStyle="@TextInputStyle"
                 >>>TrailingIcon="@TrailingIcon"
                 >>>type="@ItemType"
                 ValidationMessageFor="@ValidationMessageFor" />
 */
public partial class MBDateTimeField : InputComponent<DateTime>
{
    #region members

#nullable enable annotations

    /// <summary>
    /// The datetime can optionally suppress the time portion and just
    /// return dates (at midnight)
    /// </summary>
    [Parameter] public bool DateOnly { get; set; } = false;


    /// <summary>
    /// The numeric field's density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }


    /// <summary>
    /// Helper text that is displayed either with focus or persistently with <see cref="HelperTextPersistent"/>.
    /// </summary>
    [Parameter] public string HelperText { get; set; } = "";


    /// <summary>
    /// Makes the <see cref="HelperText"/> persistent if true.
    /// </summary>
    [Parameter] public bool HelperTextPersistent { get; set; }


    /// <summary>
    /// Field label.
    /// </summary>
    [Parameter] public string? Label { get; set; }


    /// <summary>
    /// The leading icon name. No leading icon shown if not set.
    /// </summary>
    [Parameter] public string LeadingIconName { get; set; }


    /// <summary>
    /// The maximum allowable value.
    /// </summary>
    [Parameter] public DateTime MaxDate { get; set; } = MaxAllowableDate;


    /// <summary>
    /// The minimum allowable value.
    /// </summary>
    [Parameter] public DateTime MinDate { get; set; } = MinAllowableDate;


    /// <summary>
    /// Prefix text.
    /// </summary>
    [Parameter] public string? Prefix { get; set; }


    /// <summary>
    /// Suffix text.
    /// </summary>
    [Parameter] public string? Suffix { get; set; }


    /// <summary>
    /// Set to indicate that if the value is default(DateTime) then no date is initially shown
    /// </summary>
    [Parameter] public bool SuppressDefaultDate { get; set; } = true;


    /// <summary>
    /// The text input style.
    /// <para>Overrides <see cref="MBCascadingDefaults.TextInputStyle"/></para>
    /// </summary>
    [Parameter] public MBTextInputStyle? TextInputStyle { get; set; }


    /// <summary>
    /// The trailing iconname. No trailing icon shown if not set.
    /// </summary>
    [Parameter] public string TrailingIconName { get; set; }


    /// <summary>
    /// Delivers Material Theme validation methods from native Blazor validation. Either use this or
    /// the Blazor <code>ValidationMessage</code> component, but not both. This parameter takes the same input as
    /// <code>ValidationMessage</code>'s <code>For</code> parameter.
    /// </summary>
    [Parameter] public Expression<Func<object>> ValidationMessageFor { get; set; }

#nullable restore annotations



    internal static string ErrorText { get; set; }
    private string FormattedValue { get; set; }
    internal string ItemType { get; set; }
    internal static DateTime MaxAllowableDate { get; set; } = DateTime.MaxValue;
    private string MaxDateAsString { get; set; }
    internal static DateTime MinAllowableDate { get; set; } = DateTime.MinValue;
    private string MinDateAsString { get; set; }
    private MBTextField TextField { get; set; }


    #endregion

    #region BuildRenderTreeAsync

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        var attributesToSplat = AttributesToSplat().ToArray();
        attributesToSplat.Append(new KeyValuePair<string, object>("max", MaxDateAsString));
        attributesToSplat.Append(new KeyValuePair<string, object>("min", MinDateAsString));
        attributesToSplat.Append(new KeyValuePair<string, object>("type", ItemType));
        attributesToSplat.Append(new KeyValuePair<string, object>("onfocusout", OnFocusOut));

        var rendSeq = 0;

        MBIconDescriptor leadingIcon = null;
        if (!string.IsNullOrWhiteSpace(LeadingIconName))
        {
            leadingIcon = MBIcon.IconDescriptorConstructor(name: LeadingIconName);
        }

        MBIconDescriptor trailingIcon = null;
        if (!string.IsNullOrWhiteSpace(TrailingIconName))
        {
            trailingIcon = MBIcon.IconDescriptorConstructor(name: TrailingIconName);
        }

        EventCallback<FocusEventArgs> focusOut =
            EventCallback.Factory.Create(this, (FocusEventArgs fea) => OnFocusOut(fea));

        EventCallback<ChangeEventArgs> valueChanged =
            EventCallback.Factory.Create(this, (ChangeEventArgs cea) => FormattedValueChanged(cea));

        RenderFragment renderFragment() => builder2 =>
        {
            InternalTextFieldBase.BuildRenderTreeWorker(
                builder2,
                ref rendSeq,
                CascadingDefaults,
                TextInputStyle,
                null,
                attributesToSplat,
                Density,
                @class,
                style,
                id,
                AppliedDisabled,
                FormattedValue,
                valueChanged,
                () => FormattedValue,
                focusOut,
                Label,
                Prefix,
                Suffix,
                HelperText,
                leadingIcon,
                null,
                null,
                null,
                false,
                trailingIcon,
                null,
                null,
                null,
                false
                );
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

    private void FormattedValueChanged(ChangeEventArgs newValue)
    {
        FormattedValue = (string)(newValue.Value);
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

    #region OnFocusOutAsync

    private void OnFocusOut(FocusEventArgs fea)
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
