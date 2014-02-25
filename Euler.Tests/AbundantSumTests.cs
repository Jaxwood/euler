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
    public class AbundantSumTests
    {
        [Theory]
        [InlineData(true, 12)]
        public void ShouldVerifyIfNumberIsAbundant(bool expected, int number)
        {
            var sut = new AbundantSum(new MathUtil());
            var actual = sut.IsAbundant(number);

            Assert.Equal(expected, actual);
        }
    }
}
