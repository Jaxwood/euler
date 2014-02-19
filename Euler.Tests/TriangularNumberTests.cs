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
    public class TriangularNumberTests
    {
        private TriangularNumber _sut;

        public TriangularNumberTests()
        {
            this._sut = new TriangularNumber(new PrimeFactorFinder(new PrimeUtil()));
        }

        [Theory]
        [InlineData(6, 3)]
        [InlineData(21, 6)]
        [InlineData(36, 8)]
        [InlineData(1830, 60)]
        public void ShouldGetTheNthTriangularNumber(long expected, long number)
        {
            var actual = this._sut.GetNthTriangularNumber(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 28)]
        [InlineData(12, 60)]
        [InlineData(6, 12)]
        [InlineData(100, 45360)]
        public void GetDivisorsForNumber(int expected, long number)
        {
            var actual = this._sut.DivisorsForNumber(number);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(28, 6)]
        [InlineData(6, 4)]
        [InlineData(3, 2)]
        public void ShouldGetTheLowestTriangularNumberFromDivisor(long expected, long divisor)
        {
            var actual = this._sut.GetLowestTriangularNumber(divisor);
            Assert.Equal(expected, actual);
        }
    }
}
