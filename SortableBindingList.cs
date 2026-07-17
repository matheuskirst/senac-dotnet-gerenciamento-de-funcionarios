using System;
using System.Collections.Generic;
using System.ComponentModel;

public class SortableBindingList<T> : BindingList<T>
{
    private bool _isSorted;
    private ListSortDirection _sortDirection = ListSortDirection.Ascending;
    private PropertyDescriptor? _sortProperty;

    public SortableBindingList() { }

    public SortableBindingList(IList<T> list) : base(list) { }

    protected override bool SupportsSortingCore => true;
    protected override bool IsSortedCore => _isSorted;
    protected override ListSortDirection SortDirectionCore => _sortDirection;
    protected override PropertyDescriptor? SortPropertyCore => _sortProperty;

    protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
    {
        _sortProperty = prop;
        _sortDirection = direction;

        if (this.Items is List<T> list)
        {
            // Set up a comparison based on the property's values
            Comparison<T> comparison = (x, y) =>
            {
                object? xVal = prop.GetValue(x);
                object? yVal = prop.GetValue(y);

                if (xVal == null && yVal == null) return 0;
                if (xVal == null) return direction == ListSortDirection.Ascending ? -1 : 1;
                if (yVal == null) return direction == ListSortDirection.Ascending ? 1 : -1;

                if (xVal is IComparable comparable)
                {
                    return comparable.CompareTo(yVal);
                }

                return string.Compare(xVal.ToString(), yVal.ToString(), StringComparison.Ordinal);
            };

            // Perform the sort
            list.Sort(comparison);

            // Reverse the collection if sorting Descending
            if (direction == ListSortDirection.Descending)
            {
                list.Reverse();
            }

            _isSorted = true;
            this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
    }

    protected override void RemoveSortCore()
    {
        _isSorted = false;
        _sortProperty = null;
        this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
    }
}
