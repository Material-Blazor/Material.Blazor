using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material.Blazor.Internal
{
    public abstract class InternalProgressIndicator : ComponentFoundation
    {
        #region BuildRenderTree

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            var attributesToSplat = AttributesToSplat().ToArray();

            builder.OpenElement(0, WebComponentName());

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

            builder.CloseElement();
        }

        #endregion

        #region WebComponentName

        /// <summary>
        /// Inherited classes must specify the material-web compoent name.
        /// </summary>
        /// <returns></returns>
        private protected abstract string WebComponentName();

        #endregion

    }
}
