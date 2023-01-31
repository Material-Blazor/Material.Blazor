using Material.Blazor.MD2;
using Microsoft.AspNetCore.Components;
using System;

namespace Material.Blazor.Internal.MD2;

/// <summary>
/// The internal implementation of <see cref="IMBTooltipService"/>.
/// </summary>
internal class TooltipService : IMBTooltipService
{
    private event Action<long, RenderFragment> OnAddRenderFragment;
    private event Action<long, MarkupString> OnAddMarkupString;
    private event Action<long> OnRemove;

    /// <inheritdoc/>
    event Action<long, RenderFragment> IMBTooltipService.OnAddRenderFragment
    {
        add => OnAddRenderFragment += value;
        remove => OnAddRenderFragment -= value;
    }



    /// <inheritdoc/>
    event Action<long, MarkupString> IMBTooltipService.OnAddMarkupString
    {
        add => OnAddMarkupString += value;
        remove => OnAddMarkupString -= value;
    }



    /// <inheritdoc/>
    event Action<long> IMBTooltipService.OnRemove
    {
        add => OnRemove += value;
        remove => OnRemove -= value;
    }



    /// <inheritdoc/>
    public void AddTooltip(long id, RenderFragment content)
    {
        if (OnAddRenderFragment is null)
        {
            throw new InvalidOperationException($"Material.Blazor: you attempted to add a tooltip from a {Utilities.GetTypeName(typeof(IMBTooltipService))} but have not placed an MBAnchor component at the top of either App.razor or MainLayout.razor");
        }

        OnAddRenderFragment?.Invoke(id, content);
    }



    /// <inheritdoc/>
    public void AddTooltip(long id, MarkupString content)
    {
        if (OnAddMarkupString is null)
        {
            throw new InvalidOperationException($"Material.Blazor: you attempted to add a tooltip from a {Utilities.GetTypeName(typeof(IMBTooltipService))} but have not placed a {Utilities.GetTypeName(typeof(MBAnchor))} component at the top of either App.razor or MainLayout.razor");
        }

        OnAddMarkupString?.Invoke(id, content);
    }



    /// <inheritdoc/>
    public void RemoveTooltip(long id)
    {
        if (OnRemove is null)
        {
            throw new InvalidOperationException($"Material.Blazor: you attempted to remove a tooltip from a {Utilities.GetTypeName(typeof(IMBTooltipService))} but have not placed a {Utilities.GetTypeName(typeof(MBAnchor))} component at the top of either App.razor or MainLayout.razor");
        }

        OnRemove?.Invoke(id);
    }
}
