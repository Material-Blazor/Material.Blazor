namespace Material.Blazor
{
    /// <summary>
    /// Determines what attributes to splat from <see cref="SplatAttributes"/>. Can be specified with bitwise or, eg:
    /// <code>@attributes="<see cref="AttributesToSplat"/>(<see cref="IdClassAndStyleOnly"/> | <see cref="HtmlExcludingIdClassAndStyle"/>)"</code>
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
        IdClassAndStyleOnly = 0x0001,

        /// <summary>
        /// Return only class and style values, which includes <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        HtmlExcludingIdClassAndStyle = 0x0002,

        /// <summary>
        /// Return only class and style values, which includes <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        EventsOnly = 0x0004,

        /// <summary>
        /// Return all attributes except class and style, also excluding <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        ExcludeIdClassAndStyle = HtmlExcludingIdClassAndStyle | EventsOnly,

        /// <summary>
        /// Return all attributes except class and style, also excluding <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        ExcludeHtmlExceptIdClassAndStyle = IdClassAndStyleOnly | EventsOnly,

        /// <summary>
        /// Return all attributes except class and style, also excluding <see cref="ClassMapper"/> and <see cref="StyleMapper"/>.
        /// </summary>
        ExcludeEvents = IdClassAndStyleOnly | HtmlExcludingIdClassAndStyle
    }


    /// <summary>
    /// Style for an <see cref="MBButton"/> per Material Theme styling.
    /// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="Text"/></para>
    /// </summary>
    public enum MBButtonStyle
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
        /// Regular or default style. This is the <see cref="MBCascadingDefaults"/> default.
        /// </summary>  
        Text
    }


    /// <summary>
    /// Style for an <see cref="MBCard"/> per Material Theme styling.
    /// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="Default"/></para>
    /// </summary>
    public enum MBCardStyle
    {
        /// <summary>
        /// Default style. This is the <see cref="MBCascadingDefaults"/> default.
        /// </summary>
        Default,

        /// <summary>
        /// Outlined style.
        /// </summary>
        Outlined
    }


    /// <summary>
    /// Size for an <see cref="MBCircularProgress"/>.
    /// </summary>
    public enum MBCircularProgressSize
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
    /// Type for an <see cref="MBCircularProgress"/>.
    /// </summary>
    public enum MBCircularProgressType
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
    /// Determines the allowed selections in <see cref="MBDatePicker"/>
    /// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="AllowAll"/></para>
    /// </summary>
    public enum MBDateSelectionCriteria
    {
        /// <summary>
        /// Allow weekdays and weekends. This is the <see cref="MBCascadingDefaults"/> default.
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
    /// Determines the density of a component
    /// <para>Defaults to <see cref="Default"/></para>
    /// </summary>
    public enum MBDensity
    {
        /// <summary>
        /// Density level -5.
        /// </summary>
        Minus5,

        /// <summary>
        /// Density level -4.
        /// </summary>
        Minus4,

        /// <summary>
        /// Density level -3.
        /// </summary>
        Minus3,

        /// <summary>
        /// Compact density, equal to -3.
        /// </summary>
        Compact,

        /// <summary>
        /// Density level -2.
        /// </summary>
        Minus2,

        /// <summary>
        /// Comfortable density, equal to -2.
        /// </summary>
        Comfortable,

        /// <summary>
        /// Density level -1.
        /// </summary>
        Minus1,

        /// <summary>
        /// Default density / zero.
        /// </summary>
        Default
    }


    /// <summary>
    /// Type for an <see cref="MBFloatingActionButton"/>.
    /// </summary>
    public enum MBFloatingActionButtonType
    {
        /// <summary>
        /// FAB regular variant.
        /// </summary>
        Regular,

        /// <summary>
        /// FAB mini variant.
        /// </summary>
        Mini,

        /// <summary>
        /// FAB extended variant.
        /// </summary>
        Extended
    }


    /// <summary>
    /// Specifies whether to use Material Icons from Google or Font Awesome Icons.
    /// <para>See <see cref="MBIconHelper"/></para>
    /// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="MaterialIcons"/></para>
    /// </summary>
    public enum MBIconFoundryName
    {
        /// <summary>
        /// Google Material Icons. This is the <see cref="MBCascadingDefaults"/> default.
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
    /// <para>See <see cref="MBIconHelper.MIFoundry(MBIconMITheme?)"/>, <seealso cref="IconMI"/> and <seealso cref="IconFoundryMI"/></para>
    /// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="Filled"/></para>
    /// </summary>
    public enum MBIconMITheme
    {
        /// <summary>
        /// Filled theme, <c>class="material-icons"</c>. This is the <see cref="MBCascadingDefaults"/> default.
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
    /// <para>See <see cref="MBIconHelper.FAFoundry(MBIconFAStyle?, MBIconFARelativeSize?)"/>, <seealso cref="Internal.IconFA"/> and <seealso cref="IconFoundryFA"/></para>
    /// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="Solid"/> (all other styles except <see cref="Brands"/> require a paid-for Font Awesome PRO licence)</para>
    /// </summary>
    public enum MBIconFAStyle
    {
        /// <summary>
        /// Solid style, <c>class="fas ..."</c>. This is the <see cref="MBCascadingDefaults"/> default.
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
    /// <para>See <see cref="MBIconHelper.FAFoundry(MBIconFAStyle?, MBIconFARelativeSize?)"/>, <seealso cref="Internal.IconFA"/> and <seealso cref="IconFoundryFA"/></para>
    /// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="Regular"/></para>
    /// </summary>
    public enum MBIconFARelativeSize
    {
        /// <summary>
        /// Regular relative size (no markup applied). This is the <see cref="MBCascadingDefaults"/> default.
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
    /// Determines how an <see cref="MBSlider"/> responds to user events.
    /// </summary>
    public enum MBInputEventType
    {
        /// <summary>
        /// Emits events only when the thumb is released via an change event.
        /// </summary>
        OnChange,

        /// <summary>
        /// Emits debounced events during slider movement via input events. Debouncing requires the slider to be still for a period before emitting an event.
        /// </summary>
        OnInputDebounced,

        /// <summary>
        /// Emits throttled events during slider movement via input events. Throttling emits events even while the slider is moving.
        /// </summary>
        OnInputThrottled
    }


    /// <summary>
    /// A helper to determine how a <see cref="MBSelect{TItem}"/> or <see cref="MBRadioButtonGroup{TItem}"/> should handle an intial bound value not matching elements in the value list.
    /// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="Exception"/></para>
    /// </summary>
    public enum MBItemValidation
    {
        /// <summary>
        /// Sets the bound value to the first item in the list.
        /// </summary>
        DefaultToFirst,

        /// <summary>
        /// Throws an exception. This is the <see cref="MBCascadingDefaults"/> default.
        /// </summary>
        Exception,

        /// <summary>
        /// Does nothing, leaving the bound value as it is.
        /// </summary>
        NoSelection
    }


    /// <summary>
    /// Type for an <see cref="MBLinearProgress"/>.
    /// </summary>
    public enum MBLinearProgressType
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
    /// Style for an <see cref="MBList{TItem}"/>. The <see cref="Outlined"/> variety borrows card markup matching <see cref="MBCardStyle.Outlined"/>.
    /// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="None"/></para>
    /// </summary>
    public enum MBListStyle
    {
        /// <summary>
        /// No styling applied. This is the <see cref="MBCascadingDefaults"/> default.
        /// </summary>
        None,

        /// <summary>
        /// Borrows card markup matching <see cref="MBCardStyle.Outlined"/>.
        /// </summary>
        Outlined
    }


    /// <summary>
    /// Type for an <see cref="MBList{TItem}"/>.
    /// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="Regular"/></para>
    /// </summary>
    public enum MBListType
    {
        /// <summary>
        /// A regular list. This is the <see cref="MBCascadingDefaults"/> default.
        /// </summary>
        Regular,

        /// <summary>
        /// Applies the mdc-list--dense CSS class.
        /// </summary>
        Dense,

        /// <summary>
        /// Applies the mdc-list--avatar CSS class.
        /// </summary>
        Avatar
    }


    /// <summary>
    /// Determines the positioning and width of a menu surface.
    /// </summary>
    public enum MBMenuSurfacePositioning
    {
        /// <summary>
        /// Placed with display: relative. and assuming a width determined by its contents.
        /// </summary>
        Regular,


        /// <summary>
        /// Width set to match the parent anchor - incompatible with Fixed position.
        /// </summary>
        FullWidth,


        /// <summary>
        /// Places the menu with fixed positioning.
        /// </summary>
        Fixed
    }


    ///// **** Would prefer to use the following line for the summary however this fails to produce inline documentation and causes the following DocFX warning:
    ///// **** [20-07-16 02:56:26.727]Warning:[MetadataCommand.ExtractMetadata]Invalid triple slash comment is ignored: <!-- Badly formed XML comment ignored for member "T:Material.Blazor.MBNumericInputMagnitude" -->


    ///// A helper to determine the magnitude adjustment when displaying or editting values using <see cref="MBNumericDoubleField"/> and <see cref="MBNumericIntField">.
    /// <summary>
    /// A helper to determine the magnitude adjustment when displaying or editting values using numeric input fields.
    /// </summary>
    public enum MBNumericInputMagnitude
    {
        /// <summary>
        /// Normal numbers requiring no adjustment.
        /// </summary>
        Normal = 0,

        /// <summary>
        /// Percentages where the numeric input needs to multiply the value by 100 when displaying or editting (formatted display can be handled by standard percent C# formatting).
        /// </summary>
        Percent = 2,

        /// <summary>
        /// Basis points where the numeric input needs to multiply the value by 10 000 when displaying or editting (formatted display is not handled by standard percent C# formatting which lacks support for basis points).
        /// </summary>
        BasisPoints = 4
    }


    /// <summary>
    /// Material Theme select input style applied to <see cref="MBSelect{TItem}"/>.
    /// <para>Applied also to <seealso cref="MBDatePicker"/></para>
    /// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="Filled"/></para>
    /// </summary>
    public enum MBSelectInputStyle
    {
        /// <summary>
        /// The filled style. This is the <see cref="MBCascadingDefaults"/> default.
        /// </summary>
        Filled,

        /// <summary>
        /// The outlined style.
        /// </summary>
        Outlined
    }


    /// <summary>
    /// Determines whether a <see cref="MBShield"/> displays the label (left hand element), value (right hand element) or both.
    /// <para>Defaults to <see cref="LabelAndValue"/></para>
    /// </summary>
    public enum MBShieldType
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
    /// Determines the type of an <see cref="MBSlider"/>.
    /// </summary>
    public enum MBSliderType
    {
        /// <summary>
        /// Continuous value.
        /// </summary>
        Continuous,

        /// <summary>
        /// Discrete values.
        /// </summary>
        Discrete,

        /// <summary>
        /// Discrete values with tickmarks.
        /// </summary>
        DiscreteWithTickmarks
    }


    /// <summary>
    /// A helper to set the alignment of text in <see cref="MBTextField"/>, <see cref="MBTextArea"/> and <see cref="MBSelect{TItem}"/>.
    /// <para>Applied also to <seealso cref="MBAutocompleteTextField"/>, <seealso cref="MBDebouncedTextField"/>, <seealso cref="MBNumericDoubleField"/> and <seealso cref="MBNumericIntField"/></para>
    /// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="Default"/></para>
    /// </summary>
    public enum MBTextAlignStyle
    {
        /// <summary>
        /// Default - no further styling applied. This is the <see cref="MBCascadingDefaults"/> default.
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
    /// Material Theme text field and text area input style applied to <see cref="MBTextField"/> and <see cref="MBTextArea"/>.
    /// <para>Applied also to <seealso cref="MBAutocompleteTextField"/>, <seealso cref="MBDebouncedTextField"/>, <seealso cref="MBNumericDoubleField"/> and <seealso cref="MBNumericIntField"/></para>
    /// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="Filled"/></para>
    /// </summary>
    public enum MBTextInputStyle
    {
        /// <summary>
        /// The filled style (pending in Material Web Components 6.0.0 for <see cref="MBTextArea"/>). This is the <see cref="MBCascadingDefaults"/> default.
        /// </summary>
        Filled,

        /// <summary>
        /// The outlined style.
        /// </summary>
        Outlined
    }


    /// <summary>
    /// Material Theme top app bar type applied to an <see cref="MBTopAppBar"/>.
    /// </summary>
    public enum MBTopAppBarType
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
    /// Determines whether a toast notfication times out and whether it has a close button.
    /// <para>Defaults to <see cref="TimeoutAndCloseButton"/></para>
    /// </summary>
    public enum MBToastCloseMethod
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
    public enum MBToastLevel
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
    public enum MBToastPosition
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


    /// <summary>
    /// Determines the density of a component
    /// <para>Defaults to <see cref="Span"/></para>
    /// </summary>
    public enum MBTooltipType
    {
        /// <summary>
        /// Uses a &lt;span&gt; element for a tooltip - the default.
        /// </summary>
        Span,

        /// <summary>
        /// Uses a &lt;div&gt; element for a tooltip - the default.
        /// </summary>
        Div
    }
}
