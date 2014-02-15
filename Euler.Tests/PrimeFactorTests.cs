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
            var sut = new PrimeFactorFinder(number);            
            var actual = sut.GetPrimeFactors();

            Assert.Equal(expected, actual);
        }
    }
}
