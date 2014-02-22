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
    public class LatticeTests
    {
        [Theory]
        [InlineData(6, 2, 2)]
        [InlineData(20, 3, 3)]
        public void ShouldCalculateLatticePathThroughGrid(int expected, int a, int b)
        {
            var sut = new Lattice();
            var actual = sut.GetPaths(a, b);

            Assert.Equal(expected, actual);
        }
    }
}
