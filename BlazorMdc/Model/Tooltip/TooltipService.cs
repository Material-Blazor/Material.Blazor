using Microsoft.AspNetCore.Components;
using System;

namespace BlazorMdc.Internal
{
    /// <summary>
    /// The internal implementation of <see cref="IMTTooltipService"/>.
    /// </summary>
    internal class TooltipService : IMTTooltipService
    {
        private event Action<Guid, RenderFragment> OnAdd;

        /// <inheritdoc/>
        event Action<Guid, RenderFragment> IMTTooltipService.OnAdd
        {
            add => OnAdd += value;
            remove => OnAdd -= value;
        }



        private event Action<Guid> OnRemove;

        /// <inheritdoc/>
        event Action<Guid> IMTTooltipService.OnRemove
        {
            add => OnRemove += value;
            remove => OnRemove -= value;
        }



        /// <inheritdoc/>
        public void AddTooltip(Guid id, RenderFragment content)
        {
            if (OnAdd is null)
            {
                throw new InvalidOperationException($"BlazorMdc: you attempted to add a tooltip from a {Utilities.GetTypeName(typeof(IMTTooltipService))} but have not placed a {Utilities.GetTypeName(typeof(MTAnchor))} component at the top of either App.razor or MainLayout.razor");
            }

            OnAdd?.Invoke(id, content);
        }



        /// <inheritdoc/>
        public void RemoveTooltip(Guid id)
        {
            if (OnRemove is null)
            {
                throw new InvalidOperationException($"BlazorMdc: you attempted to remove a tooltip from a {Utilities.GetTypeName(typeof(IMTTooltipService))} but have not placed a {Utilities.GetTypeName(typeof(MTAnchor))} component at the top of either App.razor or MainLayout.razor");
            }

            OnRemove?.Invoke(id);
        }
    }
}
