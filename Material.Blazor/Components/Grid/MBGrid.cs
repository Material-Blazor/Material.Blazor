// ToDo:
//
//  Cleanup:
//      Move enumerations to MBEnumerations
//  
//  Bugs:
//      MeasureWidth execution time
//      Padding resolution for GridHeader
//      Resolve issue with ElementReferences
//


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
//
//  Implements a scrollable, multi-column grid. When created we get a list of column
//  config objects and a list of data objects with the column content for each
//  row.
//
//  We 'select' a line when it is clicked on so the caller can either immediately respond or
//  save the selection for later.
//

namespace Material.Blazor
{
    /// <summary>
    /// A Material Theme grid capable of displaying icons, colored text, and text.
    /// 
    /// N.B.: At this time the grid is in preview. Expect the API to change.
    /// </summary>
    public class MBGrid<TRowData> : ComponentFoundation
    {
        #region Parameters
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        /// <summary>
        /// The configuration of each column to be displayed. See the definition of MBGridColumnConfiguration
        /// for details.
        /// </summary>
        [Parameter] public List<MBGridColumnConfiguration<TRowData>> ColumnConfigurations { get; set; } = null;
        /// <summary>
        /// TheDataDictionary contains the data to be displayed. The dictionary key must be a unique identifier
        /// that is used to indicate a row that has been clicked.
        /// </summary>
        [Parameter] public Dictionary<string, TRowData> DataDictionary { get; set; }
        /// <summary>
        /// The GroupExpression is an optional expression indicating that grouping is to occur by a 
        /// particular column.
        /// </summary>
        [Parameter] public Func<TRowData, object>? GroupExpression { get; set; } = null;
        /// <summary>
        /// If you are grouping (As determined by the presence of the GroupExpression) then it is
        /// sometimes a requirement to show empty group headers. See the demo website for an example.
        /// </summary>
        [Parameter] public List<string> GroupOrderedList { get; set; }
        /// <summary>
        /// A boolean indicating whether the selected row is highlighted
        /// </summary>
        [Parameter] public bool HighlightSelectedRow { get; set; } = false;
        /// <summary>
        /// The KeyExpression is used to add a key to each row of the grid
        /// </summary>
        [Parameter] public Func<TRowData, object>? KeyExpression { get; set; } = null;
        /// <summary>
        /// Measurement determines the unit of size (EM, Percent, PX) or if the grid is to measure the
        /// data widths (FitToData)
        /// </summary>
        [Parameter] public MB_Grid_Measurement Measurement { get; set; } = MB_Grid_Measurement.Percent;
        /// <summary>
        /// Callback for a mouse click
        /// </summary>
        [Parameter] public EventCallback<string> OnMouseClick { get; set; }
        /// <summary>
        /// First sort expression
        /// </summary>
        [Parameter] public Func<TRowData, object>? SortExpressionFirst { get; set; } = null;
        /// <summary>
        /// Second sort expression
        /// </summary>
        [Parameter] public Func<TRowData, object>? SortExpressionSecond { get; set; } = null;
        /// <summary>
        /// Headers are optional
        /// </summary>
        [Parameter] public bool SupressHeader { get; set; } = false;
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        #endregion

        #region Members
        private float[] ColumnWidthArray;
        private ElementReference GridBodyRef { get; set; }
        private ElementReference GridHeaderRef { get; set; }
        private string GridBodyID { get; set; } = Utilities.GenerateUniqueElementName();
        private string GridHeaderID { get; set; } = Utilities.GenerateUniqueElementName();
        private bool HasCompletedFullRender { get; set; } = false;
        private bool HasRendered { get; set; } = false;
        private bool IsFirstRender { get; set; } = true;
        private List<KeyValuePair<string, List<TRowData>>> OrderedGroupedData { get; set; } = null;
        private float ScrollWidth { get; set; }
        private string SelectedKey { get; set; } = "";

        //Instantiate a Singleton of the Semaphore with a value of 1. This means that only 1 thread can be granted access at a time.
        private static readonly SemaphoreSlim semaphoreSlim = new(1, 1);

        private bool ShouldRenderReturnValue { get; set; } = true;

        #endregion

        #region BuildColGroup
        private void BuildColGroup(RenderTreeBuilder builder, ref int rendSeq)
        {
            // Create the sizing colgroup collection
            builder.OpenElement(rendSeq++, "colgroup");
            builder.AddAttribute(rendSeq++, "class", "mb-grid-colgroup");
            var colIndex = 0;
            foreach (var col in ColumnConfigurations)
            {
                var styleStr = CreateMeasurementStyle(col, ColumnWidthArray[colIndex]);
                builder.OpenElement(rendSeq++, "col");
                builder.AddAttribute(rendSeq++, "style", styleStr);
                builder.CloseElement(); // col
                colIndex++;
            }
            builder.CloseElement(); // colgroup
        }
        #endregion

        #region BuildNewGridTD
        private static string BuildNewGridTD(
            RenderTreeBuilder builder,
            ref int rendSeq,
            bool isFirstColumn,
            bool isHeaderRow,
            string rowBackgroundColorClass)
        {
            builder.OpenElement(rendSeq++, "td");
            builder.AddAttribute(rendSeq++, "class", "mb-grid-td " + rowBackgroundColorClass);

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

        #region BuildRenderTree
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            if (IsFirstRender)
            {
                Logger.LogInformation("BuildRenderTree entered (IsFirstRender == true)");
                // We are going to render a DIV and nothing else
                // We need to get into OnAfterRenderAsync so that we can use JS interop to measure
                // the text
                base.BuildRenderTree(builder);
                builder.OpenElement(1, "div");
                builder.CloseElement();
                Logger.LogInformation("                leaving (IsFirstRender == true)");
                return;
            }

            Logger.LogInformation("BuildRenderTree entered (IsFirstRender == false)");


            //
            //  Using the column cfg and column data, render our list. Here is the layout.
            //  The column headers are optional.
            //
            //  div mb-grid-header          - Contains the header and the vscroll
            //      table                   - 
            //          tr                  - 
            //              td*             - Header
            //  div mb-grid-body            - Contains the rows and the vscroll
            //      table                   - Contains the rows
            //          tr*                 - Rows
            //              td*             - Columns of the row
            //

            base.BuildRenderTree(builder);
            var rendSeq = 1;
            string styleStr;

            // Based on the column config generate the column titles unless asked not to
            if (!SupressHeader)
            {
                builder.OpenElement(rendSeq++, "div");
                builder.AddAttribute(rendSeq++, "class", "mb-grid-div-header mb-grid-backgroundcolor-header-background");
                //builder.AddAttribute(rendSeq++, "style", "padding-right: " + ScrollWidth.ToString() + "px; ");
                builder.AddAttribute(rendSeq++, "id", GridHeaderID);
                builder.AddElementReferenceCapture(rendSeq++, (__value) => { GridHeaderRef = __value; });
                builder.OpenElement(rendSeq++, "table");
                builder.AddAttribute(rendSeq++, "class", "mb-grid-table");
                BuildColGroup(builder, ref rendSeq);
                builder.OpenElement(rendSeq++, "thead");
                builder.AddAttribute(rendSeq++, "class", "mb-grid-thead");
                builder.OpenElement(rendSeq++, "tr");
                builder.AddAttribute(rendSeq++, "class", "mb-grid-tr");

                // For each column output a TD
                var isHeaderRow = true;
                var colCount = 0;
                foreach (MBGridColumnConfiguration<TRowData> col in ColumnConfigurations)
                {
                    styleStr = BuildNewGridTD(
                        builder,
                        ref rendSeq,
                        colCount == 0,
                        isHeaderRow,
                        "mb-grid-backgroundcolor-header-background");

                    // Set the header colors
                    styleStr += " color: " + col.ForegroundColor.Name + ";";
                    styleStr += " background-color : " + col.BackgroundColor.Name + ";";

                    builder.AddAttribute(rendSeq++, "style", styleStr);
                    builder.AddContent(rendSeq++, col.Title);

                    // Close this column TD
                    builder.CloseElement();

                    colCount++;
                }

                builder.CloseElement(); // tr

                builder.CloseElement(); // thead

                builder.CloseElement(); //table

                builder.CloseElement(); // div mb-grid-header
            }

            //
            // We now need to build a "display centric" data representation with rows added for breaks, etc.
            // For the first pass we are going to skip this step and just display the raw content
            //

            if (OrderedGroupedData != null)
            {
                var isFirstGrouper = true;

                // This div holds the scrolled content
                builder.OpenElement(rendSeq++, "div");
                builder.AddAttribute(rendSeq++, "class", "mb-grid-div-body");
                builder.AddAttribute(rendSeq++, "onscroll",
                    EventCallback.Factory.Create<System.EventArgs>(this, GridSyncScroll));
                builder.AddAttribute(rendSeq++, "id", GridBodyID);
                builder.AddElementReferenceCapture(rendSeq++, (__value) => { GridBodyRef = __value; });
                builder.OpenElement(rendSeq++, "table");
                builder.AddAttribute(rendSeq++, "class", "mb-grid-table");
                BuildColGroup(builder, ref rendSeq);
                builder.OpenElement(rendSeq++, "tbody");
                builder.AddAttribute(rendSeq++, "class", "mb-grid-tbody");

                foreach (var kvp in OrderedGroupedData)
                {
                    if (GroupExpression != null)
                    {
                        // We output a row with the group name
                        // Do a div for this row
                        builder.OpenElement(rendSeq++, "tr");
                        builder.AddAttribute(rendSeq++, "class", "mb-grid-tr");
                        builder.OpenElement(rendSeq++, "td");
                        builder.AddAttribute(rendSeq++, "colspan", ColumnConfigurations.Count.ToString());
                        builder.AddAttribute(rendSeq++, "class", "mb-grid-td-group mb-grid-backgroundcolor-row-group");
                        if (isFirstGrouper)
                        {
                            isFirstGrouper = false;
                            builder.AddAttribute(rendSeq++, "style", "border-top: 1px solid black; ");
                        }
                        builder.AddAttribute(rendSeq++, "mbgrid-td-wide", "0");
                        builder.AddContent(rendSeq++, "  " + kvp.Key);
                        builder.CloseElement(); // td
                        builder.CloseElement(); // tr
                    }

                    var rowCount = 0;
                    foreach (TRowData rowValues in kvp.Value)
                    {
                        var rowKey = KeyExpression(rowValues).ToString(); ;

                        string rowBackgroundColorClass;
                        if ((rowKey == SelectedKey) && HighlightSelectedRow)
                        {
                            // It's the selected row so set the selection color as the background
                            rowBackgroundColorClass = "mb-grid-backgroundcolor-row-selected";
                        }
                        else
                        {
                            // Not selected or not highlighted so we alternate
                            if ((rowCount / 2) * 2 == rowCount)
                            {
                                // Even
                                rowBackgroundColorClass = "mb-grid-backgroundcolor-row-even";
                            }
                            else
                            {
                                // Odd
                                rowBackgroundColorClass = "mb-grid-backgroundcolor-row-odd";
                            }
                        }

                        // Do a tr
                        builder.OpenElement(rendSeq++, "tr");
                        builder.AddAttribute(rendSeq++, "class", "mb-grid-tr " + rowBackgroundColorClass);

                        builder.AddAttribute
                        (
                            rendSeq++,
                            "onclick",
                            EventCallback.Factory.Create<MouseEventArgs>(this, e => OnMouseClickInternal(rowKey))
                        );

                        // For each column output a td
                        var colCount = 0;
                        var isHeaderRow = false;
                        foreach (MBGridColumnConfiguration<TRowData> columnDefinition in ColumnConfigurations)
                        {
                            styleStr = BuildNewGridTD(
                                builder,
                                ref rendSeq,
                                colCount == 0,
                                isHeaderRow,
                                rowBackgroundColorClass);

                            switch (columnDefinition.ColumnType)
                            {
                                case MB_Grid_ColumnType.Icon:
                                    if (columnDefinition.DataExpression != null)
                                    {
                                        try
                                        {
                                            var value = (MBGridIconSpecification)columnDefinition.DataExpression(rowValues);

                                            // We need to add the color alignment to the base styles
                                            styleStr +=
                                                " color: " + ColorToCSSColor(value.IconColor) + ";"
                                                + " text-align: center;";

                                            builder.AddAttribute(rendSeq++, "style", styleStr);
                                            builder.OpenComponent(rendSeq++, typeof(MBIcon));
                                            builder.AddAttribute(rendSeq++, "IconFoundry", value.IconFoundry);
                                            builder.AddAttribute(rendSeq++, "IconName", value.IconName);
                                            builder.CloseComponent();
                                        }
                                        catch
                                        {
                                            throw new Exception("Backing value incorrect for MBGrid.Icon column.");
                                        }
                                    }
                                    break;

                                case MB_Grid_ColumnType.Text:
                                    // It's a text type column so add the text related styles
                                    styleStr +=
                                        " color: " + ColorToCSSColor(columnDefinition.ForegroundColor) + ";";

                                    builder.AddAttribute(rendSeq++, "style", styleStr);

                                    // Bind the object as our content.
                                    if (columnDefinition.DataExpression != null)
                                    {
                                        var value = columnDefinition.DataExpression(rowValues);
                                        var formattedValue = string.IsNullOrEmpty(columnDefinition.FormatString) ? value?.ToString() : string.Format("{0:" + columnDefinition.FormatString + "}", value);
                                        builder.AddContent(1, formattedValue);
                                    }
                                    break;

                                case MB_Grid_ColumnType.TextColor:
                                    if (columnDefinition.DataExpression != null)
                                    {
                                        try
                                        {
                                            var value = (MBGridTextColorSpecification)columnDefinition.DataExpression(rowValues);

                                            if (value.Supress)
                                            {
                                                builder.AddAttribute(rendSeq++, "style", styleStr);
                                            }
                                            else
                                            {
                                                // We need to add the colors
                                                styleStr +=
                                                    " color: " + ColorToCSSColor(value.ForegroundColor)
                                                    + "; background-color: " + ColorToCSSColor(value.BackgroundColor) + ";";

                                                builder.AddAttribute(rendSeq++, "style", styleStr);
                                                builder.AddContent(rendSeq++, value.Text);
                                            }
                                        }
                                        catch
                                        {
                                            throw new Exception("Backing value incorrect for MBGrid.TextColor column.");
                                        }
                                    }
                                    break;

                                default:
                                    throw new Exception("MBGrid -- Unknown column type");
                            }

                            // Close this column span
                            builder.CloseElement();

                            colCount++;
                        }

                        // Close this row's div
                        builder.CloseElement();

                        rowCount++;
                    }
                }

                builder.CloseElement(); // tbody

                builder.CloseElement(); // table

                builder.CloseElement(); // div mb-grid-body-outer
            }

            HasCompletedFullRender = true;
            Logger.LogInformation("                leaving (IsFirstRender == false)");
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

        #region ConvertPxMeasureToFloat
        private static float ConvertPxMeasureToFloat(string pxMeasure)
        {
            //          return Convert.ToSingle(pxMeasure.Substring(0, pxMeasure.Length - 2));
            //          The c# 8.0 range (https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#indices-and-ranges)
            //          allows that to be converted to the following
            return Convert.ToSingle(pxMeasure[0..^2]);
        }
        #endregion

        #region CreateMeasurementStyle
        private string CreateMeasurementStyle(MBGridColumnConfiguration<TRowData> col, float columnWidth)
        {
            string subStyle = Measurement switch
            {
                MB_Grid_Measurement.EM => "em",
                MB_Grid_Measurement.FitToData => "",
                MB_Grid_Measurement.PX => "px",
                MB_Grid_Measurement.Percent => "%",
                _ => throw new Exception("Unexpected measurement type in MBGrid"),
            };

            if (subStyle.Length > 0)
            {
                return
                    "width: " + col.Width.ToString() + subStyle + " !important; " +
                    "max-width: " + col.Width.ToString() + subStyle + " !important; " +
                    "min-width: " + col.Width.ToString() + subStyle + " !important; ";
            }
            else
            {
                return
                    "width: " + columnWidth.ToString() + "px !important; " +
                    "max-width: " + columnWidth.ToString() + "px !important; " +
                    "min-width: " + columnWidth.ToString() + "px !important; ";
            }
        }
        #endregion

        #region GridSyncScroll
        protected async Task GridSyncScroll()
        {
            Logger.LogInformation("GridSyncScroll()");
            await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBGrid.syncScrollByID", GridHeaderID, GridBodyID);
            //await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBGrid.syncScrollByRef", GridHeaderRef, GridBodyRef);
        }
        #endregion

        #region MeasureWidthsAsync
        private async Task MeasureWidthsAsync()
        {
            //
            // We are going to measure the actual sizes using JS if the Measurement is FitToData
            // We need to create the ColumnWidthArray regardless of the measurement type as we need to pass
            // values to CreateTD
            //
            ColumnWidthArray = new float[ColumnConfigurations.Count];

            // Measure the width of a vertical scrollbar (Used to set the padding of the header)
            //ScrollWidth = await JsRuntime.InvokeAsync<int>(
            //    "MaterialBlazor.MBGrid.getScrollBarWidth",
            //    "mb-grid-div-body");
            ScrollWidth = 0;

            if (Measurement == MB_Grid_Measurement.FitToData)
            {
                // Measure the header columns
                var colIndex = 0;
                foreach (var col in ColumnConfigurations)
                {
                    ColumnWidthArray[colIndex] = ConvertPxMeasureToFloat(
                        await JsRuntime.InvokeAsync<string>(
                            "MaterialBlazor.MBGrid.getTextWidth",
                            "mb-grid-header-td",
                            col.Title));
                    colIndex++;
                }

                // Measure the body columns
                foreach (var kvp in DataDictionary)
                {
                    IEnumerable<TRowData> enumerableData = DataDictionary.Values;

                    foreach (var rowValues in enumerableData)
                    {
                        colIndex = 0;
                        foreach (var columnDefinition in ColumnConfigurations)
                        {
                            switch (columnDefinition.ColumnType)
                            {
                                case MB_Grid_ColumnType.Icon:
                                    // We let the column width get driven by the title
                                    break;

                                case MB_Grid_ColumnType.Text:
                                    if (columnDefinition.DataExpression != null)
                                    {
                                        var value = columnDefinition.DataExpression(rowValues);
                                        var formattedValue = string.IsNullOrEmpty(columnDefinition.FormatString) ? value?.ToString() : string.Format("{0:" + columnDefinition.FormatString + "}", value);
                                        var width = ConvertPxMeasureToFloat(
                                            await JsRuntime.InvokeAsync<string>(
                                                "MaterialBlazor.MBGrid.getTextWidth",
                                                "mb-grid-body-td",
                                                formattedValue));
                                        if (width > ColumnWidthArray[colIndex])
                                        {
                                            ColumnWidthArray[colIndex] = width;
                                        }
                                    }
                                    break;

                                case MB_Grid_ColumnType.TextColor:
                                    if (columnDefinition.DataExpression != null)
                                    {
                                        try
                                        {
                                            var value = (MBGridTextColorSpecification)columnDefinition.DataExpression(rowValues);
                                            if (!value.Supress)
                                            {
                                                var width = ConvertPxMeasureToFloat(
                                                    await JsRuntime.InvokeAsync<string>(
                                                        "MaterialBlazor.MBGrid.getTextWidth",
                                                        "mb-grid-body-td",
                                                        value.Text));
                                                if (width > ColumnWidthArray[colIndex])
                                                {
                                                    ColumnWidthArray[colIndex] = width;
                                                }
                                            }
                                        }
                                        catch
                                        {
                                            throw new Exception("Backing value incorrect for MBGrid.TextColor column.");
                                        }
                                    }
                                    break;

                                default:
                                    throw new Exception("MBGrid -- Unknown column type");
                            }

                            colIndex++;
                        }
                    }
                }

                for (var col = 0; col < ColumnWidthArray.Length; col++)
                {
                    // We fudge a bit because we were still getting an ellipsis on the longest text
                    ColumnWidthArray[col] += 1;
                }
            }
        }
        #endregion

        #region OnAfterRenderAsync
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await semaphoreSlim.WaitAsync();
            try
            {
                await base.OnAfterRenderAsync(firstRender);

                HasRendered = true;

                Logger.LogInformation("OnAfterRenderAsync entered");
                Logger.LogInformation("                   firstRender: " + firstRender.ToString());
                Logger.LogInformation("                   IsFirstRender: " + IsFirstRender.ToString());
                Logger.LogInformation("                   HasCompletedFullRender: " + HasCompletedFullRender.ToString());

                if (IsFirstRender)
                {
                    IsFirstRender = false;
                    Logger.LogInformation("                   Calling MeasureWidthsAsync");
                    await MeasureWidthsAsync();
                    Logger.LogInformation("                   Returned from MeasureWidthsAsync");
                }
            }
            finally
            {
                Logger.LogInformation("                   about to release semaphore");

                semaphoreSlim.Release();
            }
        }
        #endregion

        #region OnInitialized
        protected override void OnInitialized()
        {
            Logger.LogInformation("MBGrid.OnInitialized entered");
            base.OnInitialized();

            if (ColumnConfigurations == null)
            {
                throw new System.Exception("MBGrid requires column configuration definitions.");
            }
            Logger.LogInformation("MBGrid.OnInitialized completed");
        }
        #endregion

        #region OnMouseClickInternal
        private bool OnMouseClickInternal(string newRowKey)
        {
            //
            //  We set a click handler on the rows for now, and make the spans transparent. So we only
            //  get the row index. We raise our selection changed event when it changes.
            //
            if (newRowKey != SelectedKey)
            {
                SelectedKey = newRowKey;
                OnMouseClick.InvokeAsync(newRowKey);
            }
            else
            {
                OnMouseClick.InvokeAsync(newRowKey);
            }

            return false;
        }
        #endregion

        #region OnParametersSetAsync
        protected override async Task OnParametersSetAsync()
        {
            await semaphoreSlim.WaitAsync();
            try
            {
                Logger.LogInformation("OnParametersSetAsync entry");
                Logger.LogInformation("                     HasRendered: " + HasRendered.ToString());
                Logger.LogInformation("                     HasCompletedFullRender: " + HasCompletedFullRender.ToString());

                await base.OnParametersSetAsync();

                OrderedGroupedData = null;

                if (DataDictionary != null)
                {
                    // Perform the sort(s)
                    IEnumerable<TRowData> sortedData;
                    if (SortExpressionFirst != null)
                    {
                        if (SortExpressionSecond != null)
                        {
                            sortedData = DataDictionary.Values
                                    .OrderBy(SortExpressionFirst)
                                    .ThenBy(SortExpressionSecond);
                        }
                        else
                        {
                            sortedData = DataDictionary.Values
                                    .OrderBy(SortExpressionFirst);
                        }
                    }
                    else
                    {
                        {
                            // No sorting at all
                            sortedData = DataDictionary.Values;
                        }
                    }

                    // Perform the grouping
                    OrderedGroupedData = new List<KeyValuePair<string, List<TRowData>>>();
                    if (GroupExpression == null)
                    {
                        OrderedGroupedData.Add(new KeyValuePair<string, List<TRowData>>("FauxKey", new List<TRowData>(sortedData)));
                    }
                    else
                    {
                        var groupedData = sortedData
                            .GroupBy(GroupExpression)
                            .ToDictionary(g => g.Key.ToString(), g => g.ToList());

                        if (GroupOrderedList == null)
                        {
                            // We will default to alphabetical order
                            var sortedGroupedData = new SortedDictionary<string, List<TRowData>>(groupedData, new StringComparer());
                            foreach (var kvp in groupedData)
                            {
                                OrderedGroupedData.Add(new KeyValuePair<string, List<TRowData>>(kvp.Key, kvp.Value));
                            }
                        }
                        else
                        {
                            foreach (var key in GroupOrderedList)
                            {
                                if (groupedData.ContainsKey(key))
                                {
                                    OrderedGroupedData.Add(new KeyValuePair<string, List<TRowData>>(key, groupedData[key]));
                                }
                                else
                                {
                                    var emptyList = new List<TRowData>();
                                    OrderedGroupedData.Add(new KeyValuePair<string, List<TRowData>>(key, emptyList));
                                }
                            }
                        }
                    }
                }

                if (HasRendered)
                {
                    Logger.LogInformation("                     Calling MeasureWidthsAsync");
                    await MeasureWidthsAsync();
                    Logger.LogInformation("                     Returned from MeasureWidthsAsync");
                }
            }
            finally
            {
                Logger.LogInformation("                     about to release semaphore");
                semaphoreSlim.Release();
            }
        }
        #endregion

        #region SetShouldRenderReturnValue
        public void SetShouldRenderReturnValue(bool shouldRenderReturnValue)
        {
            ShouldRenderReturnValue = shouldRenderReturnValue;
        }
        #endregion

        #region ShouldRender
        protected override bool ShouldRender()
        {
            return ShouldRenderReturnValue;
        }
        #endregion

        #region StringComparer
        class StringComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return string.Compare(x, y, true);
            }
        }
        #endregion

    }
}
