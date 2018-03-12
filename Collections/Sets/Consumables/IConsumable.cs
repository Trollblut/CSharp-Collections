//-----------------------------------------------------------------------
// <copyright file="IConsumable.cs" company="Public Domain">
//     Public Domain as according to the unlicense
// </copyright>
//-----------------------------------------------------------------------

/*
** This is free and unencumbered software released into the public domain.
** 
** Anyone is free to copy, modify, publish, use, compile, sell, or
** distribute this software, either in source code form or as a compiled
** binary, for any purpose, commercial or non-commercial, and by any
** means.
** 
** In jurisdictions that recognize copyright laws, the author or authors
** of this software dedicate any and all copyright interest in the
** software to the public domain. We make this dedication for the benefit
** of the public at large and to the detriment of our heirs and
** successors. We intend this dedication to be an overt act of
** relinquishment in perpetuity of all present and future rights to this
** software under copyright law.
** 
** 
** THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
** EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
** MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
** IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
** OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
** ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
** OTHER DEALINGS IN THE SOFTWARE.
** 
** For more information, please refer to <http://unlicense.org/>
**-----------------------------------------------------------------------*/

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
