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
    public class NumberSpiralDiagonalTests
    {
        [Theory]
        [InlineData(101, 5)]
        [InlineData(25, 3)]
        public void ShouldFindTheDiagonalSum(int expected, int size)
        {
            var sut = new NumberSpiralDiagonal();
            var actual = sut.GetDiagonalSum(size);

            Assert.Equal(expected, actual);
        }
    }
}
