namespace WillyNilly.Variables
{
    /// <summary>
    /// Returns a value from any one of the input variables,
    /// choosing from them with uniform distribution.
    /// </summary>
    internal sealed class OrVariable<T> : IRandomVariable<T>
    {
        private readonly IRandomSource _source;
        private readonly IRandomVariable<T>[] _inputs;

        public OrVariable(IRandomSource source, IRandomVariable<T>[] inputs)
        {
            _source = source;
            _inputs = inputs;
        }

        public T Measure()
        {
            var index = _source.NextInt(0, _inputs.Length);
            var source = _inputs[index];
            return source.Measure();
        }

    }
}
