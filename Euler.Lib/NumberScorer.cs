using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class NumberScorer
    {    
        private const int ASCIICODE_A = 96;
        private string[] _names;

        public NumberScorer(string[] names)
        {
            this._names = names.OrderBy(c => c, StringComparer.InvariantCultureIgnoreCase).ToArray();
        }

        public int NumberScore(string name)
        {
            return name.ToLower().Select(c => (int)c - ASCIICODE_A).Sum();
        }

        public int GetScore(string name, int numberscore)
        {
            return this._names.Where(c => c.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                              .Select(c => Array.IndexOf(this._names, c) + 1)
                              .Aggregate(numberscore, (acc, c) => acc * c);
        }

        public int ScoreNames()
        {
            return this._names.Select(c => this.GetScore(c, this.NumberScore(c))).Sum();
        }
    }
}
