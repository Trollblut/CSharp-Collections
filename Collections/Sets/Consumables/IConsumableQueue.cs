
namespace Collections.Sets.Consumables
{
    interface IConsumableQueue<T> : IConsumableSet<T>
    {
        ref readonly Consumable<T> Dequeuer { get; }
    }
    static class ConsumableQueueExtensions
    {
        public static T Dequeue<T>(this IConsumableQueue<T> queue) => queue.Dequeuer.Take();
        public static bool TryDequeue<T>(this IConsumableQueue<T> queue, out T item) => queue.Dequeuer.TryTake(out item);
    }
}
