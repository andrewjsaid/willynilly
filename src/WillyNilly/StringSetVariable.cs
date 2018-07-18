using System;

namespace WillyNilly
{
    /// <summary>
    /// Returns from the input string array in uniform distribution.
    /// </summary>
    public class StringSetVariable : IRandomVariable<string>
    {
        private readonly string[] _members;

        public StringSetVariable(string[] members)
        {
            _members = members ?? throw new ArgumentNullException(nameof(members));
        }

        public string Measure() => _members[RandomPool.NextInt(0, _members.Length)];
    }
}