using System;

namespace Collections.Collections
{
    interface IDistinctFixedSizeCollection<T> : IDistinctReadonlyCollection<T> where T : IEquatable<T>
    {
        bool Replace(in T newItem, in T replacedItem);
    }
}
