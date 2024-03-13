using Material.Blazor.Internal;

using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Material.Blazor;

public partial class MBPaginator : ComponentFoundation
{
    [CascadingParameter(Name = "IsWithinDataTable")] private bool RequiresBorder { get; set; }


    /// <summary>
    /// A list of the allowable number of items per page for the
    /// paginator to present to the user.
    /// </summary>
    [Parameter] public IEnumerable<int> ItemsPerPageSelection { get; set; }


    /// <summary>
    /// The total number if items being paged.
    /// </summary>
    [Parameter] public int ItemCount { get; set; }
    private int _cachedItemCount;


    private int BackingItemsPerPage
    {
        get => ItemsPerPage;
        set
        {
            if (value != ItemsPerPage)
            {
                ItemsPerPage = value;
                _ = ItemsPerPageChanged.InvokeAsync(value);
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
                if (HasRendered)
                {
                    PageNumberChanged.InvokeAsync(value);
                }
            }
            else
            {
                var clampedValue = Math.Clamp(value, 0, MaxPageNumber);

                if (clampedValue != PageNumber)
                {
                    PageNumber = clampedValue;
                    if (HasRendered)
                    {
                        PageNumberChanged.InvokeAsync(value);
                    }
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


    /// <summary>
    /// A function delegate that formats the items per page text in the language of your choice. The two parameters are number of items per page and the applicable culture respectively.
    /// When neither set nor overrided by cascading defaults, <see cref="DefaultItemsPerPageFormatter(int, CultureInfo)"/> is used.
    /// </summary>
    [Parameter] public Func<int, CultureInfo, string> ItemsPerPageFormatter { get; set; } = null;


    /// <summary>
    /// A function delegate that formats the position text in the language of your choice. The four parameters are the first item number, the last item number, the total item count and the applicable culture respectively.
    /// When neither set nor overrided by cascading defaults, <see cref="DefaultPositionFormatter(int, int, int, CultureInfo)"/> is used.
    /// </summary>
    [Parameter] public Func<int, int, int, CultureInfo, string> PositionFormatter { get; set; } = null;


    /// <summary>
    /// The <see cref="CultureInfo"/> that determines the culture-specific format for dates according to the <see cref="DateFormat"/>.
    /// </summary>
    [Parameter] public CultureInfo CultureInfo { get; set; } = null;


    private bool HasRendered { get; set; } = false;
    private Func<int, CultureInfo, string> AppliedItemsPerPageFormatter => CascadingDefaults.AppliedPaginatorItemsPerPageFormatter(ItemsPerPageFormatter);
    private Func<int, int, int, CultureInfo, string> AppliedPositionFormatter => CascadingDefaults.AppliedPaginatorPositionFormatter(PositionFormatter);
    private CultureInfo AppliedCultureInfo => CascadingDefaults.AppliedCultureInfo(CultureInfo);
    private ElementReference ContainerReference { get; set; }
    private MBIconButtonToggle IconButtonToggle { get; set; }
    private MBSelectElement<int>[] ItemsPerPageItems { get; set; }
    private int MaxPageNumber => ItemsPerPage == 0 ? 0 : Math.Max(0, Convert.ToInt32(Math.Ceiling((double)ItemCount / ItemsPerPage)) - 1);
    private string MaxPositionText => PositionTextString(MaxPageNumber);
    private MBMenu Menu { get; set; }
    private bool NextDisabled => PageNumber >= MaxPageNumber;
    private string PositionText => PositionTextString(PageNumber);
    private bool PreviousDisabled => PageNumber <= 0;
    private string ItemsText => AppliedItemsPerPageFormatter(ItemsPerPage, AppliedCultureInfo);
    private string PositionTextString(int pageNumber) => AppliedPositionFormatter(pageNumber * ItemsPerPage + 1, Math.Min(ItemCount, (pageNumber + 1) * ItemsPerPage), ItemCount, AppliedCultureInfo);




    private bool toggleOn;
    private bool ToggleOn 
    {
        get => toggleOn;
        set
        {
            if (value != toggleOn)
            {
                toggleOn = value;

                if (toggleOn)
                {
                    _ = InvokeAsync(Menu.ToggleAsync);
                }
            }
        }
    }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        _ = ConditionalCssClasses
            .AddIf("no-border", () => !RequiresBorder);

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
    protected override async Task OnParametersSetAsync()
    {
        await base.OnParametersSetAsync().ConfigureAwait(false);

        if (_cachedItemCount != ItemCount)
        {
            _cachedItemCount = ItemCount;
            PageNumber = 0;
        }
    }


    // Would like to use <inheritdoc/> however DocFX cannot resolve to references outside Material.Blazor
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);

        HasRendered = true;
    }


    private void OnMenuItemClick(int itemsPerPage)
    {
        double ratio = (double)ItemsPerPage / itemsPerPage;
        BackingItemsPerPage = itemsPerPage;
        BackingPageNumber = Convert.ToInt32(PageNumber * ratio);
    }


    private void OnMenuClosed()
    {
        toggleOn = false;
        _ = InvokeAsync(StateHasChanged);
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


    public static string DefaultItemsPerPageFormatter(int itemsPerPage, CultureInfo cultureInfo)
    {
        return $"{itemsPerPage.ToString("G0", cultureInfo)} items per page";
    }


    public static string DefaultPositionFormatter(int firstItemNumber, int lastItemNumber, int itemCount, CultureInfo cultureInfo)
    {
        return $"{firstItemNumber.ToString("G0", cultureInfo)}-{lastItemNumber.ToString("G0", cultureInfo)} of {itemCount.ToString("G0", cultureInfo)}";
    }
}
