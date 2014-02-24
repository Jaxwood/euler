using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Euler.Lib;
using Xunit.Extensions;

namespace Euler.Tests
{
    public class DateFinderTests
    {
        [Theory]
        [InlineData(2, "1901-01-01", "1902-01-01", DayOfWeek.Sunday)]
        [InlineData(2, "2013-01-01", "2014-01-01", DayOfWeek.Sunday)]
        [InlineData(2, "2013-01-01", "2013-12-31", DayOfWeek.Sunday)] 
        public void ShouldReturnTheNumberOfSundaysOnDate(int expected, string from, string to, DayOfWeek day)
        {
            var sut = new DateFinder();
            var dt = DateTime.Now;
            
            var actual = sut.GetMonthsWithDay(DateTime.Parse(from), DateTime.Parse(to), day);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanParse()
        {
            Assert.DoesNotThrow(delegate { DateTime.Parse("2013-12-31"); });
        }
    }
}
