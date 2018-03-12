using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Sets.OrderedSets
{
    public class OrderEqualityComparer<T> : IEqualityComparer<T>
    {
        private delegate int ComparerFunction<U>(U x, U y);
        private readonly ComparerFunction<T> _comparer;
        public OrderEqualityComparer(IComparer<T> comparer) => _comparer = comparer.Compare;

        public bool Equals(T x, T y) => _comparer(x, y) == 0;

        public int GetHashCode(T obj) => _comparer.GetHashCode();
    }
}
