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
    public class PalindromeFinderTests
    {
        private PalindromeFinder _sut;

        public PalindromeFinderTests()
        {
            this._sut = new PalindromeFinder(new MathUtil());
        }

        [Theory]
        [InlineData(121, true)]
        [InlineData(321, false)]
        [InlineData(32211, false)]
        [InlineData(9009, true)]
        public void CanVerifyIfNumberIsAPalindrome(int number, bool expected)
        {
            var actual = _sut.IsPalindrome(number);
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 99)]
        [InlineData(3, 999)]
        [InlineData(5, 99999)]
        public void ShouldReturnHighestNumberMadeOfDigits(int digits, int expected)
        {
            var actual = _sut.GetMaxNumber(digits);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 9801)]
        [InlineData(3, 998001)]
        [InlineData(5, 1409865409)]
        public void ShouldReturnProductOfTheHigestNumber(int digits, int expected)
        {
            var actual = _sut.GetProduct(digits);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 99, 91 }, 2, 9009)]
        [InlineData(new int[] { 0, 0 }, 2, 9779)]
        public void ShouldFindHigestProductOfNumber(int[] expected, int digits, int number)
        {
            var actual = _sut.GetLargestProductOfNumber(digits, number);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9009, 2)]            
        public void ShouldReturnLargestPalindromeOfTwoDigitsProduct(int expected, int digits)
        {            
            var actual = _sut.GetLargestPalindrome(digits);

            Assert.Equal(expected, actual);
        }
    }
}
