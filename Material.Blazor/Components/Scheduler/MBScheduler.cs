#define xLogging

// ToDo:
//
//  Cleanup:
//      Move enumerations to MBEnumerations
//  
//  Bugs:
//      Padding resolution for GridHeader
//      Resolve issue with ElementReferences
//

using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
//
//  Implements a scrollable, multi-column schedule.
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

        [Parameter] public int NumberOfDays { get; set; } = 5;
        [Parameter] public DateTime StartDate { get; set; } = new DateTime(2022, 04, 04);
        [Parameter] public DateTime WorkDayStart { get; set; } = new DateTime(2000, 1, 1, 7, 0, 0); //the time portion is important
        [Parameter] public DateTime WorkDayEnd { get; set; } = new DateTime(2000, 1, 1, 17, 0, 0); //the time portion is important

        [Inject] IJSRuntime JsRuntime { get; set; }

        private List<ColumnConfiguration> ColumnConfigurations { get; set; }
        private bool HasCompletedFullRender { get; set; } = false;
        private bool IsSimpleRender { get; set; } = true;
        //private bool IsMeasurementNeeded { get; set; } = false;
        //private float ScrollWidth { get; set; }
        //private string SelectedKey { get; set; } = "";

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
                var styleStr = CreateMeasurementStyle(col);
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
            ScheduleLogDebug("BuildRenderTree entered; IsSimpleRender == " + IsSimpleRender.ToString());
            ScheduleLogDebug("                         HasCompletedFullRender == " + HasCompletedFullRender.ToString());
            ScheduleLogDebug("                         ShouldRenderValue == " + ShouldRenderValue.ToString());
#endif
            if (IsSimpleRender || (!ShouldRenderValue))
            {
#if Logging
                ScheduleLogDebug("                (Simple) entered");
#endif
                // We are going to render a DIV and nothing else
                // We need to get into OnAfterRenderAsync so that we can use JS interop to measure
                // the text
                base.BuildRenderTree(builder);
                builder.OpenElement(1, "div");
                builder.CloseElement();
                HasCompletedFullRender = false;
#if Logging
                ScheduleLogDebug("                (Simple) leaving");
#endif
            }
            else
            {
#if Logging
                ScheduleLogDebug("                (Full) entered");
#endif

                //
                //  Using the column cfg and column data, render our list. Here is the layout.
                //  The column headers are optional.
                //
                //  div class="@class", style="@style"
                //      div mb-scheduler-header          - Contains the header and the vscroll
                //          table                   - 
                //              tr                  - 
                //                  td*             - Header
                //      div mb-scheduler-body            - Contains the rows and the vscroll
                //          table                   - Contains the rows
                //              tr*                 - Rows
                //                  td*             - Columns of the row
                //

                base.BuildRenderTree(builder);
                var rendSeq = 2;
                string styleStr;

                if (((@class != null) && (@class.Length > 0)) || ((style != null) && (style.Length > 0)))
                {
                    builder.OpenElement(rendSeq++, "div");
                    builder.AddAttribute(rendSeq++, "class", "mb-scheduler-div-outer " + @class);
                    builder.AddAttribute(rendSeq++, "style", style);
                }

                // Based on the column config generate the column titles unless asked not to
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
                        "mb-scheduler-backgroundcolor-header-background");

                    // Set the header colors
                    styleStr += " color: Black;";
                    styleStr += " background-color : LightGray;";

                    builder.AddAttribute(rendSeq++, "style", styleStr);
                    builder.AddContent(rendSeq++, col.Title);

                    // Close this column TD
                    builder.CloseElement();

                    colCount++;
                }

                builder.CloseElement(); // tr

                builder.CloseElement(); // thead

                builder.CloseElement(); //table

                builder.CloseElement(); // div mb-scheduler-header

            }

#if Logging
            ScheduleLogDebug("                leaving; IsSimpleRender == " + IsSimpleRender.ToString());
            ScheduleLogDebug("                leaving; HasCompletedFullRender == " + HasCompletedFullRender.ToString());
#endif
        }
        #endregion

        #region BuildScheduleTD
        private static string BuildScheduleTD(
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

        #region ColorToCSSColor
        private static string ColorToCSSColor(Color color)
        {
            int rawColor = color.ToArgb();
            rawColor &= 0xFFFFFF;
            return "#" + rawColor.ToString("X6");
        }
        #endregion

        #region CreateMeasurementStyle
        private string CreateMeasurementStyle(ColumnConfiguration col)
        {
            return
                "width: " + col.Width.ToString() + "% !important; " +
                "max-width: " + col.Width.ToString() + "% !important; " +
                "min-width: " + col.Width.ToString() + "% !important; ";
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
                ScheduleLogDebug("                   IsSimpleRender: " + IsSimpleRender.ToString());
                ScheduleLogDebug("                   IsMeasurementNeeded: " + IsMeasurementNeeded.ToString());
#endif

                if (IsSimpleRender)
                {
                    IsSimpleRender = false;
                    needsSHC = true;
                }

//                if (IsMeasurementNeeded)
//                {
//                    IsMeasurementNeeded = false;

//                    if (Measurement == MB_Grid_Measurement.FitToData)
//                    {
//#if Logging
//                        ScheduleLogDebug("                   Calling MeasureWidthsAsync");
//#endif
//                        await MeasureWidthsAsync();
//#if Logging
//                        ScheduleLogDebug("                   Returned from MeasureWidthsAsync");
//#endif
//                        needsSHC = true;
//                    }
//                }
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

        #region OnInitialized
        protected override async Task OnInitializedAsync()
        {
#if Logging
            ScheduleLogDebug("MBSchedule.OnInitialized entered");
#endif
            await base.OnInitializedAsync();

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
