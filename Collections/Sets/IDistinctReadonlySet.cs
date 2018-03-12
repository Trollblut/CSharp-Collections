using System;

namespace Collections.Sets
{
    public interface IDistinctReadonlySet<T> : ISimpleReadonlySet<T>, IComparableSet<T> where T : IEquatable<T>
    {
        bool IsDistinct { get; }
        bool IsDistinctSet { get; }
        bool Contains(in T item);
    }
}
