using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;
using Euler.Lib;

namespace Euler.Tests
{
    public class SumOfSquaresTests
    {
        [Theory]
        [InlineData(2640, 1, 10)]
        public void ShouldFindTheDifferenceBetweenSumOfSquaresAndSquareOfSums(long expected, int start, int size)
        {
            var sut = new SumOfSquaresCalculator();
            var actual = sut.GetSum(Enumerable.Range(start, size).ToArray());

            Assert.Equal(expected, actual);
        }
    }
}
