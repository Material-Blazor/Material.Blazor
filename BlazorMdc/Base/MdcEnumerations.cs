//
//  2020-04-23  Mark Stega
//              Created from the enumerations defined in MdcCascadingDefaults
//
namespace BlazorMdc
{
    /// Mdc components
    

    /// <summary>
    /// The MDC Top App Bar type: all items are mutually exclusive
    /// </summary>
    public enum MdcTopAppBarType { Standard, Fixed, Dense, Prominent, Short, ShortCollapsed }


    /// <summary>
    /// The style of MDC input: note that FullWidth is mutually exclusive with Outlined
    /// </summary>
    public enum MdcTextAlignStyle { Default, Left, Center, Right }


    /// <summary>
    /// The style of MDC input: note that FullWidth is mutually exclusive with Outlined
    /// </summary>
    public enum MdcTextInputStyle { Filled, Outlined, FullWidth }


    /// <summary>
    /// The style of MDC select
    /// </summary>
    public enum MdcSelectInputStyle { Filled, Outlined }


    /// <summary>
    /// The style of MDC input: note that FullWidth is mutually exclusive with Outlined
    /// </summary>
    public enum MdcNumericInputMagnitude { Normal = 0, Percent = 2, BasisPoints = 4 }


    /// <summary>
    /// MDC button styling
    /// </summary>
    public enum MdcButtonStyle { ContainedRaised, ContainedUnelevated, Outlined, Text }


    /// <summary>
    /// MDC list styling
    /// </summary>
    public enum MdcListStyle { None, Outlined }


    /// <summary>
    /// MDC card styling
    /// </summary>
    public enum MdcCardStyle { Default, Outlined }


    /// PMdc components


    /// <summary>
    /// PMdcDatePicker selection criteria
    /// </summary>
    public enum PMdcDateSelectionCriteria { AllowAll, WeekendsOnly, WeekdaysOnly }


    /// <summary>
    /// PMdcRadioButtonGroup item validation methodology
    /// </summary>
    public enum PMdcRadioButtonGroupItemValidation { DefaultToFirst, Exception, NoSelection }
}
