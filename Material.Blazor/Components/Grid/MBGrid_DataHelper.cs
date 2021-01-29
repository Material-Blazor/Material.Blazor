using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Material.Blazor.Components.Grid
{
    public enum Direction { Ascending, Descending }
    public class MBGrid_DataHelper<TRowData>
    {
        IOrderedEnumerable<KeyValuePair<string, IOrderedEnumerable<KeyValuePair<string, TRowData>>>>
            PrepareGridData(
            IEnumerable<TRowData> data,
            PropertyInfo sortPropertyInfo1 = null,
            Direction sortDirection1 = Direction.Ascending,
            PropertyInfo sortPropertyInfo2 = null,
            Direction sortDirection2 = Direction.Ascending,
            Func<IEnumerable<TRowData>,
                PropertyInfo,
                Direction,
                PropertyInfo,
                Direction,
                IOrderedEnumerable<TRowData>> OrderItems = null,
            bool group = false,
            PropertyInfo groupKeyInfo = null,
            PropertyInfo groupExpressionInfo = null,
            IEnumerable<string> groupItems = null,
            Func<IOrderedEnumerable<TRowData>,
                bool,
                PropertyInfo,
                PropertyInfo,
                IEnumerable<string>,
                IOrderedEnumerable<KeyValuePair<string, IOrderedEnumerable<KeyValuePair<string, TRowData>>>>> GroupItems = null
            )
        {
            IOrderedEnumerable<TRowData> sortedData;

            if (OrderItems == null)
            {
                sortedData = orderItems(
                    data,
                    sortPropertyInfo1,
                    sortDirection1,
                    sortPropertyInfo2,
                    sortDirection2);
            }
            else
            {
                sortedData = OrderItems(
                    data,
                    sortPropertyInfo1,
                    sortDirection1,
                    sortPropertyInfo2,
                    sortDirection2);
            }

            IOrderedEnumerable<KeyValuePair<string, IOrderedEnumerable<KeyValuePair<string, TRowData>>>> groupedSortedData = new();

            if (GroupItems == null)
            {
                return groupItems(
                    sortedData,
            group,
            groupKeyInfo,
            groupExpressionInfo,
            groupItems);
            }
            else
            {
                return GroupItems(
                    sortedData,
            group,
            groupKeyInfo,
            groupExpressionInfo,
            groupItems);
            }
        }

        IOrderedEnumerable<TRowData> orderItems(
            IEnumerable<TRowData> data,
            PropertyInfo sortPropertyInfo1 = null,
            Direction sortDirection1 = Direction.Ascending,
            PropertyInfo sortPropertyInfo2 = null,
            Direction sortDirection2 = Direction.Ascending
            )
        {
            // Perform the sort(s)
            IOrderedEnumerable<TRowData> sortedData;

            if (sortDirection1 == Direction.Ascending)
            {
                if (sortDirection2 == Direction.Ascending)
                {
                    sortedData = data
                            .OrderBy(x => sortPropertyInfo1.GetValue(x))
                            .ThenBy(x => sortPropertyInfo2.GetValue(x));
                }
                else
                {
                    sortedData = data
                            .OrderBy(x => sortPropertyInfo1.GetValue(x))
                            .ThenByDescending(x => sortPropertyInfo2.GetValue(x));
                }
            }
            else
            {
                if (sortDirection2 == Direction.Ascending)
                {
                    sortedData = data
                            .OrderByDescending(x => sortPropertyInfo1.GetValue(x))
                            .ThenBy(x => sortPropertyInfo2.GetValue(x));
                }
                else
                {
                    sortedData = data
                            .OrderByDescending(x => sortPropertyInfo1.GetValue(x))
                            .ThenByDescending(x => sortPropertyInfo2.GetValue(x));
                }
            }
            return sortedData;
        }

        IOrderedEnumerable<KeyValuePair<string, IOrderedEnumerable<KeyValuePair<string, TRowData>>>>
            groupItems(
                IOrderedEnumerable<TRowData> sortedData,
                bool group = false,
                PropertyInfo groupKeyInfo = null,
                PropertyInfo groupExpressionInfo = null,
                IEnumerable<string> groupItems = null)
        {
            List<KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>> groupedSortedData = new();

            // Perform the grouping
            if (!group)
            {
                var tempDataAsSingleGroup = new List<KeyValuePair<string, TRowData>>();
                foreach (var db in sortedData)
                {
                    tempDataAsSingleGroup.Add(new KeyValuePair<string, TRowData>(x => groupKeyInfo.GetValue(x), db));
                }
                groupedSortedData.Add(new KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>("FauxKey", tempDataAsSingleGroup));
            }
            else
            {
                var groupedData = sortedData
                    .GroupBy(x => groupExpressionInfo.GetValue(x))
                    .ToDictionary(g => g.Key.ToString(), g => g.ToList());

                if (groupItems == null)
                {
                    // We will default to alphabetical order
                    var sortedGroupedData = new SortedDictionary<string, List<TRowData>>(groupedData, new StringComparer());
                    foreach (var kvp in sortedGroupedData)
                    {
                        var tempGroupedSortedData = new List<KeyValuePair<string, TRowData>>();
                        foreach (var db in kvp.Value)
                        {
                            tempGroupedSortedData.Add(new KeyValuePair<string, TRowData>(x => groupKeyInfo.GetValue(x), db));
                        }
                        groupedSortedData.Add(new KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>(kvp.Key, tempGroupedSortedData));
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
                                tempGroupedSortedData.Add(new KeyValuePair<string, TRowData>(x => groupKeyInfo.GetValue(x), db));
                            }
                            groupedSortedData.Add(new KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>(key, tempGroupedSortedData));
                        }
                        else
                        {
                            var tempEmptyGroupedSortedData = new List<KeyValuePair<string, TRowData>>();
                            groupedSortedData.Add(new KeyValuePair<string, IEnumerable<KeyValuePair<string, TRowData>>>(key, tempEmptyGroupedSortedData));
                        }
                    }
                }
            }
        }
    }

    #region StringComparer
        class StringComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return string.Compare(x, y, true);
            }
        }

    #endregion

}
