using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Collections
{
    interface IDistinctCollection<T> : IDistinctFixedSizeCollection<T> where T : IEquatable<T>
    {
        bool Add(in T item);
        bool RemoveOnce(in T item);
    }
}
