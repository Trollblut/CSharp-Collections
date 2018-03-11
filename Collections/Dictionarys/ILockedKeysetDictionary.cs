using Collections.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Dictionarys
{
    interface ILockedKeysetDictionary<TKey, TValue> : IReadonlyDictionary<TKey, TValue> where TKey : IEquatable<TKey>
    {
        new TValue this[in TKey key] { get; set; }
        void EditValue(in TKey key, in ItemEditor<TValue> editor);
        bool TryEditValue(in TKey key, in ItemEditor<TValue> editor);
    }
}
