using Collections.Sets;
using System;

namespace Collections.Maps
{
    public interface ILockedKeysetMap<TKey, TValue> : IReadonlyMap<TKey, TValue> where TKey : IEquatable<TKey>
    {
        new TValue this[in TKey key] { get; set; }
        void EditValue(in TKey key, in ItemEditor<TValue> editor);
        bool TryEditValue(in TKey key, in ItemEditor<TValue> editor);
    }
}
