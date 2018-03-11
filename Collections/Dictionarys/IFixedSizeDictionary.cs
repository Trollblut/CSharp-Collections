using Collections.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections.Dictionarys
{
    interface IFixedSizeDictionary<TKey, TValue> : ILockedKeysetDictionary<TKey, TValue>, IDistinctFixedSizeCollection<KeyValuePair<TKey, TValue>> where TKey : IEquatable<TKey>
    {
    }
}
