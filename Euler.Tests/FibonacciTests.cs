using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xunit.Extensions;
using Euler.Lib;
using Xunit;
using Euler.Lib.Specification;

namespace Euler.Tests
{
    public class FibonacciTests
    {
        [Theory]
        [InlineData(144, 12)]
        [InlineData(8, 6)]
        public void ShouldGenerateFibonacciNumbers(int expected, int term)
        {
            var sut = new Fibonacci();
            var actual = sut.GetTerm(term);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, 2)]
        [InlineData(12, 3)]
        public void ShouldGenerateFibonacciNumbersUntilDigitsReachSize(int expected, int size)
        {
            var sut = new Fibonacci();
            var spec = new DigitSpecification(size);
            var actual = sut.GetUntil(spec);

            Assert.Equal(expected, spec.Result);
        }

        [Theory]        
        [InlineData(10, 10)]
        [InlineData(44, 40)]
        public void ShouldSumEvenNumberFibonacciNumbersUntilMax(int expected, int max)
        {
            var sut = new Fibonacci();
            var spec = new FibonacciSumSpecification(max);
            var actual = sut.GetUntil(spec);

            Assert.Equal(expected, spec.Result);
        }
    }
}
