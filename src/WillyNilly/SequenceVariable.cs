﻿using System;
using System.Collections.Generic;

namespace WillyNilly
{
    /// <summary>
    /// Returns elements sequentially from an infinite sequence
    /// </summary>
    public class SequenceVariable<T> : IRandomVariable<T>
    {
        // do not make readonly in case of struct enumerator
        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        private IEnumerator<T> _enumerator;

        public SequenceVariable(
            IEnumerable<T> sequence)
        {
            if(sequence == null) throw new ArgumentNullException(nameof(sequence));
            _enumerator = sequence.GetEnumerator();
        }

        public T Measure()
        {
            var next = _enumerator.MoveNext();
            if (!next)
            {
                throw new InvalidOperationException("Sequence has no more elements");
            }

            return _enumerator.Current;
        }

    }
}
