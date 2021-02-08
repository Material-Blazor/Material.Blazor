using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// For Material.Blazor internal use only.
    /// </summary>
    public partial class InternalDatePickerDayButton : ComponentFoundation
    {
        /// <summary>
        /// The currently selected date.
        /// </summary>
        [Parameter] public DateTime CurrentDate { get; set; }


        /// <summary>
        /// The date being displayed by this button
        /// </summary>
        [Parameter] public DateTime DisplayDate { get; set; }


        /// <summary>
        /// First day of the month being displayed
        /// </summary>
        [Parameter] public DateTime StartOfDisplayMonth { get; set; }


        /// <summary>
        /// Callback returning the date if the button is clicked
        /// </summary>
        [Parameter] public EventCallback<DateTime> OnItemClickAsync { get; set; }


        /// <summary>
        /// Date selection criteria
        /// </summary>
        [Parameter] public MBDateSelectionCriteria? DateSelectionCriteria { get; set; }


#nullable enable annotations
        /// <summary>
        /// Control whether a date is selectable by evaluating the method.
        /// </summary>
        [Parameter] public Func<DateTime, bool>? DateIsSelectable { get; set; }
#nullable restore annotations


        /// <summary>
        /// Minimum date set by the consumer
        /// </summary>
        [Parameter] public DateTime MinDate { get; set; }


        /// <summary>
        /// Maximum date set by the consumer
        /// </summary>
        [Parameter] public DateTime MaxDate { get; set; }


        private string Day => DisplayDate.Day.ToString();
        private MBButtonStyle ButtonStyle => (DisplayDate == CurrentDate) ? MBButtonStyle.ContainedUnelevated : MBButtonStyle.Text;


        private bool ButtonDisabled
        {
            get
            {
                if (DisplayDate.Month != StartOfDisplayMonth.Month)
                {
                    return true;
                }

                if (DateIsSelectable != null && DateIsSelectable != MBDatePicker.DateIsSelectableNotUsed && !DateIsSelectable(DisplayDate))
                {
                    return true;
                }

                var criteria = CascadingDefaults.AppliedDateSelectionCriteria(DateSelectionCriteria);

                switch (criteria)
                {
                    case MBDateSelectionCriteria.WeekendsOnly:
                        if ((DisplayDate.DayOfWeek != DayOfWeek.Sunday) && (DisplayDate.DayOfWeek != DayOfWeek.Saturday))
                        {
                            return true;
                        }
                        break;

                    case MBDateSelectionCriteria.WeekdaysOnly:
                        if ((DisplayDate.DayOfWeek == DayOfWeek.Sunday) || (DisplayDate.DayOfWeek == DayOfWeek.Saturday))
                        {
                            return true;
                        }
                        break;
                }

                return DisplayDate < MinDate || DisplayDate > MaxDate;
            }
        }


        private async Task OnClickAsync() => await OnItemClickAsync.InvokeAsync(DisplayDate);
    }
}
