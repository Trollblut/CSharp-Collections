using System;

namespace Collections.Sets
{
    public interface IReadonlySet<T> : IDistinctReadonlySet<T> where T : IEquatable<T>
    {
        int CountOccuences(in T item);
    }
}
