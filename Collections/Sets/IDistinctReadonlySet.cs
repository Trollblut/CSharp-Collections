using System;

namespace Collections.Sets
{
    interface IDistinctReadonlySet<T> : ISimpleReadonlySet<T> where T : IEquatable<T>
    {
        bool IsDistinct { get; }
        bool IsDistinctSet { get; }
        bool Contains(in T item);
    }
}
