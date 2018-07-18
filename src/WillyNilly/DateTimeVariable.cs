using System;

namespace WillyNilly
{
    public class DateTimeVariable : IRandomVariable<DateTime>
    {
        private readonly DateTime _minDate;
        private readonly DateTime _maxDate;

        public DateTimeVariable(DateTime minDate, DateTime maxDate)
        {
            _minDate = minDate;
            _maxDate = maxDate;
        }

        public DateTime Measure()
        {
            var perc = RandomPool.NextDouble();
            var diff = _maxDate.Ticks - _minDate.Ticks;
            var result = new DateTime((long)(_minDate.Ticks + (perc * diff)));
            return result;
        }
    }
}
