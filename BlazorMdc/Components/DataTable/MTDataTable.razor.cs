using BlazorMdc.Internal;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMdc
{
    /// <summary>
    /// This is a general purpose Material Theme data table.
    /// </summary>
    public partial class MTDataTable<TItem> : ComponentFoundation
    {
        /// <summary>
        /// Data to render in the <see cref="TableRow"/> render fragment.
        /// </summary>
        [Parameter] public IEnumerable<TItem> Items { get; set; }


        /// <summary>
        /// The table header as a render fragment using <c>&lt;th&gt;</c> HTML elements.
        /// </summary>
        [Parameter] public RenderFragment TableHeader { get; set; }


        /// <summary>
        /// Render fragment for each row of the table using <c>&lt;td&gt;</c> HTML elements.
        /// </summary>
        [Parameter] public RenderFragment<TItem> TableRow { get; set; }


        /// <summary>
        /// The data table's density.
        /// </summary>
        [Parameter] public MTDensity? Density { get; set; }


        private ElementReference ElementReference { get; set; }

        private MTCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityInfo(CascadingDefaults.AppliedDataTableDensity(Density));


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside BlazorMdc
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapper
                .Add("mdc-data-table")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass);
        }


        /// <inheritdoc/>
        private protected async override Task InitializeMdcComponent() => await JsRuntime.InvokeAsync<object>("BlazorMdc.dataTable.init", ElementReference);
    }
}
