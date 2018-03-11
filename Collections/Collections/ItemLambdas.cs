using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Collections
{
    delegate bool ItemChooser<T>(in T item);
    delegate bool ItemEditor<T>(ref T item);
}
