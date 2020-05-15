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
        /// Filled theme, <code>class="material-icons"</code>.
        /// </summary>
        Filled,

        /// <summary>
        /// Outlined theme, <code>class="material-icons-outlined"</code>.
        /// </summary>
        Outlined,
        /// <summary>
        /// Rounded theme, <code>class="material-icons-round"</code>.
        /// </summary>
        Round,

        /// <summary>
        /// Two-tone theme, <code>class="material-icons-two-tone"</code>. Note that two-tone does not use css color, but filter instead.
        /// </summary>
        TwoTone,

        /// <summary>
        /// Sharp theme, <code>class="material-icons-sharp"</code>.
        /// </summary>
        Sharp
    }



    /// <summary>
    /// Sets the Font Awesome style.
    /// </summary>
    public enum MdcIconFAStyle 
    {
        /// <summary>
        /// Solid style, <code>class="fas ..."</code>.
        /// </summary>
        Solid,

        /// <summary>
        /// Regular style, <code>class="far ..."</code>. Requires a PRO licence.
        /// </summary>
        Regular,

        /// <summary>
        /// Light style, <code>class="fal ..."</code>. Requires a PRO licence.
        /// </summary>
        Light,

        /// <summary>
        /// Duotone style, <code>class="fad ..."</code>. Requires a PRO licence.
        /// </summary>
        Duotone,

        /// <summary>
        /// Brands style, <code>class="fab ..."</code>.
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
        /// Extra small relative size: 
        /// <code>class="... fa-xs"</code>
        /// </summary> 
        ExtraSmall,

        /// <summary>
        /// Small relative size: 
        /// <code>class="... fa-sm"</code>
        /// </summary> 
        Small,

        /// <summary>
        /// Large relative size: 
        /// <code>class="... fa-lg"</code>
        /// </summary>
        Large,

        /// <summary>
        /// Two times relative size: 
        /// <code>class="... fa-2x"</code>
        /// </summary> 
        TwoTimes,

        /// <summary>
        /// Three times relative size:
        /// <code>class="... fa-3x"</code>
        /// </summary>
        ThreeTimes,

        /// <summary>
        /// Five times relative size: 
        /// <code>class="... fa-5x"</code>
        /// </summary>
        FiveTimes,

        /// <summary>
        /// Seven times relative size: 
        /// <code>class="... fa-7x"</code>
        /// </summary>
        SevenTimes,

        /// <summary>
        /// Ten times relative size:
        /// <code>class="... fa-10x"</code>
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
