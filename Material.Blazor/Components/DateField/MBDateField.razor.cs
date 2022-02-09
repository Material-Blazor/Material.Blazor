using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme date input field. This wraps <see cref="MBTextField"/> and normally
    /// displays the numeric value as formatted text, but switches to a pure number on being selected.
    /// </summary>
    public partial class MBDateField : InputComponent<DateTime>
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
        /// The minimum allowable value.
        /// </summary>
        [Parameter] public DateTime MinDate { get; set; } = MinAllowableDate;


        /// <summary>
        /// The maximum allowable value.
        /// </summary>
        [Parameter] public DateTime MaxDate { get; set; } = MaxAllowableDate;


        /// <summary>
        /// Set to indicate that if the value is default(DateTime) then no date is initially shown
        /// </summary>
        [Parameter] public bool SuppressDefaultDate { get; set; } = true;


#nullable restore annotations

        internal static readonly DateTime MinAllowableDate = DateTime.MinValue;
        internal static readonly DateTime MaxAllowableDate = DateTime.MaxValue;

        private MBTextField TextField { get; set; }
        private string MaxDateString { get { return MaxDate.ToString("yyyy-MM-dd"); } }
        private string MinDateString { get { return MinDate.ToString("yyyy-MM-dd"); } }

        private string FormattedValue
        {
            get
            {
                if ((ComponentValue == default) & SuppressDefaultDate)
                {
                    return "";
                }
                else
                {
                    return ComponentValue.ToString("yyyy-MM-dd");
                }
            }

            set
            {
                ComponentValue = Convert.ToDateTime(value);
            }
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override async Task OnInitializedAsync()
        {
            //  Note the use of multiple parameters that presume invariance during the
            //  life of this component.
            //      MaxDate
            //      MinDate
            //      SupressDefaultDate

            await base.OnInitializedAsync();
        }

        private bool FirstTime { get; set; } = true;
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (FirstTime && (TextField != null))
            {
                FirstTime = false;

                await TextField.SetType(FormattedValue, "date", true).ConfigureAwait(false);
            }
        }


    }
}
