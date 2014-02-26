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
    public class LexicographicPermutationTests
    {
        [Theory]
        [InlineData(210, 6, 120)]
        [InlineData(102, 3, 120)]
        [InlineData(4321, 24, 1234)]        
        public void ShouldFindTheNthLexicographicPermutation(int expected, int permutation, int number)
        {
            var sut = new LexicographicPermutation(new MathUtil());
            var actual = sut.GetPermutation(number, permutation);

            Assert.Equal(expected, actual);
        }
    }
}
