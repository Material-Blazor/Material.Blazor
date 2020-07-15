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
    /// nest cascading values in the normal manner.
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

        /// <summary>
        /// Determines whether <see cref="Internal.ComponentFoundation"/> should throw an exception for invalid 
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
        /// Further attributes that can be set as allowable when <see cref="Internal.ComponentFoundation"/>
        /// performs unmatched attribute validation. Works with <see cref="ConstrainSplattableAttributes"/>
        /// and <see cref="EssentialSplattableAttributes"/>.
        /// </summary>
        public IEnumerable<string> AllowedSplattableAttributes { get; set; } = Array.Empty<string>();

        /// <summary>
        /// An enumerable of allowable attributes formed from a distinct union of <see cref="EssentialSplattableAttributes"/>
        /// and <see cref="AllowedSplattableAttributes"/>
        /// </summary>
        internal IEnumerable<string> AppliedAllowedSplattableAttributes => EssentialSplattableAttributes.Union(AllowedSplattableAttributes.Select(x => x.ToLower())).Distinct();

        public MTItemValidation ItemValidation { get; set; } = MTItemValidation.Exception;
        internal MTItemValidation AppliedItemValidationSelect(MTItemValidation? criteria = null) => (criteria is null) ? ItemValidation : (MTItemValidation)criteria;
        internal MTItemValidation AppliedItemValidationRadioButtonGroup(MTItemValidation? criteria = null) => (criteria is null) ? ItemValidation : (MTItemValidation)criteria;



        /*************************************************************************************************************
         * 
         * 
         *      ICON FOUNDRIES AND THEIR OPTIONAL PARAMETERS
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// The default foundry name, initialized to <see cref="MTIconFoundryName.MaterialIcons"/> if not explicitly set.
        /// </summary>
        public MTIconFoundryName IconFoundryName { get; set; } = MTIconFoundryName.MaterialIcons;

        /// <summary>
        /// The foundry name to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFoundryName">The foundry name parameter passed to the component</param>
        /// <returns>The <see cref="IconFoundryName"/> to apply.</returns>
        internal MTIconFoundryName AppliedIconFoundryName(MTIconFoundryName? iconFoundryName = null) => (iconFoundryName is null) ? IconFoundryName : (MTIconFoundryName)iconFoundryName;


        /// <summary>
        /// The default Material Icons theme, initialized to <see cref="MTIconMITheme.Filled"/> if not explicitly set.
        /// </summary>
        public MTIconMITheme IconMITheme { get; set; } = MTIconMITheme.Filled;

        /// <summary>
        /// The Material Icons theme to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconMITheme">The theme parameter passed to the component</param>
        /// <returns>The <see cref="IconMITheme"/> to apply.</returns>
        internal MTIconMITheme AppliedIconMITheme(MTIconMITheme? iconMITheme = null) => (iconMITheme is null) ? IconMITheme : (MTIconMITheme)iconMITheme;


        /// <summary>
        /// The default Font Awesome style, initialized to <see cref="MTIconFAStyle.Solid"/> if not explicitly set.
        /// </summary>
        public MTIconFAStyle IconFAStyle { get; set; } = MTIconFAStyle.Solid;

        /// <summary>
        /// The Font Awesome style to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFAStyle">The style parameter passed to the component</param>
        /// <returns>The <see cref="IconFAStyle"/> to apply.</returns>
        internal MTIconFAStyle AppliedIconFAStyle(MTIconFAStyle? iconFAStyle = null) => (iconFAStyle is null) ? IconFAStyle : (MTIconFAStyle)iconFAStyle;

        /// <summary>
        /// The default Font Awesome relative size, initialized to <see cref="MTIconFARelativeSize.Regular"/> if not explicitly set.
        /// </summary>
        public MTIconFARelativeSize IconFARelativeSize { get; set; } = MTIconFARelativeSize.Regular;

        /// <summary>
        /// The Font Awesome relative size to apply within a BlazorMdc component.
        /// </summary>
        /// <param name="iconFARelativeSize">The relative size parameter passed to the component</param>
        /// <returns>The <see cref="IconFARelativeSize"/> to apply.</returns>
        internal MTIconFARelativeSize AppliedIconFARelativeSize(MTIconFARelativeSize? iconFARelativeSize = null) => (iconFARelativeSize is null) ? IconFARelativeSize : (MTIconFARelativeSize)iconFARelativeSize;



        /*************************************************************************************************************
         * 
         * 
         *      MDC CORE COMPONENTS
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// The default style for an <see cref="MTButton"/>, initialized to <see cref="MTButtonStyle.Text"/> if not explicitly set.
        /// </summary>
        public MTButtonStyle ButtonStyle { get; set; } = MTButtonStyle.Text;

        /// <summary>
        /// The default style for a card action button/<see cref="MTButton"/> in an <see cref="MdcCard"/>, initialized to <see cref="MTButtonStyle.Text"/> if not explicitly set.
        /// </summary>
        public MTButtonStyle CardActionButtonStyle { get; set; } = MTButtonStyle.Text;
        
        /// <summary>
        /// The default style for a dialog action button/<see cref="MTButton"/> in an <see cref="MTDialog"/>, initialized to <see cref="MTButtonStyle.Text"/> if not explicitly set.
        /// </summary>
        public MTButtonStyle DialogActionButtonStyle { get; set; } = MTButtonStyle.Text;

        /// <summary>
        /// The style to apply within an <see cref="MTButton"/>. <see cref="MdcCard"/> and <see cref="MTDialog"/> must
        /// pass a reference to themselves (<c>this</c>) to reference the relevant default.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MTButton"/></param>
        /// <param name="card">The <see cref="MTMTButton"/>'s card reference (null if button is not in a card)</param>
        /// <param name="dialog">The <see cref="MTDialog"/>'s card reference (null if button is not in a dialog)</param>
        /// <returns>The <see cref="ButtonStyle"/> to apply.</returns>
        internal MTButtonStyle AppliedStyle(MTButtonStyle? style, MTCard card, MTDialog dialog)
        {
            if (style != null) return (MTButtonStyle)style;
            if (card != null) return CardActionButtonStyle;
            if (dialog != null) return DialogActionButtonStyle;
            return ButtonStyle;
        }


        /// <summary>
        /// The default style for an <see cref="MdcCard"/>, initialized to <see cref="MTICardStyle.Default"/> if not explicitly set.
        /// </summary>
        public MTCardStyle CardStyle { get; set; } = MTCardStyle.Default;

        /// <summary>
        /// The style to apply to an <see cref="MdcCard"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcCard"/></param>
        /// <returns>The <see cref="CardStyle"/> to apply.</returns>
        public MTCardStyle AppliedStyle(MTCardStyle? style = null) => (style is null) ? CardStyle : (MTCardStyle)style;


        /// <summary>
        /// The default style for an <see cref="MdcList{TItem}"/>, initialized to <see cref="MTListStyle.None"/> if not explicitly set.
        /// </summary>
        public MTListStyle ListStyle { get; set; } = MTListStyle.None;

        /// <summary>
        /// The style to apply to an <see cref="MdcList{TItem}"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcList{TItem}"/></param>
        /// <returns>The <see cref="ListStyle"/> to apply.</returns>
        internal MTListStyle AppliedStyle(MTListStyle? style = null) => (style is null) ? ListStyle : (MTListStyle)style;


        /// <summary>
        /// The default style for an <see cref="MTSelect{TItem}"/>, initialized to <see cref="MTSelectInputStyle.Filled"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="MTDatePicker"/>.
        /// </remarks>
        public MTSelectInputStyle SelectInputStyle { get; set; } = MTSelectInputStyle.Filled;

        /// <summary>
        /// The style to apply to an <see cref="MdcCard"/>.
        /// </summary>
        /// <param name="style">The style parameter passed to the <see cref="MdcCard"/></param>
        /// <returns>The <see cref="CardStyle"/> to apply.</returns>
        internal MTSelectInputStyle AppliedStyle(MTSelectInputStyle? style = null) => (style is null) ? SelectInputStyle : (MTSelectInputStyle)style;


        /// <summary>
        /// The default text alignment style for an <see cref="MTTextField"/>, an <see cref="MdcTextArea"/> or <see cref="MTSelect{TItem}"/>, initialized to <see cref="MTTextAlignStyle.Default"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="MTAutocomplete"/>, <seealso cref="MTDebouncedTextField"/>, <seealso cref="MTNumericDoubleField"/> and <seealso cref="MTNumericIntField"/>.
        /// </remarks>
        public MTTextAlignStyle TextAlignStyle { get; set; } = MTTextAlignStyle.Default;

        /// <summary>
        /// The text alignment style to apply to an <see cref="MTTextField"/>, an <see cref="MdcTextArea"/> or <see cref="MTSelect{TItem}"/>.
        /// </summary>
        /// <param name="style">The text align style parameter passed to the <see cref="MTTextField"/>, <see cref="MdcTextArea"/> or <see cref="MTSelect{TItem}"/></param>
        /// <returns>The <see cref="TextAlignStyle"/> to apply.</returns>
        public MTTextAlignStyle AppliedStyle(MTTextAlignStyle? style = null) => (style is null) ? TextAlignStyle : (MTTextAlignStyle)style;


        /// <summary>
        /// The default style for an <see cref="MTTextField"/> or an <see cref="MdcTextArea"/>, initialized to <see cref="MTTextInputStyle.Filled"/> if not explicitly set.
        /// </summary>
        /// <remarks>
        /// Also applied to <seealso cref="MTAutocomplete"/>, <seealso cref="MTDebouncedTextField"/>, <seealso cref="MTNumericDoubleField"/> and <seealso cref="MTNumericIntField"/>.
        /// </remarks>
        public MTTextInputStyle TextInputStyle { get; set; } = MTTextInputStyle.Filled;

        /// <summary>
        /// The text input style to apply to an <see cref="MTTextField"/> or an <see cref="MdcTextArea"/>.
        /// </summary>
        /// <param name="style">The text input style parameter passed to the <see cref="MTTextField"/> or <see cref="MdcTextArea"/></param>
        /// <returns>The <see cref="TextAlignStyle"/> to apply.</returns>
        internal MTTextInputStyle AppliedStyle(MTTextInputStyle? style = null) => (style is null) ? TextInputStyle : (MTTextInputStyle)style;



        /*************************************************************************************************************
         * 
         * 
         *      PLUS COMPONENTS
         * 
         * 
         ************************************************************************************************************/

        /// <summary>
        /// The default date selection criteria for a <see cref="MTDatePicker"/>, initialized to <see cref="MTDateSelectionCriteria.AllowAll"/> if not explicitly set.
        /// </summary>
        public MTDateSelectionCriteria DateSelectionCriteria { get; set; } = MTDateSelectionCriteria.AllowAll;

        /// <summary>
        /// The date selection criteria to apply to a <see cref="MTDatePicker"/>.
        /// </summary>
        /// <param name="criteria">The criteria style parameter passed to the <see cref="MTDatePicker"/></param>
        /// <returns>The <see cref="DateSelectionCriteria"/> to apply.</returns>
        internal MTDateSelectionCriteria AppliedDateSelectionCriteria(MTDateSelectionCriteria? criteria = null) => (criteria is null) ? DateSelectionCriteria : (MTDateSelectionCriteria)criteria;


        /// <summary>
        /// The default debounce interval in milliseconds for a <see cref="MTDebouncedTextField"/>, initialized to 300 milliseconds if not explicitly set.
        /// </summary>
        public int DebounceInterval { get; set; } = 300;

        /// <summary>
        /// The text debounce interval in milliseconds to apply to an <see cref="MTDebouncedTextField"/>.
        /// </summary>
        /// <param name="style">The text input style parameter passed to the <see cref="MTDebouncedTextField"/></param>
        /// <returns>The interval in milliseconds to apply.</returns>
        internal int AppliedDebounceInterval(int? debounceInterval = null) => (debounceInterval is null) ? 300 : (int)debounceInterval;
    }
}
