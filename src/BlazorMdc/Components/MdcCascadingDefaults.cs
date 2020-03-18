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
        public MdcSelectInputStyle SelectInputStyle { get; set; } = MdcSelectInputStyle.Filled;
        public MdcButtonStyle ButtonStyle { get; set; } = MdcButtonStyle.Text;
        public MdcCardStyle CardStyle { get; set; } = MdcCardStyle.Default;
        public MdcListStyle ListStyle { get; set; } = MdcListStyle.None;
        public MdcButtonStyle CardActionButtonStyle { get; set; } = MdcButtonStyle.Text;
        public MdcButtonStyle DialogActionButtonStyle { get; set; } = MdcButtonStyle.Text;
        public MdcDateSelectionCriteria DateSelectionCriteria { get; set; } = MdcDateSelectionCriteria.AllowAll;
    }
}
