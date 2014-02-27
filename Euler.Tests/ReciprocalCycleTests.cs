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
    public class ReciprocalCycleTests
    {
        [Theory]
        [InlineData(0, 2)]
        [InlineData(6, 26)]
        [InlineData(1, 3)]
        [InlineData(16, 85)]        
        public void ShouldFindSizeOfRecurringPattern(int expected, long denominator)
        {
            var sut = new ReciprocalCycle(new PrimeFactorFinder(new PrimeUtil()));
            var actual = sut.GetRecurring(denominator);

            Assert.Equal(expected, actual);
        }

        [Theory]        
        [InlineData(7, 10)]
        public void ShouldFindLargestRecurringPattern(int expected, long top)
        {
            var sut = new ReciprocalCycle(new PrimeFactorFinder(new PrimeUtil()));
            var actual = sut.GetLargestRecurring(top);

            Assert.Equal(expected, actual);
        }
    }
}
