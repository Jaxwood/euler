using Euler.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Euler.Tests
{
    public class ProblemOneTests
    {
        private int[] _range = Enumerable.Range(1, 9).ToArray();
        
        private int[] _multiples = new int[] { 3, 5 };        
        
        private NaturalNumberCalculator _sut;
        
        public ProblemOneTests()
        {
            this._sut = new NaturalNumberCalculator();
        }
        
        // If we list all the natural numbers below 10 that are multiples of 3 or 5, 
        // we get 3, 5, 6 and 9. 
        [Fact]
        public void ShouldReturnAllNaturalNumbersBetween1And10()
        {
            int[] expected = new int[] { 3, 5, 6, 9 };
            var actual = this._sut.GetAllNumbers(this._multiples, this._range);
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnAllNaturalNumbersBetween1And20()
        {
            int[] expected = new int[] { 3, 5, 6, 9, 10, 12, 15, 18, 20 };
            var actual = this._sut.GetAllNumbers(this._multiples, Enumerable.Range(1,20).ToArray());

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnAllNaturalNumbersBetween1And20AndSum()
        {
            var expected = 98;            
            var actual = this._sut.GetAllNumbers(this._multiples, Enumerable.Range(1, 20).ToArray()).Sum();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldSumTheNaturalNumbers()
        {
            var expected = 23;
            var actual = this._sut.GetAllNumbers(this._multiples, this._range).Sum();
            
            Assert.Equal(expected, actual);
        }
    }
}
