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
    public class DigitPowerFinderTests
    {
        [Theory]
        [InlineData(new int[] { 1634, 8208, 9474 }, 4)]
        public void ShouldFindAllNumberThatIsTheSumOfItsPowers(int[] expected, int power)
        {
            var sut = new DigitPowerFinder(new MathUtil());
            var actual = sut.GetNumbersWithPower(power);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(19316, 4)]
        public void ShouldFindTheSumOfAllNumberThatIsTheSumOfItsPowers(int expected, int power)
        {
            var sut = new DigitPowerFinder(new MathUtil());
            var actual = sut.GetSum(power);

            Assert.Equal(expected, actual);
        }
    }
}
