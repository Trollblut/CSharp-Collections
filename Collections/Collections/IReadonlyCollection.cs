using System;

namespace Collections.Collections
{
    interface IReadonlyCollection<T> : IDistinctReadonlyCollection<T> where T : IEquatable<T>
    {
        int CountOccuences(in T item);
    }
}
