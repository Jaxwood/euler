using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class GridProductFinder
    {
        private int _sequence;
        public GridProductFinder(int sequence)
        {
            this._sequence = sequence;
        }

        public int GetProduct(int[,] grid)
        {
            var product = 0;
            
            for(int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    // calculate diagonal product forward
                    int forwardDiagonally = 1;
                    int forwardCnt = this._sequence;

                    for (int i = 0; i < this._sequence; i++)
                    {
                        if (forwardCnt > 0 && (x + y + i) < grid.GetLength(0))
                        {
                            forwardDiagonally *= grid[x + y + i, y + i];
                            forwardCnt--;
                        }
                    }

                    if (forwardDiagonally > product)
                    {
                        product = forwardDiagonally;
                    }
  
                    // calculate diagonal product backward
                    int backwardDiagonally = 1;
                    int backwardCnt = this._sequence;
                    
                    for (int i = 0; i < this._sequence; i++)
                    {
                        if (backwardCnt > 0 && (x - y - i) >= 0)
                        {
                            backwardDiagonally *= grid[x - y - i, y + i];
                            backwardCnt--;
                        }
                    }

                    if (backwardDiagonally > product)
                    {
                        product = backwardDiagonally;
                    }

                    // calculate vertical product
                    var horizontal = 1;

                    for (int i = x; i < this._sequence + x; i++)
                    {
                        if (i < grid.GetLength(0))
                        {
                            horizontal *= grid[i, y];
                        }
                    }

                    if (horizontal > product)
                    {
                        product = horizontal;
                    }

                    // calculate horizontal product
                    var vertical = 1;

                    for (int i = y; i < this._sequence + y; i++)
                    {
                        if (i < grid.GetLength(1))
                        {
                            vertical *= grid[x, i];
                        }
                    }

                    if (vertical > product)
                    {
                        product = vertical;
                    }
                }
            }

            return product;
        }
    }
}
