using Euler.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace Euler.Tests
{
    public class GridProductFinderTests
    {
        [Fact]
        public void ShouldFindTheGreatestProductInGridLocatedHorizontal()
        {
            var expected = 720;
            var grid = new int[5, 5] 
            { 
                { 1, 1, 1,  1, 1 }, 
                { 1, 1, 1,  1, 1 }, 
                { 8, 9, 10, 2, 2 }, 
                { 1, 1, 1,  1, 1 }, 
                { 1, 1, 1,  1, 1 } 
            };
            var sut = new GridProductFinder(3);
            var actual = sut.GetProduct(grid);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldFindTheGreatestProductInGridLocatedVertical()
        {
            var expected = 720;
            var grid = new int[5, 5] 
            { 
                { 1, 1, 3,  1, 1 }, 
                { 1, 1, 3,  1, 1 }, 
                { 1, 1, 9,  1, 1 }, 
                { 1, 1, 10, 1, 1 }, 
                { 1, 1, 8,  1, 1 } 
            };

            var sut = new GridProductFinder(3);
            var actual = sut.GetProduct(grid);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldFindTheGreatestProductInGridLocatedDiagonallyForward()
        {
            var expected = 720;
            var grid = new int[5, 5] 
            { 
                { 1, 1, 1,  1, 1 }, 
                { 1, 1, 1,  1, 1 }, 
                { 1, 8, 1,  1, 1 }, 
                { 1, 1, 9,  1, 1 }, 
                { 1, 1, 1, 10, 1 } 
            };
            var sut = new GridProductFinder(3);
            var actual = sut.GetProduct(grid);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldFindTheGreatestProductInGridLocatedDiagonallyBackward()
        {
            var expected = 720;
            var grid = new int[5, 5] 
            { 
                { 1, 1, 1,  1, 1 }, 
                { 1, 1, 1,  9, 1 }, 
                { 1, 1, 10, 1, 1 }, 
                { 1, 8, 1,  1, 1 }, 
                { 1, 1, 1,  1, 1 } 
            };
            var sut = new GridProductFinder(3);
            var actual = sut.GetProduct(grid);

            Assert.Equal(expected, actual);
        }
    }
}
