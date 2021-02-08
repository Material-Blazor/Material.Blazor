using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// For Material.Blazor internal use only.
    /// </summary>
    public partial class InternalDatePickerYearButton : ComponentFoundation
    {
        /// <summary>
        /// The currently selected year.
        /// </summary>
        [Parameter] public int CurrentYear { get; set; }


        /// <summary>
        /// The year being displayed by this button.
        /// </summary>
        [Parameter] public int DisplayYear { get; set; }


        /// <summary>
        /// Callback returning the year if this button is clicked
        /// </summary>
        [Parameter] public EventCallback<int> OnItemClickAsync { get; set; }


        /// <summary>
        /// Minimum date set by the consumer
        /// </summary>
        [Parameter] public DateTime MinDate { get; set; }


        /// <summary>
        /// Maximum date set by the consumer
        /// </summary>
        [Parameter] public DateTime MaxDate { get; set; }


        /// <summary>
        /// HTML element id for the current year
        /// </summary>
        [Parameter] public string CurrentYearId { get; set; }


        private MBButtonStyle ButtonStyle => (DisplayYear == CurrentYear) ? MBButtonStyle.ContainedUnelevated : MBButtonStyle.Text;


        private Dictionary<string, object> Attributes
        {
            get
            {
                var result = new Dictionary<string, object>();

                if (DisplayYear == CurrentYear)
                {
                    result.Add("id", CurrentYearId);
                }

                return result;
            }
        }

        private bool ButtonDisabled => (MaxDate < new DateTime(DisplayYear, 1, 1)) || (MinDate > new DateTime(DisplayYear, 12, 31));


        private async Task OnClickAsync() => await OnItemClickAsync.InvokeAsync(DisplayYear);
    }
}
