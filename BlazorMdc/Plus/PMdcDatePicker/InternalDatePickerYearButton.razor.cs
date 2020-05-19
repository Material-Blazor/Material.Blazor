using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// For BlazorMdc internal use only.
    /// </summary>
    public partial class InternalDatePickerYearButton : MdcComponentBase
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


        private MdcButtonStyle ButtonStyle => (DisplayYear == CurrentYear) ? MdcButtonStyle.ContainedUnelevated : MdcButtonStyle.Text;
        

        private bool ButtonDisabled => (MaxDate < new DateTime(DisplayYear, 1, 1)) || (MinDate > new DateTime(DisplayYear, 12, 31));


        private async Task OnClickAsync() => await OnItemClickAsync.InvokeAsync(DisplayYear);
    }
}
