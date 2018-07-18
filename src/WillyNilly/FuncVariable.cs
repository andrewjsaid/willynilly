﻿using System;

namespace WillyNilly
{
    /// <summary>
    /// Returns the element generated by an input function.
    /// </summary>
    public class FuncVariable<T> : IRandomVariable<T>
    {
        private readonly Func<T> _func;

        public FuncVariable(Func<T> func)
        {
            _func = func ?? throw new ArgumentNullException(nameof(func));
        }

        public T Measure() => _func();
    }
}
