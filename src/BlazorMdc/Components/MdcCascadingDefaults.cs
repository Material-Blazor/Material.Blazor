using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMdc.Components
{
    /// <summary>
    /// The style of MDC input: note that FullWidth is mutually exclusive with Outlined
    /// </summary>
    public enum MdcTextAlign { Default, Left, Center, Right }


    /// <summary>
    /// The style of MDC input: note that FullWidth is mutually exclusive with Outlined
    /// </summary>
    public enum MdcTextInputStyle { Filled, Outlined, FullWidth }


    /// <summary>
    /// The style of MDC select
    /// </summary>
    public enum MdcSelectInputStyle { Filled, Outlined }


    /// <summary>
    /// The style of MDC input: note that FullWidth is mutually exclusive with Outlined
    /// </summary>
    public enum MdcNumericInputMagnitude { Normal, Percent, BasisPoints }


    /// <summary>
    /// MDC button styling
    /// </summary>
    public enum MdcButtonStyle { ContainedRaised, ContainedUnelevated, Outlined, Text }


    /// <summary>
    /// MDC list styling
    /// </summary>
    public enum MdcListStyle { None, Outlined }


    /// <summary>
    /// MDC card styling
    /// </summary>
    public enum MdcCardStyle { Default, Outlined }


    /// <summary>
    /// Date Picker selection criteria
    /// </summary>
    public enum MdcDateSelectionCriteria { AllowAll, WeekendsOnly, WeekdaysOnly }


    public class MdcCascadingDefaults
    {
        public MdcTextAlign TextAlign { get; set; } = MdcTextAlign.Default;
        public MdcTextInputStyle TextInputStyle { get; set; } = MdcTextInputStyle.Filled;
        public string TextFieldCssClass { get; set; } = "";
        public MdcSelectInputStyle SelectInputStyle { get; set; } = MdcSelectInputStyle.Filled;
        public MdcButtonStyle ButtonStyle { get; set; } = MdcButtonStyle.Text;
        public MdcCardStyle CardStyle { get; set; } = MdcCardStyle.Default;
        public MdcListStyle ListStyle { get; set; } = MdcListStyle.None;
        public MdcButtonStyle CardActionButtonStyle { get; set; } = MdcButtonStyle.Text;
        public MdcButtonStyle DialogActionButtonStyle { get; set; } = MdcButtonStyle.Text;
        public MdcDateSelectionCriteria DateSelectionCriteria { get; set; } = MdcDateSelectionCriteria.AllowAll;


        internal MdcTextAlign AppliedTextAlign(MdcTextAlign? style = null) => (style is null) ? TextAlign : (MdcTextAlign)style;

        internal MdcTextInputStyle AppliedTextInputStyle(MdcTextInputStyle? style = null) => (style is null) ? TextInputStyle : (MdcTextInputStyle)style;

        internal MdcSelectInputStyle AppliedSelectInputStyle(MdcSelectInputStyle? style = null) => (style is null) ? SelectInputStyle : (MdcSelectInputStyle)style;

        internal MdcButtonStyle AppliedButtonStyle(MdcButtonStyle? style = null) => (style is null) ? ButtonStyle : (MdcButtonStyle)style;

        internal MdcCardStyle AppliedCardStyle(MdcCardStyle? style = null) => (style is null) ? CardStyle : (MdcCardStyle)style;

        internal MdcListStyle AppliedListStyle(MdcListStyle? style = null) => (style is null) ? ListStyle : (MdcListStyle)style;

        internal MdcButtonStyle AppliedCardActionButtonStyle(MdcButtonStyle? style = null) => (style is null) ? CardActionButtonStyle : (MdcButtonStyle)style;

        internal MdcButtonStyle AppliedDialogActionButtonStyle(MdcButtonStyle? style = null) => (style is null) ? DialogActionButtonStyle : (MdcButtonStyle)style;

        internal MdcDateSelectionCriteria AppliedDateSelectionCriteria(MdcDateSelectionCriteria? criteria = null) => (criteria is null) ? DateSelectionCriteria : (MdcDateSelectionCriteria)criteria;
    }
}
