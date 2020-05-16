//
//  2020-04-23  Mark Stega
//              Created from the enumerations defined in MdcCascadingDefaults
//
namespace BlazorMdc
{
    /*
     * ==============================================
     * 
     * Mdc Components
     * 
     * ==============================================
     */


    /// <summary>
    /// Specifies whether to use Material Icons from Google or Font Awesome Icons.
    /// </summary>
    public enum MdcIconFoundryName 
    {
        /// <summary>
        /// Google Material Icons.
        /// </summary>
        MaterialIcons,

        /// <summary>
        /// Font Awesome Icons.
        /// </summary>
        FontAwesome
    }



    /// <summary>
    /// Sets the Google Material Icons theme.
    /// </summary>
    public enum MdcIconMITheme 
    {
        /// <summary>
        /// Filled theme, <c>class="material-icons"</c>.
        /// </summary>
        Filled,

        /// <summary>
        /// Outlined theme, <c>class="material-icons-outlined"</c>.
        /// </summary>
        Outlined,
        /// <summary>
        /// Rounded theme, <c>class="material-icons-round"</c>.
        /// </summary>
        Round,

        /// <summary>
        /// Two-tone theme, <c>class="material-icons-two-tone"</c>. Note that two-tone does not use css color, but filter instead.
        /// </summary>
        TwoTone,

        /// <summary>
        /// Sharp theme, <c>class="material-icons-sharp"</c>.
        /// </summary>
        Sharp
    }



    /// <summary>
    /// Sets the Font Awesome style.
    /// </summary>
    public enum MdcIconFAStyle 
    {
        /// <summary>
        /// Solid style, <c>class="fas ..."</c>.
        /// </summary>
        Solid,

        /// <summary>
        /// Regular style, <c>class="far ..."</c>. Requires a PRO licence.
        /// </summary>
        Regular,

        /// <summary>
        /// Light style, <c>class="fal ..."</c>. Requires a PRO licence.
        /// </summary>
        Light,

        /// <summary>
        /// Duotone style, <c>class="fad ..."</c>. Requires a PRO licence.
        /// </summary>
        Duotone,

        /// <summary>
        /// Brands style, <c>class="fab ..."</c>.
        /// </summary> 
        Brands
    }



    /// <summary>
    /// Sets the Font Awesome relative size.
    /// </summary>
    public enum MdcIconFARelativeSize 
    {
        /// <summary>
        /// Regular relative size (no markup change).
        /// </summary> 
        Regular,

        /// <summary>
        /// Extra small relative size, <c>class="... fa-xs"</c>
        /// </summary> 
        ExtraSmall,

        /// <summary>
        /// Small relative size: <c>class="... fa-sm"</c>
        /// </summary> 
        Small,

        /// <summary>
        /// Large relative size, <c>class="... fa-lg"</c>
        /// </summary>
        Large,

        /// <summary>
        /// Two times relative size. <c>class="... fa-2x"</c>
        /// </summary> 
        TwoTimes,

        /// <summary>
        /// Three times relative size, <c>class="... fa-3x"</c>
        /// </summary>
        ThreeTimes,

        /// <summary>
        /// Five times relative size, <c>class="... fa-5x"</c>
        /// </summary>
        FiveTimes,

        /// <summary>
        /// Seven times relative size, <c>class="... fa-7x"</c>
        /// </summary>
        SevenTimes,

        /// <summary>
        /// Ten times relative size, <c>class="... fa-10x"</c>
        /// </summary> 
        TenTimes
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




    /*
     * ==============================================
     * 
     * PMdc Plus Components
     * 
     * ==============================================
     */


    public enum PMdcDateSelectionCriteria { AllowAll, WeekendsOnly, WeekdaysOnly }

    public enum PMdcShieldType { LabelAndValue, LabelOnly, ValueOnly }

    public enum PMdcToastCloseMethod { TimeoutAndCloseButton, Timeout, CloseButton }
    public enum PMdcToastLevel { Info, Success, Warning, Error }
    public enum PMdcToastPosition { TopLeft, TopRight, TopCenter, BottomLeft, BottomRight, BottomCenter }
}
