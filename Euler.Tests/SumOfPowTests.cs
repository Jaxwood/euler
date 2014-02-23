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
    public class SumOfPowTests
    {
        [Theory]
        [InlineData(26, 15)]
        public void ShouldSumTheResultOfPowOfTwo(int expected, int pow)
        {
            var sut = new SumOfPow(2);
            var actual = sut.GetSum(pow);

            Assert.Equal(expected, actual);
        }
    }
}
