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
    public class SumDigitTests
    {
        [Theory]
        [InlineData(2736, "123456789123456789", 3)]
        [InlineData(495, "123456789123456789", 2)]
        public void ShouldSumDigits(long expected, string digitsequence, int digitlength)
        {
            var sut = new SumDigitProcessor(digitlength);
            var actual = sut.Sum(digitsequence);
            
            Assert.Equal(expected, actual);
        }
    }
}
