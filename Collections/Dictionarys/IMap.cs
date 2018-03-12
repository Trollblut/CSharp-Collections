using System;
using Collections.Sets;

namespace Collections.Maps
{
    interface IMap<TKey, TValue> : IFixedSizeMap<TKey, TValue>, IDistinctSet<KeyValuePair<TKey, TValue>> where TKey : IEquatable<TKey>
    {
    }
    static class IDictionaryExtension
    {
        public static void Add<TKey, TValue>(this IMap<TKey, TValue> dict, in TKey key, in TValue value) where TKey : IEquatable<TKey>
        {
            dict.Add(new KeyValuePair<TKey, TValue>(key, value));
        }
    }
}
