using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

/// <summary>
/// A list of user provided render fragments that can be re-ordered with drag and drop.
/// </summary>
public partial class MBDragAndDropList<TItem> : InputComponent<List<TItem>>
{
    /// <summary>
    /// A function delegate to return the parameters for <c>@key</c> attributes. If unused
    /// "fake" keys set to GUIDs will be used.
    /// </summary>
    [Parameter] public Func<TItem, object> GetKeysFunc { get; set; }


    /// <summary>
    /// Render fragment for each displayable item.
    /// </summary>
    [Parameter] public RenderFragment<TItem> Content { get; set; }


    private ElementReference ElementReference { get; set; }
    private Func<TItem, object> KeyGenerator { get; set; }
    private string HoverClass { get; set; } = "";
    private int DraggedItemIndex { get; set; } = -1;
    private bool IsDragging { get; set; } = false;
    private SortedDictionary<int, TItem> ItemDict { get; set; } = new();


    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        ForceShouldRenderToTrue = true;
    }

    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync();

        KeyGenerator = GetKeysFunc ?? delegate (TItem item) { return item; };

        BuildItemDict();
    }


    private void BuildItemDict()
    {
        ItemDict.Clear();

        var index = 0;

        foreach (var item in Value)
        {
            ItemDict.Add(index++, item);
        }
    }


    private void SetDraggedItemIndex(int index)
    {
        DraggedItemIndex = index;
        IsDragging = true;
        _ = InvokeAsync(StateHasChanged);
    }


    private void ClearDraggedItemIndex()
    {
        DraggedItemIndex = -1;
        IsDragging = false;
        _ = InvokeAsync(StateHasChanged);
    }


    private bool ShowDropZone(int index)
    {
        return IsDragging && index != DraggedItemIndex && index != DraggedItemIndex + 1;
    }


    private void ReOrderItems(int selectedIndex)
    {
        SortedDictionary<int, TItem> newDict = new();

        var newIndex = 0;

        foreach (var (index, item) in ItemDict.Where(x => x.Key < selectedIndex))
        {
            if (index != DraggedItemIndex)
            {
                newDict[newIndex++] = item;
            }
        }

        newDict[newIndex++] = ItemDict[DraggedItemIndex];

        foreach (var (index, item) in ItemDict.Where(x => x.Key >= selectedIndex))
        {
            if (index != DraggedItemIndex)
            {
                newDict[newIndex++] = item;
            }
        }

        ItemDict = newDict;

        ComponentValue = ItemDict.Values.ToList();
    }
}
