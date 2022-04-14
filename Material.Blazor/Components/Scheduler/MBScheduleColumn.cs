using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Threading;

namespace Material.Blazor.Internal
{
    internal class MBScheduleColumn : ComponentFoundation
    {
        #region Members

        [Parameter] public int ColumnWidth { get; set; }
        [Parameter] public TimeOnly WorkDayStart { get; set; }
        [Parameter] public TimeOnly WorkDayEnd { get; set; }

        //Instantiate a Semaphore with a value of 1. This means that only 1 thread can be granted access at a time.
        private SemaphoreSlim SemaphoreSlim { get; set; } = new(1, 1);

        #endregion
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            //
            // We now need to build the background grid showing the time (on the
            // hour) and the quarter hour lines
            //

            // This div holds the scrolled content
            var rendSeq = 1;
            builder.OpenElement(rendSeq++, "div");
            builder.AddAttribute(rendSeq++, "class", "mb-scheduler-div-body");

            builder.OpenElement(rendSeq++, "table");
                        builder.AddAttribute(rendSeq++, "class", "mb-scheduler-table");
            
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

            builder.OpenElement(rendSeq++, "tbody");
            builder.AddAttribute(rendSeq++, "class", "mb-scheduler-tbody");

            var rowCount = 0;
            var dateTime = new DateTime(2022, 1, 1, WorkDayStart.Hour, WorkDayStart.Minute, 0);
            var endTime = new DateTime(2022, 1, 1, WorkDayEnd.Hour, WorkDayEnd.Minute, 0);
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

                // For each column output a td
                //colCount = 0;
                //string rowColorClass = rowColorClassNormal;
                //foreach (var columnDefinition in ColumnConfigurations)
                //{
                //    string formattedValue;
                //    if (colCount == 0)
                //    {
                //        if (dateTime.Minute == 0)
                //        {
                //            formattedValue = dateTime.ToString("HHmm");
                //        }
                //        else
                //        {
                //            formattedValue = ".";
                //            rowColorClass = rowColorClassHidden;
                //        }
                //    }
                //    else
                //    {
                //        formattedValue = " ";
                //    }
                //    styleStr = BuildScheduleTD(
                //        builder,
                //        ref rendSeq,
                //        colCount == 0,
                //        false,
                //        rowColorClass);

                //    builder.AddAttribute(rendSeq++, "style", styleStr);
                //    if ((rowCount == 0) && (colCount == 1))
                //    {
                //        builder.AddAttribute(rendSeq++, "id", ScheduleID2);
                //    }
                //    builder.AddContent(1, formattedValue);

                    // Close this column span
                    builder.CloseElement();
                }

                // Close this row's div
                builder.CloseElement();

                rowCount++;
                dateTime += new TimeSpan(0, 15, 0);
            }

            builder.CloseElement(); // tbody

            builder.CloseElement(); // table

        }
    }
}
