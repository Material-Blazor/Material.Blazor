using System;

namespace Material.Blazor;

#region MBBadge

/// <summary>
/// Style for an <see cref="MBBadge"/>.
/// </summary>
public enum MBBadgeStyle
{
    /// <summary>
    /// Bears a numeric value.
    /// </summary> 
    ValueBearing,

    /// <summary>
    /// Blank, full sized badge.
    /// </summary> 
    BlankFullSized,

    /// <summary>
    /// Small dot badge.
    /// </summary> 
    Dot
}

#endregion

#region MBButton

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

