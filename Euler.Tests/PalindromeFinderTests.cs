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
    }
}
