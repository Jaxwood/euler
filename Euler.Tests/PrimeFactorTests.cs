using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Euler.Lib;
using Xunit.Extensions;

namespace Euler.Tests
{
    public class PrimeFactorTests
    {
        [Theory]
        [InlineData(12, new long[] { 2, 2, 3 })]
        [InlineData(21, new long[] { 3, 7 })]
        [InlineData(13, new long[] { 13 })]
        public void ShouldReturnPrimeFactorsForNumber(long number, long[] expected)
        {
            var sut = new PrimeFactorFinder(new PrimeUtil());            
            var actual = sut.GetPrimeFactors(number);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 28)]
        [InlineData(12, 60)]
        [InlineData(6, 12)]
        [InlineData(100, 45360)]
        public void GetDivisorsForNumber(int expected, long number)
        {
            var sut = new PrimeFactorFinder(new PrimeUtil());
            var actual = sut.DivisorsForNumber(number);
            Assert.Equal(expected, actual);
        }
    }
}
