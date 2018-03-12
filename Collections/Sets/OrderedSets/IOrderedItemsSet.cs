using System.Collections.Generic;

namespace Collections.Sets.OrderedSets
{
    public interface IOrderedItemsSet<T>:IDistinctReadonlySet<T>
    {
        /// <summary>
        /// Gets the comparer used by this set to tell whether items are equal.
        /// </summary>
        /// <value>
        /// The comparer.
        /// </value>
        IComparer<T> Comparer { get; }
    }
}
