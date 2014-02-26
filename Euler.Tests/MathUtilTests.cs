using Euler.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace Euler.Tests
{
    public class MathUtilTests
    {
        [Theory]
        [InlineData(16, 12)]
        public void ShouldFindSumOfDivisorsForNumber(int expected, int number)
        {
            var sut = new MathUtil();
            var actual = sut.GetSumOfDivisors(number);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(121, new int[] { 1, 2, 1 })]
        [InlineData(321, new int[] { 3, 2, 1 })]
        [InlineData(32211, new int[] { 3, 2, 2, 1, 1 })]
        public void CanFindDigitsOfANumber(int number, int[] expected)
        {
            var sut = new MathUtil();
            var actual = sut.GetDigits(number);

            Assert.Equal(expected, actual);
        }
    }
}
