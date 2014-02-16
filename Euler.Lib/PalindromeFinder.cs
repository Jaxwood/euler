using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Lib
{
    public class PalindromeFinder
    {
        public int GetLargestPalindrome(int digits)
        {
            var highestFoundProduct = new int[] { 0, 0 };
            var palindrome = 0;
            var number = this.GetProduct(digits);
            var until = this.GetMaxNumber(digits - 1);

            while (number >= until)
            {
                if (number % 11 == 0 && this.IsPalindrome(number))
                {
                    var product = this.GetLargestProductOfNumber(digits, number);
                    if (product.First() > highestFoundProduct.First())
                    {
                        if ( product.Last() > highestFoundProduct.Last())
                        { 
                            highestFoundProduct = product;
                            palindrome = number;
                        }                    
                    }
                }
                number = number - 1;
            }

            return palindrome;
        }

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

            for (int i = 0; i < digits.Length / 2; i++)
            { 
                if (digits[i] != digits[(digits.Length - 1) - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }

        public int GetMaxNumber(int digits)
        {
            return Convert.ToInt32(Math.Pow(10, digits)) - 1;
        }

        public int GetProduct(int digits)
        {
            return this.GetMaxNumber(digits) * this.GetMaxNumber(digits);
        }

        public int[] GetLargestProductOfNumber(int digits, int number)
        {
            int maxNumber = this.GetMaxNumber(digits);
            int counter = maxNumber;

            while (number % counter != 0)
            {
                counter = counter - 1;
            }

            var dividend = number / counter;

            if (dividend > maxNumber)
            {
                return new int[] { 0, 0 };
            }

            return new int[] { maxNumber, (number / counter) };
        }
    }
}
