﻿using System.Collections.Generic;

namespace Material.Blazor;

/// <summary>
/// The results of a search calling <see cref="MBAutocompleteTextFieldAsync.GetMatchingSelection"/>. Both parameters
/// must be set to enable the autocomplete to know if there is an overflow condition due to too many items being returned,
/// an exact match or no items were found.
/// </summary>
public class MBAutocompleteAsyncSearchResult
{
    /// <summary>
    /// Returned list of select items. Can be empty either
    /// because no items matching search criteria were found, or
    /// because the item list is too long, signfied by setting the 
    /// <see cref="ItemListTooLong"/> parameter to true.
    /// </summary>
    public IEnumerable<string> MatchingItems { get; set; }


    /// <summary>
    /// Describes the contents of <see cref="MatchingItems"/>.
    /// </summary>
    public MBSearchResultTypes SearchResultType { get; set; }
}
