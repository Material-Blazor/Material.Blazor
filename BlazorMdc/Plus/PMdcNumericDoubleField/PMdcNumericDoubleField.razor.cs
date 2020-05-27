using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// A Material Theme numeric input field. This wraps <see cref="MdcTextField"/> and normally
    /// displays the numeric value as formatted text, but switches to a pure number on being selected.
    /// </summary>
    public partial class PMdcNumericDoubleField : MdcInputComponentBase<double>
    {
#nullable enable annotations
        /// <summary>
        /// The text input style.
        /// </summary>
        [Parameter] public BEnum.TextInputStyle? TextInputStyle { get; set; }


        /// <summary>
        /// Field label.
        /// </summary>
        [Parameter] public string Label { get; set; } = "";


        /// <summary>
        /// Hides the label if True. Defaults to False.
        /// </summary>
        [Parameter] public bool NoLabel { get; set; } = false;


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
        /// <para><c>IconFoundry="BModel.IconHelper.MIIcon()"</c></para>
        /// <para><c>IconFoundry="BModel.IconHelper.FAIcon()"</c></para>
        /// <para><c>IconFoundry="BModel.IconHelper.OIIcon()"</c></para>
        /// </summary>
        [Parameter] public BModel.IIconFoundry? IconFoundry { get; set; }


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
        /// Adjusts the value's maginitude as a number when the field is selected. Used for
        /// percentages and basis points (the latter of which lacks appropriate Numeric Format in C#:
        /// this issue may not get solved.
        /// </summary>
        [Parameter] public BEnum.NumericInputMagnitude Magnitude { get; set; } = BEnum.NumericInputMagnitude.Normal;


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


        private MdcTextField TextField { get; set; }
        private double Mult { get; set; } = 1;
        private double AppliedMult => HasFocus ? Mult : 1;
        private int MyDecimalPlaces { get; set; } = 0;
        private Regex Regex { get; set; }
        private string Type => HasFocus ? "number" : "text";
        private Dictionary<string, object> MyAttributes { get; set; }


        /// <summary>
        /// ///////////Need to fix this.
        /// </summary>
        //private bool myFormNoValidate => hasFocus ? true : FormNoValidate;


        private bool PrevHasFocus { get; set; } = false;
        private bool HasFocus { get; set; } = false;


        private string FormattedValue
        {
            get
            {
                return HasFocus ? Math.Round(Convert.ToDouble(ReportingValue) * Mult, MyDecimalPlaces).ToString() : StringValue(ReportingValue);
            }

            set
            {
                var enteredVal = HasFocus ? Convert.ToDouble(Convert.ToDouble(string.IsNullOrWhiteSpace(value) ? "0" : value.Trim()) / Mult) : NumericValue(value);
                ReportingValue = Math.Round(Math.Max(Min ?? enteredVal, Math.Min(enteredVal, Max ?? enteredVal)), MyDecimalPlaces + (int)Magnitude);
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


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            bool allowSign = !(Min != null && Min >= 0);

            Mult = Math.Pow(10, (int)Magnitude);

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


        /// <inheritdoc/>
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


        /// <inheritdoc/>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (HasFocus == true && PrevHasFocus == false)
            {
                await TextField.Select();
            }

            PrevHasFocus = HasFocus;
        }


        private void OnFocusIn()
        {
            HasFocus = true;
            BuildMyAttributes();
        }


        private void OnFocusOut()
        {
            HasFocus = false;
            BuildMyAttributes();
        }
        
        
        
        private string StringValue(double? value) => (Convert.ToDouble(value) * AppliedMult).ToString(AppliedFormat);


        private double NumericValue(string displayText)
        {
            int myRounding = MyDecimalPlaces + Convert.ToInt32(Math.Log(AppliedMult));

            if (!Regex.IsMatch(displayText))
            {
                return ReportingValue;
            }

            double amount;
            try
            {
                amount = Convert.ToDouble(Math.Round(Convert.ToDouble(displayText) / AppliedMult, myRounding));
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
