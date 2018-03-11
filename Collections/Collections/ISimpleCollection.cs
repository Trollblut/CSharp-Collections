using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Collections
{
    interface ISimpleCollection<T> : ISimpleFixedSizeCollection<T>
    {
        void Add(in T item);
        int RemoveAll(in ItemChooser<T> chooser);
        bool RemoveOnce(in ItemChooser<T> chooser);
    }
}
