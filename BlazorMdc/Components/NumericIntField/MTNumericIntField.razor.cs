using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;

using System;

namespace BlazorMdc
{
    /// <summary>
    /// An integer variant of <see cref="MTNumericDoubleField"/>.
    /// </summary>
    public partial class MTNumericIntField : InputComponentFoundation<int>
    {
#nullable enable annotations
        /// <summary>
        /// The text input style.
        /// </summary>
        [Parameter] public MTTextInputStyle? TextInputStyle { get; set; }


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
        /// </summary>
        [Parameter] public IMTIconFoundry? IconFoundry { get; set; }


        /// <summary>
        /// The numeric field's density.
        /// </summary>
        [Parameter] public MTDensity? Density { get; set; }


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
        /// Adjusts the value's maginitude as a number when the field is focussed. Used for
        /// percentages and basis points (the latter of which lacks appropriate Numeric Format in C#:
        /// this issue may not get solved.
        /// </summary>
        [Parameter] public MTNumericInputMagnitude FocussedMagnitude { get; set; } = MTNumericInputMagnitude.Normal;


        /// <summary>
        /// Adjusts the value's maginitude as a number when the field is unfocussed. Used for
        /// percentages and basis points (the latter of which lacks appropriate Numeric Format in C#:
        /// this issue may not get solved.
        /// </summary>
        [Parameter] public MTNumericInputMagnitude UnfocussedMagnitude { get; set; } = MTNumericInputMagnitude.Normal;


        /// <summary>
        /// The minimum allowable value.
        /// </summary>
        [Parameter] public double? Min { get; set; }


        /// <summary>
        /// The maximum allowable value.
        /// </summary>
        [Parameter] public double? Max { get; set; }
#nullable restore annotations


        private double DblVal
        {
            get => (double)ReportingValue;
            set => ReportingValue = Convert.ToInt32(Math.Round(value, 0));
        }


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ForceShouldRenderToTrue = true;
        }
    }
}
