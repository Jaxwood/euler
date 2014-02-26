using Euler.Lib.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace Euler.Tests
{
    public class DigitsSpecificationTests
    {
        [Theory]
        [InlineData(5, 12345)]
        [InlineData(10, 1234567890)]
        public void ShouldReturnTrueIfNumberOfDigitsMatch(int size, int number)
        {
            var sut = new DigitSpecification(size);

            Assert.True(sut.IsSatisfiedBy(number));
        }
    }
}
