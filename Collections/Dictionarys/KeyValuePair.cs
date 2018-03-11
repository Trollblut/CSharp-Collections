using System;

namespace Collections.Dictionarys
{
    struct KeyValuePair<TKey, TValue> : IEquatable<KeyValuePair<TKey, TValue>> where TKey : IEquatable<TKey>
    {
        public readonly TKey Key;
        public TValue Value;
        private TKey key;
        private TValue value;

        public KeyValuePair(in TKey key, in TValue value) : this()
        {
            this.key = key;
            this.value = value;
        }

        public bool Equals(KeyValuePair<TKey, TValue> other)
        {
            return Key == null ? other.Key == null : Key.Equals(other.Key);
        }
    }
}
