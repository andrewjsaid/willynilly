namespace WillyNilly
{
    /// <summary>
    /// Returns either true or false.
    /// </summary>
    public class BooleanVariable : IRandomVariable<bool>
    {
        private readonly double _prob;

        /// <summary>
        /// Creates a variable which returns true and false in equal measures.
        /// </summary>
        public BooleanVariable() : this(0.5) { }

        /// <summary>
        /// Creates a variable which returns true with the specified probability.
        /// </summary>
        /// <param name="prob">A number between 0 and 1, representing the probability of the measuring true</param>
        public BooleanVariable(double prob)
        {
            _prob = prob;
        }

        public bool Measure() => RandomPool.NextDouble() < _prob;
    }
}
