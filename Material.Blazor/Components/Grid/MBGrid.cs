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
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
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

        /// <summary>
        /// The configuration of each column to be displayed. See the definition of MBGridColumnConfiguration
        /// for details.
        /// </summary>
        [Parameter] public IEnumerable<MBGridColumnConfiguration<TRowData>> ColumnConfigurations { get; set; } = null;

        /// <summary>
        /// The Group is an optional boolean indicating that grouping is in effect.
        /// </summary>
        [Parameter] public bool Group { get; set; } = false;

        /// <summary>
        /// The GroupedOrderedData contains the data to be displayed.
        /// The outer key is used for grouping and is directly displayed if grouping is enabled.
        /// The inner key must be a unique identifier
        /// that is used to indicate a row that has been clicked.
        /// </summary>
        [Parameter] public IEnumerable<KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>> GroupedOrderedData { get; set; }

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
        /// ObscurePMI controls whether or not columns marked as PMI are obscured.
        /// </summary>
        [Parameter] public bool ObscurePMI { get; set; }

        /// <summary>
        /// Callback for a mouse click
        /// </summary>
        [Parameter] public EventCallback<string> OnMouseClick { get; set; }

        /// <summary>
        /// Headers are optional
        /// </summary>
        [Parameter] public bool SupressHeader { get; set; } = false;

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
        private float ScrollWidth { get; set; }
        private string SelectedKey { get; set; } = "";

        //Instantiate a Singleton of the Semaphore with a value of 1. This means that only 1 thread can be granted access at a time.
        private static readonly SemaphoreSlim semaphoreSlim = new(1, 1);

        private bool ShouldRenderValue { get; set; } = true;

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
            if (IsFirstRender ||
                (!ShouldRenderValue) ||
                (ColumnWidthArray == null) ||
                ((ColumnWidthArray != null) && (ColumnWidthArray.Length != ColumnConfigurations.Count())))
            {
#if LoggingVerbose
                Logger.LogInformation("BuildRenderTree entered (IsFirstRender == true)");
#endif
                // We are going to render a DIV and nothing else
                // We need to get into OnAfterRenderAsync so that we can use JS interop to measure
                // the text
                base.BuildRenderTree(builder);
                builder.OpenElement(1, "div");
                builder.CloseElement();
#if LoggingVerbose
                Logger.LogInformation("                leaving (IsFirstRender == true)");
#endif
                return;
            }

#if LoggingVerbose
            Logger.LogInformation("BuildRenderTree entered (IsFirstRender == false)");
#endif

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
            var rendSeq = 2;
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
                    styleStr += " color: " + col.ForegroundColorHeader.Name + ";";
                    styleStr += " background-color : " + col.BackgroundColorHeader.Name + ";";

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

            if (GroupedOrderedData != null)
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

                foreach (var kvp in GroupedOrderedData)
                {
                    if (Group)
                    {
                        // We output a row with the group name
                        // Do a div for this row
                        builder.OpenElement(rendSeq++, "tr");
                        builder.AddAttribute(rendSeq++, "class", "mb-grid-tr");
                        builder.OpenElement(rendSeq++, "td");
                        builder.AddAttribute(rendSeq++, "colspan", ColumnConfigurations.Count().ToString());
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
                    foreach (var rowValues in kvp.Value)
                    {
                        var rowKey = KeyExpression(rowValues.Value).ToString();

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
                                            var value = (MBGridIconSpecification)columnDefinition.DataExpression(rowValues.Value);

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
                                    // We may be overriding the alternating row color added by class

                                    if (columnDefinition.ForegroundColorExpression != null)
                                    {
                                        var value = columnDefinition.ForegroundColorExpression(rowValues.Value);
                                        styleStr +=
                                            " color: " + ColorToCSSColor((Color)value) + "; ";
                                    }

                                    if (columnDefinition.BackgroundColorExpression != null)
                                    {
                                        var value = columnDefinition.BackgroundColorExpression(rowValues.Value);
                                        styleStr +=
                                            " background-color: " + ColorToCSSColor((Color)value) + "; ";
                                    }

                                    if (columnDefinition.IsPMI && ObscurePMI)
                                    {
                                        styleStr +=
                                            " filter: blur(0.25em); ";
                                    }

                                    builder.AddAttribute(rendSeq++, "style", styleStr);

                                    // Bind the object as our content.
                                    if (columnDefinition.DataExpression != null)
                                    {
                                        var value = columnDefinition.DataExpression(rowValues.Value);
                                        var formattedValue = string.IsNullOrEmpty(columnDefinition.FormatString) ? value?.ToString() : string.Format("{0:" + columnDefinition.FormatString + "}", value);
                                        builder.AddContent(1, formattedValue);
                                    }
                                    break;

                                case MB_Grid_ColumnType.TextColor:
                                    if (columnDefinition.DataExpression != null)
                                    {
                                        try
                                        {
                                            var value = (MBGridTextColorSpecification)columnDefinition.DataExpression(rowValues.Value);

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

                                                if (columnDefinition.IsPMI && ObscurePMI)
                                                {
                                                    styleStr +=
                                                        " filter: blur(0.25em); ";
                                                }

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
#if LoggingVerbose
            Logger.LogInformation("                leaving (IsFirstRender == false)");
#endif
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
#if LoggingVerbose
            Logger.LogInformation("GridSyncScroll()");
#endif
            await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBGrid.syncScrollByID", GridHeaderID, GridBodyID);
            //await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBGrid.syncScrollByRef", GridHeaderRef, GridBodyRef);
        }
        #endregion

        #region MeasureWidthsAsync
        private async Task MeasureWidthsAsync()
        {
            if (GroupedOrderedData == null)
            {
                return;
            }
            //
            // We are going to measure the actual sizes using JS if the Measurement is FitToData
            // We need to create the ColumnWidthArray regardless of the measurement type as we need to pass
            // values to CreateTD
            //
            ColumnWidthArray = new float[ColumnConfigurations.Count()];

            // Measure the width of a vertical scrollbar (Used to set the padding of the header)
            ScrollWidth = await JsRuntime.InvokeAsync<int>(
                "MaterialBlazor.MBGrid.getScrollBarWidth",
                "mb-grid-div-body");
            ScrollWidth = 0;

            if (Measurement == MB_Grid_Measurement.FitToData)
            {
                // Create a simple data dictionary from the GroupedDataDictionary
                var dataList = new List<TRowData>();
                foreach (var outerKVP in GroupedOrderedData)
                {
                    foreach (var innerKVP in outerKVP.Value)
                    {
                        dataList.Add(innerKVP.Value);
                    }
                }
                // Measure the header columns
                var stringArrayHeader = new string[ColumnConfigurations.Count()];
                var colIndex = 0;
                foreach (var col in ColumnConfigurations)
                {
                    stringArrayHeader[colIndex] = col.Title;
                    colIndex++;
                }

                ColumnWidthArray = await JsRuntime.InvokeAsync<float[]>(
                        "MaterialBlazor.MBGrid.getTextWidths",
                        "mb-grid-header-td-measure",
                        ColumnWidthArray,
                        stringArrayHeader);

                // Measure the body columns
                var stringArrayBody = new string[ColumnConfigurations.Count() * dataList.Count];
                colIndex = 0;
                foreach (var enumerableData in dataList)
                {
                    foreach (var columnDefinition in ColumnConfigurations)
                    {
                        switch (columnDefinition.ColumnType)
                        {
                            case MB_Grid_ColumnType.Icon:
                                // We let the column width get driven by the title
                                stringArrayBody[colIndex] = "";
                                break;

                            case MB_Grid_ColumnType.Text:
                                if (columnDefinition.DataExpression != null)
                                {
                                    var value = columnDefinition.DataExpression(enumerableData);
                                    var formattedValue = string.IsNullOrEmpty(columnDefinition.FormatString) ? value?.ToString() : string.Format("{0:" + columnDefinition.FormatString + "}", value);
                                    stringArrayBody[colIndex] = formattedValue;
                                }
                                break;

                            case MB_Grid_ColumnType.TextColor:
                                if (columnDefinition.DataExpression != null)
                                {
                                    try
                                    {
                                        var value = (MBGridTextColorSpecification)columnDefinition.DataExpression(enumerableData);
                                        if (!value.Supress)
                                        {
                                            stringArrayBody[colIndex] = value.Text;
                                        }
                                        else
                                        {
                                            stringArrayBody[colIndex] = "";
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
                ColumnWidthArray = await JsRuntime.InvokeAsync<float[]>(
                        "MaterialBlazor.MBGrid.getTextWidths",
                        "mb-grid-body-td-measure",
                        ColumnWidthArray,
                        stringArrayBody);

                for (var col = 0; col < ColumnWidthArray.Length; col++)
                {
                    //
                    // We adjust a bit because we were still getting an ellipsis on the longest text.
                    // This is caused by the fact that <Col style="width: 372.8px"/> creates
                    // a 372px wide column
                    //

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

#if LoggingVerbose
                Logger.LogInformation("OnAfterRenderAsync entered");
                Logger.LogInformation("                   firstRender: " + firstRender.ToString());
                Logger.LogInformation("                   IsFirstRender: " + IsFirstRender.ToString());
                Logger.LogInformation("                   HasCompletedFullRender: " + HasCompletedFullRender.ToString());
#endif

                if (IsFirstRender)
                {
                    IsFirstRender = false;
                    Logger.LogInformation("                   Calling MeasureWidthsAsync");
                    await MeasureWidthsAsync();
                    Logger.LogInformation("                   Returned from MeasureWidthsAsync");
                    StateHasChanged();
                }
            }
            finally
            {
#if LoggingVerbose
                Logger.LogInformation("                   about to release semaphore");
#endif
                semaphoreSlim.Release();
            }
        }
        #endregion

        #region OnInitialized
        protected override void OnInitialized()
        {
#if LoggingVerbose
            Logger.LogInformation("MBGrid.OnInitialized entered");
#endif
            base.OnInitialized();

            if (ColumnConfigurations == null)
            {
                throw new System.Exception("MBGrid requires column configuration definitions.");
            }
#if LoggingVerbose
            Logger.LogInformation("MBGrid.OnInitialized completed");
#endif
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
#if LoggingVerbose
                Logger.LogInformation("OnParametersSetAsync entry");
                Logger.LogInformation("                     HasRendered: " + HasRendered.ToString());
                Logger.LogInformation("                     HasCompletedFullRender: " + HasCompletedFullRender.ToString());
#endif

                await base.OnParametersSetAsync();

                if (HasRendered)
                {
                    Logger.LogInformation("                     Calling MeasureWidthsAsync");
                    await MeasureWidthsAsync();
                    Logger.LogInformation("                     Returned from MeasureWidthsAsync");
                    StateHasChanged();
                }
            }
            finally
            {
#if LoggingVerbose
                Logger.LogInformation("                     about to release semaphore");
#endif
                semaphoreSlim.Release();
            }
        }
        #endregion

        #region SetShouldRenderValue
        public void SetShouldRenderValue(bool shouldRenderReturnValue)
        {
            ShouldRenderValue = shouldRenderReturnValue;
        }
        #endregion

        #region ShouldRender
        protected override bool ShouldRender()
        {
            return ShouldRenderValue;
        }
        #endregion

    }
}
