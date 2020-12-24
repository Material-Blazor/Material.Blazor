using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme numeric input field. This wraps <see cref="MBTextField"/> and normally
    /// displays the numeric value as formatted text, but switches to a pure number on being selected.
    /// </summary>
    public partial class MBNumericDecimalField : InputComponent<decimal>
    {
#nullable enable annotations
        /// <summary>
        /// Helper text that is displayed either with focus or persistently with <see cref="HelperTextPersistent"/>.
        /// </summary>
        [Parameter] public string HelperText { get; set; } = "";


        /// <summary>
        /// Makes the <see cref="HelperText"/> persistent if true.
        /// </summary>
        [Parameter] public bool HelperTextPersistent { get; set; } = false;


        /// <summary>
        /// Delivers Material Theme validation methods from native Blazor validation. Either use this or
        /// the Blazor <code>ValidationMessage</code> component, but not both. This parameter takes the same input as
        /// <code>ValidationMessage</code>'s <code>For</code> parameter.
        /// </summary>
        [Parameter] public Expression<Func<object>> ValidationMessageFor { get; set; }


        /// <summary>
        /// The text input style.
        /// <para>Overrides <see cref="MBCascadingDefaults.TextInputStyle"/></para>
        /// </summary>
        [Parameter] public MBTextInputStyle? TextInputStyle { get; set; }


        /// <summary>
        /// Field label.
        /// </summary>
        [Parameter] public string? Label { get; set; }


        /// <summary>
        /// Prefix text.
        /// </summary>
        [Parameter] public string? Prefix { get; set; }


        /// <summary>
        /// Suffix text.
        /// </summary>
        [Parameter] public string? Suffix { get; set; }


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
        /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
        /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
        /// </summary>
        [Parameter] public IMBIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// The numeric field's density.
        /// </summary>
        [Parameter] public MBDensity? Density { get; set; }


        /// <summary>
        /// Format to apply to the numeric value when the field is not selected.
        /// </summary>
        [Parameter] public string NumericFormat { get; set; }


        /// <summary>
        /// Alternative format for a singular number if required. An example is "1 month"
        /// vs "3 months".
        /// </summary>
        [Parameter] public string? NumericSingularFormat { get; set; }


        /// <summary>
        /// Adjusts the value's maginitude as a number when the field is focused. Used for
        /// percentages and basis points (the latter of which lacks appropriate Numeric Format in C#:
        /// this issue may not get solved.
        /// </summary>
        [Parameter] public MBNumericInputMagnitude FocusedMagnitude { get; set; } = MBNumericInputMagnitude.Normal;


        /// <summary>
        /// Adjusts the value's maginitude as a number when the field is unfocused. Used for
        /// percentages and basis points (the latter of which lacks appropriate Numeric Format in C#:
        /// this issue may not get solved.
        /// </summary>
        [Parameter] public MBNumericInputMagnitude UnfocusedMagnitude { get; set; } = MBNumericInputMagnitude.Normal;


        /// <summary>
        /// The minimum allowable value.
        /// </summary>
        [Parameter] public decimal? Min { get; set; }


        /// <summary>
        /// The maximum allowable value.
        /// </summary>
        [Parameter] public decimal? Max { get; set; }


        /// <summary>
        /// Number of decimal places for the value. If more dp are entered the value gets rounded properly.
        /// </summary>
        [Parameter] public uint DecimalPlaces { get; set; } = 2;
#nullable restore annotations


        private const string DoublePattern = @"^[-+]?[0-9]*\.?[0-9]+$";
        private const string PositiveDoublePattern = @"[0-9]*\.?[0-9]+$";
        private const string IntegerPattern = @"^(\+|-)?\d+$";
        private const string PositiveIntegerPattern = @"^\d+$";


        private decimal AppliedMultiplier => HasFocus ? FocusedMultiplier : UnfocusedMultiplier;
        private decimal FocusedMultiplier { get; set; } = 1;
        private Dictionary<string, object> MyAttributes { get; set; }
        private int MyDecimalPlaces { get; set; } = 0;
        private Regex Regex { get; set; }
        private MBTextField TextField { get; set; }
        private decimal UnfocusedMultiplier { get; set; } = 1;


        private bool HasFocus { get; set; } = false;


        // There may be a case for simplifying this code. Does FormattedValue need to be bound like this or can we instead bind to a string representation of the
        // properly scaled number without formatting intended only for human legibility?
        private string FormattedValue
        {
            get
            {
                return HasFocus ? Math.Round(Convert.ToDecimal(ComponentValue) * AppliedMultiplier, MyDecimalPlaces).ToString() : StringValue(ComponentValue);
            }

            set
            {
                var enteredVal = HasFocus ? Convert.ToDecimal(Convert.ToDecimal(string.IsNullOrWhiteSpace(value) ? "0" : value.Trim()) / FocusedMultiplier) : NumericValue(value) / AppliedMultiplier;
                ComponentValue = Convert.ToDecimal(Math.Round(Math.Max(Min ?? enteredVal, Math.Min(enteredVal, Max ?? enteredVal)), MyDecimalPlaces + (int)FocusedMagnitude));
            }
        }


        private string AppliedFormat
        {
            get
            {
                if (HasFocus) return "";

                if (!(NumericSingularFormat is null) && Utilities.DecimalEqual(Math.Abs(ComponentValue), 1)) return NumericSingularFormat;

                return NumericFormat;
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            bool allowSign = !(Min != null && Min >= 0);

            FocusedMultiplier = Convert.ToDecimal(Math.Pow(10, (int)FocusedMagnitude));
            UnfocusedMultiplier = Convert.ToDecimal(Math.Pow(10, (int)UnfocusedMagnitude));

            if (DecimalPlaces <= 0)
            {
                MyDecimalPlaces = 0;
                Regex = new Regex(allowSign ? IntegerPattern : PositiveIntegerPattern);
            }
            else
            {
                MyDecimalPlaces = (int)DecimalPlaces;
                Regex = new Regex(allowSign ? DoublePattern : PositiveDoublePattern);
            }

            // Required for MBNumericIntField to work
            ForceShouldRenderToTrue = true;
        }


        private async Task OnFocusInAsync()
        {
            HasFocus = true;
            await TextField.SetType(FormattedValue, "number", true);
        }


        private async Task OnFocusOutAsync()
        {
            HasFocus = false;
            await TextField.SetType(FormattedValue, "text", false);
        }


        private string StringValue(decimal? value) => (Convert.ToDecimal(value) * AppliedMultiplier).ToString(AppliedFormat);


        private decimal NumericValue(string displayText)
        {
            int myRounding = MyDecimalPlaces + Convert.ToInt32(Math.Log(Convert.ToDouble(AppliedMultiplier)));

            if (!Regex.IsMatch(displayText))
            {
                return ComponentValue;
            }

            decimal amount;
            try
            {
                amount = Convert.ToDecimal(Math.Round(Convert.ToDecimal(displayText) / AppliedMultiplier, myRounding));
            }
            catch
            {
                return ComponentValue;
            }

            if ((Min != null && amount < Min) || (Max != null && amount > Max))
            {
                return ComponentValue;
            }

            return amount;
        }
    }
}
