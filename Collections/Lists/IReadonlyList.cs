//-----------------------------------------------------------------------
// <copyright file="IReadonlyList.cs" company="Public Domain">
//     Public Domain as according to the unlicense
// </copyright>
//-----------------------------------------------------------------------

/*
** This is free and unencumbered software released into the public domain.
** 
** Anyone is free to copy, modify, publish, use, compile, sell, or
** distribute this software, either in source code form or as a compiled
** binary, for any purpose, commercial or non-commercial, and by any
** means.
** 
** In jurisdictions that recognize copyright laws, the author or authors
** of this software dedicate any and all copyright interest in the
** software to the public domain. We make this dedication for the benefit
** of the public at large and to the detriment of our heirs and
** successors. We intend this dedication to be an overt act of
** relinquishment in perpetuity of all present and future rights to this
** software under copyright law.
** 
** 
** THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
** EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
** MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
** IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
** OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
** ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
** OTHER DEALINGS IN THE SOFTWARE.
** 
** For more information, please refer to <http://unlicense.org/>
**-----------------------------------------------------------------------*/

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
            
            public IEqualityComparer<Maps.KeyValuePair<int, T>> EqualityComparer => throw new System.NotImplementedException();

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
