using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Sets
{
    interface ISet<T> : IDistinctSet<T> where T : IEquatable<T>
    {
    }
}
