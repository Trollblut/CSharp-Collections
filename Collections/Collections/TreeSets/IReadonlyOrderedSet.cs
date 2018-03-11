using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Collections.TreeSets
{
    interface IReadonlyOrderedSet<T> : IDistinctReadonlyOrderedSet<T>, IReadonlyCollection<T> where T : IComparable<T>, IEquatable<T>
    {
    }
}
