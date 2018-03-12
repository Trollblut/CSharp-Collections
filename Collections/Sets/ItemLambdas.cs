using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Sets
{
    public delegate bool ItemChooser<T>(in T item);
    public delegate bool ItemEditor<T>(ref T item);
    public delegate void ItemSink<T>(in T item);
    public delegate bool DistinctItemSink<T>(in T item);
}
