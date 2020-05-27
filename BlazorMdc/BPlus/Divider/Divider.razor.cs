using BBase;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BPlus
{
    /// <summary>
    /// A Material Theme divider.
    /// </summary>
    public partial class Divider : BBase.ComponentBase
    {
        /// <summary>
        /// Material Theme "mdc-list-divider--inset" if True.
        /// </summary>
        [Parameter] public bool Inset { get; set; }


        /// <summary>
        /// Material Theme "mdc-list-divider--padded" if True.
        /// </summary>
        [Parameter] public bool Padded { get; set; }


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-list-divider")
                .AddIf("mdc-list-divider--inset", () => Inset)
                .AddIf("mdc-list-divider--padded", () => Padded);
        }

    }
}
