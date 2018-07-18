namespace WillyNilly
{
    /// <summary>
    /// Returns a constant value.
    /// </summary>
    public class ConstantVariable<T> : IRandomVariable<T>
    {
        private readonly T _value;

        public ConstantVariable(T value)
        {
            _value = value;
        }

        public T Measure() => _value;
    }
}
