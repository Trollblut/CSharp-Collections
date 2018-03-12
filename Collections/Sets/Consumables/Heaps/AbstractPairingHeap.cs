using Collections.Sets.OrderedSets;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections.Sets.Consumables.Heaps
{
    abstract class AbstractPairingHeap<T> : IOrderedItemsSet<T>, IConsumable<T>
    {
        private int _count = 0;
        private PairingHeapNode<T> _root;

        private bool _minHeap;
        private IComparer<T> _comparer;
        protected AbstractPairingHeap(bool minHeap, IComparer<T> comparer)
        {
            _minHeap = minHeap;
            _comparer = comparer;
        }

        public bool IsDistinct => throw new NotImplementedException();

        public bool IsDistinctSet => false;


        public IEqualityComparer<T> EqualityComparer => new OrderEqualityComparer<T>(_comparer);

        public int Count => _count;

        public bool IsReadonly => false;

        public bool IsStatic => false;

        public IComparer<T> Comparer => _comparer;

        public bool HasAny => _root != null;

        public void Add(in T item) => AddOnce(item);
        public bool AddOnce(in T item)
        {
            _count++;
            var newNode = new PairingHeapNode<T>(item);
            _root = _root == null ? newNode : Merge(_root, newNode, _comparer, _minHeap);
            return true;
        }

        private static PairingHeapNode<T> Merge(PairingHeapNode<T> x, PairingHeapNode<T> y, IComparer<T> comparer, bool minHeap)
        {
            if (comparer.Compare(x.Value, y.Value) > 0 == minHeap)
            {
                (x, y) = (y, x);
            }
            y.Sibling = x.Child;
            x.Child = y;
            return x;
        }

        public bool Contains(in T item)
        {
            foreach (var i in this)
                if (_comparer.Compare(i, item) == 0)
                    return true;

            return false;
        }

        public int CountOccuences(in T item)
        {
            int count = 0;
            foreach (var i in this)
                if (_comparer.Compare(i, item) == 0)
                    count++;

            return count;
        }

        public int EditAll(in ItemEditor<T> editor)
        {
            throw new NotImplementedException();
        }

        public bool EditOnce(in ItemEditor<T> editor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetBetween(T infimum, T supremum, bool includeInfimum, bool includeSupremum)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetConsumable()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            if (_root == null)
                throw new InvalidOperationException("Heap is empty.");
            return _root.Value;
        }

        public int RemoveAll(in ItemChooser<T> chooser)
        {
            throw new NotImplementedException();
        }

        public bool RemoveOnce(in T item)
        {
            throw new NotImplementedException();
        }

        public bool RemoveOnce(in ItemChooser<T> chooser)
        {
            throw new NotImplementedException();
        }

        public bool Replace(in T newItem, in T replacedItem)
        {
            throw new NotImplementedException();
        }

        public int ReplaceAll(in T item, in ItemChooser<T> chooser)
        {
            throw new NotImplementedException();
        }

        public bool ReplaceOnce(in T item, in ItemChooser<T> chooser)
        {
            throw new NotImplementedException();
        }

        public T Take()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private class PairingHeapNode<U>
        {
            public readonly T Value;
            public PairingHeapNode<U> Child;
            public PairingHeapNode<U> Sibling;

            public PairingHeapNode(T item)
            {
                this.Value = item;
            }
        }
    }
}
