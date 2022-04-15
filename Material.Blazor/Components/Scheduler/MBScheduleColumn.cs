using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Threading;

namespace Material.Blazor.Internal
{
    internal class MBScheduleColumn : ComponentFoundation
    {
        #region Members

        [Parameter] public string ColumnTitle { get; set; }
        [Parameter] public int ColumnWidth { get; set; }
        [Parameter] public bool IsFirstDataColumn { get; set; }
        [Parameter] public bool IsTimeColumn { get; set; }
        [Parameter] public string ScheduleID1 { get; set; }
        [Parameter] public string ScheduleID2 { get; set; }
        [Parameter] public TimeOnly WorkDayStart { get; set; }
        [Parameter] public TimeOnly WorkDayEnd { get; set; }

        //Instantiate a Semaphore with a value of 1. This means that only 1 thread can be granted access at a time.
        private SemaphoreSlim SemaphoreSlim { get; set; } = new(1, 1);

        #endregion

        #region BuildRenderTree
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            var rendSeq = 1;
            string styleStr;

            //
            // Output the header
            //
            builder.OpenElement(rendSeq++, "div");
            builder.AddAttribute(rendSeq++, "class", "mb-scheduler-div-column");

            builder.OpenElement(rendSeq++, "table");
            builder.AddAttribute(rendSeq++, "class", "mb-scheduler-table");
            BuildColGroup(builder, ref rendSeq);

            builder.OpenElement(rendSeq++, "thead");
            builder.AddAttribute(rendSeq++, "class", "mb-scheduler-thead");
            
            builder.OpenElement(rendSeq++, "tr");
            builder.AddAttribute(rendSeq++, "class", "mb-scheduler-tr");

            // Output a TD
            styleStr = BuildScheduleTD(
                builder,
                ref rendSeq,
                IsTimeColumn,
                true,
                false,
                "mb-scheduler-header");

            builder.AddAttribute(rendSeq++, "style", styleStr);
            if (IsTimeColumn)
            {
                builder.AddAttribute(rendSeq++, "id", ScheduleID1);
            }
            builder.AddContent(rendSeq++, ColumnTitle);

            builder.CloseElement(); // td
            builder.CloseElement(); // tr
            builder.CloseElement(); // thead


            //
            // We now need to build the background grid showing the quarter hour lines
            // and if the first column, the times
            //
            builder.OpenElement(rendSeq++, "tbody");
            builder.AddAttribute(rendSeq++, "class", "mb-scheduler-tbody");

            var dateTime = new DateTime(2022, 1, 1, WorkDayStart.Hour, WorkDayStart.Minute, 0);
            var endTime = new DateTime(2022, 1, 1, WorkDayEnd.Hour, WorkDayEnd.Minute, 0);
            var rowCount = 0;
            var lastRow = Convert.ToInt32(((endTime - dateTime).TotalMinutes / 15) - 1);
            while (dateTime < endTime)
            {
                // We alternate colors
                string rowColorClassNormal;
                string rowColorClassHidden;
                if ((rowCount / 2) * 2 == rowCount)
                {
                    // Even
                    rowColorClassNormal = "mb-scheduler-color-row-even-normal";
                    rowColorClassHidden = "mb-scheduler-color-row-even-hidden";
                }
                else
                {
                    // Odd
                    rowColorClassNormal = "mb-scheduler-color-row-odd-normal";
                    rowColorClassHidden = "mb-scheduler-color-row-odd-hidden";
                }

                // Do a tr
                builder.OpenElement(rendSeq++, "tr");
                builder.AddAttribute(rendSeq++, "class", "mb-scheduler-tr " + rowColorClassNormal);

                string rowColorClass = rowColorClassNormal;
                string formattedValue;
                if (IsTimeColumn && (dateTime.Minute == 0))
                {
                    formattedValue = dateTime.ToString("HHmm");
                }
                else
                {
                    formattedValue = ".";
                    rowColorClass = rowColorClassHidden;
                }
                styleStr = BuildScheduleTD(
                    builder,
                    ref rendSeq,
                    IsTimeColumn,
                    false,
                    rowCount == lastRow,
                    rowColorClass);

                builder.AddAttribute(rendSeq++, "style", styleStr);
                if ((rowCount == 0) && (IsFirstDataColumn))
                {
                    builder.AddAttribute(rendSeq++, "id", ScheduleID2);
                }
                builder.AddContent(1, formattedValue);

                //Close this column span
                builder.CloseElement();

                // Close this row's div
                builder.CloseElement();

                rowCount++;
                dateTime += new TimeSpan(0, 15, 0);
            }

            builder.CloseElement(); // tbody
            builder.CloseElement(); // table
            builder.CloseElement(); // div
        }

        #endregion

        #region BuildColGroup
        private void BuildColGroup(RenderTreeBuilder builder, ref int rendSeq)
        {
            builder.OpenElement(rendSeq++, "colgroup");
            builder.AddAttribute(rendSeq++, "class", "mb-scheduler-colgroup");
            var styleStr =
                "width: " + ColumnWidth.ToString() + "% !important; " +
                "max-width: " + ColumnWidth.ToString() + "% !important; " +
                "min-width: " + ColumnWidth.ToString() + "% !important; ";

            builder.OpenElement(rendSeq++, "col");
            builder.AddAttribute(rendSeq++, "style", styleStr);
            builder.CloseElement(); // col
            builder.CloseElement(); // colgroup
        }

        #endregion

        #region BuildScheduleTD
        internal static string BuildScheduleTD(
            RenderTreeBuilder builder,
            ref int rendSeq,
            bool isFirstColumn,
            bool isHeaderRow,
            bool isLastRow,
            string rowBackgroundColorClass)
        {
            builder.OpenElement(rendSeq++, "td");
            builder.AddAttribute(rendSeq++, "class", "mb-scheduler-td " + rowBackgroundColorClass);

            if (isHeaderRow)
            {
                if (isFirstColumn)
                {
                    // T R B L
                    return " border-width: 1px; border-style: solid; border-color: black; ";
                }
                else
                {
                    // T R B
                    return " border-width: 1px 1px 1px 0px; border-style: solid; border-color: black; ";
                }
            }
            else
            {
                if (isLastRow)
                {
                    if (isFirstColumn)
                    {
                        // R B L
                        return " border-width: 0px 1px 1px 1px; border-style: solid; border-color: black; ";
                    }
                    else
                    {
                        // R B
                        return " border-width: 0px 1px 1px 0px; border-style: solid; border-color: black; ";
                    }
                }
                else
                {
                    if (isFirstColumn)
                    {
                        // R L
                        return " border-width: 0px 1px 0px 1px; border-style: solid; border-color: black; ";
                    }
                    else
                    {
                        // R
                        return " border-width: 0px 1px 0px 0px; border-style: solid; border-color: black; ";
                    }
                }
            }
        }
        #endregion

    }
}
