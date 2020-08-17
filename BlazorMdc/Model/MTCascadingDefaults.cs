using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorMdc
{
    /// <summary>
    /// A class to be used as a cascading value setting defaults for your application.
    /// </summary>
    /// <remarks>
    /// For example the default style for
    /// a material button is <see cref="MTButtonStyle.Text"/>, however you can change that by setting <see cref="ButtonStyle"/>
    /// to another value and your whole application within the cascading value will change appearance. You can of course
    /// nest cascading values in the normal manner. Exposes a property <see cref="Version"/> that is incremented each time another
    /// property is updated; <see cref="Version"/> can be used with an `@key(CascadingDefaults.Version)` attribute to force components
    /// to re-render when cascading defaults have updated. See <see href="https://blazormdc.com/docs/articles/CascadingDefaults.html"/>.
    /// </remarks>
    public class MTCascadingDefaults
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
        /// A list of unmatched attributes that are used by and therefore essential for BlazorMdc. Works with 
        /// <see cref="ConstrainSplattableAttributes"/> and <see cref="AllowedSplattableAttributes"/>.
        /// </summary>
        /// <remarks>
        /// Includes "formnovalidate", "id", "max", "min", "role", "step", "tabindex" and "type"
        /// </remarks>
        public readonly IEnumerable<string> EssentialSplattableAttributes = new string[] { "class", "style", "formnovalidate", "id", "max", "min", "role", "step", "tabindex", "type" };



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


        
        private MTItemValidation _itemValidation = MTItemValidation.Exception;
        /// <summary>
        /// Defines how radio button groups and selects validate mismtatch between item lists and initial value.
        /// </summary>
        public MTItemValidation ItemValidation { get => _itemValidation; set => SetParameter(ref _itemValidation, value); }

        /// <summary>
        /// The applied item validation for selects and radio button groups.
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        internal MTItemValidation AppliedItemValidation(MTItemValidation? criteria = null) => criteria ?? ItemValidation;



        /*************************************************************************************************************
         * 
         * 
         *      ICON FOUNDRIES AND THEIR OPTIONAL PARAMETERS
         * 
         * 
         ************************************************************************************************************/

        private MTIconFoundryName _iconFoundryName = MTIconFoundryName.MaterialIcons;
        /// <summary>
        /// The default foundry name, initialized to <see cref="MTIconFoundryName.MaterialIcons"/> if not explicitly set.
        /// </summary>
        public MTIconFoundryName IconFoundryName { get => _iconFoundryName; set => SetParameter(ref _iconFoundryName, value); }

        /// <summary>
        /// The foundry name to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFoundryName">The foundry name parameter passed to the component</param>
        /// <returns>The <see cref="IconFoundryName"/> to apply.</returns>
        internal MTIconFoundryName AppliedIconFoundryName(MTIconFoundryName? iconFoundryName = null) => iconFoundryName ?? IconFoundryName;



        private MTIconMITheme _iconMITheme = MTIconMITheme.Filled;
        /// <summary>
        /// The default Material Icons theme, initialized to <see cref="MTIconMITheme.Filled"/> if not explicitly set.
        /// </summary>
        public MTIconMITheme IconMITheme { get => _iconMITheme; set => SetParameter(ref _iconMITheme, value); }

        /// <summary>
        /// The Material Icons theme to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconMITheme">The theme parameter passed to the component</param>
        /// <returns>The <see cref="IconMITheme"/> to apply.</returns>
        internal MTIconMITheme AppliedIconMITheme(MTIconMITheme? iconMITheme = null) => iconMITheme ?? IconMITheme;



        private MTIconFAStyle _iconFAStyle = MTIconFAStyle.Solid;
        /// <summary>
        /// The default Font Awesome style, initialized to <see cref="MTIconFAStyle.Solid"/> if not explicitly set.
        /// </summary>
        public MTIconFAStyle IconFAStyle { get => _iconFAStyle; set => SetParameter(ref _iconFAStyle, value); }

        /// <summary>
        /// The Font Awesome style to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFAStyle">The style parameter passed to the component</param>
        /// <returns>The <see cref="IconFAStyle"/> to apply.</returns>
        internal MTIconFAStyle AppliedIconFAStyle(MTIconFAStyle? iconFAStyle = null) => iconFAStyle ?? IconFAStyle ;



        private MTIconFARelativeSize _iconFARelativeSize = MTIconFARelativeSize.Regular;
        /// <summary>
        /// The default Font Awesome relative size, initialized to <see cref="MTIconFARelativeSize.Regular"/> if not explicitly set.
        /// </summary>
        public MTIconFARelativeSize IconFARelativeSize { get => _iconFARelativeSize; set => SetParameter(ref _iconFARelativeSize, value); }

        /// <summary>
        /// The Font Awesome relative size to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFARelativeSize">The relative size parameter passed to the component</param>
        /// <returns>The <see cref="IconFARelativeSize"/> to apply.</returns>
        internal MTIconFARelativeSize AppliedIconFARelativeSize(MTIconFARelativeSize? iconFARelativeSize = null) => iconFARelativeSize ?? IconFARelativeSize;



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
        /// <returns>The <see cref="MTCardStyle"/> to apply.</returns>
        internal bool AppliedDisabled(bool? disabled = null) => disabled ?? Disabled;



        private MTButtonStyle _buttonStyle = MTButtonStyle.Text;
        /// <summary>
        /// The default style for an <see cref="MTButton"/>, initialized to <see cref="MTButtonStyle.Text"/> if not explicitly set.
        /// </summary>
        public MTButtonStyle ButtonStyle { get => _buttonStyle; set => SetParameter(ref _buttonStyle, value); }

        private MTButtonStyle? _cardButtonStyle = null;
        /// <summary>
        /// The default style for a card action button/<see cref="MTButton"/> in an <see cref="MTCard"/>, returns the value of <see cref="ButtonStyle"/> if not explicitly set.
        /// </summary>
        public MTButtonStyle CardActionButtonStyle { get => _cardButtonStyle ?? ButtonStyle; set => SetParameter(ref _cardButtonStyle, value); }

        private MTButtonStyle? _dialogButtonStyle = null;
        /// <summary>
        /// The default style for a dialog action button/<see cref="MTButton"/> in an <see cref="MTDialog"/>, returns the value of <see cref="ButtonStyle"/> if not explicitly set.
        /// </summary>
        public MTButtonStyle DialogActionButtonStyle { get => _dialogButtonStyle ?? ButtonStyle; set => SetParameter(ref _dialogButtonStyle, value); }

        /// <summary>
        /// The style to apply within an <see cref="MTButton"/>. <see cref="MTCard"/> and <see cref="MTDialog"/> must
        /// pass a reference to themselves (<c>this</c>) to reference the relevant default.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MTButton"/></param>
        /// <param name="card">The <see cref="MTMTButton"/>'s card reference (null if button is not in a card)</param>
        /// <param name="dialog">The <see cref="MTDialog"/>'s card reference (null if button is not in a dialog)</param>
        /// <returns>The <see cref="MTButtonStyle"/> to apply.</returns>
        internal MTButtonStyle AppliedStyle(MTButtonStyle? style, MTCard card, MTDialog dialog)
        {
            if (style != null) return (MTButtonStyle)style;
            if (card != null) return CardActionButtonStyle;
            if (dialog != null) return DialogActionButtonStyle;
            return ButtonStyle;
        }



        private MTCardStyle _cardStyle = MTCardStyle.Default;
        /// <summary>
        /// The default style for an <see cref="MTCard"/>, initialized to <see cref="MTCardStyle.Default"/> if not explicitly set.
        /// </summary>
        public MTCardStyle CardStyle { get => _cardStyle; set => SetParameter(ref _cardStyle, value); }

        /// <summary>
        /// The style to apply to an <see cref="MTCard"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MTCard"/></param>
        /// <returns>The <see cref="MTCardStyle"/> to apply.</returns>
        internal MTCardStyle AppliedStyle(MTCardStyle? style = null) => style ?? CardStyle;



        private MTListStyle _listStyle = MTListStyle.None;
        /// <summary>
        /// The default style for an <see cref="MTList{TItem}"/>, initialized to <see cref="MTListStyle.None"/> if not explicitly set.
        /// </summary>
        public MTListStyle ListStyle { get => _listStyle; set => SetParameter(ref _listStyle, value); }

        /// <summary>
        /// The style to apply to an <see cref="MTList{TItem}"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MTList{TItem}"/></param>
        /// <returns>The <see cref="MTListStyle"/> to apply.</returns>
        internal MTListStyle AppliedStyle(MTListStyle? style = null) => style ?? ListStyle;



        private MTListType _listType = MTListType.Regular;
        /// <summary>
        /// The default type for an <see cref="MTList{TItem}"/>, initialized to <see cref="MTListType.Regular"/> if not explicitly set.
        /// </summary>
        public MTListType ListType { get => _listType; set => SetParameter(ref _listType, value); }

        /// <summary>
        /// The style to apply to an <see cref="MTList{TItem}"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MTList{TItem}"/></param>
        /// <returns>The <see cref="MTListStyle"/> to apply.</returns>
        internal MTListType AppliedType(MTListType? type = null) => type ?? ListType;



        private MTSelectInputStyle _selectInputStyle = MTSelectInputStyle.Filled;
        /// <summary>
        /// The default style for an <see cref="MTSelect{TItem}"/>, initialized to <see cref="MTSelectInputStyle.Filled"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="MTDatePicker"/>.
        /// </remarks>
        public MTSelectInputStyle SelectInputStyle { get => _selectInputStyle; set => SetParameter(ref _selectInputStyle, value); }

        /// <summary>
        /// The style to apply to an <see cref="MTSelect{TItem}"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MTSelect{TItem}"/></param>
        /// <returns>The <see cref="MTSelectInputStyle"/> to apply.</returns>
        internal MTSelectInputStyle AppliedStyle(MTSelectInputStyle? style = null) => style ?? SelectInputStyle;



        private MTTextAlignStyle _textAlignStyle = MTTextAlignStyle.Default;
        /// <summary>
        /// The default text alignment style for an <see cref="MTTextField"/>, an <see cref="MTTextArea"/> or <see cref="MTSelect{TItem}"/>, initialized to <see cref="MTTextAlignStyle.Default"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="MTAutocomplete"/>, <seealso cref="MTDebouncedTextField"/>, <seealso cref="MTNumericDoubleField"/> and <seealso cref="MTNumericIntField"/>.
        /// </remarks>
        public MTTextAlignStyle TextAlignStyle { get => _textAlignStyle; set => SetParameter(ref _textAlignStyle, value); }

        /// <summary>
        /// The text alignment style to apply to an <see cref="MTTextField"/>, an <see cref="MTTextArea"/> or <see cref="MTSelect{TItem}"/>.
        /// </summary>
        /// <param name="style">The text align style parameter passed to the <see cref="MTTextField"/>, <see cref="MTTextArea"/> or <see cref="MTSelect{TItem}"/></param>
        /// <returns>The <see cref="MTTextAlignStyle"/> to apply.</returns>
        internal MTTextAlignStyle AppliedStyle(MTTextAlignStyle? style = null) => style ?? TextAlignStyle;



        private MTTextInputStyle _textInputStyle = MTTextInputStyle.Filled;
        /// <summary>
        /// The default style for an <see cref="MTTextField"/> or an <see cref="MTTextArea"/>, initialized to <see cref="MTTextInputStyle.Filled"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="MTAutocomplete"/>, <seealso cref="MTDebouncedTextField"/>, <seealso cref="MTNumericDoubleField"/> and <seealso cref="MTNumericIntField"/>.
        /// </remarks>
        public MTTextInputStyle TextInputStyle { get => _textInputStyle; set => SetParameter(ref _textInputStyle, value); }

        /// <summary>
        /// The text input style to apply to an <see cref="MTTextField"/> or an <see cref="MTTextArea"/>.
        /// </summary>
        /// <param name="style">The text input style parameter passed to the <see cref="MTTextField"/> or <see cref="MTTextArea"/></param>
        /// <returns>The <see cref="MTTextInputStyle"/> to apply.</returns>
        internal MTTextInputStyle AppliedStyle(MTTextInputStyle? style = null) => style ?? TextInputStyle;



        /*************************************************************************************************************
         * 
         * 
         *      PLUS COMPONENTS
         * 
         * 
         ************************************************************************************************************/

        private MTDateSelectionCriteria _dateSelectionCriteria = MTDateSelectionCriteria.AllowAll;
        /// <summary>
        /// The default date selection criteria for a <see cref="MTDatePicker"/>, initialized to <see cref="MTDateSelectionCriteria.AllowAll"/> if not explicitly set.
        /// </summary>
        public MTDateSelectionCriteria DateSelectionCriteria { get => _dateSelectionCriteria; set => SetParameter(ref _dateSelectionCriteria, value); }

        /// <summary>
        /// The date selection criteria to apply to a <see cref="MTDatePicker"/>.
        /// </summary>
        /// <param name="criteria">The criteria style parameter passed to the <see cref="MTDatePicker"/></param>
        /// <returns>The <see cref="MTDateSelectionCriteria"/> to apply.</returns>
        internal MTDateSelectionCriteria AppliedDateSelectionCriteria(MTDateSelectionCriteria? criteria = null) => criteria ?? DateSelectionCriteria;



        private int _debounceInterval = 300;
        /// <summary>
        /// The default debounce interval in milliseconds for a <see cref="MTDebouncedTextField"/>, initialized to 300 milliseconds if not explicitly set.
        /// </summary>
        public int DebounceInterval { get => _debounceInterval; set => SetParameter(ref _debounceInterval, value); }

        /// <summary>
        /// The text debounce interval in milliseconds to apply to an <see cref="MTDebouncedTextField"/>.
        /// </summary>
        /// <param name="style">The text input style parameter passed to the <see cref="MTDebouncedTextField"/></param>
        /// <returns>The interval in milliseconds to apply.</returns>
        internal int AppliedDebounceInterval(int? debounceInterval = null) => debounceInterval ?? 300;



        /*************************************************************************************************************
         * 
         * 
         *      COMPONENT DENSITY
         * 
         * 
         ************************************************************************************************************/

        private MTDensity _themeDensity = MTDensity.Default;
        /// <summary>
        /// The default density for an all components. Any individual component density that is set overrides theme density.
        /// </summary>
        public MTDensity ThemeDensity { get => _themeDensity; set => SetParameter(ref _themeDensity, value); }


        private MTDensity? _buttonDensity = null;
        /// <summary>
        /// The default density for an <see cref="MTButton"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MTDensity ButtonDensity { get => _buttonDensity ?? ThemeDensity; set => SetParameter(ref _buttonDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MTButton"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MTButton"/></param>
        /// <returns></returns>
        internal MTDensity AppliedButtonDensity(MTDensity? density) => density ?? ButtonDensity;



        private MTDensity? _checkboxDensity = null;
        /// <summary>
        /// The default density for an <see cref="MTCheckbox"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MTDensity CheckboxDensity { get => _checkboxDensity ?? ThemeDensity; set => SetParameter(ref _checkboxDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MTCheckbox"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MTCheckbox"/></param>
        /// <returns></returns>
        internal MTDensity AppliedCheckboxDensity(MTDensity? density) => density ?? CheckboxDensity;



        private MTDensity? _dataTableDensity = null;
        /// <summary>
        /// The default density for an <see cref="MTDataTable{TItem}"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MTDensity DataTableDensity { get => _dataTableDensity ?? ThemeDensity; set => SetParameter(ref _dataTableDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MTDataTable{TItem}"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MTDataTable{TItem}"/></param>
        /// <returns></returns>
        internal MTDensity AppliedDataTableDensity(MTDensity? density) => density ?? DataTableDensity;



        private MTDensity? _iconButtonDensity = null;
        /// <summary>
        /// The default density for an <see cref="MTIconButton"/> or <see cref="MTIconButtonToggle"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MTDensity IconButtonDensity { get => _iconButtonDensity ?? ThemeDensity; set => SetParameter(ref _iconButtonDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MTIconButton"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MTIconButton"/></param>
        /// <returns></returns>
        internal MTDensity AppliedIconButtonDensity(MTDensity? density) => density ?? IconButtonDensity;



        private MTDensity? _listSingleLineDensity = null;
        /// <summary>
        /// The default single line density for an <see cref="MTList{TItem}"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MTDensity ListSingleLineDensity { get => _listSingleLineDensity ?? ThemeDensity; set => SetParameter(ref _listSingleLineDensity, value); }

        /// <summary>
        /// The single density to apply to an <see cref="MTList{TItem}"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MTList{TItem}"/></param>
        /// <returns></returns>
        internal MTDensity AppliedListSingleLineDensity(MTDensity? density) => density ?? IconButtonDensity;



        private MTDensity? _radioButtonDensity = null;
        /// <summary>
        /// The default density for an <see cref="MTRadioButton{TItem}"/> or <see cref="MTRadioButtonGroup{TItem}"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MTDensity RadioButtonDensity { get => _radioButtonDensity ?? ThemeDensity; set => SetParameter(ref _radioButtonDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MTRadioButton{TItem}"/> or <see cref="MTRadioButtonGroup{TItem}"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MTRadioButton{TItem}"/></param>
        /// <returns></returns>
        internal MTDensity AppliedRadioButtonDensity(MTDensity? density) => density ?? RadioButtonDensity;



        private MTDensity? _selectDensity = null;
        /// <summary>
        /// The default density for an <see cref="MTSelect{TItem}"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MTDensity SelectDensity { get => _selectDensity ?? ThemeDensity; set => SetParameter(ref _selectDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MTSelect{TItem}"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MTSelect{TItem}"/></param>
        /// <returns></returns>
        internal MTDensity AppliedSelectDensity(MTDensity? density) => density ?? SelectDensity;



        private MTDensity? _switchDensity = null;
        /// <summary>
        /// The default density for an <see cref="MTSwitch"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MTDensity SwitchDensity { get => _switchDensity ?? ThemeDensity; set => SetParameter(ref _switchDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MTSwitch"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MTSwitch"/></param>
        /// <returns></returns>
        internal MTDensity AppliedSwitchDensity(MTDensity? density) => density ?? SwitchDensity;



        private MTDensity? _tabBarDensity = null;
        /// <summary>
        /// The default density for an <see cref="MTTabBar{TItem}"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MTDensity TabBarDensity { get => _tabBarDensity ?? ThemeDensity; set => SetParameter(ref _tabBarDensity, value); }

        /// <summary>
        /// The density to apply to an <see cref="MTTabBar{TItem}"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MTTabBar{TItem}"/></param>
        /// <returns></returns>
        internal MTDensity AppliedTabBarDensity(MTDensity? density) => density ?? TabBarDensity;



        private MTDensity? _textFieldDensity = null;
        /// <summary>
        /// The default density for an <see cref="MTTextField"/>, <see cref="MTTextArea"/>, <see cref="MTAutocomplete"/>, <see cref="MTDebouncedTextField"/>, 
        /// <see cref="MTNumericDoubleField"/> or <see cref="MTNumericIntField"/>, defaults to <see cref="ThemeDensity"/> if not explicitly set.
        /// </summary>
        public MTDensity TextFieldDensity { get => _textFieldDensity ?? ThemeDensity; set => SetParameter(ref _textFieldDensity, value); }

        /// <summary>
        /// The density to apply to an an <see cref="MTTextField"/>, <see cref="MTTextArea"/>, <see cref="MTAutocomplete"/>, <see cref="MTDebouncedTextField"/>, 
        /// <see cref="MTNumericDoubleField"/> or <see cref="MTNumericIntField"/>, initialized to <see cref="MTDensity.Default"/>.
        /// </summary>
        /// <param name="density">The density parameter passed to the <see cref="MTTextField"/></param>
        /// <returns></returns>
        internal MTDensity AppliedTextFieldDensity(MTDensity? density) => density ?? TextFieldDensity;


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
        internal DensityInfo GetDensityCssClass(MTDensity density)
        {
            return new DensityInfo()
            {
                ApplyCssClass = density != MTDensity.Default,
                CssClassName = density switch
                {
                    MTDensity.Default => "dense-default",
                    MTDensity.Minus1 => "dense--1",
                    MTDensity.Minus2 => "dense--2",
                    MTDensity.Comfortable => "dense-comfortable",
                    MTDensity.Minus3 => "dense--3",
                    MTDensity.Compact => "dense-compact",
                    MTDensity.Minus4 => "dense--4",
                    MTDensity.Minus5 => "dense--5",
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
