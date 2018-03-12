using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Sets
{
    interface ISimpleSet<T> : ISimpleFixedSizeSet<T>
    {
        void Add(in T item);
        int RemoveAll(in ItemChooser<T> chooser);
        bool RemoveOnce(in ItemChooser<T> chooser);
    }
}
