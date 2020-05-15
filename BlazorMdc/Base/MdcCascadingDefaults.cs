//
//  2020-04-23  Mark Stega
//              Removed all enumerations and placed them in MdcEnumerations
//
using System.Collections;
using System.Collections.Generic;

namespace BlazorMdc
{
    public class MdcCascadingDefaults
    {
        public bool UnconstrainSplattableAttributes { get; set; } = false;
        public IList<string> AllowedSplattableAttributes { get; set; } = new string[] { "class", "style", "disabled", "type" };


        public string TextFieldCssClass { get; set; } = "";

        // Mdc Components
        public MdcIconFoundryName IconFoundryName { get; set; } = MdcIconFoundryName.MaterialIcons;
        internal MdcIconFoundryName AppliedIconFoundryName(MdcIconFoundryName? iconFoundryName = null) => (iconFoundryName is null) ? IconFoundryName : (MdcIconFoundryName)iconFoundryName;


        public MdcIconMITheme IconMITheme { get; set; } = MdcIconMITheme.Filled;
        internal MdcIconMITheme AppliedIconMITheme(MdcIconMITheme? iconMITheme = null) => (iconMITheme is null) ? IconMITheme : (MdcIconMITheme)iconMITheme;


        public MdcIconFAStyle IconFAStyle { get; set; } = MdcIconFAStyle.Solid;
        public MdcIconFARelativeSize IconFARelativeSize { get; set; } = MdcIconFARelativeSize.Regular;
        internal MdcIconFAStyle AppliedIconFAStyle(MdcIconFAStyle? iconFAStyle = null) => (iconFAStyle is null) ? IconFAStyle : (MdcIconFAStyle)iconFAStyle;
        internal MdcIconFARelativeSize AppliedIconFARelativeSize(MdcIconFARelativeSize? iconFARelativeSize = null) => (iconFARelativeSize is null) ? IconFARelativeSize : (MdcIconFARelativeSize)iconFARelativeSize;


        public MdcButtonStyle ButtonStyle { get; set; } = MdcButtonStyle.Text;
        public MdcButtonStyle CardActionButtonStyle { get; set; } = MdcButtonStyle.Text;
        public MdcButtonStyle DialogActionButtonStyle { get; set; } = MdcButtonStyle.Text;
        internal MdcButtonStyle AppliedStyle(MdcButtonStyle? style, MdcCard card, MdcDialog dialog)
        {
            if (style != null) return (MdcButtonStyle)style;
            if (card != null) return CardActionButtonStyle;
            if (dialog != null) return DialogActionButtonStyle;
            return ButtonStyle;
        }


        public MdcCardStyle CardStyle { get; set; } = MdcCardStyle.Default;
        public MdcCardStyle AppliedStyle(MdcCardStyle? style = null) => (style is null) ? CardStyle : (MdcCardStyle)style;


        public MdcItemValidation ItemValidation { get; set; } = MdcItemValidation.Exception;
        internal MdcItemValidation AppliedItemValidationSelect(MdcItemValidation? criteria = null) => (criteria is null) ? ItemValidation : (MdcItemValidation)criteria;
        internal MdcItemValidation AppliedItemValidationRadioButtonGroup(MdcItemValidation? criteria = null) => (criteria is null) ? ItemValidation : (MdcItemValidation)criteria;


        public MdcListStyle ListStyle { get; set; } = MdcListStyle.None;
        internal MdcListStyle AppliedStyle(MdcListStyle? style = null) => (style is null) ? ListStyle : (MdcListStyle)style;


        public MdcTextAlignStyle TextAlign { get; set; } = MdcTextAlignStyle.Default;
        public MdcTextAlignStyle AppliedStyle(MdcTextAlignStyle? style = null) => (style is null) ? TextAlign : (MdcTextAlignStyle)style;


        public MdcTextInputStyle TextInputStyle { get; set; } = MdcTextInputStyle.Filled;
        internal MdcTextInputStyle AppliedStyle(MdcTextInputStyle? style = null) => (style is null) ? TextInputStyle : (MdcTextInputStyle)style;


        public MdcSelectInputStyle SelectInputStyle { get; set; } = MdcSelectInputStyle.Filled;
        internal MdcSelectInputStyle AppliedStyle(MdcSelectInputStyle? style = null) => (style is null) ? SelectInputStyle : (MdcSelectInputStyle)style;



        // PMdc components
        public PMdcDateSelectionCriteria DateSelectionCriteria { get; set; } = PMdcDateSelectionCriteria.AllowAll;
        internal PMdcDateSelectionCriteria AppliedDateSelectionCriteria(PMdcDateSelectionCriteria? criteria = null) => (criteria is null) ? DateSelectionCriteria : (PMdcDateSelectionCriteria)criteria;


        public int DebounceInterval { get; set; } = 300;
        internal int AppliedDebounceInterval(int? debounceInterval = null) => (debounceInterval is null) ? 300 : (int)debounceInterval;
    }
}
