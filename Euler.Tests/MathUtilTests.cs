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
    }
}
