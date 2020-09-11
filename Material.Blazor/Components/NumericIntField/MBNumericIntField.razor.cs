using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;

using System;

namespace Material.Blazor
{
    /// <summary>
    /// An integer variant of <see cref="MBNumericDoubleField"/>.
    /// </summary>
    public partial class MBNumericIntField : InputComponentFoundation<int>
    {
#nullable enable annotations
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
