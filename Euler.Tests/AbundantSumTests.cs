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
    public class AbundantSumTests
    {
        [Theory]
        [InlineData(true, 12)]
        public void ShouldVerifyIfNumberIsAbundant(bool expected, int number)
        {
            var sut = new AbundantSum(new MathUtil());
            var actual = sut.IsAbundant(number);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 24, 30, 32, 36, 38, 40 }, new int[] { 12, 18, 20 })]
        public void ShouldFindPermutationsOfSumOfAbundantNumbers(int[] expected, int[] abundantNumbers)
        {
            var sut = new AbundantSum(new MathUtil());
            var actual = sut.GetSumOfAbundantNumbers(abundantNumbers);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 12, 18, 20, 24, 30, 36, 40 }, 40)]
        public void ShouldFindAbundantNumbersInRange(int[] expected, int top)
        {
            var sut = new AbundantSum(new MathUtil());
            var actual = sut.GetAbundantNumbers(top);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(301, 25)]
        public void ShouldFindIntegerThatIsNotASumOfAbundantNumbers(int expected, int top)
        {
            var sut = new AbundantSum(new MathUtil());
            var actual = sut.GetSumOfIntegersThatIsNotSumOfAbundantNumbers(top);

            Assert.Equal(expected, actual);
        }
    }
}
