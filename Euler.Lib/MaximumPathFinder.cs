using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class MaximumPathFinder
    {
        private int _index;
        private int _take = 2;
        private readonly int _lookahead;

        public MaximumPathFinder(int lookahead)
        {
            this._lookahead = lookahead;
        }

        public MaximumPathFinder()
        {
            this._lookahead = 4;
        }

        public int GetMax(int[][] triangle)
        {
            this._index = 0;
            int sum = 0;

            for (int i = 0; i < triangle.Length; i++ )
            {
                var arr = triangle[i];
                if (arr.Length == 1)
                {
                    sum += arr[0];
                }
                else
                {
                    var val = this.GetBestValue(i, triangle);
                    sum += val;
                    this._index = Array.IndexOf(arr, val);
                }
            }

            return sum;
        }

        private int GetBestValue(int current, int[][] triangle)
        {
            var index = 0;
            var best = 0;
            var candidates = triangle[current].Skip(this._index).Take(this._take).ToArray();
            var length = triangle.Length;

            for (int i = 0; i < 2; i++)
            {
                var previous = candidates[i];
                var sum = previous;

                for (int j = 0; j < this._lookahead; j++)
                {
                    if (length <= (current + j + 1)) break;
                    
                    var value = this.GetNextValue(triangle[(current + (j+1))], Array.IndexOf(triangle[current + j], previous));
                    previous = value;
                    sum += value;
                }               
                            
                if (sum > best)
                {
                    best = sum;
                    index = i;
                }
            }

            return candidates[index];
        }

        private int GetNextValue(int[] next, int index)
        {
            return next.Skip(index).Take(2).Max();
        }
    }
}
