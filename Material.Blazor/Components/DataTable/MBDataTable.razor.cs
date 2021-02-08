using Material.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Material.Blazor
{
    /// <summary>
    /// This is a general purpose Material Theme data table.
    /// </summary>
    public partial class MBDataTable<TItem> : ComponentFoundation
    {
        /// <summary>
        /// A cascading to be used by <see cref="MBPaginator"/> to
        /// identify that it is within a data table.
        /// </summary>
        internal const string DataTableCascadingValue = "DataTableCascadingValue";


        /// <summary>
        /// A reference for <see cref="DataTableCascadingValue"/> to be used by <see cref="MBPaginator"/> to
        /// identify that it is within a data table.
        /// </summary>
        internal const string DataTableReference = "276994ab-401c-434b-835d-740e06e5aa82";


        /// <summary>
        /// A function delegate to return the parameters for <c>@key</c> attributes. If unused
        /// "fake" keys set to GUIDs will be used.
        /// </summary>
        [Parameter] public Func<TItem, object> GetKeysFunc { get; set; }


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
        /// Render fragment to contain an <see cref="MBPaginator"/>.
        /// </summary>
        [Parameter] public RenderFragment Paginator { get; set; }


        /// <summary>
        /// Determines whether the data table has a progress bar.
        /// </summary>
        [Parameter] public bool HasProgressBar { get; set; }


        private bool showProgress;
        /// <summary>
        /// Determines whether the data table has a progress bar.
        /// </summary>
        [Parameter]
        public bool ShowProgress
        {
            get => showProgress;
            set
            {
                if (value != showProgress)
                {
                    showProgress = value;

                    if (HasProgressBar && HasInstantiated)
                    {
                        InvokeAsync(async () => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBDataTable.setProgress", ElementReference, showProgress));
                    }
                }
            }
        }


        /// <summary>
        /// The data table's density.
        /// </summary>
        [Parameter] public MBDensity? Density { get; set; }


        private MBCascadingDefaults.DensityInfo DensityInfo => CascadingDefaults.GetDensityCssClass(CascadingDefaults.AppliedDataTableDensity(Density));
        private ElementReference ElementReference { get; set; }
        private Func<TItem, object> KeyGenerator { get; set; }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ClassMapperInstance
                .Add("mdc-data-table")
                .AddIf(DensityInfo.CssClassName, () => DensityInfo.ApplyCssClass);
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            KeyGenerator = GetKeysFunc ?? delegate (TItem item) { return item; };
        }


        /// <inheritdoc/>
        private protected async override Task InstantiateMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBDataTable.init", ElementReference, HasProgressBar && ShowProgress);


        /// <inheritdoc/>
        private protected async override Task DestroyMcwComponent() => await JsRuntime.InvokeVoidAsync("MaterialBlazor.MBDataTable.destroy", ElementReference);
    }
}
