using System.Collections.Generic;
using Collections.Maps;
using Collections.Sets;
namespace Collections.Lists
{
    interface IReadonlyList<T> : IReadonlyMap<int, T>
    {
    }

    static class IReadonlyListExtensions
    {

        public static IReadonlyList<T> AsReadonlyList<T>(IReadonlyList<T> list)
        {
            if (list.IsStatic || list.IsReadonly)
            {
                return list;
            }
            return new ReadonlyList<T>(list);
        }
        private class ReadonlyList<T> : IReadonlyList<T>
        {
            private readonly IReadonlyList<T> _list;

            public ReadonlyList(IReadonlyList<T> list) => _list = list;

            public T this[in int key] => _list[key];

            public IReadonlySet<int> Keys => _list.Keys;

            public ISimpleReadonlySet<T> Values => _list.Values;

            public bool IsDistinct => _list.IsDistinct;

            public bool IsDistinctSet => _list.IsDistinctSet;

            public int Count => _list.Count;

            public bool IsReadonly => true;

            public bool IsStatic => false;

            public IComparer<Maps.KeyValuePair<int, T>> Comparer => _list.Comparer;

            public bool Contains(in Maps.KeyValuePair<int, T> item) => _list.Contains(item);

            public System.Collections.Generic.IEnumerator<Maps.KeyValuePair<int, T>> GetEnumerator()
            {
                return _list.GetEnumerator();
            }

            public bool TryGetValue(in int key, out T value) => _list.TryGetValue(key, out value);

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return _list.GetEnumerator();
            }
        }
    }
}
