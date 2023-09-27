using Material.Blazor.MD2.Internal;
using Microsoft.AspNetCore.Components;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Material.Blazor.MD2;

/// <summary>
/// A Material Theme date input field. This wraps <see cref="MBTextField"/> and normally
/// displays the numeric value as formatted text, but switches to a pure number on being selected.
/// </summary>
public partial class MBDateTimeField : InputComponentMD2<DateTime>
{
#nullable enable annotations

    /// <summary>
    /// The datetime can optionally supress the time portion and just
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
    /// The foundry to use for both leading and trailing icons.
    /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
    /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
    /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
    /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
    /// </summary>
    [Parameter] public IMBIconFoundry? IconFoundry { get; set; }


    /// <summary>
    /// Field label.
    /// </summary>
    [Parameter] public string? Label { get; set; }


    /// <summary>
    /// The leading icon's name. No leading icon shown if not set.
    /// </summary>
    [Parameter] public string? LeadingIcon { get; set; }


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
    /// The trailing icon's name. No leading icon shown if not set.
    /// </summary>
    [Parameter] public string? TrailingIcon { get; set; }


    /// <summary>
    /// Delivers Material Theme validation methods from native Blazor validation. Either use this or
    /// the Blazor <code>ValidationMessage</code> component, but not both. This parameter takes the same input as
    /// <code>ValidationMessage</code>'s <code>For</code> parameter.
    /// </summary>
    [Parameter] public Expression<Func<object>> ValidationMessageFor { get; set; }

#nullable restore annotations

    internal static readonly DateTime MinAllowableDate = DateTime.MinValue;
    internal static readonly DateTime MaxAllowableDate = DateTime.MaxValue;
    internal static string ErrorText { get; set; }
    internal string ItemType { get; set; }

    private MBTextField TextField { get; set; }
    private string MaxDateString { get; set; }
    private string MinDateString { get; set; }

    private string FormattedValue { get; set; }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor.MD2
    protected override async Task OnInitializedAsync()
    {
        //  Note the use of multiple parameters that presume invariance during the
        //  life of this component.
        //      DateOnly
        //      MaxDate
        //      MinDate
        //      SupressDefaultDate

        await base.OnInitializedAsync();

        if (DateOnly)
        {
            ErrorText = "Invalid date, hover for more information";
            ItemType = "date";
            MaxDateString = MaxDate.ToString("yyyy-MM-dd");
            MinDateString = MinDate.ToString("yyyy-MM-dd");
        }
        else
        {
            ErrorText = "Invalid datetime, hover for more information";
            ItemType = "datetime-local";
            MaxDateString = MaxDate.ToString("yyyy-MM-ddTHH:mm");
            MinDateString = MinDate.ToString("yyyy-MM-ddTHH:mm");
        }
    }

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

    private async Task OnFocusOutAsync()
    {
        try
        {
            await Task.CompletedTask;
            var potentialComponentValue = Convert.ToDateTime(FormattedValue);
            if (potentialComponentValue >= MinDate && potentialComponentValue <= MaxDate)
            {
                ComponentValue = potentialComponentValue;
            }
        }
        catch { }
    }

}
