// ToDo:
//
//  Remove leading p on property names
//  


using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

//
//  Implements a scrollable, multi-column grid. When created we get a list of column
//  config objects and a list of data objects with the column content for each
//  row. The two lists must be the same size.
//
//  We 'select' a line when it is clicked on, and we also report the column clicked on
//  so the caller can either immediately respond or save the selection for later. They
//  can ask for the selection, but the nature of Blazor makes that often less than
//  convenient or practical.
//
namespace Material.Blazor
{
    public partial class MBGridPOC
    {
        [Inject] IJSRuntime pJsRuntime { get; set; }
        private ElementReference pGridHeaderRef { get; set; }
        private ElementReference pGridBodyRef { get; set; }

        private bool hasRendered = false;
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            hasRendered = true;
        }
        protected async Task GridSyncScroll()
        {
            if (hasRendered)
            {
                await pJsRuntime.InvokeVoidAsync("GeneralComponents.MBGrid.syncScroll", pGridHeaderRef, pGridBodyRef);
            }
        }

    }
}
