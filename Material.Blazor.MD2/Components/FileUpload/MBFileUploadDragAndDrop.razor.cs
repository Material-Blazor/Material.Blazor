using Material.Blazor.MD2.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


namespace Material.Blazor.MD2;

/// <summary>
/// A material card styled wrapper for the <code>InputFile</code> component that can load files either by drag and drop or clicking the card area
/// </summary>
public partial class MBFileUploadDragAndDrop : ComponentFoundation
{
#nullable enable annotations
    /// <summary>
    /// The button's label.
    /// </summary>
    [Parameter] public string Label { get; set; } = "Choose File";


    /// <summary>
    /// The leading icon's name. No leading icon shown if not set.
    /// </summary>
    [Parameter] public string? LeadingIcon { get; set; }


    /// <summary>
    /// The trailing icon's name. No leading icon shown if not set.
    /// </summary>
    [Parameter] public string? TrailingIcon { get; set; }


    /// <summary>
    /// The foundry to use for both leading and trailing icons.
    /// <para><c>IconFoundry="IconHelper.MIIcon()"</c></para>
    /// <para><c>IconFoundry="IconHelper.FAIcon()"</c></para>
    /// <para><c>IconFoundry="IconHelper.OIIcon()"</c></para>
    /// <para>Overrides <see cref="MBCascadingDefaults.IconFoundryName"/></para>
    /// </summary>
    [Parameter] public IMBIconFoundry? IconFoundry { get; set; }


    /// <summary>
    /// REQUIRED function called when files are loaded.
    /// </summary>
    [Parameter] public Func<InputFileChangeEventArgs, Task> OnLoadFiles { get; set; }

#nullable restore annotations

    private ElementReference ElementReference { get; set; }
    private string HoverClass { get; set; } = string.Empty;
    private string CardClass => $"mb-file-upload--drag-and-drop {ActiveConditionalClasses} {@class}" + HoverClass;
    private string Filename { get; set; } = string.Empty;
    private readonly string labelId = Utilities.GenerateUniqueElementName();


    private void OnDragEnter(DragEventArgs _)
    {
        HoverClass = " mb-file-upload--hover mdc-elevation--z7";
    }


    private void OnDragLeave(DragEventArgs _)
    {
        HoverClass = string.Empty;
    }


    private Task LocalOnLoadFiles(InputFileChangeEventArgs e)
    {
        var files = e.GetMultipleFiles();
        var count = files.Count;

        Filename = count == 1 ? files.FirstOrDefault().Name : $"{count:N0} Files";

        return OnLoadFiles(e); 
    }
}
