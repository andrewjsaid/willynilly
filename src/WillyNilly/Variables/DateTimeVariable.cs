using System;

namespace WillyNilly.Variables
{
    /// <summary>
    /// Returns dates within the specified range.
    /// </summary>
    internal sealed class DateTimeVariable : IRandomVariable<DateTime>
    {
        private readonly IRandomSource _randomSource;
        private readonly DateTime _minDate;
        private readonly DateTime _maxDate;

        public DateTimeVariable(
            IRandomSource randomSource, 
            DateTime minDateTime,
            DateTime exclusiveMaxDateTime)
        {
            _randomSource = randomSource;
            _minDate = minDateTime;
            _maxDate = exclusiveMaxDateTime;
        }

        public DateTime Measure()
        {
            var perc = _randomSource.NextDouble();
            var diff = _maxDate.Ticks - _minDate.Ticks;
            var result = new DateTime((long)(_minDate.Ticks + (perc * diff)));
            return result;
        }
    }
}
