using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class PalindromeFinder
    {
        public int[] GetDigits(int number)
        {
            List<int> arr = new List<int>();

            while(number >= 1)
            {
                arr.Add(number % 10);
                number = number / 10;
            }
            
            arr.Reverse();
            
            return arr.ToArray();
        }

        public bool IsPalindrome(int number)
        {
            bool isPalindrome = true;            
            var digits = this.GetDigits(number);

            for (int i = 0; i < digits.Length; i++)
            { 
                if (digits[i] != digits[(digits.Length - 1) - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }
}
