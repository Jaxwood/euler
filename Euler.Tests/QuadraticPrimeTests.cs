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
    public class QuadraticPrimeTests
    {        
        [Theory]        
        [InlineData(41, 1, 1, 41, 1)]
        [InlineData(-126479, -79, 1, 1601, 1)]
        public void ShouldFindProductOfAAndB(long expected, int aLow, int aCount, int bLow, int bCount)
        {
            var sut = new QuadraticPrime(new PrimeUtil());
            var actual = sut.GetProduct(aLow, aCount, bLow, bCount);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(40, 1, 41)]
        [InlineData(80, -79, 1601)]
        public void ShouldFindNumberOfPrimesInARow(long expected, int a, int b)
        {
            var sut = new QuadraticPrime(new PrimeUtil());
            var actual = sut.GetPrimes(a, b);

            Assert.Equal(expected, actual);
        }
    }
}
