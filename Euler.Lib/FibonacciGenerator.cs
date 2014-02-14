using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class FibonacciGenerator
    {
        private int _maxValue;
        private Predicate<int> _predicate;
        private int _result;

        public FibonacciGenerator(int max, Predicate<int> predicate)
        {
            this._maxValue = max;
            this._predicate = predicate;
            this._result = 0;
        }

        public int GetSum()
        {
            var arr = this.Fibonacci(new int[] { 0, 1 });

            return this._result;
        }

        private int[] Fibonacci(int[] numbers)
        {
            var current = numbers.Sum();

            if (current > this._maxValue) return numbers;

            if (this._predicate(current))
            {
                this._result += current;
            }

            numbers[0] = numbers[1];
            numbers[1] = current;

            return Fibonacci(numbers);
        }      
    }
}
