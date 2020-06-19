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
    /// a material button is <see cref="ButtonStyleEnum.Text"/>, however you can change that by setting <see cref="ButtonStyle"/>
    /// to another value and your whole application within the cascading value will change appearance. You can of course
    /// nest cascading values in the normal manner.
    /// </remarks>
    ///// <example>
    ///// <code>
    ///// '<'CascadingValue Value="defaults1"'>'
    ///// '<'/CascadingValue'>'
    ///// </code>
    ///// </example>
    public class MTCascadingDefaults
    {
        /*************************************************************************************************************
         * 
         * 
         *      ATTRIBUTE SPLATTING AND VALIDATION
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// Determines whether <see cref="ComponentBase"/> should throw an exception for invalid 
        /// unmatched HTML attributes passed to a component. Works with <see cref="EssentialSplattableAttributes"/>
        /// and <see cref="AllowedSplattableAttributes"/>
        /// </summary>
        public bool ConstrainSplattableAttributes { get; set; } = true;

        /// <summary>
        /// A list of unmatched attributes that are used by and therefore essential for BlazorMdc. Works with 
        /// <see cref="ConstrainSplattableAttributes"/> and <see cref="AllowedSplattableAttributes"/>.
        /// </summary>
        /// <remarks>
        /// Includes "formnovalidate", "id", "max", "min", "role", "step", "tabindex" and "type"
        /// </remarks>
        public readonly IEnumerable<string> EssentialSplattableAttributes = new string[] { "formnovalidate", "id", "max", "min", "role", "step", "tabindex", "type" };

        /// <summary>
        /// Further attributes that can be set as allowable when <see cref="ComponentBase"/>
        /// performs unmatched attribute validation. Works with <see cref="ConstrainSplattableAttributes"/>
        /// and <see cref="EssentialSplattableAttributes"/>.
        /// </summary>
        public IEnumerable<string> AllowedSplattableAttributes { get; set; } = Array.Empty<string>();

        /// <summary>
        /// An enumerable of allowable attributes formed from a distinct union of <see cref="EssentialSplattableAttributes"/>
        /// and <see cref="AllowedSplattableAttributes"/>
        /// </summary>
        internal IEnumerable<string> AppliedAllowedSplattableAttributes => EssentialSplattableAttributes.Union(AllowedSplattableAttributes.Select(x => x.ToLower())).Distinct();

        public ItemValidation ItemValidation { get; set; } = ItemValidation.Exception;
        internal ItemValidation AppliedItemValidationSelect(ItemValidation? criteria = null) => (criteria is null) ? ItemValidation : (ItemValidation)criteria;
        internal ItemValidation AppliedItemValidationRadioButtonGroup(ItemValidation? criteria = null) => (criteria is null) ? ItemValidation : (ItemValidation)criteria;



        /*************************************************************************************************************
         * 
         * 
         *      ICON FOUNDRIES AND THEIR OPTIONAL PARAMETERS
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// The default foundry name, initialized to <see cref="IconFoundryName.MaterialIcons"/> if not explicitly set.
        /// </summary>
        public IconFoundryName IconFoundryName { get; set; } = IconFoundryName.MaterialIcons;

        /// <summary>
        /// The foundry name to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFoundryName">The foundry name parameter passed to the component</param>
        /// <returns>The <see cref="IconFoundryName"/> to apply.</returns>
        internal IconFoundryName AppliedIconFoundryName(IconFoundryName? iconFoundryName = null) => (iconFoundryName is null) ? IconFoundryName : (IconFoundryName)iconFoundryName;


        /// <summary>
        /// The default Material Icons theme, initialized to <see cref="IconMITheme.Filled"/> if not explicitly set.
        /// </summary>
        public IconMITheme IconMITheme { get; set; } = IconMITheme.Filled;

        /// <summary>
        /// The Material Icons theme to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconMITheme">The theme parameter passed to the component</param>
        /// <returns>The <see cref="IconMITheme"/> to apply.</returns>
        internal IconMITheme AppliedIconMITheme(IconMITheme? iconMITheme = null) => (iconMITheme is null) ? IconMITheme : (IconMITheme)iconMITheme;


        /// <summary>
        /// The default Font Awesome style, initialized to <see cref="IconFAStyle.Solid"/> if not explicitly set.
        /// </summary>
        public IconFAStyle IconFAStyle { get; set; } = IconFAStyle.Solid;

        /// <summary>
        /// The Font Awesome style to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFAStyle">The style parameter passed to the component</param>
        /// <returns>The <see cref="IconFAStyle"/> to apply.</returns>
        internal IconFAStyle AppliedIconFAStyle(IconFAStyle? iconFAStyle = null) => (iconFAStyle is null) ? IconFAStyle : (IconFAStyle)iconFAStyle;

        /// <summary>
        /// The default Font Awesome relative size, initialized to <see cref="IconFARelativeSize.Regular"/> if not explicitly set.
        /// </summary>
        public IconFARelativeSize IconFARelativeSize { get; set; } = IconFARelativeSize.Regular;

        /// <summary>
        /// The Font Awesome relative size to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFARelativeSize">The relative size parameter passed to the component</param>
        /// <returns>The <see cref="IconFARelativeSize"/> to apply.</returns>
        internal IconFARelativeSize AppliedIconFARelativeSize(IconFARelativeSize? iconFARelativeSize = null) => (iconFARelativeSize is null) ? IconFARelativeSize : (IconFARelativeSize)iconFARelativeSize;



        /*************************************************************************************************************
         * 
         * 
         *      MDC CORE COMPONENTS
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// The default style for an <see cref="MdcButton"/>, initialized to <see cref="ButtonStyleEnum.Text"/> if not explicitly set.
        /// </summary>
        public ButtonStyleEnum ButtonStyle { get; set; } = ButtonStyleEnum.Text;

        /// <summary>
        /// The default style for a card action button/<see cref="MdcButton"/> in an <see cref="MdcCard"/>, initialized to <see cref="ButtonStyleEnum.Text"/> if not explicitly set.
        /// </summary>
        public ButtonStyleEnum CardActionButtonStyle { get; set; } = ButtonStyleEnum.Text;
        
        /// <summary>
        /// The default style for a dialog action button/<see cref="MdcButton"/> in an <see cref="MdcDialog"/>, initialized to <see cref="ButtonStyleEnum.Text"/> if not explicitly set.
        /// </summary>
        public ButtonStyleEnum DialogActionButtonStyle { get; set; } = ButtonStyleEnum.Text;

        /// <summary>
        /// The style to apply within an <see cref="MdcButton"/>. <see cref="MdcCard"/> and <see cref="MdcDialog"/> must
        /// pass a reference to themselves (<c>this</c>) to reference the relevant default.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcButton"/></param>
        /// <param name="card">The <see cref="MTMdcButton"/>'s card reference (null if button is not in a card)</param>
        /// <param name="dialog">The <see cref="MTDialog"/>'s card reference (null if button is not in a dialog)</param>
        /// <returns>The <see cref="ButtonStyle"/> to apply.</returns>
        internal ButtonStyleEnum AppliedStyle(ButtonStyleEnum? style, MTCard card, MTDialog dialog)
        {
            if (style != null) return (ButtonStyleEnum)style;
            if (card != null) return CardActionButtonStyle;
            if (dialog != null) return DialogActionButtonStyle;
            return ButtonStyle;
        }


        /// <summary>
        /// The default style for an <see cref="MdcCard"/>, initialized to <see cref="CardStyle.Default"/> if not explicitly set.
        /// </summary>
        public CardStyle CardStyle { get; set; } = CardStyle.Default;

        /// <summary>
        /// The style to apply to an <see cref="MdcCard"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcCard"/></param>
        /// <returns>The <see cref="CardStyle"/> to apply.</returns>
        public CardStyle AppliedStyle(CardStyle? style = null) => (style is null) ? CardStyle : (CardStyle)style;


        /// <summary>
        /// The default style for an <see cref="MdcList{TItem}"/>, initialized to <see cref="ListStyleEnum.None"/> if not explicitly set.
        /// </summary>
        public ListStyleEnum ListStyle { get; set; } = ListStyleEnum.None;

        /// <summary>
        /// The style to apply to an <see cref="MdcList{TItem}"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcList{TItem}"/></param>
        /// <returns>The <see cref="ListStyle"/> to apply.</returns>
        internal ListStyleEnum AppliedStyle(ListStyleEnum? style = null) => (style is null) ? ListStyle : (ListStyleEnum)style;


        /// <summary>
        /// The default style for an <see cref="MdcSelect{TItem}"/>, initialized to <see cref="SelectInputStyleEnum.Filled"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="PMdcDatePicker"/>.
        /// </remarks>
        public SelectInputStyleEnum SelectInputStyle { get; set; } = SelectInputStyleEnum.Filled;

        /// <summary>
        /// The style to apply to an <see cref="MdcCard"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcCard"/></param>
        /// <returns>The <see cref="CardStyle"/> to apply.</returns>
        internal SelectInputStyleEnum AppliedStyle(SelectInputStyleEnum? style = null) => (style is null) ? SelectInputStyle : (SelectInputStyleEnum)style;


        /// <summary>
        /// The default text alignment style for an <see cref="MdcTextField"/>, an <see cref="MdcTextArea"/> or <see cref="MdcSelect{TItem}"/>, initialized to <see cref="TextAlignStyle.Default"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="PMdcAutocomplete"/>, <seealso cref="PMdcDebouncedTextField"/>, <seealso cref="PMdcNumericDoubleField"/> and <seealso cref="PMdcNumericIntField"/>.
        /// </remarks>
        public TextAlignStyle TextAlignStyle { get; set; } = TextAlignStyle.Default;

        /// <summary>
        /// The text alignment style to apply to an <see cref="MdcTextField"/>, an <see cref="MdcTextArea"/> or <see cref="MdcSelect{TItem}"/>.
        /// </summary>
        /// <param name="style">The text align style parameter passed to the <see cref="MdcTextField"/>, <see cref="MdcTextArea"/> or <see cref="MdcSelect{TItem}"/></param>
        /// <returns>The <see cref="TextAlignStyle"/> to apply.</returns>
        public TextAlignStyle AppliedStyle(TextAlignStyle? style = null) => (style is null) ? TextAlignStyle : (TextAlignStyle)style;


        /// <summary>
        /// The default style for an <see cref="MdcTextField"/> or an <see cref="MdcTextArea"/>, initialized to <see cref="TextInputStyleEnum.Filled"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="PMdcAutocomplete"/>, <seealso cref="PMdcDebouncedTextField"/>, <seealso cref="PMdcNumericDoubleField"/> and <seealso cref="PMdcNumericIntField"/>.
        /// </remarks>
        public TextInputStyleEnum TextInputStyle { get; set; } = TextInputStyleEnum.Filled;

        /// <summary>
        /// The text input style to apply to an <see cref="MdcTextField"/> or an <see cref="MdcTextArea"/>.
        /// </summary>
        /// <param name="style">The text input style parameter passed to the <see cref="MdcTextField"/> or <see cref="MdcTextArea"/></param>
        /// <returns>The <see cref="TextAlignStyle"/> to apply.</returns>
        internal TextInputStyleEnum AppliedStyle(TextInputStyleEnum? style = null) => (style is null) ? TextInputStyle : (TextInputStyleEnum)style;



        /*************************************************************************************************************
         * 
         * 
         *      PLUS COMPONENTS
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// The default date selection criteria for a <see cref="PMdcDatePicker"/>, initialized to <see cref="DateSelectionCriteria.AllowAll"/> if not explicitly set.
        /// </summary>
        public DateSelectionCriteria DateSelectionCriteria { get; set; } = DateSelectionCriteria.AllowAll;

        /// <summary>
        /// The date selection criteria to apply to a <see cref="PMdcDatePicker"/>.
        /// </summary>
        /// <param name="criteria">The criteria style parameter passed to the <see cref="PMdcDatePicker"/></param>
        /// <returns>The <see cref="DateSelectionCriteria"/> to apply.</returns>
        internal DateSelectionCriteria AppliedDateSelectionCriteria(DateSelectionCriteria? criteria = null) => (criteria is null) ? DateSelectionCriteria : (DateSelectionCriteria)criteria;


        /// <summary>
        /// The default debounce interval in milliseconds for a <see cref="PMdcDebouncedTextField"/>, initialized to 300 milliseconds if not explicitly set.
        /// </summary>
        public int DebounceInterval { get; set; } = 300;

        /// <summary>
        /// The text debounce interval in milliseconds to apply to an <see cref="PMdcDebouncedTextField"/>.
        /// </summary>
        /// <param name="style">The text input style parameter passed to the <see cref="PMdcDebouncedTextField"/></param>
        /// <returns>The interval in milliseconds to apply.</returns>
        internal int AppliedDebounceInterval(int? debounceInterval = null) => (debounceInterval is null) ? 300 : (int)debounceInterval;
    }
}
