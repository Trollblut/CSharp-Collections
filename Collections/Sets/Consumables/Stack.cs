using System;

namespace Collections.Sets.Consumables
{
    class Stack<T> : IStack<T>
    {
        private StackFrame<T> _top;
        private int _count = 0;
        public ref readonly Consumable<T> StackPopper => throw new NotImplementedException();

        public int Count => _count;

        public bool IsReadonly => false;

        public bool IsStatic => false;

        public bool HasAny => _count != 0;

        public void Add(in T item)
        {
            throw new NotImplementedException();
        }

        public int EditAll(in ItemEditor<T> editor)
        {
            throw new NotImplementedException();
        }

        public bool EditOnce(in ItemEditor<T> editor)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<T> GetConsumable()
        {
            while (HasAny)
                yield return Take();
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator() => GetEnumerable().GetEnumerator();

        public T Peek()
        {
            if (_top == null)
                throw new InvalidOperationException("Stack is empty.");
            return _top.Value;
        }

        public int RemoveAll(in ItemChooser<T> chooser)
        {
            throw new NotImplementedException();
        }

        public bool RemoveOnce(in ItemChooser<T> chooser)
        {
            throw new NotImplementedException();
        }

        public int ReplaceAll(in T item, in ItemChooser<T> chooser)
        {
            var current = _top;
            var count = 0;
            while (current != null)
            {
                if (chooser(current.Value))
                    current.Value = item;
                current = current.Previous;
            }
            return count;
        }

        public bool ReplaceOnce(in T item, in ItemChooser<T> chooser)
        {
            var current = _top;
            while (current != null)
            {
                if (chooser(current.Value))
                {
                    current.Value = item;
                    return true;
                }
                current = current.Previous;
            }
            return false;
        }

        public T Take()
        {
            if (_top == null)
                throw new InvalidOperationException("Stack is empty.");
            var ret = _top.Value;
            _top = _top.Previous;
            return ret;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerable().GetEnumerator();
        private System.Collections.Generic.IEnumerable<T> GetEnumerable()
        {
            var current = _top;
            while (current != null)
            {
                yield return current.Value;
                current = current.Previous;
            }
        }
        private class StackFrame<U>
        {
            public U Value;
            public StackFrame<U> Previous;
        }
    }
}
