using System;

namespace Collections.Sets
{
    public interface IDistinctSet<T> : IDistinctFixedSizeSet<T> where T : IEquatable<T>
    {
        bool Add(in T item);
        bool RemoveOnce(in T item);
    }
}
