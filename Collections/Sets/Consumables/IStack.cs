using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Sets.Consumables
{
    interface IStack<T> : ISimpleSet<T>, IConsumableStack<T>
    {
    }
}
