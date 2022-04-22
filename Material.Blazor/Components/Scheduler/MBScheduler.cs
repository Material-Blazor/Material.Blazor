#define Logging

using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

//
//  Implements a multi-column schedule.
//

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme scheduler capable of displaying icons, colored text, and text.
    /// 
    /// N.B.: At this time the scheduler is in preview. Expect the API to change.
    /// </summary>
    public class MBScheduler : ComponentFoundation
    {
        #region Members

        /// <summary>
        /// The set of appointments to be displayed
        /// </summary>
        [Parameter] public IEnumerable<MBSchedulerAppointment> Appointments { get; set; }

        /// <summary>
        /// The number of subcolumns within a day
        /// </summary>
        [Parameter] public int NumberOfSubColumns { get; set; } = 2;

        /// <summary>
        /// The number of days to be shown
        /// </summary>
        [Parameter] public int NumberOfDays { get; set; } = 5;

        /// <summary>
        /// Callback for a completed drag event
        /// </summary>
        [Parameter] public EventCallback<DragEndInfo> OnDragEnd { get; set; }

        /// <summary>
        /// The initial date
        /// </summary>
        [Parameter] public DateTime StartDate { get; set; } = new DateTime(2022, 04, 04);

        /// <summary>
        /// The time of the start of the workday
        /// </summary>
        [Parameter] public TimeOnly WorkDayStart { get; set; } = new TimeOnly(7, 0, 0);

        /// <summary>
        /// The time of the end of the workday
        /// </summary>
        [Parameter] public TimeOnly WorkDayEnd { get; set; } = new TimeOnly(17, 0, 0);

        [Inject] private IJSRuntime JsRuntime { get; set; }

        private double AppointmentColumnWidth { get; set; }
        private List<ColumnConfiguration> ColumnConfigurations { get; set; }
        public MBSchedulerAppointment CurrentDragSource { get; set; }
        private double DayColumnWidth { get; set; }
        private double FifteenMinuteHeight { get; set; }
        private bool IsFirstMeasurementCompleted { get; set; } = false;
        private bool IsSecondMeasurementCompleted { get; set; } = false;
        private double LeftEdgeOfColumn1 { get; set; }
        private string MeasureID { get; set; } = Utilities.GenerateUniqueElementName();
        private string ScheduleID1 { get; set; } = Utilities.GenerateUniqueElementName();
        private string ScheduleID2 { get; set; } = Utilities.GenerateUniqueElementName();

        //Instantiate a Semaphore with a value of 1. This means that only 1 thread can be granted access at a time.
        private SemaphoreSlim SemaphoreSlim { get; set; } = new(1, 1);
        private bool ShouldRenderValue { get; set; } = true;

        #endregion

        #region BuildColGroup
        private void BuildColGroup(RenderTreeBuilder builder, ref int rendSeq)
        {
            // Create the sizing colgroup collection
            builder.OpenElement(rendSeq++, "colgroup");
            builder.AddAttribute(rendSeq++, "class", "mb-scheduler-colgroup");
            var colIndex = 0;
            foreach (var col in ColumnConfigurations)
            {
                var styleStr =
                    "width: " + col.Width.ToString() + "px !important; " +
                    "max-width: " + col.Width.ToString() + "px !important; " +
                    "min-width: " + col.Width.ToString() + "px !important; ";
                builder.OpenElement(rendSeq++, "col");
                builder.AddAttribute(rendSeq++, "style", styleStr);
                builder.CloseElement(); // col
                colIndex++;
            }
            builder.CloseElement(); // colgroup
        }
        #endregion

        #region BuildRenderTree
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
#if Logging
            ScheduleLogDebug("BuildRenderTree entered; IsMeasurementCompleted == " + IsFirstMeasurementCompleted.ToString());
            ScheduleLogDebug("                         ShouldRenderValue == " + ShouldRenderValue.ToString());
#endif

            base.BuildRenderTree(builder);
            var rendSeq = 1;
            string styleStr;

            if (!IsFirstMeasurementCompleted)
            {
                // For the first render we are only going to create a simple table
                // with a header of one element at 100% width

                builder.OpenElement(rendSeq++, "div");
                builder.AddAttribute(rendSeq++, "class", "mb-scheduler-div-header mb-scheduler-backgroundcolor-header-background");
                builder.OpenElement(rendSeq++, "table");
                builder.AddAttribute(rendSeq++, "class", "mb-scheduler-table mb-scheduler-table-measurement");

                builder.OpenElement(rendSeq++, "colgroup");
                builder.AddAttribute(rendSeq++, "class", "mb-scheduler-colgroup");
                var styleStr1 =
                    "width: 100% !important; " +
                    "max-width: 100% !important; " +
                    "min-width: 100% !important; ";
                builder.OpenElement(rendSeq++, "col");
                builder.AddAttribute(rendSeq++, "style", styleStr1);
                builder.CloseElement(); // col
                builder.CloseElement(); // colgroup

                builder.OpenElement(rendSeq++, "thead");
                builder.AddAttribute(rendSeq++, "class", "mb-scheduler-thead");
                builder.OpenElement(rendSeq++, "tr");
                builder.AddAttribute(rendSeq++, "class", "mb-scheduler-tr");
                builder.OpenElement(rendSeq++, "td");
                builder.AddAttribute(rendSeq++, "class", "mb-scheduler-td ");
                var styleh = " border-width: 1px; border-style: solid; border-color: black; ";
                builder.AddAttribute(rendSeq++, "style", styleh);
                builder.AddAttribute(rendSeq++, "id", MeasureID);
                builder.AddContent(rendSeq++, "Meaningless title");
                builder.CloseElement(); //td
                builder.CloseElement(); // tr
                builder.CloseElement(); // thead
                builder.CloseElement(); //table
                builder.CloseElement(); // div mb-scheduler-header
            }
            else
            {
                //
                //  Using the column cfg and column data, render our scheduler. Here is the layout.
                //
                //  div class="@class", style="@style"
                //      div mb-scheduler-header          - Contains the header
                //          table                   - 
                //              tr                  - 
                //                  td*             - Header
                //      div mb-scheduler-body            - Contains the rows
                //          table                   - Contains the rows
                //              tr*                 - Rows
                //                  td*             - Columns of the row
                //
                rendSeq = 100;

                if (((@class != null) && (@class.Length > 0)) || ((style != null) && (style.Length > 0)))
                {
                    builder.OpenElement(rendSeq++, "div");
                    builder.AddAttribute(rendSeq++, "class", "mb-scheduler-div-outer " + @class);
                    builder.AddAttribute(rendSeq++, "style", style);
                }

                // Based on the column config generate the column titles
                builder.OpenElement(rendSeq++, "div");
                builder.AddAttribute(rendSeq++, "class", "mb-scheduler-div-header mb-scheduler-backgroundcolor-header-background");
                //builder.AddAttribute(rendSeq++, "style", "padding-right: " + ScrollWidth.ToString() + "px; ");
                builder.OpenElement(rendSeq++, "table");
                builder.AddAttribute(rendSeq++, "class", "mb-scheduler-table");
                BuildColGroup(builder, ref rendSeq);
                builder.OpenElement(rendSeq++, "thead");
                builder.AddAttribute(rendSeq++, "class", "mb-scheduler-thead");
                builder.OpenElement(rendSeq++, "tr");
                builder.AddAttribute(rendSeq++, "class", "mb-scheduler-tr");

                // For each column output a TD
                var isHeaderRow = true;
                var colCount = 0;
                foreach (var col in ColumnConfigurations)
                {
                    styleStr = BuildScheduleTD(
                        builder,
                        ref rendSeq,
                        colCount == 0,
                        isHeaderRow,
                        false,
                        "mb-scheduler-header");

                    //// Set the header colors
                    //styleStr += " color: Black;";
                    //styleStr += " background-color : LightGray;";

                    builder.AddAttribute(rendSeq++, "style", styleStr);
                    if (colCount == 0)
                    {
                        builder.AddAttribute(rendSeq++, "id", ScheduleID1);
                    }
                    builder.AddContent(rendSeq++, col.Title);

                    // Close this column TD
                    builder.CloseElement();

                    colCount++;
                }

                builder.CloseElement(); // tr

                builder.CloseElement(); // thead

                builder.CloseElement(); //table

                builder.CloseElement(); // div mb-scheduler-header

                //
                // We now need to build the background grid showing the time (on the
                // hour) and the quarter hour lines
                //

                // This div holds the scrolled content
                builder.OpenElement(rendSeq++, "div");
                builder.AddAttribute(rendSeq++, "class", "mb-scheduler-div-body");
                builder.OpenElement(rendSeq++, "table");
                builder.AddAttribute(rendSeq++, "class", "mb-scheduler-table");

                builder.AddAttribute(rendSeq++, "ondragover", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, HandleDragOver));
                builder.AddEventPreventDefaultAttribute(rendSeq++, "ondragover", true);
                builder.AddEventStopPropagationAttribute(rendSeq++, "ondragover", true);

                builder.AddAttribute(rendSeq++, "ondragstart", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, HandleDragStart));
                //builder.AddAttribute(rendSeq++, "ondragstart", "event.dataTransfer.setData('', event.target.id);");
                builder.AddEventPreventDefaultAttribute(rendSeq++, "ondragstart", true);
                builder.AddEventStopPropagationAttribute(rendSeq++, "ondragstart", true);
                
                builder.AddAttribute(rendSeq++, "ondragenter", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, HandleDragEnter));
                builder.AddEventPreventDefaultAttribute(rendSeq++, "ondragenter", true);
                builder.AddEventStopPropagationAttribute(rendSeq++, "ondragenter", true);

                builder.AddAttribute(rendSeq++, "ondragleave", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, HandleDragLeave));
                builder.AddEventPreventDefaultAttribute(rendSeq++, "ondragleave", true);
                builder.AddEventStopPropagationAttribute(rendSeq++, "ondragleave", true);

                builder.AddAttribute(rendSeq++, "ondrop", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, HandleDragDrop));
                builder.AddEventPreventDefaultAttribute(rendSeq++, "ondrop", true);
                builder.AddEventStopPropagationAttribute(rendSeq++, "ondrop", true);

                BuildColGroup(builder, ref rendSeq);
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

                    // For each column output a td
                    colCount = 0;
                    string rowColorClass = rowColorClassNormal;
                    foreach (var columnDefinition in ColumnConfigurations)
                    {
                        string formattedValue;
                        if ((colCount == 0) && (dateTime.Minute == 0))
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
                            colCount == 0,
                            false,
                            rowCount == lastRow,
                            rowColorClass);

                        builder.AddAttribute(rendSeq++, "style", styleStr);
                        if ((rowCount == 0) && (colCount == 1))
                        {
                            builder.AddAttribute(rendSeq++, "id", ScheduleID2);
                        }
                        builder.AddContent(1, formattedValue);

                        // Close this column span
                        builder.CloseElement();

                        colCount++;
                    }

                    // Close this row's div
                    builder.CloseElement();

                    rowCount++;
                    dateTime += new TimeSpan(0, 15, 0);
                }

                builder.CloseElement(); // tbody

                builder.CloseElement(); // table

                if (IsSecondMeasurementCompleted)
                {
                    foreach (var appt in Appointments)
                    {
                        ComputeAppointmentCoordinates(
                            appt,
                            out var x,
                            out var y,
                            out var h,
                            out var w);

                        builder.OpenComponent<Material.Blazor.Internal.MBAppointment>(rendSeq++);
                        builder.AddAttribute(rendSeq++, "Height", h);
                        builder.AddAttribute(
                            rendSeq++,
                            "SchedulerRef",
                            global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Material.Blazor.MBScheduler>(
                            this));
                        builder.AddAttribute(rendSeq++, "SchedulerAppointment", appt);
                        builder.AddAttribute(rendSeq++, "Width", w);
                        builder.AddAttribute(rendSeq++, "X", x);
                        builder.AddAttribute(rendSeq++, "Y", y);
                        builder.CloseComponent();
                    }
                }

                builder.CloseElement(); // div mb-scheduler-body-outer

                if (((@class != null) && (@class.Length > 0)) || ((style != null) && (style.Length > 0)))
                {
                    builder.CloseElement(); // div class= style=
                }
#if Logging
                ScheduleLogDebug("                BuildRenderTree completed");
#endif
            }
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

        #region ComputeAppointmentCoordinates

        internal void ComputeAppointmentCoordinates(MBSchedulerAppointment appt, out double x, out double y, out double h, out double w)
        {
            var dayOffsetTimespan = appt.StartTime.Date - StartDate;
            x = LeftEdgeOfColumn1 + Convert.ToDouble(dayOffsetTimespan.Days) * DayColumnWidth;
            if (appt.Column == 2)
            {
                x += AppointmentColumnWidth + 2.0;
            }

            var timeOffsetTimespan = appt.StartTime -
                new DateTime(appt.StartTime.Year,
                    appt.StartTime.Month,
                    appt.StartTime.Day,
                    WorkDayStart.Hour,
                    WorkDayStart.Minute,
                    0);
            y = timeOffsetTimespan.Hours * 4 * FifteenMinuteHeight +
                (timeOffsetTimespan.Minutes / 15) * FifteenMinuteHeight;

            var timeHeightTimespan = appt.EndTime - appt.StartTime;
            h = timeHeightTimespan.Hours * 4 * FifteenMinuteHeight +
                (timeHeightTimespan.Minutes / 15) * FifteenMinuteHeight;
            w = AppointmentColumnWidth;
        }

        #endregion

        #region HandleDragDrop

        private async Task HandleDragDrop(DragEventArgs dea)
        {
            //dropClass = "";

            //if (AllowedStatuses != null && !AllowedStatuses.Contains(Container.Payload.Status)) return;

            //await Container.UpdateJobAsync(ListStatus);
        }

        #endregion

        #region HandleDragEnter

        private async Task HandleDragEnter(DragEventArgs dea)
        {
            //dropClass = "";

            //if (AllowedStatuses != null && !AllowedStatuses.Contains(Container.Payload.Status)) return;

            //await Container.UpdateJobAsync(ListStatus);
        }

        #endregion

        #region HandleDragLeave

        private async Task HandleDragLeave(DragEventArgs dea)
        {
            //dropClass = "";

            //if (AllowedStatuses != null && !AllowedStatuses.Contains(Container.Payload.Status)) return;

            //await Container.UpdateJobAsync(ListStatus);
        }

        #endregion

        #region HandleDragOver

        private async Task HandleDragOver(DragEventArgs dea)
        {
            //dropClass = "";

            //if (AllowedStatuses != null && !AllowedStatuses.Contains(Container.Payload.Status)) return;

            //await Container.UpdateJobAsync(ListStatus);
        }

        #endregion

        #region HandleDragStart

        private async Task HandleDragStart(DragEventArgs dea)
        {
            //dropClass = "";

            //if (AllowedStatuses != null && !AllowedStatuses.Contains(Container.Payload.Status)) return;

            //await Container.UpdateJobAsync(ListStatus);
        }

        #endregion

        #region Logging

#if Logging
        private void ScheduleLogDebug(string message)
        {
            LoggingService.LogDebug(message);
        }

        private void ScheduleLogTrace(string message)
        {
            LoggingService.LogTrace(message);
        }

#endif

        #endregion

        #region MeasureKeyElementsAsync
        private async Task MeasureKeyElementsAsync(bool isFirstMeasurement)
        {
            if (isFirstMeasurement)
            {
                // We are now going to adjust the column widths to integral pixel
                // values for use in the 2nd rendering
                var elementArray = new float[2];
                elementArray = await JsRuntime.InvokeAsync<float[]>(
                            "MaterialBlazor.MBScheduler.getElementDimensions",
                            MeasureID,
                            elementArray);
                var width = Convert.ToInt32(elementArray[1]);
                var timeWidth = (6 * width) / 100;
                var availableWidth = width - timeWidth;
                var standardColumnWidth = availableWidth / NumberOfDays;
                foreach (var col in ColumnConfigurations)
                {
                    col.Width = standardColumnWidth;
                }
                ColumnConfigurations[0].Width = timeWidth;
            }
            else
            {
                var element1Array = new float[2];
                element1Array = await JsRuntime.InvokeAsync<float[]>(
                            "MaterialBlazor.MBScheduler.getElementDimensions",
                            ScheduleID1,
                            element1Array);
                LeftEdgeOfColumn1 = element1Array[1] + 1.0;

                var element2Array = new float[2];
                element2Array = await JsRuntime.InvokeAsync<float[]>(
                            "MaterialBlazor.MBScheduler.getElementDimensions",
                            ScheduleID2,
                            element2Array);
                DayColumnWidth = element2Array[1];
                FifteenMinuteHeight = element2Array[0];
                if (NumberOfSubColumns == 1)
                {
                    AppointmentColumnWidth = element2Array[1] - 5.0;
                }
                else
                {
                    AppointmentColumnWidth = (element2Array[1] / 2.0) - 5;
                }
            }
        }
        #endregion

        #region OnAfterRenderAsync
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await SemaphoreSlim.WaitAsync();
            var needsSHC = false;
            try
            {
                await base.OnAfterRenderAsync(firstRender);

#if Logging
                ScheduleLogDebug("OnAfterRenderAsync entered");
                ScheduleLogDebug("                   firstRender: " + firstRender.ToString());
                ScheduleLogDebug("                   IsFirstMeasurementCompleted: " + IsFirstMeasurementCompleted.ToString());
                ScheduleLogDebug("                   IsSecondMeasurementCompleted: " + IsSecondMeasurementCompleted.ToString());
#endif

                if (!IsFirstMeasurementCompleted)
                {
#if Logging
                    ScheduleLogDebug("                   Calling First MeasureKeyElementsAsync");
#endif
                    await MeasureKeyElementsAsync(true);

                    needsSHC = true;
                    IsFirstMeasurementCompleted = true;
                }
                else
                {
                    if (!IsSecondMeasurementCompleted)
                    {
#if Logging
                        ScheduleLogDebug("                   Calling Second MeasureKeyElementsAsync");
#endif
                        await MeasureKeyElementsAsync(false);

                        needsSHC = true;
                        IsSecondMeasurementCompleted = true;
                    }
                }
            }
            finally
            {
                if (needsSHC)
                {
                    await InvokeAsync(StateHasChanged);
                }
#if Logging
                ScheduleLogDebug("                   about to release semaphore (OnAfterRenderAsync)");
#endif
                SemaphoreSlim.Release();
            }
        }
        #endregion

        #region OnInitializedAsync
        protected override async Task OnInitializedAsync()
        {
#if Logging
            ScheduleLogDebug("MBSchedule.OnInitialized entered");
#endif
            await base.OnInitializedAsync();

            ValidateParameters();

            ColumnConfigurations = new();
            ColumnConfigurations.Add(new ColumnConfiguration("Time", 1));
            var date = StartDate;
            for (int i = 0; i < NumberOfDays; i++)
            {
                ColumnConfigurations.Add(new ColumnConfiguration(date.ToString("D"), 1));
                date += new TimeSpan(24, 0, 0);
            }

#if Logging
            ScheduleLogDebug("MBSchedule.OnInitialized completed");
#endif
        }
        #endregion

        #region ValidateParameters
        internal void ValidateParameters()
        {
            if ((NumberOfSubColumns < 1) || (NumberOfSubColumns > 2))
            {
                throw new Exception("MBScheduler -- Illegal ColumnCount of " + NumberOfSubColumns.ToString());
            }

            if (Appointments == null)
            {
                throw new Exception("MBScheduler -- Appointments is null");
            }
        }

        #endregion

        #region Class ColumnConfiguration

        internal class ColumnConfiguration
        {
            public string Title { get; set; }
            public int Width { get; set; }

            private ColumnConfiguration() { }
            public ColumnConfiguration(
                string title = "",
                int width = 10)
            {
                Title = title;
                Width = width;
            }
        }

        #endregion

        #region Struct DragEndInformation
        public enum DragResult
        {
            BadDrag,
            GoodDrag
        }
        public struct DragEndInfo
        {
            public MBSchedulerAppointment appointment { get; set; }
            public DragResult dragResult { get; set; }
            public DateTime newDateTime { get; set; }
        }

        #endregion

        #region Struct HashCode2

        /// <summary>
        /// A hash code used to help with implementing <see cref="object.GetHashCode()"/>.
        /// 
        /// This code is from the blog post at https://rehansaeed.com/gethashcode-made-easy/
        /// </summary>
        public struct HashCode2 : IEquatable<HashCode2>
        {
            private const int EmptyCollectionPrimeNumber = 19;
            public readonly int value;

            /// <summary>
            /// Initializes a new instance of the <see cref="HashCode"/> struct.
            /// </summary>
            /// <param name="value">The value.</param>
            public HashCode2(int value) => this.value = value;

            /// <summary>
            /// Performs an implicit conversion from <see cref="HashCode"/> to <see cref="int"/>.
            /// </summary>
            /// <param name="hashCode">The hash code.</param>
            /// <returns>The result of the conversion.</returns>
            public static implicit operator int(HashCode2 hashCode) => hashCode.value;

            /// <summary>
            /// Implements the operator ==.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>The result of the operator.</returns>
            public static bool operator ==(HashCode2 left, HashCode2 right) => left.Equals(right);

            /// <summary>
            /// Implements the operator !=.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>The result of the operator.</returns>
            public static bool operator !=(HashCode2 left, HashCode2 right) => !(left == right);

            /// <summary>
            /// Takes the hash code of the specified item.
            /// </summary>
            /// <typeparam name="T">The type of the item.</typeparam>
            /// <param name="item">The item.</param>
            /// <returns>The new hash code.</returns>
            public static HashCode2 Of<T>(T item) => new HashCode2(GetHashCode(item));

            /// <summary>
            /// Takes the hash code of the specified items.
            /// </summary>
            /// <typeparam name="T">The type of the items.</typeparam>
            /// <param name="items">The collection.</param>
            /// <returns>The new hash code.</returns>
            public static HashCode2 OfEach<T>(IEnumerable<T> items) =>
                items == null ? new HashCode2(0) : new HashCode2(GetHashCode(items, 0));

            /// <summary>
            /// Adds the hash code of the specified item.
            /// </summary>
            /// <typeparam name="T">The type of the item.</typeparam>
            /// <param name="item">The item.</param>
            /// <returns>The new hash code.</returns>
            public HashCode2 And<T>(T item) =>
                new HashCode2(CombineHashCodes(this.value, GetHashCode(item)));

            /// <summary>
            /// Adds the hash code of the specified items in the collection.
            /// </summary>
            /// <typeparam name="T">The type of the items.</typeparam>
            /// <param name="items">The collection.</param>
            /// <returns>The new hash code.</returns>
            public HashCode2 AndEach<T>(IEnumerable<T> items)
            {
                if (items == null)
                {
                    return new HashCode2(this.value);
                }

                return new HashCode2(GetHashCode(items, this.value));
            }

            public bool Equals(HashCode2 other) => this.value.Equals(other.value);

            public override bool Equals(object obj)
            {
                if (obj is HashCode2)
                {
                    return this.Equals((HashCode2)obj);
                }

                return false;
            }

            /// <summary>
            /// Throws <see cref="NotSupportedException" />.
            /// </summary>
            /// <returns>Does not return.</returns>
            /// <exception cref="NotSupportedException">Implicitly convert this struct to an <see cref="int" /> to get the hash code.</exception>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode() =>
                throw new NotSupportedException(
                    "Implicitly convert this struct to an int to get the hash code.");

            public static int CombineHashCodes(int h1, int h2)
            {
                unchecked
                {
                    // Code copied from System.Tuple so it must be the best way to combine hash codes or at least a good one.
                    return ((h1 << 5) + h1) ^ h2;
                }
            }

            private static int GetHashCode<T>(T item) => item?.GetHashCode() ?? 0;

            private static int GetHashCode<T>(IEnumerable<T> items, int startHashCode)
            {
                var temp = startHashCode;

                var enumerator = items.GetEnumerator();
                if (enumerator.MoveNext())
                {
                    temp = CombineHashCodes(temp, GetHashCode(enumerator.Current));

                    while (enumerator.MoveNext())
                    {
                        temp = CombineHashCodes(temp, GetHashCode(enumerator.Current));
                    }
                }
                else
                {
                    temp = CombineHashCodes(temp, EmptyCollectionPrimeNumber);
                }

                return temp;
            }
        }

        #endregion
    }

}
