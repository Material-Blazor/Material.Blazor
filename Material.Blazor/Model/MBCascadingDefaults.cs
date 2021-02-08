using System;
using System.Collections.Generic;
using System.Linq;

namespace Material.Blazor
{
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
    public class MBCascadingDefaults
    {
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
        /// unmatched HTML attributes passed to a component. Works with <see cref="EssentialSplattableAttributes"/>
        /// and <see cref="AllowedSplattableAttributes"/>
        /// </summary>
        public bool ConstrainSplattableAttributes { get => _constrainSplattableAttributes; set => SetParameter(ref _constrainSplattableAttributes, value); }

        /// <summary>
        /// A list of unmatched attributes that are used by and therefore essential for Material.Blazor. Works with 
        /// <see cref="ConstrainSplattableAttributes"/> and <see cref="AllowedSplattableAttributes"/>.
        /// </summary>
        /// <remarks>
        /// Includes "formnovalidate", "id", "max", "min", "role", "step", "tabindex" and "type"
        /// </remarks>
        public readonly IEnumerable<string> EssentialSplattableAttributes = new string[] { "class", "style", "formnovalidate", "id", "max", "min", "role", "step", "tabindex", "type", "data-prev-page" };



        private IEnumerable<string> _allowedSplattableAttributes = Array.Empty<string>();
        /// <summary>
        /// Further attributes that can be set as allowable when <see cref="Internal.ComponentFoundation"/>
        /// performs unmatched attribute validation. Works with <see cref="ConstrainSplattableAttributes"/>
        /// and <see cref="EssentialSplattableAttributes"/>.
        /// </summary>
        public IEnumerable<string> AllowedSplattableAttributes { get => _allowedSplattableAttributes; set => SetParameter(ref _allowedSplattableAttributes, value); }

        /// <summary>
        /// An enumerable of allowable attributes formed from a distinct union of <see cref="EssentialSplattableAttributes"/>
        /// and <see cref="AllowedSplattableAttributes"/>
        /// </summary>
        internal IEnumerable<string> AppliedAllowedSplattableAttributes => EssentialSplattableAttributes.Union(AllowedSplattableAttributes.Select(x => x.ToLower())).Distinct();



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



        /*************************************************************************************************************
         * 
         * 
         *      ICON FOUNDRIES AND THEIR OPTIONAL PARAMETERS
         * 
         * 
         ************************************************************************************************************/

        private MBIconFoundryName _iconFoundryName = MBIconFoundryName.MaterialIcons;
        /// <summary>
        /// The default foundry name, initialized to <see cref="MBIconFoundryName.MaterialIcons"/> if not explicitly set.
        /// </summary>
        public MBIconFoundryName IconFoundryName { get => _iconFoundryName; set => SetParameter(ref _iconFoundryName, value); }

        /// <summary>
        /// The foundry name to apply within a Material.Blazor component.
        /// </summary>
        /// <param name="iconFoundryName">The foundry name parameter passed to the component</param>
        /// <returns>The <see cref="IconFoundryName"/> to apply.</returns>
        internal MBIconFoundryName AppliedIconFoundryName(MBIconFoundryName? iconFoundryName = null) => iconFoundryName ?? IconFoundryName;



        private MBIconMITheme _iconMITheme = MBIconMITheme.Filled;
        /// <summary>
        /// The default Material Icons theme, initialized to <see cref="MBIconMITheme.Filled"/> if not explicitly set.
        /// </summary>
        public MBIconMITheme IconMITheme { get => _iconMITheme; set => SetParameter(ref _iconMITheme, value); }

        /// <summary>
        /// The Material Icons theme to apply within a Material.Blazor component.
        /// </summary>
        /// <param name="iconMITheme">The theme parameter passed to the component</param>
        /// <returns>The <see cref="IconMITheme"/> to apply.</returns>
        internal MBIconMITheme AppliedIconMITheme(MBIconMITheme? iconMITheme = null) => iconMITheme ?? IconMITheme;



        private MBIconFAStyle _iconFAStyle = MBIconFAStyle.Solid;
        /// <summary>
        /// The default Font Awesome style, initialized to <see cref="MBIconFAStyle.Solid"/> if not explicitly set.
        /// </summary>
        public MBIconFAStyle IconFAStyle { get => _iconFAStyle; set => SetParameter(ref _iconFAStyle, value); }

        /// <summary>
        /// The Font Awesome style to apply within a Material.Blazor component.
        /// </summary>
        /// <param name="iconFAStyle">The style parameter passed to the component</param>
        /// <returns>The <see cref="IconFAStyle"/> to apply.</returns>
        internal MBIconFAStyle AppliedIconFAStyle(MBIconFAStyle? iconFAStyle = null) => iconFAStyle ?? IconFAStyle;



        private MBIconFARelativeSize _iconFARelativeSize = MBIconFARelativeSize.Regular;
        /// <summary>
        /// The default Font Awesome relative size, initialized to <see cref="MBIconFARelativeSize.Regular"/> if not explicitly set.
        /// </summary>
        public MBIconFARelativeSize IconFARelativeSize { get => _iconFARelativeSize; set => SetParameter(ref _iconFARelativeSize, value); }

        /// <summary>
        /// The Font Awesome relative size to apply within a Material.Blazor component.
        /// </summary>
        /// <param name="iconFARelativeSize">The relative size parameter passed to the component</param>
        /// <returns>The <see cref="IconFARelativeSize"/> to apply.</returns>
        internal MBIconFARelativeSize AppliedIconFARelativeSize(MBIconFARelativeSize? iconFARelativeSize = null) => iconFARelativeSize ?? IconFARelativeSize;



        /*************************************************************************************************************
         * 
         * 
         *      MDC CORE COMPONENTS
         * 
         * 
         ************************************************************************************************************/

        private bool _disabled = false;
        /// <summary>
        /// The default disabled state.
        /// </summary>
        public bool Disabled { get => _disabled; set => SetParameter(ref _disabled, value); }

        /// <summary>
        /// The disabled state to apply.
        /// </summary>
        /// <param name="disabled">The required disabled state</param>
        /// <returns>The <see cref="MBCardStyle"/> to apply.</returns>
        internal bool AppliedDisabled(bool? disabled = null) => disabled ?? Disabled;



        private MBButtonStyle _buttonStyle = MBButtonStyle.Text;
        /// <summary>
        /// The default style for an <see cref="MBButton"/>, initialized to <see cref="MBButtonStyle.Text"/> if not explicitly set.
        /// </summary>
        public MBButtonStyle ButtonStyle { get => _buttonStyle; set => SetParameter(ref _buttonStyle, value); }

        private MBButtonStyle? _cardButtonStyle = null;
        /// <summary>
        /// The default style for a card action button/<see cref="MBButton"/> in an <see cref="MBCard"/>, returns the value of <see cref="ButtonStyle"/> if not explicitly set.
        /// </summary>
        public MBButtonStyle CardActionButtonStyle { get => _cardButtonStyle ?? ButtonStyle; set => SetParameter(ref _cardButtonStyle, value); }

        private MBButtonStyle? _dialogButtonStyle = null;
        /// <summary>
        /// The default style for a dialog action button/<see cref="MBButton"/> in an <see cref="MBDialog"/>, returns the value of <see cref="ButtonStyle"/> if not explicitly set.
        /// </summary>
        public MBButtonStyle DialogActionButtonStyle { get => _dialogButtonStyle ?? ButtonStyle; set => SetParameter(ref _dialogButtonStyle, value); }

        /// <summary>
        /// The style to apply within an <see cref="MBButton"/>. <see cref="MBCard"/> and <see cref="MBDialog"/> must
        /// pass a reference to themselves (<c>this</c>) to reference the relevant default.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MBButton"/></param>
        /// <param name="card">The <see cref="MBMBButton"/>'s card reference (null if button is not in a card)</param>
        /// <param name="dialog">The <see cref="MBDialog"/>'s card reference (null if button is not in a dialog)</param>
        /// <returns>The <see cref="MBButtonStyle"/> to apply.</returns>
        internal MBButtonStyle AppliedStyle(MBButtonStyle? style, MBCard card, MBDialog dialog)
        {
            if (style != null) return (MBButtonStyle)style;
            if (card != null) return CardActionButtonStyle;
            if (dialog != null) return DialogActionButtonStyle;
            return ButtonStyle;
        }



        private MBCardStyle _cardStyle = MBCardStyle.Default;
        /// <summary>
        /// The default style for an <see cref="MBCard"/>, initialized to <see cref="MBCardStyle.Default"/> if not explicitly set.
        /// </summary>
        public MBCardStyle CardStyle { get => _cardStyle; set => SetParameter(ref _cardStyle, value); }

        /// <summary>
        /// The style to apply to an <see cref="MBCard"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MBCard"/></param>
        /// <returns>The <see cref="MBCardStyle"/> to apply.</returns>
        internal MBCardStyle AppliedStyle(MBCardStyle? style = null) => style ?? CardStyle;



        private MBListStyle _listStyle = MBListStyle.None;
        /// <summary>
        /// The default style for an <see cref="MBList{TItem}"/>, initialized to <see cref="MBListStyle.None"/> if not explicitly set.
        /// </summary>
        public MBListStyle ListStyle { get => _listStyle; set => SetParameter(ref _listStyle, value); }

        /// <summary>
        /// The style to apply to an <see cref="MBList{TItem}"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MBList{TItem}"/></param>
        /// <returns>The <see cref="MBListStyle"/> to apply.</returns>
        internal MBListStyle AppliedStyle(MBListStyle? style = null) => style ?? ListStyle;



        private MBListType _listType = MBListType.Regular;
        /// <summary>
        /// The default type for an <see cref="MBList{TItem}"/>, initialized to <see cref="MBListType.Regular"/> if not explicitly set.
        /// </summary>
        public MBListType ListType { get => _listType; set => SetParameter(ref _listType, value); }

        /// <summary>
        /// The style to apply to an <see cref="MBList{TItem}"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MBList{TItem}"/></param>
        /// <returns>The <see cref="MBListStyle"/> to apply.</returns>
        internal MBListType AppliedType(MBListType? type = null) => type ?? ListType;



        private MBSelectInputStyle _selectInputStyle = MBSelectInputStyle.Filled;
        /// <summary>
        /// The default style for an <see cref="MBSelect{TItem}"/>, initialized to <see cref="MBSelectInputStyle.Filled"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="MBDatePicker"/>.
        /// </remarks>
        public MBSelectInputStyle SelectInputStyle { get => _selectInputStyle; set => SetParameter(ref _selectInputStyle, value); }

        /// <summary>
        /// The style to apply to an <see cref="MBSelect{TItem}"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MBSelect{TItem}"/></param>
        /// <returns>The <see cref="MBSelectInputStyle"/> to apply.</returns>
        internal MBSelectInputStyle AppliedStyle(MBSelectInputStyle? style = null) => style ?? SelectInputStyle;



        private MBTextAlignStyle _textAlignStyle = MBTextAlignStyle.Default;
        /// <summary>
        /// The default text alignment style for an <see cref="MBTextField"/>, an <see cref="MBTextArea"/> or <see cref="MBSelect{TItem}"/>, initialized to <see cref="MBTextAlignStyle.Default"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="MBAutocompleteTextField"/>, <seealso cref="MBDebouncedTextField"/>, <seealso cref="MBNumericDoubleField"/> and <seealso cref="MBNumericIntField"/>.
        /// </remarks>
        public MBTextAlignStyle TextAlignStyle { get => _textAlignStyle; set => SetParameter(ref _textAlignStyle, value); }

        /// <summary>
        /// The text alignment style to apply to an <see cref="MBTextField"/>, an <see cref="MBTextArea"/> or <see cref="MBSelect{TItem}"/>.
        /// </summary>
        /// <param name="style">The text align style parameter passed to the <see cref="MBTextField"/>, <see cref="MBTextArea"/> or <see cref="MBSelect{TItem}"/></param>
        /// <returns>The <see cref="MBTextAlignStyle"/> to apply.</returns>
        internal MBTextAlignStyle AppliedStyle(MBTextAlignStyle? style = null) => style ?? TextAlignStyle;



        private MBTextInputStyle _textInputStyle = MBTextInputStyle.Filled;
        /// <summary>
        /// The default style for an <see cref="MBTextField"/> or an <see cref="MBTextArea"/>, initialized to <see cref="MBTextInputStyle.Filled"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="MBAutocompleteTextField"/>, <seealso cref="MBDebouncedTextField"/>, <seealso cref="MBNumericDoubleField"/> and <seealso cref="MBNumericIntField"/>.
        /// </remarks>
        public MBTextInputStyle TextInputStyle { get => _textInputStyle; set => SetParameter(ref _textInputStyle, value); }

        /// <summary>
        /// The text input style to apply to an <see cref="MBTextField"/> or an <see cref="MBTextArea"/>.
        /// </summary>
        /// <param name="style">The text input style parameter passed to the <see cref="MBTextField"/> or <see cref="MBTextArea"/></param>
        /// <returns>The <see cref="MBTextInputStyle"/> to apply.</returns>
        internal MBTextInputStyle AppliedStyle(MBTextInputStyle? style = null) => style ?? TextInputStyle;



        /*************************************************************************************************************
         * 
         * 
         *      PLUS COMPONENTS
         * 
         * 
         ************************************************************************************************************/

        private MBDateSelectionCriteria _dateSelectionCriteria = MBDateSelectionCriteria.AllowAll;
        /// <summary>
        /// The default date selection criteria for a <see cref="MBDatePicker"/>, initialized to <see cref="MBDateSelectionCriteria.AllowAll"/> if not explicitly set.
        /// </summary>
        public MBDateSelectionCriteria DateSelectionCriteria { get => _dateSelectionCriteria; set => SetParameter(ref _dateSelectionCriteria, value); }

        /// <summary>
        /// The date selection criteria to apply to a <see cref="MBDatePicker"/>.
        /// </summary>
        /// <param name="criteria">The criteria style parameter passed to the <see cref="MBDatePicker"/></param>
        /// <returns>The <see cref="MBDateSelectionCriteria"/> to apply.</returns>
        internal MBDateSelectionCriteria AppliedDateSelectionCriteria(MBDateSelectionCriteria? criteria = null) => criteria ?? DateSelectionCriteria;



        private int _debounceInterval = 300;
        /// <summary>
        /// The default debounce interval in milliseconds for a <see cref="MBDebouncedTextField"/>, initialized to 300 milliseconds if not explicitly set.
        /// </summary>
        public int DebounceInterval { get => _debounceInterval; set => SetParameter(ref _debounceInterval, value); }

        /// <summary>
        /// The text debounce interval in milliseconds to apply to an <see cref="MBDebouncedTextField"/>.
        /// </summary>
        /// <param name="style">The text input style parameter passed to the <see cref="MBDebouncedTextField"/></param>
        /// <returns>The interval in milliseconds to apply.</returns>
        internal int AppliedDebounceInterval(int? debounceInterval = null) => debounceInterval ?? 300;



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


        private MBDensity? _buttonDensity = null;
        /// <summary>
        /// The default density for an <see cref="MBButton"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MBDensity ButtonDensity { get => _buttonDensity ?? ThemeDensity; set => SetParameter(ref _buttonDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MBButton"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MBButton"/></param>
        /// <returns></returns>
        internal MBDensity AppliedButtonDensity(MBDensity? density) => density ?? ButtonDensity;



        private MBDensity? _checkboxDensity = null;
        /// <summary>
        /// The default density for an <see cref="MBCheckbox"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MBDensity CheckboxDensity { get => _checkboxDensity ?? ThemeDensity; set => SetParameter(ref _checkboxDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MBCheckbox"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MBCheckbox"/></param>
        /// <returns></returns>
        internal MBDensity AppliedCheckboxDensity(MBDensity? density) => density ?? CheckboxDensity;



        private MBDensity? _dataTableDensity = null;
        /// <summary>
        /// The default density for an <see cref="MBDataTable{TItem}"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MBDensity DataTableDensity { get => _dataTableDensity ?? ThemeDensity; set => SetParameter(ref _dataTableDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MBDataTable{TItem}"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MBDataTable{TItem}"/></param>
        /// <returns></returns>
        internal MBDensity AppliedDataTableDensity(MBDensity? density) => density ?? DataTableDensity;



        private MBDensity? _iconButtonDensity = null;
        /// <summary>
        /// The default density for an <see cref="MBIconButton"/> or <see cref="MBIconButtonToggle"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MBDensity IconButtonDensity { get => _iconButtonDensity ?? ThemeDensity; set => SetParameter(ref _iconButtonDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MBIconButton"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MBIconButton"/></param>
        /// <returns></returns>
        internal MBDensity AppliedIconButtonDensity(MBDensity? density) => density ?? IconButtonDensity;



        private MBDensity? _listSingleLineDensity = null;
        /// <summary>
        /// The default single line density for an <see cref="MBList{TItem}"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MBDensity ListSingleLineDensity { get => _listSingleLineDensity ?? ThemeDensity; set => SetParameter(ref _listSingleLineDensity, value); }

        /// <summary>
        /// The single density to apply to an <see cref="MBList{TItem}"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MBList{TItem}"/></param>
        /// <returns></returns>
        internal MBDensity AppliedListSingleLineDensity(MBDensity? density) => density ?? IconButtonDensity;



        private MBDensity? _radioButtonDensity = null;
        /// <summary>
        /// The default density for an <see cref="MBRadioButton{TItem}"/> or <see cref="MBRadioButtonGroup{TItem}"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MBDensity RadioButtonDensity { get => _radioButtonDensity ?? ThemeDensity; set => SetParameter(ref _radioButtonDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MBRadioButton{TItem}"/> or <see cref="MBRadioButtonGroup{TItem}"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MBRadioButton{TItem}"/></param>
        /// <returns></returns>
        internal MBDensity AppliedRadioButtonDensity(MBDensity? density) => density ?? RadioButtonDensity;



        private MBDensity? _selectDensity = null;
        /// <summary>
        /// The default density for an <see cref="MBSelect{TItem}"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MBDensity SelectDensity { get => _selectDensity ?? ThemeDensity; set => SetParameter(ref _selectDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MBSelect{TItem}"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MBSelect{TItem}"/></param>
        /// <returns></returns>
        internal MBDensity AppliedSelectDensity(MBDensity? density) => density ?? SelectDensity;



        private MBDensity? _switchDensity = null;
        /// <summary>
        /// The default density for an <see cref="MBSwitch"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MBDensity SwitchDensity { get => _switchDensity ?? ThemeDensity; set => SetParameter(ref _switchDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MBSwitch"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MBSwitch"/></param>
        /// <returns></returns>
        internal MBDensity AppliedSwitchDensity(MBDensity? density) => density ?? SwitchDensity;



        private MBDensity? _tabBarDensity = null;
        /// <summary>
        /// The default density for an <see cref="MBTabBar{TItem}"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MBDensity TabBarDensity { get => _tabBarDensity ?? ThemeDensity; set => SetParameter(ref _tabBarDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MBTabBar{TItem}"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MBTabBar{TItem}"/></param>
        /// <returns></returns>
        internal MBDensity AppliedTabBarDensity(MBDensity? density) => density ?? TabBarDensity;



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


        /// <summary>
        /// A helper class for density, returning the density CSS class to be applied plus an indicator of whether to apply the class.
        /// </summary>
        internal class DensityInfo
        {
            public bool ApplyCssClass { get; set; }
            public string CssClassName { get; set; }
        }


        /// <summary>
        /// Returns a <see cref="DensityInfo"/> object for the given density parameter.
        /// </summary>
        /// <param name="density"></param>
        /// <returns></returns>
        internal DensityInfo GetDensityCssClass(MBDensity density)
        {
            return new DensityInfo()
            {
                ApplyCssClass = density != MBDensity.Default,
                CssClassName = density switch
                {
                    MBDensity.Default => "dense-default",
                    MBDensity.Minus1 => "dense--1",
                    MBDensity.Minus2 => "dense--2",
                    MBDensity.Comfortable => "dense-comfortable",
                    MBDensity.Minus3 => "dense--3",
                    MBDensity.Compact => "dense-compact",
                    MBDensity.Minus4 => "dense--4",
                    MBDensity.Minus5 => "dense--5",
                    _ => throw new System.NotImplementedException(),
                }
            };
        }



        /*************************************************************************************************************
         * 
         * 
         *      COMPONENT DENSITY
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// Gets incremented for every property update. Use Version to force Blazor to re-render components or <c>&lt;div&gt;</c> blocks
        /// with the <c>@key</c> attribute.
        /// </summary>
        public int Version { get; private set; } = 0;



        private void SetParameter<T>(ref T privateParameter, T value)
        {
            if (!value.Equals(privateParameter))
            {
                privateParameter = value;

                Version++;
            }
        }
    }
}
