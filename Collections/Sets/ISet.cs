using System;

namespace Collections.Sets
{
    public interface ISet<T> : IDistinctSet<T>, ISimpleSet<T> where T : IEquatable<T>
    {
    }
}
