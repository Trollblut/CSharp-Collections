using Collections.Collections;
using Collections.Dictionarys;
namespace Collections.Lists
{
    interface IReadonlyList<T> : IReadonlyDictionary<int, T>
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

            public IReadonlyCollection<int> Keys => _list.Keys;

            public ISimpleReadonlyCollection<T> Values => _list.Values;

            public bool IsDistinct => _list.IsDistinct;

            public bool IsDistinctCollection => _list.IsDistinctCollection;

            public int Count => _list.Count;

            public bool IsReadonly => true;

            public bool IsStatic => false;

            public bool Contains(in Dictionarys.KeyValuePair<int, T> item) => _list.Contains(item);

            public System.Collections.Generic.IEnumerator<Dictionarys.KeyValuePair<int, T>> GetEnumerator()
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
