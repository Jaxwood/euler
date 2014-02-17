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
    public class LargestProductFinderTests
    {
        [Theory]
        [InlineData(36, "236654", 2)]
        public void ShouldFindTheLargestProductInASeries(int expected, string series, int range)
        {
            var sut = new LargestProductFinder(range);

            var actual = sut.GetLargestProduct(series);

            Assert.Equal(expected, actual);
        }
    }
}
