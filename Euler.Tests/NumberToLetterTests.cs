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
    public class NumberToLetterTests
    {
        private NumberToLetter _sut;
        public NumberToLetterTests()
        {
            this._sut = new NumberToLetter();
        }

        [Theory]
        [InlineData("zero", 0)]
        [InlineData("ten", 10)]
        [InlineData("eleven", 11)]
        [InlineData("nineteen", 19)]
        [InlineData("twenty", 20)]
        [InlineData("fifty-five", 55)]
        [InlineData("ninety", 90)]
        [InlineData("ninety-nine", 99)]
        [InlineData("one hundred", 100)]
        [InlineData("one hundred and one", 101)]
        [InlineData("three hundred and forty-two", 342)]
        [InlineData("one thousand", 1000)]
        public void ShouldConvertTheNumberToLetterRepresentation(string expected, int number)
        {
            var actual = this._sut.GetTextRepresentation(number);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldThrowExpectionIfNumberAboveOneThousand()
        {
            Assert.Throws(typeof(ArgumentException), delegate { this._sut.GetTextRepresentation(1001); });
        }

        [Fact]
        public void ShouldThrowExpectionIfNumberBelowZero()
        {
            Assert.Throws(typeof(ArgumentException), delegate { this._sut.GetTextRepresentation(-1); });
        }
    }
}
