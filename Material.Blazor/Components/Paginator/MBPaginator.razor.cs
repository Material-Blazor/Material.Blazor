using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor
{
    public partial class MBPaginator : ComponentFoundation
    {
        [CascadingParameter(Name = MBDataTable<string>.DataTableCascadingValue)] private string DataTableCascadingValue { get; set; }


        /// <summary>
        /// A list of the allowable number of items per page for the
        /// paginator to present to the user.
        /// </summary>
        [Parameter] public IEnumerable<int> ItemsPerPageSelection { get; set; }


        private int _itemCount;
        /// <summary>
        /// The total number if items being paged.
        /// </summary>
        [Parameter]
        public int ItemCount
        {
            get => _itemCount;
            set
            {
                if (value != _itemCount)
                {
                    _itemCount = value;
                    PageNumber = 0;
                }
            }
        }


        private int BackingItemsPerPage
        {
            get => ItemsPerPage;
            set
            {
                if (value != ItemsPerPage)
                {
                    ItemsPerPage = value;
                    ItemsPerPageChanged.InvokeAsync(value);
                    BackingPageNumber = PageNumber; // Forces a clamp
                }
            }
        }
        /// <summary>
        /// The number of items per page as selected by the user.
        /// </summary>
        [Parameter]
        public int ItemsPerPage { get; set; } = 0;


        /// <summary>
        /// Two way binding callback for <see cref="ItemsPerPage"/>
        /// </summary>
        [Parameter] public EventCallback<int> ItemsPerPageChanged { get; set; }


        private int BackingPageNumber
        {
            get => PageNumber;
            set
            {
                if (ItemsPerPage == 0)
                {
                    PageNumber = value;
                    if (HasRendered) PageNumberChanged.InvokeAsync(value);
                }
                else
                {
                    var clampedValue = Math.Clamp(value, 0, MaxPageNumber);

                    if (clampedValue != PageNumber)
                    {
                        PageNumber = clampedValue;
                        if (HasRendered) PageNumberChanged.InvokeAsync(value);
                    }
                }
            }
        }
        /// <summary>
        /// The current page number selected by the user.
        /// </summary>
        [Parameter]
        public int PageNumber { get; set; } = 0;


        /// <summary>
        /// Two way binding callback for <see cref="PageNumber"/>
        /// </summary>
        [Parameter] public EventCallback<int> PageNumberChanged { get; set; }


        private bool HasRendered { get; set; } = false;
        private MBIconButtonToggle IconButtonToggle { get; set; }
        private MBSelectElement<int>[] ItemsPerPageItems { get; set; }
        private string ItemsText => $"{ItemsPerPage:G0} items per page";
        private int MaxPageNumber => Math.Max(0, Convert.ToInt32(Math.Ceiling((double)ItemCount / ItemsPerPage)) - 1);
        private string MaxPositionText => PositionTextString(MaxPageNumber);
        private MBMenu Menu { get; set; }
        private bool NextDisabled => PageNumber >= MaxPageNumber;
        private string PositionText => PositionTextString(PageNumber);
        private bool PreviousDisabled => PageNumber <= 0;
        private string PositionTextString(int pageNumber) => $"{pageNumber * ItemsPerPage + 1:G0}-{Math.Min(ItemCount, (pageNumber + 1) * ItemsPerPage):G0} of {ItemCount:G0}";
        private bool ToggleOn { get; set; }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnInitialized()
        {
            base.OnInitialized();

            var requiresBorder = DataTableCascadingValue != null && DataTableCascadingValue == MBDataTable<string>.DataTableReference;

            ClassMapperInstance
                .Add("mdc-data-table__pagination")
                .AddIf("no-border", () => !requiresBorder);

            if (ItemsPerPage == 0)
            {
                ItemsPerPage = ItemsPerPageSelection.FirstOrDefault();
            }

            if (!ItemsPerPageSelection.Contains(ItemsPerPage))
            {
                throw new ArgumentException($"MBPaginator: Cannot set ItemsPerPage to {ItemsPerPage} from selection of {{ {ItemsPerPageSelection.Select(r => r)} }}");
            }

            ItemsPerPageItems = (from r in ItemsPerPageSelection
                                 select new MBSelectElement<int>
                                 {
                                     SelectedValue = r,
                                     Label = r.ToString()
                                 }).ToArray();
        }


        // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);

            HasRendered = true;
        }


        private async Task OnMenuToggleAsync()
        {
            if (ToggleOn)
            {
                await Menu.ToggleAsync();
                ToggleOn = false;
            }
        }


        private void OnMenuItemClick(int itemsPerPage)
        {
            double ratio = (double)ItemsPerPage / (double)itemsPerPage;
            BackingItemsPerPage = itemsPerPage;
            BackingPageNumber = Convert.ToInt32(PageNumber * ratio);
        }


        private void OnFirstClick()
        {
            BackingPageNumber = 0;
        }


        private void OnPreviousClick()
        {
            BackingPageNumber = Math.Max(PageNumber - 1, 0);
        }


        private void OnNextClick()
        {
            BackingPageNumber = Math.Min(PageNumber + 1, MaxPageNumber);
        }


        private void OnLastClick()
        {
            BackingPageNumber = MaxPageNumber;
        }
    }
}
