//
//  2020-04-23  Mark Stega
//              Removed all enumerations and placed them in MdcEnumerations
//
namespace BlazorMdc
{
    public class MdcCascadingDefaults
    {
        public string TextFieldCssClass { get; set; } = "";

        // Mdc Components
        public MdcButtonStyle ButtonStyle { get; set; } = MdcButtonStyle.Text;
        public MdcButtonStyle CardActionButtonStyle { get; set; } = MdcButtonStyle.Text;
        public MdcButtonStyle DialogActionButtonStyle { get; set; } = MdcButtonStyle.Text;
        internal MdcButtonStyle AppliedStyle(MdcButtonStyle? style = null) => (style is null) ? ButtonStyle : (MdcButtonStyle)style;
        internal MdcButtonStyle AppliedStyle_CardActionButton(MdcButtonStyle? style = null) => (style is null) ? CardActionButtonStyle : (MdcButtonStyle)style;
        internal MdcButtonStyle AppliedStyle_DialogActionButton(MdcButtonStyle? style = null) => (style is null) ? DialogActionButtonStyle : (MdcButtonStyle)style;


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
