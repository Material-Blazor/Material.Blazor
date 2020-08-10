using Microsoft.AspNetCore.Components;
using System;

namespace BlazorMdc
{
    /// <summary>
    /// Interface for the BlazorMdc toast service, developed from the code base of Blazored Toast by Chris Sainty.
    /// Works in conjunction with a <see cref="MTToastAnchor"/> that must be placed in either App.razor or
    /// MainLayout.razor to avoid an exception being thrown when you first attempt to show a toast notification.
    /// 
    /// <para>
    /// Throws a <see cref="System.InvalidOperationException"/> if
    /// <see cref="AddTooltip(Guid, RenderFragment)"/>
    /// is called without an <see cref="MTTooltipAnchor"/> component used in the app.
    /// </para>
    /// </summary>
    internal interface IMTTooltipService
    {
        /// <summary>
        /// A event that will be invoked when adding a tooltip
        /// </summary>
        internal event Action<Guid, RenderFragment> OnAdd;



        /// <summary>
        /// A event that will be invoked when removing a tooltip
        /// </summary>
        internal event Action<Guid> OnRemove;



        /// <summary>
        /// Adds a tooltip.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="content"></param>
        void AddTooltip(Guid id, RenderFragment content);



        /// <summary>
        /// Removes the tooltip with the specified id.
        /// </summary>
        /// <param name="id"></param>
        void RemoveTooltip(Guid id);
    }
}
