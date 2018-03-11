using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Collections
{
    interface ISimpleFixedSizeCollection<T> : ISimpleReadonlyCollection<T>
    {
        int EditAll(in ItemEditor<T> editor);
        bool EditOnce(in ItemEditor<T> editor);
        int ReplaceAll(in T item, in ItemChooser<T> chooser);
        bool ReplaceOnce(in T item, in ItemChooser<T> chooser);
    }
}
