using System;

namespace WillyNilly.Variables
{
    /// <summary>
    /// Returns an element from the input array in uniform distribution.
    /// </summary>
    internal sealed class ArrayUniformVariable<T> : IRandomVariable<T>
    {
        private readonly IRandomSource _source;
        private readonly T[] _members;

        public ArrayUniformVariable(IRandomSource source, T[] members)
        {
            _source = source;
            _members = members ?? throw new ArgumentNullException(nameof(members));
        }

        public T Measure()
        {
            var index = _source.NextInt(0, _members.Length);
            return _members[index];
        }
    }
}