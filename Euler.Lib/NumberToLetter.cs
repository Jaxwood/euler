using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class NumberToLetter
    {
        private string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private string[] teens = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private string[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        
        public string GetTextRepresentation(int number)
        {
            if (number > 1000)
                throw new ArgumentException(string.Format("{0} cannot be higher than 1000", number));
            if (number < 0)
                throw new ArgumentException(string.Format("{0} cannot be lower than 0", number));

            if (number < 10)
                return numbers[number];
            if (number > 10 && number < 20)
                return teens[number - 11];
            if (number < 100)
                return number % 10 == 0 
                    ? tens[number / 10]
                    : string.Format("{0}-{1}", tens[Math.Abs(number / 10)], numbers[number % 10]);
            if (number == 1000)
                return "one thousand";
            else
                return number % 100 == 0
                    ? string.Format("{0} hundred", numbers[number / 100])
                    : string.Format("{0} hundred and {1}", numbers[Math.Abs(number / 100)], this.GetTextRepresentation(number - (Math.Abs(number / 100) * 100)));
        }
    }
}
