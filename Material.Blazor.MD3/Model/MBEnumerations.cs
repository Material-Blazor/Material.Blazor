using System;

namespace Material.Blazor;

#region MBButtonStyle

/// <summary>
/// Style for an <see cref="MBButton"/> per Material Theme styling.
/// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="Text"/></para>
/// </summary>
public enum MBButtonStyle
{
    /// <summary>
    /// Elevated style
    /// </summary> 
    Elevated,

    /// <summary>
    /// Filled style
    /// </summary> 
    Filled,

    /// <summary>
    /// FilledTonal style
    /// </summary> 
    FilledTonal,

    /// <summary>
    /// Outlined style
    /// </summary> 
    Outlined,

    /// <summary>
    /// Text style. This is the <see cref="MBCascadingDefaults"/> default.
    /// </summary>  
    Text
}

#endregion

#region MBCardStyleMD2

/// <summary>
/// Style for an <see cref="MBCard"/> per Material Theme styling.
/// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="Default"/></para>
/// </summary>
public enum MBCardStyleMD2
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

#endregion

#region MBChipType

/// <summary>
/// Material Theme chip type applied to <see cref="MBChipSet"/>.
/// </summary>
public enum MBChipType
{
    /// <summary>
    /// The assist style.
    /// </summary>
    Assist,

    /// <summary>
    /// The filter style. This is the <see cref="MBCascadingDefaults"/> default.
    /// </summary>
    Filter,

    /// <summary>
    /// The input style.
    /// </summary>
    Input,

    /// <summary>
    /// The suggestion style.
    /// </summary>
    Suggestion,

}

#endregion

#region MBDensity

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

#endregion

#region MBFloatingActionButtonSize

/// <summary>
/// Style for an <see cref="MBFloatingActionButton"/> per Material Theme styling.
/// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="Medium"/></para>
/// </summary>
public enum MBFloatingActionButtonSize
{
    /// <summary>
    /// Medium size -- This is the <see cref="MBCascadingDefaults"/> default.
    /// </summary> 
    Medium,

    /// <summary>
    /// Small size
    /// </summary>  
    Small,

    /// <summary>
    /// Large size
    /// </summary> 
    Large,
}

#endregion

#region MBFloatingActionButtonStyle

/// <summary>
/// Style for an <see cref="MBFloatingActionButton"/> per Material Theme styling.
/// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="Surface"/></para>
/// </summary>
public enum MBFloatingActionButtonStyle
{
    /// <summary>
    /// Surface style This is the <see cref="MBCascadingDefaults"/> default.
    /// </summary> 
    Surface,

    /// <summary>
    /// Primary style.
    /// </summary>  
    Primary,

    /// <summary>
    /// Secondary style
    /// </summary> 
    Secondary,

    /// <summary>
    /// Tertiary style
    /// </summary> 
    Tertiary,

    /// <summary>
    /// Branded style
    /// </summary> 
    Branded,
}

#endregion

#region MBIcon

/// <summary>
/// Determines <cref="MBIcon"/> gradient.
/// </summary>
public enum MBIconGradient
{
    LowEmphasis,
    NormalEmphasis,
    HighEmphasis
}

/// <summary>
/// Determines how an <cref="MBIcon"/> is visually styled at the gross level.
/// </summary>
public enum MBIconStyle
{
    Outlined,
    Rounded,
    Sharp
}

/// <summary>
/// Determines an <cref="MBIcon"/> size.
/// </summary>
public enum MBIconSize
{
    Size20,
    Size24,
    Size40,
    Size48,
}

/// <summary>
/// Determines an <cref="MBIcon"/> weight.
/// </summary>
public enum MBIconWeight
{
    W100,
    W200,
    W300,
    W400,
    W500,
    W600,
    W700,
}

#endregion

#region MBIconButtonStyle

/// <summary>
/// Style for an <see cref="MBIconButton"/> per Material Theme styling.
/// <para><see cref="MBCascadingDefaults"/> has a default of <see cref="Text"/></para>
/// </summary>
public enum MBIconButtonStyle
{
    /// <summary>
    /// Filled style
    /// </summary> 
    Filled,

    /// <summary>
    /// Icon style. This is the <see cref="MBCascadingDefaults"/> default.
    /// </summary>  
    Icon,

    /// <summary>
    /// FilledTonal style
    /// </summary> 
    FilledTonal,

    /// <summary>
    /// Outlined style
    /// </summary> 
    Outlined,
}

#endregion

#region MBItemValidation

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

#endregion

#region MBLoggingLevel

/// <summary>
/// Type for the level of logging performed by M.B
/// They follow the Microsoft.Logging.LogLevel definition
/// </summary>
public enum MBLoggingLevel
{
    Trace = 0,
    Debug = 1,
    Information = 2,
    Warning = 3,
    Error = 4,
    Critical = 5,
    None = 0,
}

#endregion

#region MBListItemType

/// <summary>
/// Determines the display properties of a ListItem.
/// </summary>
public enum MBListItemType
{
    /// <summary>
    /// Divider menu item
    /// </summary>
    Divider,

    /// <summary>
    /// Regular menu item.
    /// </summary>
    Regular,
}

#endregion

#region MBMenuAnchorType

/// <summary>
/// Determines the anchor of a menu.
/// </summary>
public enum MBMenuAnchorType
{
    /// <summary>
    /// Use button.
    /// </summary>
    Button,

    /// <summary>
    /// Use icon
    /// </summary>
    Icon,
}

#endregion

#region MBMenuItemType

/// <summary>
/// Determines the positioning and width of a menu surface.
/// </summary>
public enum MBMenuItemType
{
    /// <summary>
    /// Signals the beginning of a submenu.
    /// </summary>
    BeginSubMenu,

    /// <summary>
    /// Divider menu item
    /// </summary>
    Divider,

    /// <summary>
    /// Signals end of a submenu.
    /// </summary>
    EndSubMenu,

    /// <summary>
    /// Regular menu item.
    /// </summary>
    Regular,
}

#endregion

#region MBMenuPositioning

/// <summary>
/// Determines the positioning of a menu.
/// </summary>
public enum MBMenuPositioning
{
    /// <summary>
    /// Positioned at absolute location relative to the menu button.
    /// This is the default.
    /// </summary>
    Absolute,

    /// <summary>
    /// Position is relative to the document
    /// </summary>
    Document,

    /// <summary>
    /// Fixed position is relative to he document and will not scroll with underlying content
    /// </summary>
    Fixed,

    /// <summary>
    /// Popover position is on tpo of all other content
    /// </summary>
    Popover,

    /// <summary>
    /// 
    /// </summary>
    Relative
}

#endregion

#region MBMenuSurfacePositioningMD2

/// <summary>
/// Determines the positioning and width of a menu surface.
/// </summary>
public enum MBMenuSurfacePositioningMD2
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

#endregion

#region MBNotifierCloseMethod

/// <summary>
/// Determines whether a snackbar or a toast notfication times out and whether it has a dismiss button.
/// <para>Defaults to <see cref="TimeoutAndDismissButton"/></para>
/// </summary>
public enum MBNotifierCloseMethod
{
    /// <summary>
    /// Apply a timeout and show the dismiss button. This is the default.
    /// </summary>
    TimeoutAndDismissButton,

    /// <summary>
    /// Apply a timeout only.
    /// </summary>
    Timeout,

    /// <summary>
    /// Show the dismiss button only.
    /// </summary>
    DismissButton
}

#endregion

#region MBNumericInputMagnitude

/// <summary>
/// A helper to determine the magnitude adjustment when displaying or editing values using numeric input fields.
/// </summary>
public enum MBNumericInputMagnitude
{
    /// <summary>
    /// Normal numbers requiring no adjustment.
    /// </summary>
    Normal = 0,

    /// <summary>
    /// Percentages where the numeric input needs to multiply the value by 100 when displaying or editing (formatted display can be handled by standard percent C# formatting).
    /// </summary>
    Percent = 2,

    /// <summary>
    /// Basis points where the numeric input needs to multiply the value by 10 000 when displaying or editing (formatted display is not handled by standard percent C# formatting which lacks support for basis points).
    /// </summary>
    BasisPoints = 4
}

#endregion

#region MBProgress

/// <summary>
/// Stype for Progress  <see cref="MBProgress"/>.
/// </summary>
public enum MBProgressStyle
{
    /// <summary>
    /// An circular progress.
    /// </summary>
    Circular,

    /// <summary>
    /// A linear progress
    /// </summary>
    Linear
}

/// <summary>
/// Type for Progress  <see cref="MBProgress"/>.
/// </summary>
public enum MBProgressType
{
    /// <summary>
    /// An indeterminate progress.
    /// </summary>
    Indeterminate,

    /// <summary>
    /// A determinate progress with a value from 0 to 1.
    /// </summary>
    Determinate,

    /// <summary>
    /// A closed progress.
    /// </summary>
    Closed
}

#endregion

#region MBSelectInputStyle

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

#endregion

#region MBText

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
/// <para>Applied also to <see also cref="MBAutocompleteTextField"/>, <see also cref="MBDebouncedTextField"/>, <seealso cref="MBNumericDoubleField"/> and <seealso cref="MBNumericIntField"/></para>
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

#endregion

#region MBToast

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
    /// Top center, newest toasts on top.
    /// </summary>
    TopCenter,

    /// <summary>
    /// Top right, newest toasts on top.
    /// </summary>
    TopRight,

    /// <summary>
    /// Center left positioning, newest toasts on top.
    /// </summary>
    CenterLeft,

    /// <summary>
    /// Center center, newest toasts on top.
    /// </summary>
    CenterCenter,

    /// <summary>
    /// Center right, newest toasts on top.
    /// </summary>
    CenterRight,

    /// <summary>
    /// Bottom left positioning, newest toasts on the bottom.
    /// </summary>
    BottomLeft,

    /// <summary>
    /// Bottom center positioning, newest toasts on the bottom.
    /// </summary>
    BottomCenter,

    /// <summary>
    /// Bottom right positioning, newest toasts on the bottom.
    /// </summary>
    BottomRight,
}

#endregion

#region MBTopAppBarTypeMD2

/// <summary>
/// Material Theme top app bar type applied to an <see cref="MBTopAppBar"/>.
/// </summary>
[Flags]
public enum MBTopAppBarTypeMD2
{
    /// <summary>
    /// The standard variety.
    /// </summary>
    Standard = 0,

    /// <summary>
    /// The fixed variety.
    /// </summary>
    Fixed = 1 << 0,


    /// <summary>
    /// The dense variety.
    /// </summary>
    Dense = 1 << 1,

    /// <summary>
    /// The prominent variety.
    /// </summary>
    Prominent = 1 << 2,

    /// <summary>
    /// The short variety.
    /// </summary>
    Short = 1 << 3,

    /// <summary>
    /// The short collapsed variety.
    /// </summary>
    ShortCollapsed = 1 << 4
}

#endregion
