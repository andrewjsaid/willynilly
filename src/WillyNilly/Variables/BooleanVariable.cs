namespace WillyNilly.Variables
{
    /// <summary>
    /// Returns either true or false.
    /// </summary>
    internal sealed class BooleanVariable : IRandomVariable<bool>
    {
        private readonly IRandomSource _randomSource;
        private readonly double _prob;

        /// <summary>
        /// Creates a variable which returns true with the specified probability.
        /// </summary>
        /// <param name="prob">A number between 0 and 1, representing the probability of the measuring true.</param>
        public BooleanVariable(IRandomSource randomSource, double prob)
        {
            _randomSource = randomSource;
            _prob = prob;
        }

        public bool Measure() => _randomSource.NextDouble() < _prob;
    }
}
