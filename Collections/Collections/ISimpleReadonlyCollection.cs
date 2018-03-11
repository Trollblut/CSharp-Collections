using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Collections
{
    interface ISimpleReadonlyCollection<T> : IEnumerable<T>
    {
        int Count { get; }
        bool IsReadonly { get; }
        bool IsStatic { get; }
    }
}
