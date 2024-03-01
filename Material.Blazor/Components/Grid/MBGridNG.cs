#define xLogging

using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

using static System.Runtime.InteropServices.JavaScript.JSType;

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
/// </summary>
public class MBGridNG<TRowData> : ComponentFoundation
{
    #region Parameters

    /// <summary>
    /// The configuration of each column to be displayed. See the definition of MBGridColumnConfiguration
    /// for details.
    /// </summary>
    [Parameter, EditorRequired] public IEnumerable<MBGridColumnConfiguration<TRowData>> ColumnConfigurations { get; set; } = null;


    /// <summary>
    /// The grid's data table density.
    /// </summary>
    [Parameter] public MBDensity? Density { get; set; }


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


    #endregion

    #region Members

    private MBCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityCssClass(CascadingDefaults.AppliedDataTableDensity(Density));

    private string SelectedKey { get; set; } = "";

    #endregion

    #region BuildColGroup
    private void BuildColGroup(RenderTreeBuilder builder, ref int rendSeq)
    {
        if (Measurement == MB_Grid_Measurement.FitToData)
        {
            // No need for colgroup, we let the grid handle the column width

            return;
        }

        // Create the sizing colgroup collection

        builder.OpenElement(rendSeq++, "colgroup");
        {
            builder.AddAttribute(rendSeq++, "class", "mb-grid__colgroup");
            var colIndex = 0;
            foreach (var col in ColumnConfigurations)
            {
                var styleStr = CreateMeasurementStyle(col);
                builder.OpenElement(rendSeq++, "col");
                if (styleStr.Length > 0)
                {
                    builder.AddAttribute(rendSeq++, "style", styleStr);
                }
                builder.CloseElement(); // col
                colIndex++;
            }
        }
        builder.CloseElement(); // colgroup
    }
    #endregion

    #region BuildGridTD
    private static string BuildGridTD(
        RenderTreeBuilder builder,
        ref int rendSeq,
        bool isFirstColumn,
        bool isHeaderRow,
        string tdClass)
    {
        builder.OpenElement(rendSeq++, "td");
        builder.AddAttribute(rendSeq++, "class", "mb-grid__td " + tdClass);

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
        //
        //  Using the column cfg and column data, render our list. Here is the layout.
        //  The column headers are optional.
        //
        //  div class="mdc-data-table dense--4 mdc-data-table--sticky-header mb-grid__table mb-grid__colors {@class}", style=style
        //      div mdc-data-table__table-container
        //          table                           - 
        //              thead                       - optional
        //                  tr                      - optional
        //              colgroup                    - optional
        //                  tr                      - 
        //                      td*                 - Header content
        //              tr*                 - Rows
        //                  td*             - Columns of the row
        //

        base.BuildRenderTree(builder);
        var rendSeq = 0;
        string classStr = $"mdc-data-table mdc-data-table--sticky-header mb-grid__table mb-grid__colors {(DensityInfo.ApplyCssClass ? $"{DensityInfo.CssClassName}" : "")} {@class}";
        var columnCount = ColumnConfigurations.Count().ToString();
        string styleStr;

        builder.OpenElement(rendSeq++, "div");
        {
            builder.AddAttribute(rendSeq++, "class", classStr);
            builder.AddAttribute(rendSeq++, "style", style);

            builder.OpenElement(rendSeq++, "div");
            {
                builder.AddAttribute(rendSeq++, "class", "mdc-data-table__table-container");
                
                builder.OpenElement(rendSeq++, "table");
                {
                    builder.AddAttribute(rendSeq++, "class", "mdc-data-table__table");
                    BuildColGroup(builder, ref rendSeq);

                    // Based on the column config generate the column titles unless asked not to
                    if (!SuppressHeader)
                    {
                        builder.OpenElement(rendSeq++, "thead");
                        {
                            builder.OpenElement(rendSeq++, "tr");
                            {
                                builder.AddAttribute(rendSeq++, "class", "mdc-data-table__header-row");

                                // For each column output a TD
                                var colCount = 0;
                                foreach (var col in ColumnConfigurations)
                                {
                                    styleStr = BuildGridTD(
                                        builder,
                                        ref rendSeq,
                                        colCount == 0,
                                        true,
                                        "mdc-data-table__header-cell");
                                    {
                                        // Set the header colors
                                        styleStr += " color: " + col.ForegroundColorHeader.Name + ";";
                                        styleStr += " background-color : " + col.BackgroundColorHeader.Name + ";";
                                        builder.AddAttribute(rendSeq++, "style", styleStr);
                                        builder.AddContent(rendSeq++, col.Title);
                                    }
                                    // Close this column TD
                                    builder.CloseElement();

                                    colCount++;
                                }
                            }
                            builder.CloseElement(); // tr
                        }
                        builder.CloseElement(); // thead
                    }

                    //
                    // We now need to build a "display centric" data representation with rows added for breaks, etc.
                    //

                    if (GroupedOrderedData != null)
                    {
                        var isFirstGrouper = true;

                        BuildColGroup(builder, ref rendSeq);
                        builder.OpenElement(rendSeq++, "tbody");
                        builder.AddAttribute(rendSeq++, "class", "mdc-data-table__content");

                        foreach (var kvp in GroupedOrderedData)
                        {
                            if (Group)
                            {
                                // We output a row with the group name
                                // Do a div for this row
                                builder.OpenElement(rendSeq++, "tr");
                                {
                                    builder.AddAttribute(rendSeq++, "class", "mdc-data-table__row mb-grid__group-row");

                                    builder.OpenElement(rendSeq++, "td");
                                    {
                                        builder.AddAttribute(rendSeq++, "colspan", columnCount);
                                        builder.AddAttribute(rendSeq++, "class", "mdc-data-table__cell");
                                        builder.AddContent(rendSeq++, "  " + kvp.Key);
                                    }
                                    builder.CloseElement(); // td
                                }
                                builder.CloseElement(); // tr
                            }

                            var rowCount = 0;
                            foreach (var rowValues in kvp.Value)
                            {
                                var rowKey = KeyExpression(rowValues.Value).ToString();

                                var selected = (rowKey == SelectedKey) && HighlightSelectedRow;
                                // Do a tr
                                builder.OpenElement(rendSeq++, "tr");
                                builder.AddAttribute(rendSeq++, "class", $"mdc-data-table__row mb-grid__row {(selected ? "mb-grid__row-selected" : "")}");

                                builder.AddAttribute
                                (
                                    rendSeq++,
                                    "onclick",
                                    EventCallback.Factory.Create<MouseEventArgs>(this, e => OnMouseClickInternal(rowKey))
                                );

                                BuildDataRow(builder, ref rendSeq, rowValues);

                                // Close this row's div
                                builder.CloseElement();

                                rowCount++;
                            }
                        }

                        builder.CloseElement(); // tbody
                    }
                }
                builder.CloseElement(); // table mdc-data-table__table
                }
            builder.CloseElement(); // div mdc-data-table__table-container
        }
        builder.CloseElement(); // div
    }

    #endregion

    #region BuildDataRow

    private void BuildDataRow(RenderTreeBuilder builder, ref int rendSeq, KeyValuePair<string, TRowData> rowValues)
    {
        // For each column output a td
        var colCount = 0;
        var styleStr = "";
        foreach (var columnDefinition in ColumnConfigurations)
        {
            styleStr = BuildGridTD(
                builder,
                ref rendSeq,
                colCount == 0,
                false,
                "mdc-data-table__cell");

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
                        if ((Color)value != Color.Transparent)
                        {
                            styleStr +=
                                " background-color: " + ColorToCSSColor((Color)value) + "; ";
                        }
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

                            if (value.Suppress)
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

    #region OnInitialized
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        if (ColumnConfigurations == null)
        {
            throw new System.Exception("MBGrid requires column configuration definitions.");
        }
    }
    #endregion

    #region OnMouseClickInternal
    private void OnMouseClickInternal(string newRowKey)
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
    }
    #endregion

    #region ScrollToIndicatedRowAsync
    public async Task ScrollToIndicatedRowAsync(string rowIdentifier)
    {
        await InvokeJsVoidAsync("MaterialBlazor.MBGrid.scrollToIndicatedRow", rowIdentifier);
    }
    #endregion

}
