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
    public class NumberScorerTests
    {
        private NumberScorer _sut;
        public NumberScorerTests()
        {
            this._sut = new NumberScorer(
                new string[] {
                    "A", "B", "ABE", "J", "COLIN"
                });
        }

        [Theory]
        [InlineData(53, "COLIN")]
        [InlineData(8, "ABE")]
        public void ShouldScoreNumberAccordingToLetters(int expected, string name)
        {
            var actual = this._sut.NumberScore(name);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(16, 8, "ABE")]
        [InlineData(212, 53, "COLIN")]
        public void ShouldScoreNumberToPlacementInList(int expected, int numberscore, string name)
        {
            var actual = this._sut.GetScore(name, numberscore);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(285)]
        public void ShouldScoreAllNames(int expected)
        {
            var actual = this._sut.ScoreNames();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldScoreAndSortNames()
        {
            var sut = new NumberScorer(new string[] {
                "C",
                "A",
                "AA",
                "B"
            });

            var actual = sut.GetScore("B", 2);
            Assert.Equal(6, actual);
        }
    }
}
