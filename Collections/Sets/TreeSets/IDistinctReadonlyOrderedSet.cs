using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Sets.OrderedSets
{
    interface IDistinctReadonlyOrderedSet<T> : IDistinctReadonlySet<T> where T : IComparable<T>, IEquatable<T>
    {

        IEnumerable<T> GetBetween(T infimum, T supremum, bool includeInfimum, bool includeSupremum);
        IEnumerable<T> GetGreater(T supremum);
        IEnumerable<T> GetGreaterOrEqual(T supremum);
        IEnumerable<T> GetSmaller(T infimum);
        IEnumerable<T> GetSmallerOrEqual(T infimum);
    }
}
