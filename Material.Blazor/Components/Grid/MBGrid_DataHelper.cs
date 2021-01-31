using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Material.Blazor
{
    public enum Direction { Ascending, Descending }
    public class MBGrid_DataHelper<TRowData>
    {
        public IEnumerable<KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>>
            PrepareGridData(
                IEnumerable<TRowData> data,
                PropertyInfo groupKeyInfo,
                PropertyInfo sortPropertyInfo1 = null,
                Direction sortDirection1 = Direction.Ascending,
                PropertyInfo sortPropertyInfo2 = null,
                Direction sortDirection2 = Direction.Ascending,
                bool group = false,
                PropertyInfo groupExpressionInfo = null,
                IEnumerable<string> groupItemEnumerable = null,
                Func<IEnumerable<TRowData>,
                    PropertyInfo,
                    Direction,
                    PropertyInfo,
                    Direction,
                    IEnumerable<TRowData>> OrderItems = null,
                Func<IEnumerable<TRowData>,
                    bool,
                    PropertyInfo,
                    PropertyInfo,
                    IEnumerable<string>,
                    IEnumerable<KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>>> GroupItems = null
                )
        {
            IEnumerable<TRowData> orderedData;

            if (OrderItems == null)
            {
                orderedData = orderItems(
                    data,
                    sortPropertyInfo1,
                    sortDirection1,
                    sortPropertyInfo2,
                    sortDirection2);
            }
            else
            {
                orderedData = OrderItems(
                    data,
                    sortPropertyInfo1,
                    sortDirection1,
                    sortPropertyInfo2,
                    sortDirection2);
            }

            if (GroupItems == null)
            {
                return groupItems(
                    orderedData,
                    group,
                    groupKeyInfo,
                    groupExpressionInfo,
                    groupItemEnumerable);
            }
            else
            {
                return GroupItems(
                    orderedData,
                    group,
                    groupKeyInfo,
                    groupExpressionInfo,
                    groupItemEnumerable);
            }
        }

        IEnumerable<TRowData> orderItems(
            IEnumerable<TRowData> data,
            PropertyInfo sortPropertyInfo1 = null,
            Direction sortDirection1 = Direction.Ascending,
            PropertyInfo sortPropertyInfo2 = null,
            Direction sortDirection2 = Direction.Ascending
            )
        {
            // Perform the sort(s)
            IEnumerable<TRowData> orderedData;

            if (sortPropertyInfo1 == null)
            {
                // No sorting
                orderedData = data;
            }
            else
            {
                if (sortPropertyInfo2 == null)
                {
                    // Sorting by first property
                    if (sortDirection1 == Direction.Ascending)
                    {
                        orderedData = data.OrderBy(x => sortPropertyInfo1.GetValue(x));
                    }
                    else
                    {
                        orderedData = data.OrderByDescending(x => sortPropertyInfo1.GetValue(x));
                    }
                }
                else
                {
                    // Sorting by both properties
                    if (sortDirection1 == Direction.Ascending)
                    {
                        if (sortDirection2 == Direction.Ascending)
                        {
                            orderedData = data
                                    .OrderBy(x => sortPropertyInfo1.GetValue(x))
                                    .ThenBy(x => sortPropertyInfo2.GetValue(x));
                        }
                        else
                        {
                            orderedData = data
                                    .OrderBy(x => sortPropertyInfo1.GetValue(x))
                                    .ThenByDescending(x => sortPropertyInfo2.GetValue(x));
                        }
                    }
                    else
                    {
                        if (sortDirection2 == Direction.Ascending)
                        {
                            orderedData = data
                                    .OrderByDescending(x => sortPropertyInfo1.GetValue(x))
                                    .ThenBy(x => sortPropertyInfo2.GetValue(x));
                        }
                        else
                        {
                            orderedData = data
                                    .OrderByDescending(x => sortPropertyInfo1.GetValue(x))
                                    .ThenByDescending(x => sortPropertyInfo2.GetValue(x));
                        }
                    }
                }
            }
            return orderedData;
        }

        IEnumerable<KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>>
            groupItems(
                IEnumerable<TRowData> orderedData,
                bool group = false,
                PropertyInfo groupKeyInfo = null,
                PropertyInfo groupExpressionInfo = null,
                IEnumerable<string> groupItems = null)
        {
            List<KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>> groupedOrderedData = new();

            // Perform the grouping
            if (!group)
            {
                var tempDataAsSingleGroup = new List<KeyValuePair<string, TRowData>>();
                foreach (var db in orderedData)
                {
                    tempDataAsSingleGroup.Add(new KeyValuePair<string, TRowData>(groupKeyInfo.GetValue(db).ToString(), db));
                }
                groupedOrderedData.Add(new KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>("FauxKey", tempDataAsSingleGroup));
            }
            else
            {
                var groupedData = orderedData
                    .GroupBy(x => groupExpressionInfo.GetValue(x))
                    .ToDictionary(g => g.Key.ToString(), g => g.ToList());

                if (groupItems == null)
                {
                    // We will default to alphabetical order
                    var sortedGroupedData = new SortedDictionary<string, List<TRowData>>(groupedData, StringComparer.CurrentCultureIgnoreCase);
                    foreach (var kvp in sortedGroupedData)
                    {
                        var tempGroupedSortedData = new List<KeyValuePair<string, TRowData>>();
                        foreach (var db in kvp.Value)
                        {
                            tempGroupedSortedData.Add(new KeyValuePair<string, TRowData>(groupKeyInfo.GetValue(db).ToString(), db));
                        }
                        groupedOrderedData.Add(new KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>(kvp.Key, tempGroupedSortedData));
                    }
                }
                else
                {
                    foreach (var key in groupItems)
                    {
                        if (groupedData.ContainsKey(key))
                        {
                            var tempGroupedSortedData = new List<KeyValuePair<string, TRowData>>();
                            foreach (var db in groupedData[key])
                            {
                                tempGroupedSortedData.Add(new KeyValuePair<string, TRowData>(groupKeyInfo.GetValue(db).ToString(), db));
                            }
                            groupedOrderedData.Add(new KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>(key, tempGroupedSortedData));
                        }
                        else
                        {
                            var tempEmptyGroupedSortedData = new List<KeyValuePair<string, TRowData>>();
                            groupedOrderedData.Add(new KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>(key, tempEmptyGroupedSortedData));
                        }
                    }
                }
            }

            return groupedOrderedData;
        }
    }

}
