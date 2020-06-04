using System;
using System.Collections.Generic;
using System.Linq;

namespace BMdcModel
{
    /// <summary>
    /// A class to be used as a cascading value setting defaults for your application.
    /// </summary>
    /// <remarks>
    /// For example the default style for
    /// a material button is <see cref="EButtonStyle.Text"/>, however you can change that by setting <see cref="ButtonStyle"/>
    /// to another value and your whole application within the cascading value will change appearance. You can of course
    /// nest cascading values in the normal manner.
    /// </remarks>
    ///// <example>
    ///// <code>
    ///// '<'CascadingValue Value="defaults1"'>'
    ///// '<'/CascadingValue'>'
    ///// </code>
    ///// </example>
    public class CascadingDefaults
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

        public EItemValidation ItemValidation { get; set; } = EItemValidation.Exception;
        internal EItemValidation AppliedItemValidationSelect(EItemValidation? criteria = null) => (criteria is null) ? ItemValidation : (EItemValidation)criteria;
        internal EItemValidation AppliedItemValidationRadioButtonGroup(EItemValidation? criteria = null) => (criteria is null) ? ItemValidation : (EItemValidation)criteria;



        /*************************************************************************************************************
         * 
         * 
         *      ICON FOUNDRIES AND THEIR OPTIONAL PARAMETERS
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// The default foundry name, initialized to <see cref="EIconFoundryName.MaterialIcons"/> if not explicitly set.
        /// </summary>
        public EIconFoundryName IconFoundryName { get; set; } = EIconFoundryName.MaterialIcons;

        /// <summary>
        /// The foundry name to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFoundryName">The foundry name parameter passed to the component</param>
        /// <returns>The <see cref="IconFoundryName"/> to apply.</returns>
        internal EIconFoundryName AppliedIconFoundryName(EIconFoundryName? iconFoundryName = null) => (iconFoundryName is null) ? IconFoundryName : (EIconFoundryName)iconFoundryName;


        /// <summary>
        /// The default Material Icons theme, initialized to <see cref="EIconMITheme.Filled"/> if not explicitly set.
        /// </summary>
        public EIconMITheme IconMITheme { get; set; } = EIconMITheme.Filled;

        /// <summary>
        /// The Material Icons theme to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconMITheme">The theme parameter passed to the component</param>
        /// <returns>The <see cref="IconMITheme"/> to apply.</returns>
        internal EIconMITheme AppliedIconMITheme(EIconMITheme? iconMITheme = null) => (iconMITheme is null) ? IconMITheme : (EIconMITheme)iconMITheme;


        /// <summary>
        /// The default Font Awesome style, initialized to <see cref="EIconFAStyle.Solid"/> if not explicitly set.
        /// </summary>
        public EIconFAStyle IconFAStyle { get; set; } = EIconFAStyle.Solid;

        /// <summary>
        /// The Font Awesome style to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFAStyle">The style parameter passed to the component</param>
        /// <returns>The <see cref="IconFAStyle"/> to apply.</returns>
        internal EIconFAStyle AppliedIconFAStyle(EIconFAStyle? iconFAStyle = null) => (iconFAStyle is null) ? IconFAStyle : (EIconFAStyle)iconFAStyle;

        /// <summary>
        /// The default Font Awesome relative size, initialized to <see cref="EIconFARelativeSize.Regular"/> if not explicitly set.
        /// </summary>
        public EIconFARelativeSize IconFARelativeSize { get; set; } = EIconFARelativeSize.Regular;

        /// <summary>
        /// The Font Awesome relative size to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFARelativeSize">The relative size parameter passed to the component</param>
        /// <returns>The <see cref="IconFARelativeSize"/> to apply.</returns>
        internal EIconFARelativeSize AppliedIconFARelativeSize(EIconFARelativeSize? iconFARelativeSize = null) => (iconFARelativeSize is null) ? IconFARelativeSize : (EIconFARelativeSize)iconFARelativeSize;



        /*************************************************************************************************************
         * 
         * 
         *      MDC CORE COMPONENTS
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// The default style for an <see cref="MdcButton"/>, initialized to <see cref="EButtonStyle.Text"/> if not explicitly set.
        /// </summary>
        public EButtonStyle ButtonStyle { get; set; } = EButtonStyle.Text;

        /// <summary>
        /// The default style for a card action button/<see cref="MdcButton"/> in an <see cref="MdcCard"/>, initialized to <see cref="EButtonStyle.Text"/> if not explicitly set.
        /// </summary>
        public EButtonStyle CardActionButtonStyle { get; set; } = EButtonStyle.Text;
        
        /// <summary>
        /// The default style for a dialog action button/<see cref="MdcButton"/> in an <see cref="MdcDialog"/>, initialized to <see cref="EButtonStyle.Text"/> if not explicitly set.
        /// </summary>
        public EButtonStyle DialogActionButtonStyle { get; set; } = EButtonStyle.Text;

        /// <summary>
        /// The style to apply within an <see cref="MdcButton"/>. <see cref="MdcCard"/> and <see cref="MdcDialog"/> must
        /// pass a reference to themselves (<c>this</c>) to reference the relevant default.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcButton"/></param>
        /// <param name="card">The <see cref="BMdc.MdcButton"/>'s card reference (null if button is not in a card)</param>
        /// <param name="dialog">The <see cref="BMdc.Dialog"/>'s card reference (null if button is not in a dialog)</param>
        /// <returns>The <see cref="ButtonStyle"/> to apply.</returns>
        internal EButtonStyle AppliedStyle(EButtonStyle? style, BMdc.Card card, BMdc.Dialog dialog)
        {
            if (style != null) return (EButtonStyle)style;
            if (card != null) return CardActionButtonStyle;
            if (dialog != null) return DialogActionButtonStyle;
            return ButtonStyle;
        }


        /// <summary>
        /// The default style for an <see cref="MdcCard"/>, initialized to <see cref="ECardStyle.Default"/> if not explicitly set.
        /// </summary>
        public ECardStyle CardStyle { get; set; } = ECardStyle.Default;

        /// <summary>
        /// The style to apply to an <see cref="MdcCard"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcCard"/></param>
        /// <returns>The <see cref="CardStyle"/> to apply.</returns>
        public ECardStyle AppliedStyle(ECardStyle? style = null) => (style is null) ? CardStyle : (ECardStyle)style;


        /// <summary>
        /// The default style for an <see cref="MdcList{TItem}"/>, initialized to <see cref="EListStyle.None"/> if not explicitly set.
        /// </summary>
        public EListStyle ListStyle { get; set; } = EListStyle.None;

        /// <summary>
        /// The style to apply to an <see cref="MdcList{TItem}"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcList{TItem}"/></param>
        /// <returns>The <see cref="ListStyle"/> to apply.</returns>
        internal EListStyle AppliedStyle(EListStyle? style = null) => (style is null) ? ListStyle : (EListStyle)style;


        /// <summary>
        /// The default style for an <see cref="MdcSelect{TItem}"/>, initialized to <see cref="ESelectInputStyle.Filled"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="PMdcDatePicker"/>.
        /// </remarks>
        public ESelectInputStyle SelectInputStyle { get; set; } = ESelectInputStyle.Filled;

        /// <summary>
        /// The style to apply to an <see cref="MdcCard"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcCard"/></param>
        /// <returns>The <see cref="CardStyle"/> to apply.</returns>
        internal ESelectInputStyle AppliedStyle(ESelectInputStyle? style = null) => (style is null) ? SelectInputStyle : (ESelectInputStyle)style;


        /// <summary>
        /// The default text alignment style for an <see cref="MdcTextField"/>, an <see cref="MdcTextArea"/> or <see cref="MdcSelect{TItem}"/>, initialized to <see cref="ETextAlignStyle.Default"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="PMdcAutocomplete"/>, <seealso cref="PMdcDebouncedTextField"/>, <seealso cref="PMdcNumericDoubleField"/> and <seealso cref="PMdcNumericIntField"/>.
        /// </remarks>
        public ETextAlignStyle TextAlignStyle { get; set; } = ETextAlignStyle.Default;

        /// <summary>
        /// The text alignment style to apply to an <see cref="MdcTextField"/>, an <see cref="MdcTextArea"/> or <see cref="MdcSelect{TItem}"/>.
        /// </summary>
        /// <param name="style">The text align style parameter passed to the <see cref="MdcTextField"/>, <see cref="MdcTextArea"/> or <see cref="MdcSelect{TItem}"/></param>
        /// <returns>The <see cref="TextAlignStyle"/> to apply.</returns>
        public ETextAlignStyle AppliedStyle(ETextAlignStyle? style = null) => (style is null) ? TextAlignStyle : (ETextAlignStyle)style;


        /// <summary>
        /// The default style for an <see cref="MdcTextField"/> or an <see cref="MdcTextArea"/>, initialized to <see cref="ETextInputStyle.Filled"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="PMdcAutocomplete"/>, <seealso cref="PMdcDebouncedTextField"/>, <seealso cref="PMdcNumericDoubleField"/> and <seealso cref="PMdcNumericIntField"/>.
        /// </remarks>
        public ETextInputStyle TextInputStyle { get; set; } = ETextInputStyle.Filled;

        /// <summary>
        /// The text input style to apply to an <see cref="MdcTextField"/> or an <see cref="MdcTextArea"/>.
        /// </summary>
        /// <param name="style">The text input style parameter passed to the <see cref="MdcTextField"/> or <see cref="MdcTextArea"/></param>
        /// <returns>The <see cref="TextAlignStyle"/> to apply.</returns>
        internal ETextInputStyle AppliedStyle(ETextInputStyle? style = null) => (style is null) ? TextInputStyle : (ETextInputStyle)style;



        /*************************************************************************************************************
         * 
         * 
         *      PLUS COMPONENTS
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// The default date selection criteria for a <see cref="PMdcDatePicker"/>, initialized to <see cref="EDateSelectionCriteria.AllowAll"/> if not explicitly set.
        /// </summary>
        public EDateSelectionCriteria DateSelectionCriteria { get; set; } = EDateSelectionCriteria.AllowAll;

        /// <summary>
        /// The date selection criteria to apply to a <see cref="PMdcDatePicker"/>.
        /// </summary>
        /// <param name="criteria">The criteria style parameter passed to the <see cref="PMdcDatePicker"/></param>
        /// <returns>The <see cref="DateSelectionCriteria"/> to apply.</returns>
        internal EDateSelectionCriteria AppliedDateSelectionCriteria(EDateSelectionCriteria? criteria = null) => (criteria is null) ? DateSelectionCriteria : (EDateSelectionCriteria)criteria;


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
