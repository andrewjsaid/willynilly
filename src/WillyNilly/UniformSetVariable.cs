using System;

namespace WillyNilly
{
    /// <summary>
    /// Returns an element from the input array in uniform distribution.
    /// </summary>
    public class UniformSetVariable<T> : IRandomVariable<T>
    {
        private readonly T[] _members;

        public UniformSetVariable(T[] members)
        {
            _members = members ?? throw new ArgumentNullException(nameof(members));
        }

        public T Measure() => _members[RandomPool.NextInt(0, _members.Length)];
    }
}