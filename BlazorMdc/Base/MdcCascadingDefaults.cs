//
//  2020-04-23  Mark Stega
//              Removed all enumerations and placed them in MdcEnumerations
//
namespace BlazorMdc
{
    public class MdcCascadingDefaults
    {
        public MdcButtonStyle ButtonStyle { get; set; } = MdcButtonStyle.Text;
        public MdcButtonStyle CardActionButtonStyle { get; set; } = MdcButtonStyle.Text;
        public MdcButtonStyle DialogActionButtonStyle { get; set; } = MdcButtonStyle.Text;

        public MdcCardStyle CardStyle { get; set; } = MdcCardStyle.Default;
        public MdcListStyle ListStyle { get; set; } = MdcListStyle.None;
        public MdcTextAlignStyle TextAlign { get; set; } = MdcTextAlignStyle.Default;
        public MdcTextInputStyle TextInputStyle { get; set; } = MdcTextInputStyle.Filled;
        public MdcSelectInputStyle SelectInputStyle { get; set; } = MdcSelectInputStyle.Filled;

        public PMdcDateSelectionCriteria DateSelectionCriteria { get; set; } = PMdcDateSelectionCriteria.AllowAll;
        public PMdcRadioButtonGroupItemValidation RadioButtonGroupItemValidation { get; set; } = PMdcRadioButtonGroupItemValidation.Exception;

        public string TextFieldCssClass { get; set; } = "";


        public MdcButtonStyle AppliedStyle(MdcButtonStyle? style = null) => (style is null) ? ButtonStyle : (MdcButtonStyle)style;
        public MdcButtonStyle AppliedStyle_CardActionButton(MdcButtonStyle? style = null) => (style is null) ? CardActionButtonStyle : (MdcButtonStyle)style;
        public MdcButtonStyle AppliedStyle_DialogActionButton(MdcButtonStyle? style = null) => (style is null) ? DialogActionButtonStyle : (MdcButtonStyle)style;
        
        public MdcCardStyle AppliedStyle(MdcCardStyle? style = null) => (style is null) ? CardStyle : (MdcCardStyle)style;
        public MdcListStyle AppliedStyle(MdcListStyle? style = null) => (style is null) ? ListStyle : (MdcListStyle)style;
        public MdcTextAlignStyle AppliedStyle(MdcTextAlignStyle? style = null) => (style is null) ? TextAlign : (MdcTextAlignStyle)style;
        public MdcTextInputStyle AppliedStyle(MdcTextInputStyle? style = null) => (style is null) ? TextInputStyle : (MdcTextInputStyle)style;
        public MdcSelectInputStyle AppliedStyle(MdcSelectInputStyle? style = null) => (style is null) ? SelectInputStyle : (MdcSelectInputStyle)style;

        public PMdcDateSelectionCriteria AppliedDateSelectionCriteria(PMdcDateSelectionCriteria? criteria = null) => (criteria is null) ? DateSelectionCriteria : (PMdcDateSelectionCriteria)criteria;
        public PMdcRadioButtonGroupItemValidation AppliedRadioButtonGroupItemValidation(PMdcRadioButtonGroupItemValidation? criteria = null) => (criteria is null) ? RadioButtonGroupItemValidation : (PMdcRadioButtonGroupItemValidation)criteria;
    }
}
