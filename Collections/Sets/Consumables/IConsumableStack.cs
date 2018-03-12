namespace Collections.Sets.Consumables
{
    interface IConsumableStack<T>: IConsumableSet<T>
    {
        ref readonly Consumable<T> StackPopper { get; }
    }
    static class ConsumableStackExtensions
    {
        public static T Pop<T>(this IConsumableStack<T> stack) => stack.StackPopper.Take();
        public static bool TryPop<T>(this IConsumableStack<T> stack, out T item) => stack.StackPopper.TryTake(out item);
    }
}
