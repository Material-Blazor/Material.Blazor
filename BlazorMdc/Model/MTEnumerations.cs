namespace BlazorMdc
{
    /// <summary>
    /// Determines what attributes to splat from <see cref="SplatAttributes"/>. Can be specified with bitwise or, eg:
    /// <code>@attributes="<see cref="AttributesToSplat"/>(<see cref="ClassAndStyleOnly"/> | <see cref="HtmlExcludingClassAndStyle"/>)"</code>
    /// </summary>
    internal enum SplatType : ushort
    {
        /// <summary>
        /// Return all attributes including class and style, also including values from <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        All = 0xFFFF,

        /// <summary>
        /// Return only class and style values, which includes <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        ClassAndStyleOnly = 0x0001,

        /// <summary>
        /// Return only class and style values, which includes <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        HtmlExcludingClassAndStyle = 0x0002,

        /// <summary>
        /// Return only class and style values, which includes <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        EventsOnly = 0x0004,

        /// <summary>
        /// Return all attributes except class and style, also excluding <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        ExcludeClassAndStyle = HtmlExcludingClassAndStyle | EventsOnly,

        /// <summary>
        /// Return all attributes except class and style, also excluding <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        ExcludeHtmlExcludingClassAndStyle = ClassAndStyleOnly | EventsOnly,

        /// <summary>
        /// Return all attributes except class and style, also excluding <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        ExcludeEvents = ClassAndStyleOnly | HtmlExcludingClassAndStyle
    }

    /// <summary>
    /// Specifies whether to use Material Icons from Google or Font Awesome Icons.
    /// <para>See <see cref="MTIconHelper"/></para>
    /// <para><see cref="MTCascadingDefaults"/> has a default of <see cref="MaterialIcons"/></para>
    /// </summary>
    public enum MTIconFoundryName 
    {
        /// <summary>
        /// Google Material Icons. This is the <see cref="MTCascadingDefaults"/> default.
        /// </summary>
        MaterialIcons,

        /// <summary>
        /// Font Awesome Icons.
        /// </summary>
        FontAwesome,

        /// <summary>
        /// Open Iconic Icons.
        /// </summary>
        OpenIconic
    }



    /// <summary>
    /// Sets the Google Material Icons theme.
    /// <para>See <see cref="MTIconHelper.MIFoundry(MTIconMITheme?)"/>, <seealso cref="IconMI"/> and <seealso cref="IconFoundryMI"/></para>
    /// <para><see cref="MTCascadingDefaults"/> has a default of <see cref="Filled"/></para>
    /// </summary>
    public enum MTIconMITheme 
    {
        /// <summary>
        /// Filled theme, <c>class="material-icons"</c>. This is the <see cref="MTCascadingDefaults"/> default.
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
    /// <para>See <see cref="MTIconHelper.FAFoundry(MTIconFAStyle?, MTIconFARelativeSize?)"/>, <seealso cref="MTIconFA"/> and <seealso cref="IconFoundryFA"/></para>
    /// <para><see cref="MTCascadingDefaults"/> has a default of <see cref="Solid"/> (all other styles except <see cref="Brands"/> require a paid-for Font Awesome PRO licence)</para>
    /// </summary>
    public enum MTIconFAStyle 
    {
        /// <summary>
        /// Solid style, <c>class="fas ..."</c>. This is the <see cref="MTCascadingDefaults"/> default.
        /// </summary>
        Solid,

        /// <summary>
        /// Regular style, <c>class="far ..."</c>. Requires a paid-for Font Awesome PRO licence.
        /// </summary>
        Regular,

        /// <summary>
        /// Light style, <c>class="fal ..."</c>. Requires a paid-for Font Awesome PRO licence.
        /// </summary>
        Light,

        /// <summary>
        /// Duotone style, <c>class="fad ..."</c>. Requires a paid-for Font Awesome PRO licence.
        /// </summary>
        Duotone,

        /// <summary>
        /// Brands style, <c>class="fab ..."</c>.
        /// </summary> 
        Brands
    }



    /// <summary>
    /// Sets the Font Awesome relative size.
    /// <para>See <see cref="MTIconHelper.FAFoundry(MTIconFAStyle?, MTIconFARelativeSize?)"/>, <seealso cref="MTIconFA"/> and <seealso cref="IconFoundryFA"/></para>
    /// <para><see cref="MTCascadingDefaults"/> has a default of <see cref="Regular"/></para>
    /// </summary>
    public enum MTIconFARelativeSize 
    {
        /// <summary>
        /// Regular relative size (no markup applied). This is the <see cref="MTCascadingDefaults"/> default.
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


    /// <summary>
    /// Style for an <see cref="MTButton"/> per Material Theme styling.
    /// <para><see cref="MTCascadingDefaults"/> has a default of <see cref="Text"/></para>
    /// </summary>
    public enum MTButtonStyle
    {
        /// <summary>
        /// Contained style, raised.
        /// </summary> 
        ContainedRaised,

        /// <summary>
        /// Contained style, unelevated.
        /// </summary> 
        ContainedUnelevated,

        /// <summary>
        /// Outlined style.
        /// </summary> 
        Outlined,

        /// <summary>
        /// Regular or default style. This is the <see cref="MTCascadingDefaults"/> default.
        /// </summary>  
        Text
    }


    /// <summary>
    /// Style for an <see cref="MdcCard"/> per Material Theme styling.
    /// <para><see cref="MTCascadingDefaults"/> has a default of <see cref="Default"/></para>
    /// </summary>
    public enum MTCardStyle
    {
        /// <summary>
        /// Default style. This is the <see cref="MTCascadingDefaults"/> default.
        /// </summary>
        Default,

        /// <summary>
        /// Outlined style.
        /// </summary>
        Outlined
    }


    /// <summary>
    /// Size for an <see cref="MdcCircularProgress"/>.
    /// </summary>
    public enum MTCircularProgressSize
    {
        /// <summary>
        /// A small sized circular progress.
        /// </summary>
        Small,

        /// <summary>
        /// A medium sized circular progress.
        /// </summary>
        Medium,

        /// <summary>
        /// A large sized circular progress. This is the default.
        /// </summary>
        Large
    }


    /// <summary>
    /// Type for an <see cref="MdcCircularProgress"/>.
    /// </summary>
    public enum MTCircularProgressType
    {
        /// <summary>
        /// An indeterminate circular progress.
        /// </summary>
        Indeterminate,

        /// <summary>
        /// A determinate circular progress with a value from 0 to 1.
        /// </summary>
        Determinate,

        /// <summary>
        /// A closed circular progress.
        /// </summary>
        Closed
    }


    /// <summary>
    /// Type for an <see cref="MdcLinearProgress"/>.
    /// </summary>
    public enum MTLinearProgressType
    {
        /// <summary>
        /// An indeterminate linear progress.
        /// </summary>
        Indeterminate,

        /// <summary>
        /// A determinate linear progress with a value from 0 to 1.
        /// </summary>
        Determinate,

        /// <summary>
        /// A reversed determinate linear progress with a value from 0 to 1.
        /// </summary>
        ReversedDeterminate,

        /// <summary>
        /// A closed linear progress.
        /// </summary>
        Closed
    }


    /// <summary>
    /// Style for an <see cref="MdcList{TItem}"/>. The <see cref="Outlined"/> variety borrows card markup matching <see cref="MTICardStyle.Outlined"/>.
    /// <para><see cref="MTCascadingDefaults"/> has a default of <see cref="None"/></para>
    /// </summary>
    public enum MTListStyle
    {
        /// <summary>
        /// No styling applied. This is the <see cref="MTCascadingDefaults"/> default.
        /// </summary>
        None,

        /// <summary>
        /// Borrows card markup matching <see cref="MTICardStyle.Outlined"/>.
        /// </summary>
        Outlined
    }


    /// <summary>
    /// Material Theme top app bar type applied to an <see cref="MdcTopAppBar"/>.
    /// </summary>
    public enum MTTopAppBarType
    {
        /// <summary>
        /// The standard variety.
        /// </summary>
        Standard,

        /// <summary>
        /// The fixed variety.
        /// </summary>
        Fixed,

        /// <summary>
        /// The dense variety.
        /// </summary>
        Dense,

        /// <summary>
        /// The prominent variety.
        /// </summary>
        Prominent,

        /// <summary>
        /// The short variety.
        /// </summary>
        Short,

        /// <summary>
        /// The short collapsed variety.
        /// </summary>
        ShortCollapsed
    }


    /// <summary>
    /// Material Theme text field and text area input style applied to <see cref="MTTextField"/> and <see cref="MdcTextArea"/>.
    /// <para>Note that Material Web Components 6.0.0 have pending implementation of <see cref="Filled"/> and <see cref="FullWidth"/> for text areas, with degraded markup results in the interim.</para>
    /// <para>Applied also to <seealso cref="MTAutocomplete"/>, <seealso cref="MTDebouncedTextField"/>, <seealso cref="MTNumericDoubleField"/> and <seealso cref="MTNumericIntField"/></para>
    /// <para><see cref="MTCascadingDefaults"/> has a default of <see cref="Filled"/></para>
    /// </summary>
    public enum MTTextInputStyle 
    {
        /// <summary>
        /// The filled style (pending in Material Web Components 6.0.0 for <see cref="MdcTextArea"/>). This is the <see cref="MTCascadingDefaults"/> default.
        /// </summary>
        Filled,

        /// <summary>
        /// The outlined style.
        /// </summary>
        Outlined
    }


    /// <summary>
    /// Material Theme select input style applied to <see cref="MTSelect{TItem}"/>.
    /// <para>Applied also to <seealso cref="MTDatePicker"/></para>
    /// <para><see cref="MTCascadingDefaults"/> has a default of <see cref="Filled"/></para>
    /// </summary>
    public enum MTSelectInputStyle
    {
        /// <summary>
        /// The filled style. This is the <see cref="MTCascadingDefaults"/> default.
        /// </summary>
        Filled,

        /// <summary>
        /// The outlined style.
        /// </summary>
        Outlined
    }


    /// <summary>
    /// A helper to set the alignment of text in <see cref="MTTextField"/>, <see cref="MdcTextArea"/> and <see cref="MTSelect{TItem}"/>.
    /// <para>Applied also to <seealso cref="MTAutocomplete"/>, <seealso cref="MTDebouncedTextField"/>, <seealso cref="MTNumericDoubleField"/> and <seealso cref="MTNumericIntField"/></para>
    /// <para><see cref="MTCascadingDefaults"/> has a default of <see cref="Default"/></para>
    /// </summary>
    public enum MTTextAlignStyle 
    {
        /// <summary>
        /// Default - no further styling applied. This is the <see cref="MTCascadingDefaults"/> default.
        /// </summary>
        Default,

        /// <summary>
        /// Left aligned text contents.
        /// </summary>
        Left,

        /// <summary>
        /// Centered text contents.
        /// </summary>
        Center,

        /// <summary>
        /// Right aligned text contents.
        /// </summary>
        Right
    }


    /// <summary>
    /// A helper to determine how a <see cref="MTSelect{TItem}"/> or <see cref="PMTRadioButtonGroup{TItem}"/> should handle an intial bound value not matching elements in the value list.
    /// <para><see cref="MTCascadingDefaults"/> has a default of <see cref="Exception"/></para>
    /// </summary>
    public enum MTItemValidation 
    {
        /// <summary>
        /// Sets the bound value to the first item in the list.
        /// </summary>
        DefaultToFirst,

        /// <summary>
        /// Throws an exception. This is the <see cref="MTCascadingDefaults"/> default.
        /// </summary>
        Exception,
        
        /// <summary>
        /// Does nothing, leaving the bound value as it is.
        /// </summary>
        NoSelection
    }


    // The style of MDC input: note that FullWidth is mutually exclusive with Outlined
    /// <summary>
    /// A helper to determine the magnitude adjustment when editting values as text in <see cref="MTNumericDoubleField"/> and <see cref="MTNumericIntField">.
    /// <para>Note that <see cref="BasisPoints"/> is pending future implementation because unlike percentages there is no native C# support for supporting formatting basis points.</para>
    /// </summary>
    public enum MTNumericInputMagnitude 
    {
        /// <summary>
        /// Normal numbers requiring no adjustment.
        /// </summary>
        Normal = 0,

        /// <summary>
        /// Percentages where the numeric input needs to multiply the value by 100 when editting (formatted display is handled by standard percent C# formatting).
        /// </summary>
        Percent = 2,

        /// <summary>
        /// Basis points where the numeric input needs to multiply the value by 10 000 when editting (formatted display is not handled by standard percent C# formatting which lacks support for basis points).
        /// <para>PENDING FUTURE IMPLEMENTATION</para>
        /// </summary>
        BasisPoints = 4
    }


    /// <summary>
    /// Determines the allowed selections in <see cref="MTDatePicker"/>
    /// <para><see cref="MTCascadingDefaults"/> has a default of <see cref="AllowAll"/></para>
    /// </summary>
    public enum MTDateSelectionCriteria 
    {
        /// <summary>
        /// Allow weekdays and weekends. This is the <see cref="MTCascadingDefaults"/> default.
        /// </summary>
        AllowAll,

        /// <summary>
        /// Limit selection to weekends only.
        /// </summary>
        WeekendsOnly,

        /// <summary>
        /// Limit selection to weekdays only.
        /// </summary>
        WeekdaysOnly
    }


    /// <summary>
    /// Determines whether a <see cref="MTShield"/> displays the label (left hand element), value (right hand element) or both.
    /// <para>Defaults to <see cref="LabelAndValue"/></para>
    /// </summary>
    public enum MTShieldType 
    {
        /// <summary>
        /// Show both label (left hand element) and value (right hand element). This is the default.
        /// </summary>
        LabelAndValue,

        /// <summary>
        /// Show both label (left hand element) only.
        /// </summary>
        LabelOnly,

        /// <summary>
        /// Show both value (right hand element) only.
        /// </summary>
        ValueOnly
    }


    /// <summary>
    /// Determines whether a toast notfication times out and whether it has a close button.
    /// <para>Defaults to <see cref="TimeoutAndCloseButton"/></para>
    /// </summary>
    public enum MTToastCloseMethod 
    {
        /// <summary>
        /// Apply a timeout and show the close button. This is the default.
        /// </summary>
        TimeoutAndCloseButton,

        /// <summary>
        /// Apply a timeout only.
        /// </summary>
        Timeout,

        /// <summary>
        /// Show the close button only.
        /// </summary>
        CloseButton
    }


    /// <summary>
    /// Determines the type of a toast notfication. This is a required toast parameter without defaults.
    /// </summary>
    public enum MTToastLevel 
    {
        /// <summary>
        /// Informational toast.
        /// </summary>
        Info,

        /// <summary>
        /// Success toast.
        /// </summary>
        Success,

        /// <summary>
        /// Warning toast.
        /// </summary>
        Warning,

        /// <summary>
        /// Error toast.
        /// </summary>
        Error
    }


    /// <summary>
    /// Determines where toasts are positioned.
    /// <para>Defaults to <see cref="BottomRight"/></para>
    /// </summary>
    public enum MTToastPosition 
    {
        /// <summary>
        /// Top left positioning, newest toasts on top.
        /// </summary>
        TopLeft,

        /// <summary>
        /// Top left right, newest toasts on top.
        /// </summary>
        TopRight,

        /// <summary>
        /// Top left center, newest toasts on top.
        /// </summary>
        TopCenter,

        /// <summary>
        /// Bottom left positioning, newest toasts on the bottom.
        /// </summary>
        BottomLeft,

        /// <summary>
        /// Bottom right positioning, newest toasts on the bottom.
        /// </summary>
        BottomRight,

        /// <summary>
        /// Bottom center positioning, newest toasts on the bottom.
        /// </summary>
        BottomCenter
    }
}
