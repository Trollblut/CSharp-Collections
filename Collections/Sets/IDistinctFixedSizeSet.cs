using System;

namespace Collections.Sets
{
    interface IDistinctFixedSizeSet<T> : IDistinctReadonlySet<T> where T : IEquatable<T>
    {
        bool Replace(in T newItem, in T replacedItem);
    }
}
