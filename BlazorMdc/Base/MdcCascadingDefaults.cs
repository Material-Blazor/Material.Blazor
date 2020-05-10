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
        public MdcIconFoundry IconFoundry { get; set; } = MdcIconFoundry.MaterialIcons;
        internal MdcIconFoundry AppliedIconFoundry(MdcIconFoundry? iconFoundry = null) => (iconFoundry is null) ? IconFoundry : (MdcIconFoundry)iconFoundry;


        public MdcMIIconTheme MCIconTheme { get; set; } = MdcMIIconTheme.Filled;
        internal MdcMIIconTheme AppliedMCIconTheme(MdcMIIconTheme? iconTheme = null) => (iconTheme is null) ? MCIconTheme : (MdcMIIconTheme)iconTheme;


        public MdcFAIconStyle FAIconStyle { get; set; } = MdcFAIconStyle.Solid;
        public MdcFAIconRelativeSize FAIconRelativeSize { get; set; } = MdcFAIconRelativeSize.Regular;
        internal MdcFAIconStyle AppliedFAIconStyle(MdcFAIconStyle? iconStyle = null) => (iconStyle is null) ? FAIconStyle : (MdcFAIconStyle)iconStyle;
        internal MdcFAIconRelativeSize AppliedFAIconRelativeSize(MdcFAIconRelativeSize? iconRelativeSize = null) => (iconRelativeSize is null) ? FAIconRelativeSize : (MdcFAIconRelativeSize)iconRelativeSize;


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
