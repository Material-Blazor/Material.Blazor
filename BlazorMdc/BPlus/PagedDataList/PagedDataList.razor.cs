using BBase;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPlus
{
    /// <summary>
    /// A paged data list using the "wig pig" construct allowing the consumer to free render the relevant paged data.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public partial class PagedDataList<TItem> : BBase.ComponentBase
    {
        /// <summary>
        /// A CSS class to apply to the div surrounding the paged data.
        /// </summary>
        [Parameter] public string ListTemplateClass { get; set; } = "";

        /// <summary>
        /// A class for the paginator.
        /// </summary>
        [Parameter] public string PaginatorClass { get; set; } = "";

        /// <summary>
        /// A list of allowable numbers of items per page for the paginator.
        /// </summary>
        [Parameter] public IEnumerable<int> ItemsPerPageSelection { get; set; }

        /// <summary>
        /// The pageable data.
        /// </summary>
        [Parameter] public IEnumerable<TItem> Data { get; set; }

        /// <summary>
        /// The wig pig item renderfragment.
        /// </summary>
        [Parameter] public RenderFragment<TItem> ItemTemplate { get; set; }

        /// <summary>
        /// The wig pig list renderfragment.
        /// </summary>
        [Parameter] public RenderFragment<RenderFragment> ListTemplate { get; set; }


        private int _pageNumber;
        /// <summary>
        /// The page number.
        /// </summary>
        [Parameter] public int PageNumber
        {
            get => _pageNumber;
            set
            {
                if (value != _pageNumber)
                {
                    if (hasRendered)
                    {
                        InvokeAsync(() => OnPageNumberChange(value));
                    }
                    else
                    {
                        _pageNumber = value;
                    }
                }
            }
        }

        /// <summary>
        /// Change handler for <see cref="PageNumber"/>.
        /// </summary>
        [Parameter] public EventCallback<int> PageNumberChanged { get; set; }


        private int _itemsPerPage;
        /// <summary>
        /// The number of items per page.
        /// </summary>
        [Parameter] public int ItemsPerPage
        {
            get => _itemsPerPage;
            set
            {
                if (value != _itemsPerPage)
                {
                    _itemsPerPage = value;
                    if (hasRendered)
                        _ = ItemsPerPageChanged.InvokeAsync(value);
                }
            }
        }

        /// <summary>
        /// Change handler for <see cref="ItemsPerPage"/>.
        /// </summary>
        [Parameter] public EventCallback<int> ItemsPerPageChanged { get; set; }


        private string contentClass = "";
        
        private bool hasRendered = false;
        
        private IEnumerable<TItem> CheckedData => Data ?? Array.Empty<TItem>();
        
        public IEnumerable<TItem> CurrentPage => CheckedData.Skip(PageNumber * ItemsPerPage).Take(ItemsPerPage);


        private async Task OnPageNumberChange(int newPageNumber)
        {
            if (newPageNumber != _pageNumber)
            {
                string nextClass;
                if (newPageNumber < _pageNumber)
                {
                    nextClass = SlidingContent<object>.InFromLeft;
                    contentClass = SlidingContent<object>.OutToRight;
                }
                else
                {
                    nextClass = SlidingContent<object>.InFromRight;
                    contentClass = SlidingContent<object>.OutToLeft;
                }

                await Task.Delay(100);

                ClassMapper.Clear().Add(SlidingContent<object>.Hidden);
                contentClass = nextClass;
                _pageNumber = newPageNumber;
                ClassMapper.Clear().Add(SlidingContent<object>.Visible);

                StateHasChanged();
            }
        }


        /// <inheritdoc/>
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);

            hasRendered = true;
        }
    }
}
