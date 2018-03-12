//-----------------------------------------------------------------------
// <copyright file="IDistinctReadonlyOrderedSet.cs" company="Public Domain">
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

namespace Collections.Sets.OrderedSets
{
    public interface IDistinctReadonlyOrderedSet<T> : IOrderedItemsSet<T>
    {

        /// <summary>
        /// Gets the between.
        /// </summary>
        /// <param name="infimum">The lower boundary for the comparison</param>
        /// <param name="supremum">The upper boundary for the comparisson</param>
        /// <param name="includeInfimum">if set to <c>true</c> [include infimum].</param>
        /// <param name="includeSupremum">if set to <c>true</c> [include supremum].</param>
        /// <returns></returns>
        IEnumerable<T> GetBetween(T infimum, T supremum, bool includeInfimum, bool includeSupremum);

        IEnumerable<T> GetGreater(T supremum);

        IEnumerable<T> GetGreaterOrEqual(T supremum);

        IEnumerable<T> GetSmaller(T infimum);

        IEnumerable<T> GetSmallerOrEqual(T infimum);
    }
}
