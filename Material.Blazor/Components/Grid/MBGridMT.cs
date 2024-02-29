#define Logging

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

namespace Material.Blazor;

/// <summary>
/// A Material Theme grid capable of displaying icons, colored text, and text.
/// 
/// N.B.: At this time the grid is in preview. Expect the API to change.
/// </summary>
public class MBGridMT<TRowData> : ComponentFoundation
{
    #region Parameters

    /// <summary>
    /// The configuration of each column to be displayed. See the definition of MBGridColumnConfiguration
    /// for details.
    /// </summary>
    [Parameter, EditorRequired] public IEnumerable<MBGridColumnConfiguration<TRowData>> ColumnConfigurations { get; set; } = null;


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
    [Parameter, EditorRequired] public IEnumerable<KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>> GroupedOrderedData { get; set; }


    /// <summary>
    /// A boolean indicating whether the selected row is highlighted
    /// </summary>
    [Parameter] public bool HighlightSelectedRow { get; set; } = false;


#nullable enable annotations
    /// <summary>
    /// The KeyExpression is used to add a key to each row of the grid
    /// </summary>
    [Parameter] public Func<TRowData, object>? KeyExpression { get; set; } = null;
#nullable restore annotations


    /// <summary>
    /// LogIdentification is added to logging message to allow differentiation between multiple grids
    /// on a single page or component
    /// </summary>
    [Parameter] public string LogIdentification { get; set; } = null;


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
    [Parameter] public bool SuppressHeader { get; set; } = false;


    /// <summary>
    /// Set to true to apply grid colors, false to suppress.
    /// </summary>
    [Parameter] public bool ApplyColors { get; set; } = false;

    /// <summary>
    /// Set to true to apply vertical dividers to data rows and headers but not group headers.
    /// </summary>
    [Parameter] public bool ApplyVerticalDividers { get; set; } = false;


    /// <summary>
    /// The grid's data table density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }
    #endregion

    #region Members
    private MBCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityCssClass(CascadingDefaults.AppliedDataTableDensity(Density));
    private float[] ColumnWidthArray;
    //private ElementReference GridBodyRef { get; set; }
    //private ElementReference GridHeaderRef { get; set; }
    //private string GridBodyID { get; set; } = Utilities.GenerateUniqueElementName();
    private string GridHeaderID { get; set; } = Utilities.GenerateUniqueElementName();
    private bool HasCompletedFullRender { get; set; } = false;
    private bool IsSimpleRender { get; set; } = true;
    private float ScrollWidth { get; set; }
    private string SelectedKey { get; set; } = "";

    //Instantiate a Semaphore with a value of 1. This means that only 1 thread can be granted access at a time.
    private readonly SemaphoreSlim semaphoreSlim = new(1, 1);

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
            var styleStr = CreateMeasurementStyle(col);
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
#if Logging
        GridLogDebug("BuildRenderTree entered; IsSimpleRender == " + IsSimpleRender.ToString());
        GridLogDebug("                         HasCompletedFullRender == " + HasCompletedFullRender.ToString());
        GridLogDebug("                         ShouldRenderValue == " + ShouldRenderValue.ToString());
#endif
        if (IsSimpleRender || (!ShouldRenderValue))
        {
#if Logging
            GridLogDebug("                (Simple) entered");
#endif
            // We are going to render a DIV and nothing else
            // We need to get into OnAfterRenderAsync so that we can use JS interop to measure
            // the text
            base.BuildRenderTree(builder);
            builder.OpenElement(1, "div");
            builder.CloseElement();
            HasCompletedFullRender = false;
#if Logging
            GridLogDebug("                (Simple) leaving");
#endif
        }
        else
        {
#if Logging
            GridLogDebug("                (Full) entered");
#endif

            //
            //  Using the column cfg and column data, render our list. Here is the layout.
            //  The column headers are optional.
            //
            //  div class="@class", style="@style"
            //      div mb-grid-header          - Contains the header and the vscroll
            //          table                   - 
            //              tr                  - 
            //                  td*             - Header
            //      div mb-grid-body            - Contains the rows and the vscroll
            //          table                   - Contains the rows
            //              tr*                 - Rows
            //                  td*             - Columns of the row
            //

            base.BuildRenderTree(builder);
            var rendSeq = 0;
            string classStr = $"mdc-data-table{(DensityInfo.ApplyCssClass ? $" {DensityInfo.CssClassName}" : "")} mdc-data-table--sticky-header mb-grid__table {(ApplyColors ? " mb-grid__colors" : "")}{(ApplyVerticalDividers ? " mb-grid__vertical-dividers" : "")} {@class}";
            var columnCount = ColumnConfigurations.Count().ToString();

            builder.OpenElement(rendSeq++, "div");
            builder.AddAttribute(rendSeq++, "class", classStr);
            builder.AddAttribute(rendSeq++, "style", style);

            if (!SuppressHeader || GroupedOrderedData != null)
            {
                builder.OpenElement(rendSeq++, "div");
                builder.AddAttribute(rendSeq++, "class", "mdc-data-table__table-container");
                builder.OpenElement(rendSeq++, "table");
                builder.AddAttribute(rendSeq++, "class", "mdc-data-table__table");
                BuildColGroup(builder, ref rendSeq);

                // Based on the column config generate the column titles unless asked not to
                if (!SuppressHeader)
                {
                    //BuildColGroup(builder, ref rendSeq);
                    builder.OpenElement(rendSeq++, "thead");
                    builder.OpenElement(rendSeq++, "tr");
                    //builder.AddAttribute(rendSeq++, "class", "mdc-data-table__header-row mb-grid-material-trx");
                    builder.AddAttribute(rendSeq++, "class", "mdc-data-table__header-row");

                    // For each column output a TD
                    var colCount = 0;
                    foreach (var col in ColumnConfigurations)
                    {
                        //styleStr = BuildNewGridTD(
                        //    builder,
                        //    ref rendSeq,
                        //    colCount == 0,
                        //    isHeaderRow,
                        //    "mb-grid-backgroundcolor-header-background");

                        //// Set the header colors
                        //styleStr += " color: " + col.ForegroundColorHeader.Name + ";";
                        //styleStr += " background-color : " + col.BackgroundColorHeader.Name + ";";
                        builder.OpenElement(rendSeq++, "td");
                        builder.AddAttribute(rendSeq++, "class", "mdc-data-table__header-cell");
                        //builder.AddAttribute(rendSeq++, "style", styleStr);
                        builder.AddContent(rendSeq++, col.Title);

                        // Close this column TD
                        builder.CloseElement();

                        colCount++;
                    }

                    builder.CloseElement(); // tr

                    builder.CloseElement(); // thead
                }

                //
                // We now need to build a "display centric" data representation with rows added for breaks, etc.
                // For the first pass we are going to skip this step and just display the raw content
                //

                if (GroupedOrderedData != null)
                {
                    //var isFirstGrouper = true;

                    //BuildColGroup(builder, ref rendSeq);
                    builder.OpenElement(rendSeq++, "tbody");
                    builder.AddAttribute(rendSeq++, "class", "mdc-data-table__content");

                    foreach (var kvp in GroupedOrderedData)
                    {
                        if (Group)
                        {
                            // We output a row with the group name
                            // Do a div for this row
                            builder.OpenElement(rendSeq++, "tr");
                            builder.AddAttribute(rendSeq++, "class", "mdc-data-table__row mb-grid__group-row");
                            builder.OpenElement(rendSeq++, "td");
                            builder.AddAttribute(rendSeq++, "colspan", columnCount);
                            builder.AddAttribute(rendSeq++, "class", "mdc-data-table__cell");
                            //if (isFirstGrouper)
                            //{
                            //    isFirstGrouper = false;
                            //    builder.AddAttribute(rendSeq++, "style", "border-top: 1px solid black; ");
                            //}
                            //builder.AddAttribute(rendSeq++, "mbgrid-td-wide", "0");
                            builder.AddContent(rendSeq++, "  " + kvp.Key);
                            builder.CloseElement(); // td
                            builder.CloseElement(); // tr
                        }

                        var rowCount = 0;
                        foreach (var rowValues in kvp.Value)
                        {
                            var rowKey = KeyExpression(rowValues.Value).ToString();

                            //string rowBackgroundColorClass = "";

                            //if ((rowKey == SelectedKey) && HighlightSelectedRow)
                            //{
                            //    // It's the selected row so set the selection color as the background
                            //    rowBackgroundColorClass = "mb-grid__row-selected";
                            //}
                            //else
                            //{
                            //    // Not selected or not highlighted so we alternate
                            //    if ((rowCount / 2) * 2 == rowCount)
                            //    {
                            //        // Even
                            //        rowBackgroundColorClass = "mb-grid-backgroundcolor-row-even";
                            //    }
                            //    else
                            //    {
                            //        // Odd
                            //        rowBackgroundColorClass = "mb-grid-backgroundcolor-row-odd";
                            //    }
                            //}

                            var selected = (rowKey == SelectedKey) && HighlightSelectedRow;
                            // Do a tr
                            builder.OpenElement(rendSeq++, "tr");
                            //builder.AddAttribute(rendSeq++, "class", "mb-grid-tr " + rowBackgroundColorClass);
                            builder.AddAttribute(rendSeq++, "class", $"mdc-data-table__row mb-grid__row{(selected ? " mb-grid__row-selected" : "")}");

                            builder.AddAttribute
                            (
                                rendSeq++,
                                "onclick",
                                EventCallback.Factory.Create<MouseEventArgs>(this, e => OnMouseClickInternal(rowKey))
                            );

                            // For each column output a td
                            var colCount = 0;
                            foreach (var columnDefinition in ColumnConfigurations)
                            {
                                //styleStr = BuildNewGridTD(
                                //    builder,
                                //    ref rendSeq,
                                //    colCount == 0,
                                //    isHeaderRow,
                                //    rowBackgroundColorClass);
                                builder.OpenElement(rendSeq++, "td");
                                builder.AddAttribute(rendSeq++, "class", "mdc-data-table__cell");

                                switch (columnDefinition.ColumnType)
                                {
                                    case MB_Grid_ColumnType.Icon:
                                        if (columnDefinition.DataExpression != null)
                                        {
                                            try
                                            {
                                                var value = (MBGridIconSpecification)columnDefinition.DataExpression(rowValues.Value);

                                                // We need to add the color alignment to the base styles
                                                //styleStr +=
                                                //    " color: " + ColorToCSSColor(value.IconColor) + ";"
                                                //    + " text-align: center;";

                                                //builder.AddAttribute(rendSeq++, "style", styleStr);
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

                                        //if (columnDefinition.ForegroundColorExpression != null)
                                        //{
                                        //    var value = columnDefinition.ForegroundColorExpression(rowValues.Value);
                                        //    styleStr +=
                                        //        " color: " + ColorToCSSColor((Color)value) + "; ";
                                        //}

                                        //if (columnDefinition.BackgroundColorExpression != null)
                                        //{
                                        //    var value = columnDefinition.BackgroundColorExpression(rowValues.Value);
                                        //    if ((Color)value != Color.Transparent)
                                        //    {
                                        //        styleStr +=
                                        //            " background-color: " + ColorToCSSColor((Color)value) + "; ";
                                        //    }
                                        //}

                                        //if (columnDefinition.IsPMI && ObscurePMI)
                                        //{
                                        //    styleStr +=
                                        //        " filter: blur(0.25em); ";
                                        //}

                                        //builder.AddAttribute(rendSeq++, "style", styleStr);

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

                                                if (value.Suppress)
                                                {
                                                    //builder.AddAttribute(rendSeq++, "style", styleStr);
                                                }
                                                else
                                                {
                                                    // We need to add the colors
                                                    //styleStr +=
                                                    //    " color: " + ColorToCSSColor(value.ForegroundColor)
                                                    //    + "; background-color: " + ColorToCSSColor(value.BackgroundColor) + ";";

                                                    //if (columnDefinition.IsPMI && ObscurePMI)
                                                    //{
                                                    //    styleStr +=
                                                    //        " filter: blur(0.25em); ";
                                                    //}

                                                    //builder.AddAttribute(rendSeq++, "style", styleStr);
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
                }

                builder.CloseElement(); //div mdc-data-table__table-container
                builder.CloseElement(); //table

                //builder.CloseElement(); // div mb-grid-header

                //builder.CloseElement(); // div class= style=
            }

            builder.CloseElement(); // div mdc-data-table

            HasCompletedFullRender = true;
#if Logging
            GridLogDebug("                (Full) leaving");
#endif
        }
#if Logging
        GridLogDebug("                leaving; IsSimpleRender == " + IsSimpleRender.ToString());
        GridLogDebug("                leaving; HasCompletedFullRender == " + HasCompletedFullRender.ToString());
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

    #region CreateMeasurementStyle
    private string CreateMeasurementStyle(MBGridColumnConfiguration<TRowData> col)
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
            return "";
        }
    }
    #endregion

    #region Logging

    private void GridLogDebug(string message)
    {
        if (string.IsNullOrWhiteSpace(LogIdentification))
        {
            LoggingService.LogDebug(message);
        }
        else
        {
            LoggingService.LogDebug("[" + LogIdentification + "] " + message);
        }
    }

    private void GridLogTrace(string message)
    {
        if (string.IsNullOrWhiteSpace(LogIdentification))
        {
            LoggingService.LogTrace(message);
        }
        else
        {
            LoggingService.LogTrace("[" + LogIdentification + "] " + message);
        }
    }

    #endregion

    #region OnAfterRenderAsync
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        var needsSHC = false;
        await semaphoreSlim.WaitAsync();
        try
        {
            await base.OnAfterRenderAsync(firstRender);

#if Logging
            GridLogDebug("OnAfterRenderAsync entered");
            GridLogDebug("                   firstRender: " + firstRender.ToString());
            GridLogDebug("                   IsSimpleRender: " + IsSimpleRender.ToString());
#endif

            if (IsSimpleRender)
            {
                IsSimpleRender = false;
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
            GridLogDebug("                   about to release semaphore (OnAfterRenderAsync)");
#endif
            semaphoreSlim.Release();
        }
    }
    #endregion

    #region OnInitialized
    protected override async Task OnInitializedAsync()
    {
#if Logging
        GridLogDebug("MBGrid.OnInitialized entered");
#endif
        await base.OnInitializedAsync();

        if (ColumnConfigurations == null)
        {
            throw new System.Exception("MBGrid requires column configuration definitions.");
        }
#if Logging
        GridLogDebug("MBGrid.OnInitialized completed");
#endif
    }
    #endregion

    #region OnMouseClickInternal
    private void OnMouseClickInternal(string newRowKey)
    {
#if Logging
        GridLogDebug("OnMouseClickInternal with HighlightSelectedRow:" + HighlightSelectedRow.ToString());
#endif
        if (newRowKey != SelectedKey)
        {
            SelectedKey = newRowKey;
            OnMouseClick.InvokeAsync(newRowKey);
        }
        else
        {
            OnMouseClick.InvokeAsync(newRowKey);
        }
    }
    #endregion

    #region ShouldRender
    protected override bool ShouldRender()
    {
        return ShouldRenderValue;
    }
    #endregion

}
