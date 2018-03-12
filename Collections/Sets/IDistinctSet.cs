using System;

namespace Collections.Sets
{
    interface IDistinctSet<T> : IDistinctFixedSizeSet<T> where T : IEquatable<T>
    {
        bool Add(in T item);
        bool RemoveOnce(in T item);
    }
}
