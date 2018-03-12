using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Sets
{
    delegate bool ItemChooser<T>(in T item);
    delegate bool ItemEditor<T>(ref T item);
}
