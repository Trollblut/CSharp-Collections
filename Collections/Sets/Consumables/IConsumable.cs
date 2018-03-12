using System.Collections.Generic;

namespace Collections.Sets.Consumables
{
    public interface IConsumable<T>
    {
        bool HasAny { get; }
        IEnumerable<T> GetConsumable();
        T Peek();
        T Take();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Type of Values the struct returns.</typeparam>
    /// <seealso cref="Collections.Sets.Consumables.IConsumable{T}" />
    public struct Consumable<T> : IConsumable<T>
    {
        public delegate bool ConsumableHasAny();
        public delegate IEnumerable<U> ConsumableGetConsumable<U>();
        public delegate T ConsumablePeek<U>();
        public delegate T ConsumableTake<U>();

        public readonly ConsumableHasAny HasAny;
        public readonly ConsumableGetConsumable<T> GetConsumable;
        public readonly ConsumablePeek<T> Peek;
        public readonly ConsumableTake<T> Take;


        public Consumable(IConsumable<T> target)
        {
            HasAny = () => target.HasAny;
            GetConsumable = target.GetConsumable;
            Peek = target.Peek;
            Take = target.Take;
        }
        public Consumable(ConsumableHasAny hasAny, ConsumableGetConsumable<T> getConsumable,
            ConsumablePeek<T> peek, ConsumableTake<T> take)
        {
            HasAny = hasAny;
            GetConsumable = getConsumable;
            Peek = peek;
            Take = take;
        }

        bool IConsumable<T>.HasAny => HasAny();
        IEnumerable<T> IConsumable<T>.GetConsumable() => GetConsumable();

        T IConsumable<T>.Peek() => Peek();

        T IConsumable<T>.Take() => Take();
    }

    public static class ConsumableExtensions
    {
        public static bool TryPeek<T>(this IConsumable<T> consumable, out T item)
        {
            if (consumable.HasAny)
            {
                item = consumable.Peek();
                return true;
            }
            item = default;
            return false;
        }
        public static bool TryTake<T>(this IConsumable<T> consumable, out T item)
        {
            if (consumable.HasAny)
            {
                item = consumable.Take();
                return true;
            }
            item = default;
            return false;
        }
    }

}
