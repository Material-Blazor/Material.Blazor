// ToDo:
//
//  Cleanup:
//      Move enumerations to MBEnumerations
//  
//  Bugs:
//      MeasureWidth execution time
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
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        [Parameter] public List<MBGridColumnConfiguration<TRowData>> ColumnConfigurations { get; set; } = null;
        [Parameter] public Dictionary<string, TRowData> DataDictionary { get; set; }
        [Parameter] public Func<TRowData, object>? GroupExpression { get; set; } = null;
        [Parameter] public List<string> GroupOrderedList { get; set; }
        [Parameter] public bool HighlightSelectedRow { get; set; } = false;
        [Parameter] public Func<TRowData, object>? KeyExpression { get; set; } = null;
        [Parameter] public MB_Grid_Measurement Measurement { get; set; } = MB_Grid_Measurement.Percent;
        [Parameter] public EventCallback<string> OnMouseClick { get; set; }
        [Parameter] public Func<TRowData, object>? SortExpressionFirst { get; set; } = null;
        [Parameter] public Func<TRowData, object>? SortExpressionSecond { get; set; } = null;
        [Parameter] public bool SupressHeader { get; set; } = false;
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

        [Inject] private protected ILogger<MBGrid<TRowData>> Logger { get; set; }

        private float[] ColumnWidthArray;
        private string GridBodyID { get; set; } = Utilities.GenerateUniqueElementName();
        private string GridHeaderID { get; set; } = Utilities.GenerateUniqueElementName();
        private bool HasCompletedFullRender { get; set; } = false;
        private bool IsFirstRender { get; set; } = true;
        private List<KeyValuePair<string, List<TRowData>>> OrderedGroupedData { get; set; } = null;
        private float ScrollWidth { get; set; }
        private string SelectedKey { get; set; } = "";

        //Instantiate a Singleton of the Semaphore with a value of 1. This means that only 1 thread can be granted access at a time.
        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 1);

        protected override void OnInitialized()
        {
            base.OnInitialized();

            if (ColumnConfigurations == null)
            {
                throw new System.Exception("MBGrid requires column configuration definitions.");
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await semaphoreSlim.WaitAsync();
            try
            {
                await base.OnAfterRenderAsync(firstRender);

                Logger.LogInformation("OnAfterRenderAsync entered");
                Logger.LogInformation("                   firstRender: " + firstRender.ToString());
                Logger.LogInformation("                   IsFirstRender: " + IsFirstRender.ToString());
                Logger.LogInformation("                   HasCompletedFullRender: " + HasCompletedFullRender.ToString());

                if (IsFirstRender)
                {
                    IsFirstRender = false;
                    await MeasureWidths();
                    StateHasChanged();
                }
            }
            finally
            {
                Logger.LogInformation("                   about to release semaphore");

                semaphoreSlim.Release();
            }
        }

        protected override async Task OnParametersSetAsync()
        {
            Logger.LogDebug("OnParametersSetAsync entry");
            Logger.LogDebug("                     HasCompletedFullRender: " + HasCompletedFullRender.ToString());

            await base.OnParametersSetAsync();

            if (HasCompletedFullRender)
            {
                //await MeasureWidths();
            }
            Logger.LogDebug("                     exit");
        }

        private async Task MeasureWidths()
        {
            Logger.LogDebug("MeasureWidths entered");

            //
            // We are going to measure the actual sizes using JS if the Measurement is FitToData
            // We need to create the ColumnWidthArray regardless of the measurement type as we need to pass
            // values to CreateTD
            //
            ColumnWidthArray = new float[ColumnConfigurations.Count];

            // Measure the width of a vertical scrollbar (Used to set the padding of the header)
            ScrollWidth = await JsRuntime.InvokeAsync<int>("MaterialBlazor.MBGrid.getScrollBarWidth");

            if (Measurement == MB_Grid_Measurement.FitToData)
            {
                // Measure the header columns
                var colIndex = 0;
                foreach (var col in ColumnConfigurations)
                {
                    ColumnWidthArray[colIndex] = ConvertPxMeasureToFloat(
                        await JsRuntime.InvokeAsync<string>(
                            "MaterialBlazor.MBGrid.getTextWidth",
                            "mb-grid-div-header",
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
                                                "mb-grid-div-body",
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
                                                        "mb-grid-div-body",
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
                    // We need to add the padding amount from the mb-grid-td style
                    ColumnWidthArray[col] += 8;
                }
            }
            Logger.LogDebug("OnAfterRenderAsync/MeasureWidths complete");
        }
        private float ConvertPxMeasureToFloat(string pxMeasure)
        {
            return Convert.ToSingle(pxMeasure.Substring(0, pxMeasure.Length - 2));
        }
        protected async Task GridSyncScroll()
        {
            await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBGrid.syncScroll", GridHeaderID, GridBodyID);
        }

        class StringComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return string.Compare(x, y, true);
            }
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            if (IsFirstRender)
            {
                Logger.LogDebug("BuildRenderTree entered (IsFirstRender == true)");
                // We are going to render a DIV and nothing else
                // We need to get into OnAfterRenderAsync so that we can use JS interop to measure
                // the text
                base.BuildRenderTree(builder);
                builder.OpenElement(1, "div");
                builder.CloseElement();
                Logger.LogDebug("                leaving (IsFirstRender == true)");
                return;
            }

            Logger.LogDebug("BuildRenderTree entered (IsFirstRender == false)");

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
                builder.AddAttribute(rendSeq++, "style", "padding-right: " + ScrollWidth.ToString() + "px; ");
                builder.AddAttribute(rendSeq++, "id", GridHeaderID);
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
                        col,
                        "mb-grid-backgroundcolor-header-background",
                        ColumnWidthArray[colCount]);

                    // Set the header colors
                    styleStr += " color: " + col.ForegroundColor.Name + ";";
                    styleStr += " background-color : " + col.BackgroundColor.Name + ";";

                    builder.AddAttribute(rendSeq++, "style", styleStr);
                    builder.AddAttribute(rendSeq++, "mbgrid-td-normal", colCount.ToString());
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
                                columnDefinition,
                                rowBackgroundColorClass,
                                ColumnWidthArray[colCount]);
                            builder.AddAttribute(rendSeq++, "mbgrid-td-normal", colCount.ToString()); ;

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
            Logger.LogDebug("                leaving (IsFirstRender == false)");
        }

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

        private string BuildNewGridTD(
            RenderTreeBuilder builder,
            ref int rendSeq,
            bool isFirstColumn,
            bool isHeaderRow,
            MBGridColumnConfiguration<TRowData> col,
            string rowBackgroundColorClass,
            float columnWidth)
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

        private string CreateMeasurementStyle(MBGridColumnConfiguration<TRowData> col, float columnWidth)
        {
            string subStyle;
            switch (Measurement)
            {
                case MB_Grid_Measurement.EM:
                    subStyle = "em";
                    break;

                case MB_Grid_Measurement.FitToData:
                    subStyle = "";
                    break;

                case MB_Grid_Measurement.PX:
                    subStyle = "px";
                    break;

                case MB_Grid_Measurement.Percent:
                    subStyle = "%";
                    break;

                default:
                    throw new Exception("Unexpected measurement type in MBGrid");
            }

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


        //
        //  We set a click handler on the rows for now, and make the spans transparent. So we only
        //  get the row index. We raise our selection changed event when it changes.
        //
        private bool OnMouseClickInternal(string newRowKey)
        {
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
        private string ColorToCSSColor(Color color)
        {
            int rawColor = color.ToArgb();
            rawColor &= 0xFFFFFF;
            return "#" + rawColor.ToString("X6");
        }

    }
}
