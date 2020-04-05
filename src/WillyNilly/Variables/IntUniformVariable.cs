namespace WillyNilly.Variables
{
    /// <summary>
    /// Returns integers in uniform distribution.
    /// </summary>
    internal sealed class IntUniformVariable : IRandomVariable<int>
    {
        private readonly IRandomSource _source;
        private readonly int _min;
        private readonly int _max;

        public IntUniformVariable(IRandomSource source, int min, int max)
        {
            _source = source;
            _min = min;
            _max = max;
        }

        public int Measure() => _source.NextInt(_min, _max);

    }
}