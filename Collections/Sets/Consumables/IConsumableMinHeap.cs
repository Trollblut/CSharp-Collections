
namespace Collections.Sets.Consumables
{
    interface IConsumableMinHeap<T> : IConsumableSet<T>, IComparableSet<T>
    {
        ref readonly Consumable<T> MinExtractor { get; }
    }
    static class ConsumableMinHeapExtensions
    {
        public static T ExtractMin<T>(this IConsumableMinHeap<T> minHeap) => minHeap.MinExtractor.Take();
        public static bool TryExtractMin<T>(this IConsumableMinHeap<T> minHeap, out T item) => minHeap.MinExtractor.TryTake(out item);
    }
}
