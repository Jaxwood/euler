using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Euler.Lib;
using Xunit.Extensions;

namespace Euler.Tests
{
    public class LowestDividableNumberFinderTests
    {
        [Theory]
        [InlineData(2520, 1, 10)]
        [InlineData(380, 19, 2)]
        public void CanFindTheLowestDividableNumber(int expected, int rangeStart, int size)
        {
            var sut = new LowestDividableNumberFinder();
            var actual = sut.GetLowestNumberDividableWith(Enumerable.Range(rangeStart, size).ToArray());

            Assert.Equal(expected, actual);
        }
    }
}
