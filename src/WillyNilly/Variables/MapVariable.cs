using System;

namespace WillyNilly.Variables
{
    /// <summary>
    /// Applies a mapping on the output of one random variable to produce another
    /// </summary>
    internal sealed class MapVariable<TIn, TOut> : IRandomVariable<TOut>
    {
        private readonly IRandomVariable<TIn> _input;
        private readonly Func<TIn, TOut> _func;

        public MapVariable(
            IRandomVariable<TIn> input,
            Func<TIn, TOut> func)
        {
            _input = input;
            _func = func;
        }

        public TOut Measure()
        {
            var input = _input.Measure();
            return _func(input);
        }
    }
}
