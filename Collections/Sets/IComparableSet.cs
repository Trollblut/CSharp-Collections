using System.Collections.Generic;

namespace Collections.Sets
{
    public interface IComparableSet<T>
    {
        IComparer<T> Comparer { get; }
    }
}
