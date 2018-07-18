using System;

namespace WillyNilly
{
    public class VariableConverter<TIn, TOut> : IRandomVariable<TOut>
    {
        private readonly IRandomVariable<TIn> _input;
        private readonly Func<TIn, TOut> _convert;

        public VariableConverter(
            IRandomVariable<TIn> input,
            Func<TIn, TOut> convert)
        {
            _input = input;
            _convert = convert;
        }

        public TOut Measure() => _convert(_input.Measure());
    }
}
