using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMdc
{
    /// <summary>
    /// The MDC Top App Bar type: all items are mutually exclusive
    /// </summary>
    public enum MdcTopAppBarType { Standard, Fixed, Dense, Prominent, Short, ShortCollapsed }


    /// <summary>
    /// The style of MDC input: note that FullWidth is mutually exclusive with Outlined
    /// </summary>
    public enum MdcTextAlignStyle { Default, Left, Center, Right }


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
    public enum MdcNumericInputMagnitude { Normal = 0, Percent = 2, BasisPoints = 4 }


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
        public MdcButtonStyle ButtonStyle { get; set; } = MdcButtonStyle.Text;
        public MdcButtonStyle CardActionButtonStyle { get; set; } = MdcButtonStyle.Text;
        public MdcButtonStyle DialogActionButtonStyle { get; set; } = MdcButtonStyle.Text;

        public MdcCardStyle CardStyle { get; set; } = MdcCardStyle.Default;
        public MdcListStyle ListStyle { get; set; } = MdcListStyle.None;
        public MdcTextAlignStyle TextAlign { get; set; } = MdcTextAlignStyle.Default;
        public MdcTextInputStyle TextInputStyle { get; set; } = MdcTextInputStyle.Filled;
        public MdcSelectInputStyle SelectInputStyle { get; set; } = MdcSelectInputStyle.Filled;

        public MdcDateSelectionCriteria DateSelectionCriteria { get; set; } = MdcDateSelectionCriteria.AllowAll;

        public string TextFieldCssClass { get; set; } = "";


        public MdcButtonStyle AppliedStyle(MdcButtonStyle? style = null) => (style is null) ? ButtonStyle : (MdcButtonStyle)style;
        public MdcButtonStyle AppliedStyle_CardActionButton(MdcButtonStyle? style = null) => (style is null) ? CardActionButtonStyle : (MdcButtonStyle)style;
        public MdcButtonStyle AppliedStyle_DialogActionButton(MdcButtonStyle? style = null) => (style is null) ? DialogActionButtonStyle : (MdcButtonStyle)style;
        
        public MdcCardStyle AppliedStyle(MdcCardStyle? style = null) => (style is null) ? CardStyle : (MdcCardStyle)style;
        public MdcListStyle AppliedStyle(MdcListStyle? style = null) => (style is null) ? ListStyle : (MdcListStyle)style;
        public MdcTextAlignStyle AppliedStyle(MdcTextAlignStyle? style = null) => (style is null) ? TextAlign : (MdcTextAlignStyle)style;
        public MdcTextInputStyle AppliedStyle(MdcTextInputStyle? style = null) => (style is null) ? TextInputStyle : (MdcTextInputStyle)style;
        public MdcSelectInputStyle AppliedStyle(MdcSelectInputStyle? style = null) => (style is null) ? SelectInputStyle : (MdcSelectInputStyle)style;

        public MdcDateSelectionCriteria AppliedDateSelectionCriteria(MdcDateSelectionCriteria? criteria = null) => (criteria is null) ? DateSelectionCriteria : (MdcDateSelectionCriteria)criteria;
    }
}
