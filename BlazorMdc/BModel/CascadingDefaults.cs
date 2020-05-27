using System;
using System.Collections.Generic;
using System.Linq;

namespace BModel
{
    /// <summary>
    /// A class to be used as a cascading value setting defaults for your application.
    /// </summary>
    /// <remarks>
    /// For example the default style for
    /// a material button is <see cref="BEnum.ButtonStyle.Text"/>, however you can change that by setting <see cref="ButtonStyle"/>
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
        /// Determines whether <see cref="MdcComponentBase"/> should throw an exception for invalid 
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
        /// Further attributes that can be set as allowable when <see cref="MdcComponentBase"/>
        /// performs unmatched attribute validation. Works with <see cref="ConstrainSplattableAttributes"/>
        /// and <see cref="EssentialSplattableAttributes"/>.
        /// </summary>
        public IEnumerable<string> AllowedSplattableAttributes { get; set; } = Array.Empty<string>();

        /// <summary>
        /// An enumerable of allowable attributes formed from a distinct union of <see cref="EssentialSplattableAttributes"/>
        /// and <see cref="AllowedSplattableAttributes"/>
        /// </summary>
        internal IEnumerable<string> AppliedAllowedSplattableAttributes => EssentialSplattableAttributes.Union(AllowedSplattableAttributes.Select(x => x.ToLower())).Distinct();

        public BEnum.ItemValidation ItemValidation { get; set; } = BEnum.ItemValidation.Exception;
        internal BEnum.ItemValidation AppliedItemValidationSelect(BEnum.ItemValidation? criteria = null) => (criteria is null) ? ItemValidation : (BEnum.ItemValidation)criteria;
        internal BEnum.ItemValidation AppliedItemValidationRadioButtonGroup(BEnum.ItemValidation? criteria = null) => (criteria is null) ? ItemValidation : (BEnum.ItemValidation)criteria;



        /*************************************************************************************************************
         * 
         * 
         *      ICON FOUNDRIES AND THEIR OPTIONAL PARAMETERS
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// The default foundry name, initialized to <see cref="BEnum.IconFoundryName.MaterialIcons"/> if not explicitly set.
        /// </summary>
        public BEnum.IconFoundryName IconFoundryName { get; set; } = BEnum.IconFoundryName.MaterialIcons;

        /// <summary>
        /// The foundry name to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFoundryName">The foundry name parameter passed to the component</param>
        /// <returns>The <see cref="BEnum.IconFoundryName"/> to apply.</returns>
        internal BEnum.IconFoundryName AppliedIconFoundryName(BEnum.IconFoundryName? iconFoundryName = null) => (iconFoundryName is null) ? IconFoundryName : (BEnum.IconFoundryName)iconFoundryName;


        /// <summary>
        /// The default Material Icons theme, initialized to <see cref="BEnum.IconMITheme.Filled"/> if not explicitly set.
        /// </summary>
        public BEnum.IconMITheme IconMITheme { get; set; } = BEnum.IconMITheme.Filled;

        /// <summary>
        /// The Material Icons theme to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconMITheme">The theme parameter passed to the component</param>
        /// <returns>The <see cref="BEnum.IconMITheme"/> to apply.</returns>
        internal BEnum.IconMITheme AppliedIconMITheme(BEnum.IconMITheme? iconMITheme = null) => (iconMITheme is null) ? IconMITheme : (BEnum.IconMITheme)iconMITheme;


        /// <summary>
        /// The default Font Awesome style, initialized to <see cref="BEnum.IconFAStyle.Solid"/> if not explicitly set.
        /// </summary>
        public BEnum.IconFAStyle IconFAStyle { get; set; } = BEnum.IconFAStyle.Solid;

        /// <summary>
        /// The Font Awesome style to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFAStyle">The style parameter passed to the component</param>
        /// <returns>The <see cref="BEnum.IconFAStyle"/> to apply.</returns>
        internal BEnum.IconFAStyle AppliedIconFAStyle(BEnum.IconFAStyle? iconFAStyle = null) => (iconFAStyle is null) ? IconFAStyle : (BEnum.IconFAStyle)iconFAStyle;

        /// <summary>
        /// The default Font Awesome relative size, initialized to <see cref="BEnum.IconFARelativeSize.Regular"/> if not explicitly set.
        /// </summary>
        public BEnum.IconFARelativeSize IconFARelativeSize { get; set; } = BEnum.IconFARelativeSize.Regular;

        /// <summary>
        /// The Font Awesome relative size to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFARelativeSize">The relative size parameter passed to the component</param>
        /// <returns>The <see cref="BEnum.IconFARelativeSize"/> to apply.</returns>
        internal BEnum.IconFARelativeSize AppliedIconFARelativeSize(BEnum.IconFARelativeSize? iconFARelativeSize = null) => (iconFARelativeSize is null) ? IconFARelativeSize : (BEnum.IconFARelativeSize)iconFARelativeSize;



        /*************************************************************************************************************
         * 
         * 
         *      MDC CORE COMPONENTS
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// The default style for an <see cref="MdcButton"/>, initialized to <see cref="BEnum.ButtonStyle.Text"/> if not explicitly set.
        /// </summary>
        public BEnum.ButtonStyle ButtonStyle { get; set; } = BEnum.ButtonStyle.Text;

        /// <summary>
        /// The default style for a card action button/<see cref="MdcButton"/> in an <see cref="MdcCard"/>, initialized to <see cref="BEnum.ButtonStyle.Text"/> if not explicitly set.
        /// </summary>
        public BEnum.ButtonStyle CardActionButtonStyle { get; set; } = BEnum.ButtonStyle.Text;
        
        /// <summary>
        /// The default style for a dialog action button/<see cref="MdcButton"/> in an <see cref="MdcDialog"/>, initialized to <see cref="BEnum.ButtonStyle.Text"/> if not explicitly set.
        /// </summary>
        public BEnum.ButtonStyle DialogActionButtonStyle { get; set; } = BEnum.ButtonStyle.Text;

        /// <summary>
        /// The style to apply within an <see cref="MdcButton"/>. <see cref="MdcCard"/> and <see cref="MdcDialog"/> must
        /// pass a reference to themselves (<c>this</c>) to reference the relevant default.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcButton"/></param>
        /// <param name="card">The <see cref="BlazorMdc.MdcButton"/>'s card reference (null if button is not in a card)</param>
        /// <param name="dialog">The <see cref="BlazorMdc.MdcDialog"/>'s card reference (null if button is not in a dialog)</param>
        /// <returns>The <see cref="BEnum.ButtonStyle"/> to apply.</returns>
        internal BEnum.ButtonStyle AppliedStyle(BEnum.ButtonStyle? style, BlazorMdc.MdcCard card, BlazorMdc.MdcDialog dialog)
        {
            if (style != null) return (BEnum.ButtonStyle)style;
            if (card != null) return CardActionButtonStyle;
            if (dialog != null) return DialogActionButtonStyle;
            return ButtonStyle;
        }


        /// <summary>
        /// The default style for an <see cref="MdcCard"/>, initialized to <see cref="BEnum.CardStyle.Default"/> if not explicitly set.
        /// </summary>
        public BEnum.CardStyle CardStyle { get; set; } = BEnum.CardStyle.Default;

        /// <summary>
        /// The style to apply to an <see cref="MdcCard"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcCard"/></param>
        /// <returns>The <see cref="BEnum.CardStyle"/> to apply.</returns>
        public BEnum.CardStyle AppliedStyle(BEnum.CardStyle? style = null) => (style is null) ? CardStyle : (BEnum.CardStyle)style;


        /// <summary>
        /// The default style for an <see cref="MdcList{TItem}"/>, initialized to <see cref="BEnum.ListStyle.None"/> if not explicitly set.
        /// </summary>
        public BEnum.ListStyle ListStyle { get; set; } = BEnum.ListStyle.None;

        /// <summary>
        /// The style to apply to an <see cref="MdcList{TItem}"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcList{TItem}"/></param>
        /// <returns>The <see cref="BEnum.ListStyle"/> to apply.</returns>
        internal BEnum.ListStyle AppliedStyle(BEnum.ListStyle? style = null) => (style is null) ? ListStyle : (BEnum.ListStyle)style;


        /// <summary>
        /// The default style for an <see cref="MdcSelect{TItem}"/>, initialized to <see cref="BEnum.SelectInputStyle.Filled"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="PMdcDatePicker"/>.
        /// </remarks>
        public BEnum.SelectInputStyle SelectInputStyle { get; set; } = BEnum.SelectInputStyle.Filled;

        /// <summary>
        /// The style to apply to an <see cref="MdcCard"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcCard"/></param>
        /// <returns>The <see cref="BEnum.CardStyle"/> to apply.</returns>
        internal BEnum.SelectInputStyle AppliedStyle(BEnum.SelectInputStyle? style = null) => (style is null) ? SelectInputStyle : (BEnum.SelectInputStyle)style;


        /// <summary>
        /// The default text alignment style for an <see cref="MdcTextField"/>, an <see cref="MdcTextArea"/> or <see cref="MdcSelect{TItem}"/>, initialized to <see cref="BEnum.TextAlignStyle.Default"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="PMdcAutocomplete"/>, <seealso cref="PMdcDebouncedTextField"/>, <seealso cref="PMdcNumericDoubleField"/> and <seealso cref="PMdcNumericIntField"/>.
        /// </remarks>
        public BEnum.TextAlignStyle TextAlignStyle { get; set; } = BEnum.TextAlignStyle.Default;

        /// <summary>
        /// The text alignment style to apply to an <see cref="MdcTextField"/>, an <see cref="MdcTextArea"/> or <see cref="MdcSelect{TItem}"/>.
        /// </summary>
        /// <param name="style">The text align style parameter passed to the <see cref="MdcTextField"/>, <see cref="MdcTextArea"/> or <see cref="MdcSelect{TItem}"/></param>
        /// <returns>The <see cref="BEnum.TextAlignStyle"/> to apply.</returns>
        public BEnum.TextAlignStyle AppliedStyle(BEnum.TextAlignStyle? style = null) => (style is null) ? TextAlignStyle : (BEnum.TextAlignStyle)style;


        /// <summary>
        /// The default style for an <see cref="MdcTextField"/> or an <see cref="MdcTextArea"/>, initialized to <see cref="BEnum.TextInputStyle.Filled"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="PMdcAutocomplete"/>, <seealso cref="PMdcDebouncedTextField"/>, <seealso cref="PMdcNumericDoubleField"/> and <seealso cref="PMdcNumericIntField"/>.
        /// </remarks>
        public BEnum.TextInputStyle TextInputStyle { get; set; } = BEnum.TextInputStyle.Filled;

        /// <summary>
        /// The text input style to apply to an <see cref="MdcTextField"/> or an <see cref="MdcTextArea"/>.
        /// </summary>
        /// <param name="style">The text input style parameter passed to the <see cref="MdcTextField"/> or <see cref="MdcTextArea"/></param>
        /// <returns>The <see cref="BEnum.TextAlignStyle"/> to apply.</returns>
        internal BEnum.TextInputStyle AppliedStyle(BEnum.TextInputStyle? style = null) => (style is null) ? TextInputStyle : (BEnum.TextInputStyle)style;



        /*************************************************************************************************************
         * 
         * 
         *      PLUS COMPONENTS
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// The default date selection criteria for a <see cref="PMdcDatePicker"/>, initialized to <see cref="BEnum.DateSelectionCriteria.AllowAll"/> if not explicitly set.
        /// </summary>
        public BEnum.DateSelectionCriteria DateSelectionCriteria { get; set; } = BEnum.DateSelectionCriteria.AllowAll;

        /// <summary>
        /// The date selection criteria to apply to a <see cref="PMdcDatePicker"/>.
        /// </summary>
        /// <param name="criteria">The criteria style parameter passed to the <see cref="PMdcDatePicker"/></param>
        /// <returns>The <see cref="BEnum.DateSelectionCriteria"/> to apply.</returns>
        internal BEnum.DateSelectionCriteria AppliedDateSelectionCriteria(BEnum.DateSelectionCriteria? criteria = null) => (criteria is null) ? DateSelectionCriteria : (BEnum.DateSelectionCriteria)criteria;


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
