using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Extensions;
using Euler.Lib;
using Xunit;

namespace Euler.Tests
{
    public class PrimeGeneratorTests
    {
        [Theory]
        [InlineData(new long[] {2,3,5,7,11,13}, 6)]
        [InlineData(new long[] { 2,	3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113 }, 30)]
        public void ShouldListPrimeBasedOnInput(long[] expected, int number)
        {
            var sut = new PrimeGenerator(new PrimeUtil());
            var actual = sut.GetPrimes(number);

            Assert.Equal(expected, actual);
        }
    }
}
