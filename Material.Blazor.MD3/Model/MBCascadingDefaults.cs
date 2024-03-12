using Material.Blazor.MD2;

using System.Collections.Generic;
using System.Linq;

namespace Material.Blazor;

/// <summary>
/// A class to be used as a cascading value setting defaults for your application.
/// </summary>
/// <remarks>
/// For example the default style for
/// a material button is <see cref="MBButtonStyle.Text"/>, however you can change that by setting <see cref="ButtonStyle"/>
/// to another value and your whole application within the cascading value will change appearance. You can of course
/// nest cascading values in the normal manner. Exposes a property <see cref="Version"/> that is incremented each time another
/// property is updated; <see cref="Version"/> can be used with an `@key(CascadingDefaults.Version)` attribute to force components
/// to re-render when cascading defaults have updated. See <see href="https://material-blazor.com/docs/articles/CascadingDefaults.html"/>.
/// </remarks>

// MBCascadingDefaults implements the MD3 cascading defaults
// The 'MBCascadingDefaults - MD2' region contains the cascading defaults from MD2 as comments

public class MBCascadingDefaults
{
    #region ATTRIBUTE SPLATTING AND VALIDATION

    /*************************************************************************************************************
     * 
     * 
     *      ATTRIBUTE SPLATTING AND VALIDATION
     * 
     * 
     ************************************************************************************************************/

    private bool _constrainSplattableAttributes = false;
    /// <summary>
    /// Determines whether <see cref="Internal.ComponentFoundation"/> should throw an exception for invalid 
    /// unmatched HTML attributes passed to a component.
    /// and <see cref="AllowedSplattableAttributes"/>
    /// </summary>
    public bool ConstrainSplattableAttributes { get => _constrainSplattableAttributes; set => SetParameter(ref _constrainSplattableAttributes, value); }



    private IEnumerable<string> _allowedSplattableAttributes = Enumerable.Empty<string>();
    /// <summary>
    /// Further attributes that can be set as allowable when <see cref="Internal.ComponentFoundation"/>
    /// performs unmatched attribute validation. Works with <see cref="ConstrainSplattableAttributes"/>.
    /// </summary>
    public IEnumerable<string> AllowedSplattableAttributes { get => _allowedSplattableAttributes; set => SetParameter(ref _allowedSplattableAttributes, value); }



    private MBItemValidation _itemValidation = MBItemValidation.Exception;
    /// <summary>
    /// Defines how radio button groups and selects validate mismtatch between item lists and initial value.
    /// </summary>
    public MBItemValidation ItemValidation { get => _itemValidation; set => SetParameter(ref _itemValidation, value); }

    /// <summary>
    /// The applied item validation for selects and radio button groups.
    /// </summary>
    /// <param name="criteria"></param>
    /// <returns></returns>
    internal MBItemValidation AppliedItemValidation(MBItemValidation? criteria = null) => criteria ?? ItemValidation;

    #endregion

    #region COMMON ELEMENTS - COMPONENT ACCESSIBILITY, DISABLED, VERSION

    private bool _disabled = false;
    /// <summary>
    /// The default disabled state.
    /// </summary>
    public bool Disabled { get => _disabled; set => SetParameter(ref _disabled, value); }

    /// <summary>
    /// The disabled state to apply.
    /// </summary>
    /// <param name="disabled">The required disabled state</param>
    /// <returns>The <see cref="MBCardStyleMD2"/> to apply.</returns>
    internal bool AppliedDisabled(bool? disabled = null) => disabled ?? Disabled;



    //private bool _TouchTarget = true;
    ///// <summary>
    ///// Determines whether to apply touch targets for accessibility. Defaults to true.
    ///// </summary>
    //public bool TouchTarget { get => _TouchTarget; set => SetParameter(ref _TouchTarget, value); }
    //internal bool AppliedTouchTarget(bool? touchTarget) => touchTarget ?? TouchTarget;



    /// <summary>
    /// Gets incremented for every property update. Use Version to force Blazor to re-render components or <c>&lt;div&gt;</c> blocks
    /// with the <c>@key</c> attribute.
    /// </summary>
    public int Version { get; private set; } = 0;

    #endregion

    #region MD3 CORE COMPONENTS

    /*************************************************************************************************************
     * 
     * 
     *      MD3 CORE COMPONENTS
     * 
     * 
     ************************************************************************************************************/

    #region MBButton

    private MBButtonStyle _buttonStyle = MBButtonStyle.Text;
    /// <summary>
    /// The default style for an <see cref="MBButton"/>, initialized to <see cref="MBButtonStyle.Text"/> if not explicitly set.
    /// </summary>
    public MBButtonStyle ButtonStyle { get => _buttonStyle; set => SetParameter(ref _buttonStyle, value); }
    internal MBButtonStyle AppliedButtonStyle(MBButtonStyle? buttonStyle = null) => buttonStyle ?? ButtonStyle;

    #endregion

    #region MBChipType

    private MBChipType _chipType = MBChipType.Filter;
    /// <summary>
    /// The default Type for an <see cref="MBChipSet"/>, initialized to <see cref="MBChipType.Filter"/> if not explicitly set.
    /// </summary>
    public MBChipType ChipType { get => _chipType; set => SetParameter(ref _chipType, value); }
    internal MBChipType AppliedChipType(MBChipType? chipType = null) => chipType ?? ChipType;

    #endregion

    #region MBFloatingActionButton

    private MBFloatingActionButtonSize _floatingActionButtonSize = MBFloatingActionButtonSize.Medium;
    /// <summary>
    /// The default style for an <see cref="MBFloatingActionButton"/>, initialized to <see cref="MBFloatingActionButtonSize.Medium"/> if not explicitly set.
    /// </summary>
    public MBFloatingActionButtonSize FloatingActionButtonSize { get => _floatingActionButtonSize; set => SetParameter(ref _floatingActionButtonSize, value); }
    internal MBFloatingActionButtonSize AppliedFloatingActionButtonSize(MBFloatingActionButtonSize? floatingActionButtonSize = null) => floatingActionButtonSize ?? FloatingActionButtonSize;

    private MBFloatingActionButtonStyle _floatingActionButtonStyle = MBFloatingActionButtonStyle.Surface;
    /// <summary>
    /// The default style for an <see cref="MBFloatingActionButton"/>, initialized to <see cref="MBFloatingActionButtonStyle.Surface"/> if not explicitly set.
    /// </summary>
    public MBFloatingActionButtonStyle FloatingActionButtonStyle { get => _floatingActionButtonStyle; set => SetParameter(ref _floatingActionButtonStyle, value); }
    internal MBFloatingActionButtonStyle AppliedFloatingActionButtonStyle(MBFloatingActionButtonStyle? floatingActionButtonStyle = null) => floatingActionButtonStyle ?? FloatingActionButtonStyle;

    #endregion

    #region MBIcon

    private string _iconColor = "black";
    public string IconColor { get => _iconColor; set => SetParameter(ref _iconColor, value); }
    internal string AppliedIconColor(string iconColor = null) => iconColor ?? IconColor;

    private decimal _iconFill = 1;
    public decimal IconFill { get => _iconFill; set => SetParameter(ref _iconFill, value); }
    internal decimal AppliedIconFill(decimal? iconFill = null) => iconFill ?? IconFill;

    private MBIconGradient _iconGradient = MBIconGradient.NormalEmphasis;
    public MBIconGradient IconGradient { get => _iconGradient; set => SetParameter(ref _iconGradient, value); }
    internal MBIconGradient AppliedIconGradient(MBIconGradient? iconGradient = null) => iconGradient ?? IconGradient;

    private string _iconName = "home";
    public string IconName { get => _iconName; set => SetParameter(ref _iconName, value); }
    internal string AppliedIconName(string iconName = null) => iconName ?? IconName;

    private MBIconStyle _iconStyle = MBIconStyle.Outlined;
    public MBIconStyle IconStyle { get => _iconStyle; set => SetParameter(ref _iconStyle, value); }
    internal MBIconStyle AppliedIconStyle(MBIconStyle? iconStyle = null) => iconStyle ?? IconStyle;

    private MBIconSize _iconSize = MBIconSize.Size24;
    public MBIconSize IconSize { get => _iconSize; set => SetParameter(ref _iconSize, value); }
    internal MBIconSize AppliedIconSize(MBIconSize? iconSize = null) => iconSize ?? IconSize;

    private MBIconWeight _iconWeight = MBIconWeight.W400;
    public MBIconWeight IconWeight { get => _iconWeight; set => SetParameter(ref _iconWeight, value); }
    internal MBIconWeight AppliedIconWeight(MBIconWeight? iconWeight = null) => iconWeight ?? IconWeight;

    #endregion

    #region MBIconButton

    private MBIconButtonStyle _iconButtonStyle = MBIconButtonStyle.Icon;
    /// <summary>
    /// The default style for an <see cref="MBIconButton"/>, initialized to <see cref="MBIconButtonStyle.Icon"/> if not explicitly set.
    /// </summary>
    public MBIconButtonStyle IconButtonStyle { get => _iconButtonStyle; set => SetParameter(ref _iconButtonStyle, value); }
    internal MBIconButtonStyle AppliedIconButtonStyle(MBIconButtonStyle? iconButtonStyle = null) => iconButtonStyle ?? IconButtonStyle;

    #endregion

    #region MBSelect

    private MBSelectInputStyle _selectInputStyle = MBSelectInputStyle.Outlined;
    /// <summary>
    /// The default text input style for an <see cref="MBSelect"/>.
    /// </summary>
    /// <remarks>
    /// Also applied to <seealso cref="MBAutocompletePagedField{TItem}"/>,  <seealso cref="MBAutocompleteSelectField{TItem}"/>,  <seealso cref="MBAutocompleteSelectField"/>, <seealso cref="MBDebouncedSelectField"/>, <seealso cref="MBNumericDoubleField"/> and <seealso cref="MBNumericIntField"/>.
    /// </remarks>
    public MBSelectInputStyle SelectInputStyle { get => _selectInputStyle; set => SetParameter(ref _selectInputStyle, value); }

    /// <summary>
    /// The text input style to apply to an <see cref="MBSelectField"/>, an <see cref="MBSelectArea"/> or <see cref="MBSelect{TItem}"/>.
    /// </summary>
    /// <param name="style">The text Input style parameter passed to the <see cref="MBSelectField"/>, <see cref="MBSelectArea"/> or <see cref="MBSelect{TItem}"/></param>
    /// <returns>The <see cref="MBSelectInputStyle"/> to apply.</returns>
    internal MBSelectInputStyle AppliedStyle(MBSelectInputStyle? style = null) => style ?? SelectInputStyle;

    #endregion

    #region MBSwitch

    private bool _switchIcons = false;
    /// <summary>
    /// The default for whether <see cref="MBSwitch"/>, displays icons.
    /// </summary>
    public bool SwitchIcons { get => _switchIcons; set => SetParameter(ref _switchIcons, value); }

    /// <summary>
    /// The value to apply to an <see cref="MBSwitch"/>.
    /// </summary>
    /// <param name="style">The style parameter passed to the <see cref="MBSelect{TItem}"/></param>
    /// <returns>The <see cref="MBSelectInputStyleMD2"/> to apply.</returns>
    internal bool AppliedSwitchIcons(bool? icons = null) => icons ?? SwitchIcons;



    private bool _switchShowOnlySelectedIcon = false;
    /// <summary>
    /// The default for whether <see cref="MBSwitch"/>, displays only the selected icon.
    /// </summary>
    public bool SwitchShowOnlySelectedIcon { get => _switchShowOnlySelectedIcon; set => SetParameter(ref _switchShowOnlySelectedIcon, value); }

    /// <summary>
    /// The value to apply to an <see cref="MBSwitch"/>.
    /// </summary>
    /// <param name="style">The style parameter passed to the <see cref="MBSelect{TItem}"/></param>
    /// <returns>The <see cref="MBSelectInputStyleMD2"/> to apply.</returns>
    internal bool AppliedSwitchSwitchShowOnlySelectedIcon(bool? switchShowOnlySelectedIcon = null) => switchShowOnlySelectedIcon ?? SwitchShowOnlySelectedIcon;

    #endregion

    #region MBText

    private MBTextAlignStyle _textAlignStyle = MBTextAlignStyle.Default;
    /// <summary>
    /// The default text alignment style for an <see cref="MBTextField"/>, an <see cref="MBTextArea"/> or <see cref="MBSelect{TItem}"/>, initialized to <see cref="MBTextAlignStyle.Default"/> if not explicitly set.
    /// </summary>
    /// <remarks>
    /// Also applied to <seealso cref="MBAutocompletePagedField{TItem}"/>,  <seealso cref="MBAutocompleteSelectField{TItem}"/>,  <seealso cref="MBAutocompleteTextField"/>, <seealso cref="MBDebouncedTextField"/>, <seealso cref="MBNumericDoubleField"/> and <seealso cref="MBNumericIntField"/>.
    /// </remarks>
    public MBTextAlignStyle TextAlignStyle { get => _textAlignStyle; set => SetParameter(ref _textAlignStyle, value); }

    /// <summary>
    /// The text alignment style to apply to an <see cref="MBTextField"/>, an <see cref="MBTextArea"/> or <see cref="MBSelect{TItem}"/>.
    /// </summary>
    /// <param name="style">The text align style parameter passed to the <see cref="MBTextField"/>, <see cref="MBTextArea"/> or <see cref="MBSelect{TItem}"/></param>
    /// <returns>The <see cref="MBTextAlignStyle"/> to apply.</returns>
    internal MBTextAlignStyle AppliedStyle(MBTextAlignStyle? style = null) => style ?? TextAlignStyle;


    private MBDensity? _textFieldDensity = null;
    /// <summary>
    /// The default density for an <see cref="MBTextField"/>, <see cref="MBTextArea"/>, <see cref="MBAutocompleteTextField"/>, <see cref="MBDebouncedTextField"/>, 
    /// <see cref="MBNumericDoubleField"/> or <see cref="MBNumericIntField"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
    /// </summary>
    public MBDensity TextFieldDensity { get => _textFieldDensity ?? ThemeDensity; set => SetParameter(ref _textFieldDensity, value); }

    /// <summary>
    /// The density to apply to an an <see cref="MBTextField"/>, <see cref="MBTextArea"/>, <see cref="MBAutocompleteTextField"/>, <see cref="MBDebouncedTextField"/>, 
    /// <see cref="MBNumericDoubleField"/> or <see cref="MBNumericIntField"/>, initialized to <see cref="MBDensity.Default"/>.
    /// </summary>
    /// <param name="density">The density parameter passed to the <see cref="MBTextField"/></param>
    /// <returns></returns>
    internal MBDensity AppliedTextFieldDensity(MBDensity? density) => density ?? TextFieldDensity;


    private MBTextInputStyle _textInputStyle = MBTextInputStyle.Outlined;
    /// <summary>
    /// The default text input style for an <see cref="MBTextField"/>, an <see cref="MBTextArea"/> or <see cref="MBSelect{TItem}"/>, initialized to <see cref="MBTextInputStyle.Default"/> if not explicitly set.
    /// </summary>
    /// <remarks>
    /// Also applied to <seealso cref="MBAutocompletePagedField{TItem}"/>,  <seealso cref="MBAutocompleteSelectField{TItem}"/>,  <seealso cref="MBAutocompleteTextField"/>, <seealso cref="MBDebouncedTextField"/>, <seealso cref="MBNumericDoubleField"/> and <seealso cref="MBNumericIntField"/>.
    /// </remarks>
    public MBTextInputStyle TextInputStyle { get => _textInputStyle; set => SetParameter(ref _textInputStyle, value); }

    /// <summary>
    /// The text input style to apply to an <see cref="MBTextField"/>, an <see cref="MBTextArea"/> or <see cref="MBSelect{TItem}"/>.
    /// </summary>
    /// <param name="style">The text Input style parameter passed to the <see cref="MBTextField"/>, <see cref="MBTextArea"/> or <see cref="MBSelect{TItem}"/></param>
    /// <returns>The <see cref="MBTextInputStyle"/> to apply.</returns>
    internal MBTextInputStyle AppliedStyle(MBTextInputStyle? style = null) => style ?? TextInputStyle;

    #endregion

    #endregion

    #region PLUS COMPONENTS

    /*************************************************************************************************************
     * 
     * 
     *      PLUS COMPONENTS
     * 
     * 
     ************************************************************************************************************/

    #endregion

    /*************************************************************************************************************
    * 
    * 
    *      COMPONENT DENSITY
    * 
    * 
    ************************************************************************************************************/

    private MBDensity _themeDensity = MBDensity.Default;
    /// <summary>
    /// The default density for an all components. Any individual component density that is set overrides theme density.
    /// </summary>
    public MBDensity ThemeDensity { get => _themeDensity; set => SetParameter(ref _themeDensity, value); }


    #region SetParameter<T>

    private void SetParameter<T>(ref T privateParameter, T value)
    {
        if (!value.Equals(privateParameter))
        {
            privateParameter = value;

            Version++;
        }
    }

    #endregion
}
