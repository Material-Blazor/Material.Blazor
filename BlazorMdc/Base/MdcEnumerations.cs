//
//  2020-04-23  Mark Stega
//              Created from the enumerations defined in MdcCascadingDefaults
//
namespace BlazorMdc
{
    // Mdc components
    public enum MdcIconFoundry : ulong { MaterialIcons = 0x0, FontAwesome = 0x1 }
    public enum MdcMIIconTheme : ulong { Filled = 0x1 * 0b100, Outlined = 0x2 * 0b100, Round = 0x3 * 0b100, TwoTone = 0x4 * 0b100, Sharp = 0x5 * 0b100 }
    public enum MdcFAIconStyle : ulong { Solid = 0x1 * 0b100000, Regular = 0x2 * 0b100000, Light = 0x3 * 0b100000, Duotone = 0x4 * 0b100000, Brands = 0x5 * 0b100000 }
    public enum MdcFAIconRelativeSize : ulong { Regular = 0x1 * 0b100000000, ExtraSmall = 0x2 * 0b100000000, Small = 0x3 * 0b100000000, Large = 0x4 * 0b100000000, TwoTimes = 0x5 * 0b100000000, ThreeTimes = 0x6 * 0b100000000, FiveTimes = 0x7 * 0b100000000, SevenTimes = 0x8 * 0b100000000, TenTimes = 0x9 * 0b100000000 }

    internal static class IconMasks
    {
        public const ulong IconFoundry = 0b11;
        public const ulong MIIconTheme = 0b11100;
        public const ulong FAIconStyle = 0b11100000;
        public const ulong FAIconRelativeSize = 0b111100000000;
    }


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
