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
    public class PrimeFinderTests
    {
        [Theory]
        [InlineData(17, 10)]
        [InlineData(1060, 100)]
        public void ShouldFindTheSumOfAllPrimeBelowNumber(long expected, int max)
        {
            var sut = new PrimeFinder(new PrimeUtil());
            var actual = sut.GetSumOfPrimes(max);

            Assert.Equal(expected, actual);
        }
    }
}
