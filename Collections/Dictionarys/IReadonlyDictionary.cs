
using Collections.Collections;
using System;

namespace Collections.Dictionarys
{
    interface IReadonlyDictionary<TKey, TValue> : IDistinctReadonlyCollection<KeyValuePair<TKey, TValue>> where TKey : IEquatable<TKey>
    {
        TValue this[in TKey key] { get; }
        IReadonlyCollection<TKey> Keys { get; }
        ISimpleReadonlyCollection<TValue> Values { get; }

        bool TryGetValue(in TKey key, out TValue value);
    }
}
