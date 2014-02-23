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
    public class MaximumPathTests
    {
        [Fact]
        public void ShouldFindTheMaximumPathThroughTriangle()
        {
            var triangle = new int[][] 
            { 
                new int[] { 3 }, 
                new int[] { 7, 4 }, 
                new int[] { 2, 4, 6 }, 
                new int[] { 8, 5, 9, 3 } 
            };

            var sut = new MaximumPathFinder();
            var actual = sut.GetMax(triangle);

            Assert.Equal(23, actual);
        }
    }
}
