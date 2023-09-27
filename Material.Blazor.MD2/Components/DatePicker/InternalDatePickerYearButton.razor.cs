using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Material.Blazor.MD2.Internal;

/// <summary>
/// For Material.Blazor.MD2 internal use only.
/// </summary>
public partial class InternalDatePickerYearButton : ComponentFoundationMD2
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


    /// <summary>
    /// We want to scroll to the current year when the year picker opens. So the year that's currently active needs an ID.
    /// </summary>
    private string CurrentYearIdHelper => (DisplayYear == CurrentYear) ? CurrentYearId : null;


    private bool ButtonDisabled => (MaxDate < new DateTime(DisplayYear, 1, 1)) || (MinDate > new DateTime(DisplayYear, 12, 31));


    private Task OnClickAsync() => OnItemClickAsync.InvokeAsync(DisplayYear);
}
