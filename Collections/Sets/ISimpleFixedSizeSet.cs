using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Sets
{
    public interface ISimpleFixedSizeSet<T> : ISimpleReadonlySet<T>
    {
        int EditAll(in ItemEditor<T> editor);
        bool EditOnce(in ItemEditor<T> editor);
        int ReplaceAll(in T item, in ItemChooser<T> chooser);
        bool ReplaceOnce(in T item, in ItemChooser<T> chooser);
    }
}
