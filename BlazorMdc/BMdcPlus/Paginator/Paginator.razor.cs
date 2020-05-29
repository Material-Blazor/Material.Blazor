using BMdcBase;

using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMdcPlus
{
    public partial class Paginator : BMdcComponentBase
    {
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


        private int _itemsPerPage = 0;
        /// <summary>
        /// The number of items per page as selected by the user.
        /// </summary>
        [Parameter]
        public int ItemsPerPage
        {
            get => _itemsPerPage;
            set
            {
                if (value != _itemsPerPage)
                {
                    _itemsPerPage = value;
                    _ = ItemsPerPageChanged.InvokeAsync(value);
                    PageNumber = _pageNumber; // Forces a clamp
                }
            }
        }


        /// <summary>
        /// Two way binding callback for <see cref="ItemsPerPage"/>
        /// </summary>
        [Parameter] public EventCallback<int> ItemsPerPageChanged { get; set; }


        private int _pageNumber = 0;
        /// <summary>
        /// The current page number selected by the user.
        /// </summary>
        [Parameter]
        public int PageNumber
        {
            get => _pageNumber;
            set
            {
                if (ItemsPerPage == 0)
                {
                    _pageNumber = value;
                    if (HasRendered)
                        _ = PageNumberChanged.InvokeAsync(value);
                }
                else
                {
                    var clampedValue = Math.Clamp(value, 0, MaxPageNumber);

                    if (clampedValue != _pageNumber)
                    {
                        _pageNumber = clampedValue;
                        if (HasRendered)
                            _ = PageNumberChanged.InvokeAsync(value);
                    }
                }
            }
        }

        /// <summary>
        /// Two way binding callback for <see cref="PageNumber"/>
        /// </summary>
        [Parameter] public EventCallback<int> PageNumberChanged { get; set; }


        private bool HasRendered { get; set; } = false;
        private BMdc.Menu Menu { get; set; }
        private BMdc.IconButtonToggle IconButtonToggle { get; set; }
        private bool ToggleOn { get; set; }
        private BMdcModel.ListElement<int>[] ItemsPerPageItems { get; set; }
        private int MaxPageNumber => Math.Max(0, Convert.ToInt32(Math.Ceiling((double)ItemCount / ItemsPerPage)) - 1);
        private string ItemsText => $"{ItemsPerPage:G0} items per page";
        private string PositionText => PositionTextString(PageNumber);
        private string MaxPositionText => PositionTextString(MaxPageNumber);
        private bool PreviousDisabled => PageNumber <= 0;
        private bool NextDisabled => PageNumber >= MaxPageNumber;
        private string PositionTextString(int pageNumber) => $"{pageNumber * ItemsPerPage + 1:G0}-{Math.Min(ItemCount, (pageNumber + 1) * ItemsPerPage):G0} of {ItemCount:G0}";


        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            if (ItemsPerPage == 0)
            {
                ItemsPerPage = ItemsPerPageSelection.FirstOrDefault();
            }

            if (!ItemsPerPageSelection.Contains(ItemsPerPage))
            {
                throw new ArgumentException($"PMdcPaginator: Cannot set ItemsPerPage to {ItemsPerPage} from selection of {{ {ItemsPerPageSelection.Select(r => r)} }}");
            }

            ItemsPerPageItems = (from r in ItemsPerPageSelection
                                 select new BMdcModel.ListElement<int>
                                 {
                                     SelectedValue = r,
                                     Label = r.ToString()
                                 }).ToArray();
        }


        /// <inheritdoc/>
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);

            HasRendered = true;
        }


        private async Task OnMenuToggleAsync()
        {
            if (ToggleOn)
            {
                _ = await Menu.ToggleAsync();
                ToggleOn = false;
                StateHasChanged();
            }
        }


        private void OnMenuItemClick(int itemsPerPage)
        {
            double ratio = (double)ItemsPerPage / (double)itemsPerPage;
            ItemsPerPage = itemsPerPage;
            PageNumber = Convert.ToInt32(PageNumber * ratio);
        }


        private void OnPreviousClick()
        {
            PageNumber = Math.Max(PageNumber - 1, 0);
            StateHasChanged();
        }


        private void OnNextClick()
        {
            PageNumber = Math.Min(PageNumber + 1, MaxPageNumber);
            StateHasChanged();
        }
    }
}
