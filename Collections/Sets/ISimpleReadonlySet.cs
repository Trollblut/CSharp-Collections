using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Sets
{
    public interface ISimpleReadonlySet<T> : IEnumerable<T>
    {
        int Count { get; }

        bool IsReadonly { get; }

        bool IsStatic { get; }
    }
}
