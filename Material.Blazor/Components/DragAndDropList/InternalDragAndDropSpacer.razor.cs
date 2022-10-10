﻿using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Material.Blazor.Internal;

/// <summary>
/// For Material.Blazor internal use only.
/// </summary>
public partial class InternalDragAndDropSpacer : ComponentFoundation
{
    /// <summary>
    /// The spacer's index.
    /// </summary>
    [Parameter] public int Index { get; set; }


    /// <summary>
    /// Action called when item is dropped on this spacer.
    /// </summary>
    [Parameter] public Action<int> DropNotifier { get; set; }


    private string HoverClass { get; set; } = "";


    private void OnDragEnter()
    {
        Console.Write("enter");
        HoverClass = " mb-drag-and-drop-list__hover";
        _ = InvokeAsync(StateHasChanged);
    }


    private void OnDragLeave()
    {
        Console.Write("left");
        HoverClass = string.Empty;
        _ = InvokeAsync(StateHasChanged);
    }
}
