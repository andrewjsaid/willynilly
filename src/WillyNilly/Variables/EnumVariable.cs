using System;

namespace WillyNilly.Variables
{
    /// <summary>
    /// Returns the declared values of an enum with uniform probability.
    /// </summary>
    internal sealed class EnumVariable<T> : IRandomVariable<T> where T : struct
    {
        private readonly IRandomSource _randomSource;
        private readonly Array _values;

        public EnumVariable(IRandomSource randomSource)
        {
            _randomSource = randomSource;

            var type = typeof(T);
            if (!type.IsEnum)
            {
                throw new InvalidOperationException("EnumVariable must only be used for enums");
            }

            _values = type.GetEnumValues();
        }

        public T Measure()
        {
            return (T) _values.GetValue(_randomSource.NextInt(0, _values.Length));
        }
    }
}
