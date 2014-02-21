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
    public class CollatzTests
    {
        [Theory]        
        [InlineData(10, 13)]
        public void ShouldFindNumberOfTermsForNumber(int expected, int start)
        {
            var sut = new CollatzTermsFinder();
            var actual = sut.GetTerms(start);

            Assert.Equal(expected, actual);
        }

        [Theory]        
        [InlineData(9, 10)]
        [InlineData(7, 8)]
        [InlineData(97, 127)]
        public void ShouldFindNumberWithTerms(int expected, int start)
        {
            var sut = new CollatzTermsFinder();
            var actual = sut.GetLargestTermBelowNumber(start);

            Assert.Equal(expected, actual);
        }
    }
}
