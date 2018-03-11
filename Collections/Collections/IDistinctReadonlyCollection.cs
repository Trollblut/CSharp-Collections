using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Collections
{
    interface IDistinctReadonlyCollection<T> : ISimpleReadonlyCollection<T> where T : IEquatable<T>
    {
        bool IsDistinct { get; }
        bool IsDistinctCollection { get; }
        bool Contains(in T item);
    }
}
