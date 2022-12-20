using System.Collections.Generic;

namespace Material.Blazor;

/// <summary>
/// The results of a search calling <see cref="MBAutocompleteSelectField.GetMatchingSelection"/>. Both parameters
/// must be set to enable the autocomplete to know if there is an overflow condition due to too many items being returned,
/// an exact match or no items were found.
/// </summary>
public class MBAsyncSearchResult<TItem>
{
    /// <summary>
    /// Returned list of select items. Can be empty either
    /// because no items matching search criteria were found, or
    /// because the item list is too long, signfied by setting the 
    /// <see cref="ItemListTooLong"/> parameter to true.
    /// </summary>
    public IEnumerable<MBSelectElement<TItem>> MatchingItems { get; set; }


    /// <summary>
    /// Describes the contents of <see cref="MatchingItems"/>.
    /// </summary>
    public MBSearchResultTypes SearchResultType { get; set; }


    /// <summary>
    /// The total number of matching items, irrespective of whether <see cref="MatchingItems"/> is populated.
    /// </summary>
    public int MatchingItemCount { get; set; }


    /// <summary>
    /// The maximum number of items that the query will return before setting <see cref="SearchResultType"/> to <see cref="MBSearchResultTypes.TooManyItemsFound"/>.
    /// </summary>
    public int MaxItemCount { get; set; }
}
