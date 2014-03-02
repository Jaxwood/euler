using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;
using Euler.Lib;
using System.Numerics;

namespace Euler.Tests
{
    public class DistinctPowerTests
    {
        [Fact]
        public void ShouldFindAllDistinctPowersInRange()
        {
            var expected = new BigInteger[] { 4, 8, 9, 16, 25, 27, 32, 64, 81, 125, 243, 256, 625, 1024, 3125 };
            var low = 2;
            var high = 5;

            var sut = new DistinctPower();
            var actual = sut.GetPowers(low, high);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, 2, 5)]
        public void ShouldFindNumberOfDistinctTerms(int expected, int low, int high)
        {
            var sut = new DistinctPower();
            var actual = sut.GetNumberOfTerms(low, high);

            Assert.Equal(expected, actual);
        }
    }
}
