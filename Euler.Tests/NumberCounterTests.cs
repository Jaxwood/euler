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
    public class NumberCounterTests
    {
        [Theory]
        [InlineData(19, 1, 5)]
        [InlineData(23, 342, 1)]
        [InlineData(20, 115, 1)]        
        public void ShouldCountTextWithoutWhiteSpaceAndDashes(int expected, int low, int count)
        {
            var sut = new NumberCounter(new NumberToLetter());
            var actual = sut.GetTextCount(low, count);

            Assert.Equal(expected, actual);
        }
    }
}
