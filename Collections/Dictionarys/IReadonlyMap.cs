
using Collections.Sets;
using System;

namespace Collections.Maps
{
    interface IReadonlyMap<TKey, TValue> : IDistinctReadonlySet<KeyValuePair<TKey, TValue>> where TKey : IEquatable<TKey>
    {
        TValue this[in TKey key] { get; }
        IReadonlySet<TKey> Keys { get; }
        ISimpleReadonlySet<TValue> Values { get; }

        bool TryGetValue(in TKey key, out TValue value);
    }
}
