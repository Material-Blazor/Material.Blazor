using System.Collections.Generic;

namespace Material.Blazor.MD2;

/// <summary>
/// The results of a search calling <see cref="MBAutocompleteSelectField{TItem}.GetMatchingSelection"/>. Both parameters
/// must be set to enable the autocomplete to know if there is an overflow condition due to too many items being returned,
/// an exact match or no items were found.
/// </summary>
public class MBPagedSearchResult<TItem>
{
    /// <summary>
    /// Returned list of select items. Can be empty either
    /// because no items matching search criteria were found, or
    /// because the item list is too long, signfied by setting the 
    /// <see cref="SearchResultType"/> parameter to <see cref="MBSearchResultTypes.TooManyItemsFound"/>.
    /// </summary>
    public IEnumerable<MBSelectElement<TItem>> MatchingItems { get; set; }


    /// <summary>
    /// Describes the contents of <see cref="MatchingItems"/>.
    /// </summary>
    public MBSearchResultTypes SearchResultType { get; set; }


    /// <summary>
    /// The returned page number.
    /// </summary>
    public int PageNumber { get; set; }


    /// <summary>
    /// The size of each page.
    /// </summary>
    public int SelectItemsPerPage { get; set; }


    /// <summary>
    /// The total number of matching items, irrespective of whether <see cref="MatchingItems"/> is populated.
    /// </summary>
    public int MatchingItemCount { get; set; }


    /// <summary>
    /// True indicates that the search is pending results that will be supplied subsequently.
    /// </summary>
    public bool ResultsPending { get; set; }
}
