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
                PropertyInfo dataKeyInfo,
                PropertyInfo orderPropertyInfo1 = null,
                Direction orderDirection1 = Direction.Ascending,
                PropertyInfo orderPropertyInfo2 = null,
                Direction orderDirection2 = Direction.Ascending,
                bool group = false,
                PropertyInfo groupPropertyInfo = null,
                IEnumerable<string> groupItemEnumerable = null,
                Func<IEnumerable<TRowData>,
                    PropertyInfo,
                    Direction,
                    PropertyInfo,
                    Direction,
                    IEnumerable<TRowData>> OrderData = null,
                Func<IEnumerable<TRowData>,
                    bool,
                    PropertyInfo,
                    PropertyInfo,
                    IEnumerable<string>,
                    IEnumerable<KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>>> GroupItems = null
                )
        {
            IEnumerable<TRowData> orderedData;

            if (OrderData == null)
            {
                orderedData = orderData(
                    data,
                    orderPropertyInfo1,
                    orderDirection1,
                    orderPropertyInfo2,
                    orderDirection2);
            }
            else
            {
                orderedData = OrderData(
                    data,
                    orderPropertyInfo1,
                    orderDirection1,
                    orderPropertyInfo2,
                    orderDirection2);
            }

            if (GroupItems == null)
            {
                return groupItems(
                    orderedData,
                    group,
                    dataKeyInfo,
                    groupPropertyInfo,
                    groupItemEnumerable);
            }
            else
            {
                return GroupItems(
                    orderedData,
                    group,
                    dataKeyInfo,
                    groupPropertyInfo,
                    groupItemEnumerable);
            }
        }

        private IEnumerable<TRowData> orderData(
            IEnumerable<TRowData> data,
            PropertyInfo orderPropertyInfo1,
            Direction orderDirection1,
            PropertyInfo orderPropertyInfo2,
            Direction orderDirection2
            )
        {
            // Perform the group(s)
            IEnumerable<TRowData> orderedData;

            if (orderPropertyInfo1 == null)
            {
                // No grouping
                orderedData = data;
            }
            else
            {
                if (orderPropertyInfo2 == null)
                {
                    // grouping by first property
                    if (orderDirection1 == Direction.Ascending)
                    {
                        orderedData = data.OrderBy(x => orderPropertyInfo1.GetValue(x));
                    }
                    else
                    {
                        orderedData = data.OrderByDescending(x => orderPropertyInfo1.GetValue(x));
                    }
                }
                else
                {
                    // grouping by both properties
                    if (orderDirection1 == Direction.Ascending)
                    {
                        if (orderDirection2 == Direction.Ascending)
                        {
                            orderedData = data
                                    .OrderBy(x => orderPropertyInfo1.GetValue(x))
                                    .ThenBy(x => orderPropertyInfo2.GetValue(x));
                        }
                        else
                        {
                            orderedData = data
                                    .OrderBy(x => orderPropertyInfo1.GetValue(x))
                                    .ThenByDescending(x => orderPropertyInfo2.GetValue(x));
                        }
                    }
                    else
                    {
                        if (orderDirection2 == Direction.Ascending)
                        {
                            orderedData = data
                                    .OrderByDescending(x => orderPropertyInfo1.GetValue(x))
                                    .ThenBy(x => orderPropertyInfo2.GetValue(x));
                        }
                        else
                        {
                            orderedData = data
                                    .OrderByDescending(x => orderPropertyInfo1.GetValue(x))
                                    .ThenByDescending(x => orderPropertyInfo2.GetValue(x));
                        }
                    }
                }
            }
            return orderedData;
        }

        private IEnumerable<KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>>
            groupItems(
                IEnumerable<TRowData> orderedData,
                bool group,
                PropertyInfo dataKeyInfo,
                PropertyInfo groupPropertyInfo,
                IEnumerable<string> groupItems)
        {
            List<KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>> groupedOrderedData = new();

            // Perform the grouping
            if (!group)
            {
                var tempDataAsSingleGroup = new List<KeyValuePair<string, TRowData>>();
                foreach (var db in orderedData)
                {
                    tempDataAsSingleGroup.Add(new KeyValuePair<string, TRowData>(dataKeyInfo.GetValue(db).ToString(), db));
                }
                groupedOrderedData.Add(new KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>("FauxKey", tempDataAsSingleGroup));
            }
            else
            {
                var groupedData = orderedData
                    .GroupBy(x => groupPropertyInfo.GetValue(x))
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
                            tempGroupedSortedData.Add(new KeyValuePair<string, TRowData>(dataKeyInfo.GetValue(db).ToString(), db));
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
                                tempGroupedSortedData.Add(new KeyValuePair<string, TRowData>(dataKeyInfo.GetValue(db).ToString(), db));
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
