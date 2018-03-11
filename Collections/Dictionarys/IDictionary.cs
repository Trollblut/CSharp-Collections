using System;
using System.Collections;
using System.Collections.Generic;
using Collections.Collections;

namespace Collections.Dictionarys
{
    interface IDictionary<TKey, TValue> : IFixedSizeDictionary<TKey, TValue>, IDistinctCollection<KeyValuePair<TKey, TValue>> where TKey : IEquatable<TKey>
    {
    }
    static class IDictionaryExtension
    {
        public static void Add<TKey, TValue>(this IDictionary<TKey, TValue> dict, in TKey key, in TValue value) where TKey : IEquatable<TKey>
        {
            dict.Add(new KeyValuePair<TKey, TValue>(key, value));
        }
    }
}
