#define Logging

using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
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

        [Parameter] public IEnumerable<MBSchedulerAppointment> Appointments { get; set; }
        [Parameter] public int NumberOfColumns { get; set; } = 2;
        [Parameter] public int NumberOfDays { get; set; } = 5;
        [Parameter] public DateTime StartDate { get; set; } = new DateTime(2022, 04, 04);
        [Parameter] public TimeOnly WorkDayStart { get; set; } = new TimeOnly(7, 0, 0);
        [Parameter] public TimeOnly WorkDayEnd { get; set; } = new TimeOnly(17, 0, 0);

        [Inject] IJSRuntime JsRuntime { get; set; }

        private int AppointmentColumnWidth { get; set; }
        private List<ColumnConfiguration> ColumnConfigurations { get; set; }
        private double DayColumnWidth { get; set; }
        private double FifteenMinuteHeight { get; set; }
        private double HeaderHeight { get; set; }
        private bool IsMeasurementCompleted { get; set; } = false;
        private double LeftEdgeOfColumn1 { get; set; }
        private string ScheduleID1 { get; set; } = Utilities.GenerateUniqueElementName();
        private string ScheduleID2 { get; set; } = Utilities.GenerateUniqueElementName();

        //Instantiate a Semaphore with a value of 1. This means that only 1 thread can be granted access at a time.
        private SemaphoreSlim SemaphoreSlim { get; set; } = new(1, 1);
        private bool ShouldRenderValue { get; set; } = true;

        #endregion

        #region BuildRenderTree
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
#if Logging
            ScheduleLogDebug("BuildRenderTree entered; IsMeasurementCompleted == " + IsMeasurementCompleted.ToString());
            ScheduleLogDebug("                         ShouldRenderValue == " + ShouldRenderValue.ToString());
#endif
            var rendSeq = 1;
            string styleStr;

            if (((@class != null) && (@class.Length > 0)) || ((style != null) && (style.Length > 0)))
            {
                builder.OpenElement(rendSeq++, "div");
                builder.AddAttribute(rendSeq++, "class", "mb-scheduler-div-outer " + @class);
                builder.AddAttribute(rendSeq++, "style", style);
            }

            // This div holds the content
            builder.OpenElement(rendSeq++, "div");
            builder.AddAttribute(rendSeq++, "class", "mb-scheduler-div-body");

            // For each column output a ScheduleColumn
            var colCount = 0;
            foreach (var columnDefinition in ColumnConfigurations)
            {
                builder.OpenComponent<Material.Blazor.Internal.MBScheduleColumn>(rendSeq++);
                builder.AddAttribute(rendSeq++, "ColumnTitle", columnDefinition.Title);
                builder.AddAttribute(rendSeq++, "ColumnWidth", columnDefinition.Width);
                builder.AddAttribute(rendSeq++, "IsFirstDataColumn", colCount == 1);
                builder.AddAttribute(rendSeq++, "IsTimeColumn", colCount == 0);
                builder.AddAttribute(rendSeq++, "ScheduleID1", ScheduleID1);
                builder.AddAttribute(rendSeq++, "ScheduleID2", ScheduleID2);
                builder.AddAttribute(rendSeq++, "WorkdayEnd", WorkDayEnd);
                builder.AddAttribute(rendSeq++, "WorkdayStart", WorkDayStart);
                builder.CloseComponent();
                colCount++;
            }

            if (IsMeasurementCompleted)
            {
                foreach (var appt in Appointments)
                {
                    ComputeAppointmentPosition(
                        appt,
                        out var x,
                        out var y,
                        out var h,
                        out var w);

                    builder.OpenComponent<Material.Blazor.Internal.MBAppointment>(rendSeq++);
                    builder.AddAttribute(rendSeq++, "BackgroundColor", appt.BackgroundColor);
                    builder.AddAttribute(rendSeq++, "ForegroundColor", appt.ForegroundColor);
                    builder.AddAttribute(rendSeq++, "Height", h);
                    builder.AddAttribute(rendSeq++, "Title", appt.Title);
                    builder.AddAttribute(rendSeq++, "Width", w);
                    builder.AddAttribute(rendSeq++, "X", x);
                    builder.AddAttribute(rendSeq++, "Y", y);
                    builder.CloseComponent();
                }
            }

            builder.CloseElement(); // div mb-scheduler-div-body

            if (((@class != null) && (@class.Length > 0)) || ((style != null) && (style.Length > 0)))
            {
                builder.CloseElement(); // div class= style=
            }
#if Logging
            ScheduleLogDebug("                BuildRenderTree completed");
#endif
        }
        #endregion

        #region BuildScheduleTD
        internal static string BuildScheduleTD(
            RenderTreeBuilder builder,
            ref int rendSeq,
            bool isFirstColumn,
            bool isHeaderRow,
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
        #endregion

        #region ComputeAppointmentPosition

        internal void ComputeAppointmentPosition(MBSchedulerAppointment appt, out double x, out double y, out double h, out double w)
        {
            var dayOffsetTimespan = appt.StartTime.Date - StartDate;
            x = LeftEdgeOfColumn1 + dayOffsetTimespan.Days * DayColumnWidth;
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
            y = HeaderHeight +
                timeOffsetTimespan.Hours * 4 * FifteenMinuteHeight +
                (timeOffsetTimespan.Minutes / 15) * FifteenMinuteHeight;

            var timeHeightTimespan = appt.EndTime - appt.StartTime;
            h = timeHeightTimespan.Hours * 4 * FifteenMinuteHeight +
                (timeHeightTimespan.Minutes / 15) * FifteenMinuteHeight;
            w = AppointmentColumnWidth;
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
        private async Task MeasureKeyElementsAsync()
        {
            var element1Array = new float[2];
            element1Array = await JsRuntime.InvokeAsync<float[]>(
                        "MaterialBlazor.MBScheduler.getElementDimensions",
                        ScheduleID1,
                        element1Array);
            HeaderHeight = element1Array[0];
            LeftEdgeOfColumn1 = element1Array[1];

            var element2Array = new float[2];
            element2Array = await JsRuntime.InvokeAsync<float[]>(
                        "MaterialBlazor.MBScheduler.getElementDimensions",
                        ScheduleID2,
                        element2Array);
            DayColumnWidth = element2Array[1];
            FifteenMinuteHeight = element2Array[0];
            if (NumberOfColumns == 1)
            {
                AppointmentColumnWidth = Convert.ToInt32(element2Array[1]) - 5;
            }
            else
            {
                AppointmentColumnWidth = Convert.ToInt32(element2Array[1] / 2.0) - 5;
            }
        }
        #endregion

        #region OnAfterRenderAsync
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            var needsSHC = false;
            await SemaphoreSlim.WaitAsync();
            try
            {
                await base.OnAfterRenderAsync(firstRender);

#if Logging
                ScheduleLogDebug("OnAfterRenderAsync entered");
                ScheduleLogDebug("                   firstRender: " + firstRender.ToString());
                ScheduleLogDebug("                   IsMeasurementCompleted: " + IsMeasurementCompleted.ToString());
#endif

                if (!IsMeasurementCompleted)
                {
                    IsMeasurementCompleted = true;
                    needsSHC = true;
#if Logging
                    ScheduleLogDebug("                   Calling MeasureKeyElementsAsync");
#endif
                    await MeasureKeyElementsAsync();
#if Logging
                    ScheduleLogDebug("                   Returned from MeasureKeyElementsAsync");
#endif
                    needsSHC = true;
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

            int timeWidth = 6;
            int columnWidth = (100 - timeWidth) / NumberOfDays;
            int leftOver = (100 - timeWidth) - (columnWidth * NumberOfDays);
            timeWidth += leftOver;
            ColumnConfigurations = new();
            ColumnConfigurations.Add(new ColumnConfiguration("Time", timeWidth));
            var date = StartDate;
            for (int i = 0; i < NumberOfDays; i++)
            {
                ColumnConfigurations.Add(new ColumnConfiguration(date.ToString("D"), columnWidth));
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
            if ((NumberOfColumns < 1) || (NumberOfColumns > 2))
            {
                throw new Exception("MBScheduler -- Illegal ColumnCount of " + NumberOfColumns.ToString());
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
