//
//  2020-04-23  Mark Stega
//              Created from the enumerations defined in MdcCascadingDefaults
//
namespace BlazorMdc
{
    // Mdc components
    public enum MdcIconFoundry { MaterialComponents, FontAwesome }
    public enum MdcMCIconTheme { Filled, Outlined, Round, TwoTone, Sharp }
    public enum MdcFAIconStyle { Solid, Regular, Light, Duotone, Brands }
    public enum MdcFAIconRelativeSize { Regular, ExtraSmall, Small, Large, TwoTimes, ThreeTimes, FiveTimes, SevenTimes, TenTimes }


    public enum MdcButtonStyle { ContainedRaised, ContainedUnelevated, Outlined, Text }

    
    public enum MdcCardStyle { Default, Outlined }


    public enum MdcItemValidation { DefaultToFirst, Exception, NoSelection }


    public enum MdcListStyle { None, Outlined }


    // The style of MDC input: note that FullWidth is mutually exclusive with Outlined
    public enum MdcNumericInputMagnitude { Normal = 0, Percent = 2, BasisPoints = 4 }


    public enum MdcTopAppBarType { Standard, Fixed, Dense, Prominent, Short, ShortCollapsed }


    public enum MdcTextAlignStyle { Default, Left, Center, Right }
    

    // The style of MDC input: note that FullWidth is mutually exclusive with Outlined
    public enum MdcTextInputStyle { Filled, Outlined, FullWidth }


    public enum MdcSelectInputStyle { Filled, Outlined }




    // PMdc components
    public enum PMdcDateSelectionCriteria { AllowAll, WeekendsOnly, WeekdaysOnly }

    public enum PMdcToastCloseMethod { TimeoutAndCloseButton, Timeout, CloseButton }
    public enum PMdcToastLevel { Info, Success, Warning, Error }
    public enum PMdcToastPosition { TopLeft, TopRight, TopCenter, BottomLeft, BottomRight, BottomCenter }
}
