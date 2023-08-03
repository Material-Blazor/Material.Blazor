using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material.Blazor
{
    public sealed class MBProgressIndicator : ComponentFoundation
    {
        #region members

        [Parameter] public double DeterminantValue { get; set; } = 0.0f;
        [Parameter] public bool IsDeterminant { get; set; } = false;
        [Parameter] public bool IsLinear { get; set; } = false;
        [Parameter] public bool IsFourColor { get; set; } = false;

        #endregion

        #region BuildRenderTree

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            var attributesToSplat = AttributesToSplat().ToArray();

            if (IsLinear)
            {
                builder.OpenElement(0, "md-linear-progress");
            }
            else
            {
                builder.OpenElement(0, "md-circular-progress");
            }

            if (attributesToSplat.Any())
            {
                builder.AddMultipleAttributes(1, attributesToSplat);
            }

            if (AppliedDisabled)
            {
                builder.AddAttribute(2, "disabled");
            }

            builder.AddAttribute(3, "class", @class);
            builder.AddAttribute(4, "style", style);
            builder.AddAttribute(5, "id", id);

            if (IsDeterminant)
            {
                builder.AddAttribute(6, "value", DeterminantValue.ToString());
            }
            else
            {
                builder.AddAttribute(6, "indeterminant");
            }

            if (IsFourColor)
            {
                builder.AddAttribute(7, "four-color");
            }

            builder.CloseElement();
        }

        #endregion

    }
}
