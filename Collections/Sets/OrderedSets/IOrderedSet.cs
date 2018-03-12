using System;

namespace Collections.Sets.OrderedSets
{
    public interface IOrderedSet<T> : IDistinctOrderedSet<T>, IReadonlyOrderedSet<T>, ISet<T> where T : IComparable<T>, IEquatable<T>
    {
    }
}
