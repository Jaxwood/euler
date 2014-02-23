using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Euler.Lib
{
    public class NumberCounter
    {
        private NumberToLetter _numberToLetter;

        public NumberCounter(NumberToLetter numToLetter)
        {
            this._numberToLetter = numToLetter;
        }

        public int GetTextCount(int low, int count)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var num in Enumerable.Range(low, count))
                sb.Append(this._numberToLetter.GetTextRepresentation(num));

            return Regex.Replace(sb.ToString(), "[\\s\\-]", string.Empty).Length;
        }
    }
}
