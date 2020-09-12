using Microsoft.AspNetCore.Components;
using System;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// The internal implementation of <see cref="IMBTooltipService"/>.
    /// </summary>
    internal class TooltipService : IMBTooltipService
    {
        private event Action<Guid, RenderFragment> OnAddRenderFragment;
        private event Action<Guid, MarkupString> OnAddMarkupString;

        /// <inheritdoc/>
        event Action<Guid, RenderFragment> IMBTooltipService.OnAddRenderFragment
        {
            add => OnAddRenderFragment += value;
            remove => OnAddRenderFragment -= value;
        }



        /// <inheritdoc/>
        event Action<Guid, MarkupString> IMBTooltipService.OnAddMarkupString
        {
            add => OnAddMarkupString += value;
            remove => OnAddMarkupString -= value;
        }



        /// <inheritdoc/>
        private event Action<Guid> OnRemove;

        /// <inheritdoc/>
        event Action<Guid> IMBTooltipService.OnRemove
        {
            add => OnRemove += value;
            remove => OnRemove -= value;
        }



        /// <inheritdoc/>
        public void AddTooltip(Guid id, RenderFragment content)
        {
            if (OnAddRenderFragment is null)
            {
                throw new InvalidOperationException($"Material.Blazor: you attempted to add a tooltip from a {Utilities.GetTypeName(typeof(IMBTooltipService))} but have not placed a {Utilities.GetTypeName(typeof(MBAnchor))} component at the top of either App.razor or MainLayout.razor");
            }

            OnAddRenderFragment?.Invoke(id, content);
        }



        /// <inheritdoc/>
        public void AddTooltip(Guid id, MarkupString content)
        {
            if (OnAddMarkupString is null)
            {
                throw new InvalidOperationException($"Material.Blazor: you attempted to add a tooltip from a {Utilities.GetTypeName(typeof(IMBTooltipService))} but have not placed a {Utilities.GetTypeName(typeof(MBAnchor))} component at the top of either App.razor or MainLayout.razor");
            }

            OnAddMarkupString?.Invoke(id, content);
        }



        /// <inheritdoc/>
        public void RemoveTooltip(Guid id)
        {
            if (OnRemove is null)
            {
                throw new InvalidOperationException($"Material.Blazor: you attempted to remove a tooltip from a {Utilities.GetTypeName(typeof(IMBTooltipService))} but have not placed a {Utilities.GetTypeName(typeof(MBAnchor))} component at the top of either App.razor or MainLayout.razor");
            }

            OnRemove?.Invoke(id);
        }
    }
}
