using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme numeric input field. This wraps <see cref="MBTextField"/> and normally
    /// displays the numeric value as formatted text, but switches to a pure number on being selected.
    /// </summary>
    public partial class MBNumericDoubleField : InputComponentFoundation<double>
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
        /// <see cref="ValidationMessage{TValue}"/>, but not both. This parameter takes the same input as
        /// <see cref="ValidationMessage{TValue}.For"/>.
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
        [Parameter] public double? Min { get; set; }


        /// <summary>
        /// The maximum allowable value.
        /// </summary>
        [Parameter] public double? Max { get; set; }


        /// <summary>
        /// Number of decimal places for the value. If more dp are entered the value gets rounded properly.
        /// </summary>
        [Parameter] public int DecimalPlaces { get; set; } = 2;
#nullable restore annotations


        private const string DoublePattern = @"^[-+]?[0-9]*\.?[0-9]+$";
        private const string PositiveDoublePattern = @"[0-9]*\.?[0-9]+$";
        private const string IntegerPattern = @"^(\+|-)?\d+$";
        private const string PositiveIntegerPattern = @"^\d+$";


        private MBTextField TextField { get; set; }
        private double FocusedMultiplier { get; set; } = 1;
        private double UnfocusedMultiplier { get; set; } = 1;
        private double AppliedMultiplier => HasFocus ? FocusedMultiplier : UnfocusedMultiplier;
        private int MyDecimalPlaces { get; set; } = 0;
        private string NextType { get; set; } = "";
        private Regex Regex { get; set; }
        private Dictionary<string, object> MyAttributes { get; set; }


        ///// <summary>
        ///// Need to fix this.
        ///// </summary>
        //private bool myFormNoValidate => hasFocus ? true : FormNoValidate;


        private bool HasFocus { get; set; } = false;


        private string FormattedValue
        {
            get
            {
                return HasFocus ? Math.Round(Convert.ToDouble(ReportingValue) * AppliedMultiplier, MyDecimalPlaces).ToString() : StringValue(ReportingValue);
            }

            set
            {
                var enteredVal = HasFocus ? Convert.ToDouble(Convert.ToDouble(string.IsNullOrWhiteSpace(value) ? "0" : value.Trim()) / FocusedMultiplier) : NumericValue(value) / AppliedMultiplier;
                ReportingValue = Math.Round(Math.Max(Min ?? enteredVal, Math.Min(enteredVal, Max ?? enteredVal)), MyDecimalPlaces + (int)FocusedMagnitude);
            }
        }


        private string AppliedFormat
        {
            get
            {
                if (HasFocus) return "";

                if (!(NumericSingularFormat is null) && Utilities.DoubleEqual(Math.Abs(ReportingValue), 1)) return NumericSingularFormat;

                return NumericFormat;
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            bool allowSign = !(Min != null && Min >= 0);

            FocusedMultiplier = Math.Pow(10, (int)FocusedMagnitude);
            UnfocusedMultiplier = Math.Pow(10, (int)UnfocusedMagnitude);

            if (DecimalPlaces <= 0)
            {
                MyDecimalPlaces = 0;
                Regex = new Regex(allowSign ? IntegerPattern : PositiveIntegerPattern);
            }
            else
            {
                MyDecimalPlaces = DecimalPlaces;
                Regex = new Regex(allowSign ? DoublePattern : PositiveDoublePattern);
            }

            ForceShouldRenderToTrue = true;
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            BuildMyAttributes();
        }

        
        private void BuildMyAttributes()
        {
            MyAttributes = (from a in AttributesToSplat()
                            select new KeyValuePair<string, object>(a.Key, a.Value))
                            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            if (HasFocus)
            {
                MyAttributes.Add("formnovalidate", true);
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            
            if (!string.IsNullOrWhiteSpace(NextType))
            {
                await TextField.SetType(NextType);
                NextType = "";
            }
        }


        private void OnFocusIn()
        {
            HasFocus = true;
            NextType = "number";
            TextField.SelectAllText = true;
            TextField.AllowNextRender = true;
            BuildMyAttributes();
        }


        private void OnFocusOut()
        {
            HasFocus = false;
            NextType = "text";
            TextField.SelectAllText = false;
            TextField.AllowNextRender = true;
            BuildMyAttributes();
        }


        private void StopForceSelect() => TextField.SelectAllText = false;        
        
        
        private string StringValue(double? value) => (Convert.ToDouble(value) * AppliedMultiplier).ToString(AppliedFormat);


        private double NumericValue(string displayText)
        {
            int myRounding = MyDecimalPlaces + Convert.ToInt32(Math.Log(AppliedMultiplier));

            if (!Regex.IsMatch(displayText))
            {
                return ReportingValue;
            }

            double amount;
            try
            {
                amount = Convert.ToDouble(Math.Round(Convert.ToDouble(displayText) / AppliedMultiplier, myRounding));
            }
            catch
            {
                return ReportingValue;
            }

            if ((Min != null && amount < Min) || (Max != null && amount > Max))
            {
                return ReportingValue;
            }

            return amount;
        }
    }
}
