using System;

namespace Collections.Sets.OrderedSets
{
    public interface IDistinctOrderedSet<T> : IDistinctReadonlyOrderedSet<T>, IDistinctSet<T> where T : IComparable<T>, IEquatable<T>
    {
    }
}
