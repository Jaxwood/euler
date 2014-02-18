using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Extensions;
using Euler.Lib;
using Xunit;

namespace Euler.Tests
{
    public class PythagoreanTripletTests
    {
        [Theory]
        [InlineData(new int [] { 3, 4, 5 }, 12)]
        [InlineData(new int[] { 200, 375, 425 }, 1000)] 
        public void ShouldFindProductOfAAndB(int[] expected, int sum)
        {
            var sut = new PythagoreanTripletFinder();
            var actual = sut.GetTriplets(sum);

            Assert.Equal(expected, actual);
        }
    }
}
