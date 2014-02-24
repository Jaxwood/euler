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
    public class FactorialSumFinderTests
    {
        [Theory]
        [InlineData(27, 10)]
        public void ShouldFindTheSumOfTheDigitsFactorialNumber(int expected, int factorial)
        {
            var sut = new FactorialSumFinder();
            var actual = sut.GetFactorialSum(factorial);

            Assert.Equal(expected, actual);
        }
    }
}
