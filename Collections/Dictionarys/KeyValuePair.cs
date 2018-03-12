using System;

namespace Collections.Maps
{
    public struct KeyValuePair<TKey, TValue> : IEquatable<KeyValuePair<TKey, TValue>> where TKey : IEquatable<TKey>
    {
        public readonly TKey Key;
        public TValue Value;

        public KeyValuePair(in TKey key, in TValue value)
        {
            Key = key;
            Value = value;
        }

        public bool Equals(KeyValuePair<TKey, TValue> other)
        {
            return Key == null ? other.Key == null : Key.Equals(other.Key);
        }
    }
}
