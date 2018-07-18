using System;

namespace WillyNilly
{
    /// <summary>
    /// Returns the declared values of an enum with uniform probability
    /// </summary>
    public class EnumVariable<T> : IRandomVariable<T>
    {
        private readonly Array _values;

        public EnumVariable()
        {
            var type = typeof(T);
            if (!type.IsEnum)
            {
                throw new InvalidOperationException("EnumVariable must only be used for enums");
            }

            _values = type.GetEnumValues();
        }

        public T Measure()
        {
            return (T) _values.GetValue(RandomPool.NextInt(0, _values.Length));
        }
    }
}
