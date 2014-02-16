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
        [Theory]
        [InlineData(121, new int[] { 1, 2, 1 })]
        [InlineData(321, new int[] { 3, 2, 1 })]
        [InlineData(32211, new int[] { 3, 2, 2, 1, 1 })]
        public void CanFindDigitsOfANumber(int number, int [] expected)
        {
            var sut = new PalindromeFinder();
            var actual = sut.GetDigits(number);
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(121, true)]
        [InlineData(321, false)]
        [InlineData(32211, false)]
        [InlineData(9009, true)]
        public void CanVerifyIfNumberIsAPalindrome(int number, bool expected)
        {
            var sut = new PalindromeFinder();
            var actual = sut.IsPalindrome(number);
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 99)]
        [InlineData(3, 999)]
        [InlineData(5, 99999)]
        public void ShouldReturnHighestNumberMadeOfDigits(int digits, int expected)
        {
            var sut = new PalindromeFinder();
            var actual = sut.GetMaxNumber(digits);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 9801)]
        [InlineData(3, 998001)]
        [InlineData(5, 1409865409)]
        public void ShouldReturnProductOfTheHigestNumber(int digits, int expected)
        {
            var sut = new PalindromeFinder();
            var actual = sut.GetProduct(digits);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 99, 91 }, 2, 9009)]
        [InlineData(new int[] { 0, 0 }, 2, 9779)]
        public void ShouldFindHigestProductOfNumber(int[] expected, int digits, int number)
        {
            var sut = new PalindromeFinder();
            var actual = sut.GetLargestProductOfNumber(digits, number);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9009, 2)]            
        public void ShouldReturnLargestPalindromeOfTwoDigitsProduct(int expected, int digits)
        {            
            var sut = new PalindromeFinder();
            var actual = sut.GetLargestPalindrome(digits);

            Assert.Equal(expected, actual);
        }
    }
}
