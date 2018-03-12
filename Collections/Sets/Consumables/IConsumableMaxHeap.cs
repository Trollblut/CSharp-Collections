
namespace Collections.Sets.Consumables
{
    interface IConsumableMaxHeap<T> : IConsumableSet<T>, IComparableSet<T>
    {
        ref readonly Consumable<T> MaxExtractor { get; }
    }
    static class ConsumableMaxHeapExtensions
    {
        public static T ExtractMax<T>(this IConsumableMaxHeap<T> minHeap) => minHeap.MaxExtractor.Take();
        public static bool TryExtractMin<T>(this IConsumableMaxHeap<T> minHeap, out T item) => minHeap.MaxExtractor.TryTake(out item);
    }
}
