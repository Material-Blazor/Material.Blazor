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
    /// a material button is <see cref="BMdcModel.ButtonStyle.Text"/>, however you can change that by setting <see cref="ButtonStyle"/>
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
        /// Determines whether <see cref="BMdcComponentBase"/> should throw an exception for invalid 
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
        /// Further attributes that can be set as allowable when <see cref="BMdcComponentBase"/>
        /// performs unmatched attribute validation. Works with <see cref="ConstrainSplattableAttributes"/>
        /// and <see cref="EssentialSplattableAttributes"/>.
        /// </summary>
        public IEnumerable<string> AllowedSplattableAttributes { get; set; } = Array.Empty<string>();

        /// <summary>
        /// An enumerable of allowable attributes formed from a distinct union of <see cref="EssentialSplattableAttributes"/>
        /// and <see cref="AllowedSplattableAttributes"/>
        /// </summary>
        internal IEnumerable<string> AppliedAllowedSplattableAttributes => EssentialSplattableAttributes.Union(AllowedSplattableAttributes.Select(x => x.ToLower())).Distinct();

        public BMdcModel.ItemValidation ItemValidation { get; set; } = BMdcModel.ItemValidation.Exception;
        internal BMdcModel.ItemValidation AppliedItemValidationSelect(BMdcModel.ItemValidation? criteria = null) => (criteria is null) ? ItemValidation : (BMdcModel.ItemValidation)criteria;
        internal BMdcModel.ItemValidation AppliedItemValidationRadioButtonGroup(BMdcModel.ItemValidation? criteria = null) => (criteria is null) ? ItemValidation : (BMdcModel.ItemValidation)criteria;



        /*************************************************************************************************************
         * 
         * 
         *      ICON FOUNDRIES AND THEIR OPTIONAL PARAMETERS
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// The default foundry name, initialized to <see cref="BMdcModel.IconFoundryName.MaterialIcons"/> if not explicitly set.
        /// </summary>
        public BMdcModel.IconFoundryName IconFoundryName { get; set; } = BMdcModel.IconFoundryName.MaterialIcons;

        /// <summary>
        /// The foundry name to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFoundryName">The foundry name parameter passed to the component</param>
        /// <returns>The <see cref="BMdcModel.IconFoundryName"/> to apply.</returns>
        internal BMdcModel.IconFoundryName AppliedIconFoundryName(BMdcModel.IconFoundryName? iconFoundryName = null) => (iconFoundryName is null) ? IconFoundryName : (BMdcModel.IconFoundryName)iconFoundryName;


        /// <summary>
        /// The default Material Icons theme, initialized to <see cref="BMdcModel.IconMITheme.Filled"/> if not explicitly set.
        /// </summary>
        public BMdcModel.IconMITheme IconMITheme { get; set; } = BMdcModel.IconMITheme.Filled;

        /// <summary>
        /// The Material Icons theme to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconMITheme">The theme parameter passed to the component</param>
        /// <returns>The <see cref="BMdcModel.IconMITheme"/> to apply.</returns>
        internal BMdcModel.IconMITheme AppliedIconMITheme(BMdcModel.IconMITheme? iconMITheme = null) => (iconMITheme is null) ? IconMITheme : (BMdcModel.IconMITheme)iconMITheme;


        /// <summary>
        /// The default Font Awesome style, initialized to <see cref="BMdcModel.IconFAStyle.Solid"/> if not explicitly set.
        /// </summary>
        public BMdcModel.IconFAStyle IconFAStyle { get; set; } = BMdcModel.IconFAStyle.Solid;

        /// <summary>
        /// The Font Awesome style to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFAStyle">The style parameter passed to the component</param>
        /// <returns>The <see cref="BMdcModel.IconFAStyle"/> to apply.</returns>
        internal BMdcModel.IconFAStyle AppliedIconFAStyle(BMdcModel.IconFAStyle? iconFAStyle = null) => (iconFAStyle is null) ? IconFAStyle : (BMdcModel.IconFAStyle)iconFAStyle;

        /// <summary>
        /// The default Font Awesome relative size, initialized to <see cref="BMdcModel.IconFARelativeSize.Regular"/> if not explicitly set.
        /// </summary>
        public BMdcModel.IconFARelativeSize IconFARelativeSize { get; set; } = BMdcModel.IconFARelativeSize.Regular;

        /// <summary>
        /// The Font Awesome relative size to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFARelativeSize">The relative size parameter passed to the component</param>
        /// <returns>The <see cref="BMdcModel.IconFARelativeSize"/> to apply.</returns>
        internal BMdcModel.IconFARelativeSize AppliedIconFARelativeSize(BMdcModel.IconFARelativeSize? iconFARelativeSize = null) => (iconFARelativeSize is null) ? IconFARelativeSize : (BMdcModel.IconFARelativeSize)iconFARelativeSize;



        /*************************************************************************************************************
         * 
         * 
         *      MDC CORE COMPONENTS
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// The default style for an <see cref="MdcButton"/>, initialized to <see cref="BMdcModel.ButtonStyle.Text"/> if not explicitly set.
        /// </summary>
        public BMdcModel.ButtonStyle ButtonStyle { get; set; } = BMdcModel.ButtonStyle.Text;

        /// <summary>
        /// The default style for a card action button/<see cref="MdcButton"/> in an <see cref="MdcCard"/>, initialized to <see cref="BMdcModel.ButtonStyle.Text"/> if not explicitly set.
        /// </summary>
        public BMdcModel.ButtonStyle CardActionButtonStyle { get; set; } = BMdcModel.ButtonStyle.Text;
        
        /// <summary>
        /// The default style for a dialog action button/<see cref="MdcButton"/> in an <see cref="MdcDialog"/>, initialized to <see cref="BMdcModel.ButtonStyle.Text"/> if not explicitly set.
        /// </summary>
        public BMdcModel.ButtonStyle DialogActionButtonStyle { get; set; } = BMdcModel.ButtonStyle.Text;

        /// <summary>
        /// The style to apply within an <see cref="MdcButton"/>. <see cref="MdcCard"/> and <see cref="MdcDialog"/> must
        /// pass a reference to themselves (<c>this</c>) to reference the relevant default.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcButton"/></param>
        /// <param name="card">The <see cref="BMdc.MdcButton"/>'s card reference (null if button is not in a card)</param>
        /// <param name="dialog">The <see cref="BMdc.Dialog"/>'s card reference (null if button is not in a dialog)</param>
        /// <returns>The <see cref="BMdcModel.ButtonStyle"/> to apply.</returns>
        internal BMdcModel.ButtonStyle AppliedStyle(BMdcModel.ButtonStyle? style, BMdc.Card card, BMdc.Dialog dialog)
        {
            if (style != null) return (BMdcModel.ButtonStyle)style;
            if (card != null) return CardActionButtonStyle;
            if (dialog != null) return DialogActionButtonStyle;
            return ButtonStyle;
        }


        /// <summary>
        /// The default style for an <see cref="MdcCard"/>, initialized to <see cref="BMdcModel.CardStyle.Default"/> if not explicitly set.
        /// </summary>
        public BMdcModel.CardStyle CardStyle { get; set; } = BMdcModel.CardStyle.Default;

        /// <summary>
        /// The style to apply to an <see cref="MdcCard"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcCard"/></param>
        /// <returns>The <see cref="BMdcModel.CardStyle"/> to apply.</returns>
        public BMdcModel.CardStyle AppliedStyle(BMdcModel.CardStyle? style = null) => (style is null) ? CardStyle : (BMdcModel.CardStyle)style;


        /// <summary>
        /// The default style for an <see cref="MdcList{TItem}"/>, initialized to <see cref="BMdcModel.ListStyle.None"/> if not explicitly set.
        /// </summary>
        public BMdcModel.ListStyle ListStyle { get; set; } = BMdcModel.ListStyle.None;

        /// <summary>
        /// The style to apply to an <see cref="MdcList{TItem}"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcList{TItem}"/></param>
        /// <returns>The <see cref="BMdcModel.ListStyle"/> to apply.</returns>
        internal BMdcModel.ListStyle AppliedStyle(BMdcModel.ListStyle? style = null) => (style is null) ? ListStyle : (BMdcModel.ListStyle)style;


        /// <summary>
        /// The default style for an <see cref="MdcSelect{TItem}"/>, initialized to <see cref="BMdcModel.SelectInputStyle.Filled"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="PMdcDatePicker"/>.
        /// </remarks>
        public BMdcModel.SelectInputStyle SelectInputStyle { get; set; } = BMdcModel.SelectInputStyle.Filled;

        /// <summary>
        /// The style to apply to an <see cref="MdcCard"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcCard"/></param>
        /// <returns>The <see cref="BMdcModel.CardStyle"/> to apply.</returns>
        internal BMdcModel.SelectInputStyle AppliedStyle(BMdcModel.SelectInputStyle? style = null) => (style is null) ? SelectInputStyle : (BMdcModel.SelectInputStyle)style;


        /// <summary>
        /// The default text alignment style for an <see cref="MdcTextField"/>, an <see cref="MdcTextArea"/> or <see cref="MdcSelect{TItem}"/>, initialized to <see cref="BMdcModel.TextAlignStyle.Default"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="PMdcAutocomplete"/>, <seealso cref="PMdcDebouncedTextField"/>, <seealso cref="PMdcNumericDoubleField"/> and <seealso cref="PMdcNumericIntField"/>.
        /// </remarks>
        public BMdcModel.TextAlignStyle TextAlignStyle { get; set; } = BMdcModel.TextAlignStyle.Default;

        /// <summary>
        /// The text alignment style to apply to an <see cref="MdcTextField"/>, an <see cref="MdcTextArea"/> or <see cref="MdcSelect{TItem}"/>.
        /// </summary>
        /// <param name="style">The text align style parameter passed to the <see cref="MdcTextField"/>, <see cref="MdcTextArea"/> or <see cref="MdcSelect{TItem}"/></param>
        /// <returns>The <see cref="BMdcModel.TextAlignStyle"/> to apply.</returns>
        public BMdcModel.TextAlignStyle AppliedStyle(BMdcModel.TextAlignStyle? style = null) => (style is null) ? TextAlignStyle : (BMdcModel.TextAlignStyle)style;


        /// <summary>
        /// The default style for an <see cref="MdcTextField"/> or an <see cref="MdcTextArea"/>, initialized to <see cref="BMdcModel.TextInputStyle.Filled"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="PMdcAutocomplete"/>, <seealso cref="PMdcDebouncedTextField"/>, <seealso cref="PMdcNumericDoubleField"/> and <seealso cref="PMdcNumericIntField"/>.
        /// </remarks>
        public BMdcModel.TextInputStyle TextInputStyle { get; set; } = BMdcModel.TextInputStyle.Filled;

        /// <summary>
        /// The text input style to apply to an <see cref="MdcTextField"/> or an <see cref="MdcTextArea"/>.
        /// </summary>
        /// <param name="style">The text input style parameter passed to the <see cref="MdcTextField"/> or <see cref="MdcTextArea"/></param>
        /// <returns>The <see cref="BMdcModel.TextAlignStyle"/> to apply.</returns>
        internal BMdcModel.TextInputStyle AppliedStyle(BMdcModel.TextInputStyle? style = null) => (style is null) ? TextInputStyle : (BMdcModel.TextInputStyle)style;



        /*************************************************************************************************************
         * 
         * 
         *      PLUS COMPONENTS
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// The default date selection criteria for a <see cref="PMdcDatePicker"/>, initialized to <see cref="BMdcModel.DateSelectionCriteria.AllowAll"/> if not explicitly set.
        /// </summary>
        public BMdcModel.DateSelectionCriteria DateSelectionCriteria { get; set; } = BMdcModel.DateSelectionCriteria.AllowAll;

        /// <summary>
        /// The date selection criteria to apply to a <see cref="PMdcDatePicker"/>.
        /// </summary>
        /// <param name="criteria">The criteria style parameter passed to the <see cref="PMdcDatePicker"/></param>
        /// <returns>The <see cref="BMdcModel.DateSelectionCriteria"/> to apply.</returns>
        internal BMdcModel.DateSelectionCriteria AppliedDateSelectionCriteria(BMdcModel.DateSelectionCriteria? criteria = null) => (criteria is null) ? DateSelectionCriteria : (BMdcModel.DateSelectionCriteria)criteria;


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
