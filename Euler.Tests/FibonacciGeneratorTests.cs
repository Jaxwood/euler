using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Euler.Lib;

namespace Euler.Tests
{
    public class FibonacciGeneratorTests
    {
        private int[] _first10FibNumbers;
        private int _sumOfFirst10FibNumber;

        public FibonacciGeneratorTests()
        {
            this._first10FibNumbers = new int[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            this._sumOfFirst10FibNumber = this._first10FibNumbers.Sum();
        }

        [Fact]
        public void ShouldGenerateFirst10FibonacciNumbersWithinMaxNumberAndSumTheResult()
        {
            var sut = new FibonacciGenerator(this._first10FibNumbers.Last(), x => true);
            var actual = sut.GetSum();

            Assert.Equal(this._sumOfFirst10FibNumber, actual);
        }
        
        [Fact]
        public void ShouldGenerateEvenFibonacciNumbersWithinMaxNumberAndSumTheResult()
        {
            var expected = this._first10FibNumbers.Where(c => c % 2 == 0).Sum();
            var sut = new FibonacciGenerator(this._first10FibNumbers.Last(), x => x % 2 == 0);
            var actual = sut.GetSum();

            Assert.Equal(expected, actual);
        }
    }
}
