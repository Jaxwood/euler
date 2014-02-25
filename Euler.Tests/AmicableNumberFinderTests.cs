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
    public class AmicableNumberFinderTests
    {
        [Theory]
        //[InlineData(true, 284)]
        //[InlineData(true, 220)]
        //[InlineData(false, 100)]
        //[InlineData(false, 50)]
        [InlineData(false, 6)]
        public void ShouldFindVerifyIfNumberIsAmicable(bool expected, int number)
        {
            var sut = new AmicableNumberFinder(new MathUtil());
            var actual = sut.IsAmicableNumber(number);

            Assert.Equal(expected, actual);
        }
    }
}
