﻿using System;

namespace Collections.Sets.OrderedSets
{
    interface IReadonlyOrderedSet<T> : IDistinctReadonlyOrderedSet<T>, IReadonlySet<T> where T : IComparable<T>, IEquatable<T>
    {
    }
}
