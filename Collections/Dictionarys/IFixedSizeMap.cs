using Collections.Sets;
using System;

namespace Collections.Maps
{
    interface IFixedSizeMap<TKey, TValue> : ILockedKeysetMap<TKey, TValue>, IDistinctFixedSizeSet<KeyValuePair<TKey, TValue>> where TKey : IEquatable<TKey>
    {
    }
}
