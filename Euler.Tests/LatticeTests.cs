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
        [Theory(Skip="Awaiting Node factory impl")]
        [InlineData(6, 2)]
        [InlineData(20, 3)]
        public void ShouldCalculateLatticePathThroughGrid(int expected, int size)
        {
            var sut = new Lattice(size);
            var actual = sut.GetPaths();

            Assert.Equal(expected, actual);
        }
    }
}
