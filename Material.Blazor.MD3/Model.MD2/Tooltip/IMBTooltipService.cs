using Microsoft.AspNetCore.Components;
using System;

namespace Material.Blazor.MD2;

/// <summary>
/// Interface for the Material.Blazor tooltip service, developed from the code base of Blazored Toast by Chris Sainty.
/// Works in conjunction with a <see cref="MBAnchor"/> that must be placed in either App.razor or
/// MainLayout.razor to avoid an exception being thrown when you first attempt to show a tooltip notification.
/// 
/// <para>
/// Throws a <see cref="System.InvalidOperationException"/> if
/// <see cref="AddTooltip(long, RenderFragment)"/>
/// is called without an <see cref="MBAnchor"/> component used in the app.
/// </para>
/// </summary>
public interface IMBTooltipService
{
    /// <summary>
    /// A event that will be invoked when adding a tooltip
    /// </summary>
    event Action<long, RenderFragment> OnAddRenderFragment;



    /// <summary>
    /// A event that will be invoked when adding a tooltip
    /// </summary>
    event Action<long, MarkupString> OnAddMarkupString;



    /// <summary>
    /// A event that will be invoked when removing a tooltip
    /// </summary>
    event Action<long> OnRemove;



    /// <summary>
    /// Adds a tooltip.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="content"></param>
    void AddTooltip(long id, RenderFragment content);



    /// <summary>
    /// Adds a tooltip.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="content"></param>
    void AddTooltip(long id, MarkupString content);



    /// <summary>
    /// Removes the tooltip with the specified id.
    /// </summary>
    /// <param name="id"></param>
    void RemoveTooltip(long id);
}
