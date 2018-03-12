using System;
using Collections.Sets;

namespace Collections.Maps
{
    /// <summary>
    /// Common interface for Maps that .
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <seealso cref="Collections.Maps.ILockedKeysetMap{TKey, TValue}" />
    /// <seealso cref="Collections.Sets.IDistinctFixedSizeSet{Collections.Maps.KeyValuePair{TKey, TValue}}" />
    public interface IFixedSizeMap<TKey, TValue> : ILockedKeysetMap<TKey, TValue>, IDistinctFixedSizeSet<KeyValuePair<TKey, TValue>> where TKey : IEquatable<TKey>
    {
    }
}
