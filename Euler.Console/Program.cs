using Euler.Lib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var nat = new NaturalNumberCalculator();
            System.Console.WriteLine(
                "The sum of natural number between 1 1000 is {0}", 
                nat.GetAllNumbers(
                    new int[] { 3, 5 }, 
                    Enumerable.Range(1, 999).ToArray()
                ).Sum());

            var fib = new FibonacciGenerator(4000000, x => x % 2 == 0);
            System.Console.WriteLine(
                "Fibonacci whose values do not exceed four million - the sum of even valued terms: {0}", 
                fib.GetSum());

            var primeFinder = new PrimeFactorFinder(600851475143, new PrimeUtil());
            System.Console.WriteLine(
                "The largest prime factor of the number 600851475143 is {0}",
                primeFinder.GetPrimeFactors().Max());

            var palindromeFinder = new PalindromeFinder();
            System.Console.WriteLine(
                "Largest paldindrome of the product of two 3 digits numbers is {0}",
                palindromeFinder.GetLargestPalindrome(3));

            var lowestDividableNumberFinder = new LowestDividableNumberFinder();
            System.Console.WriteLine(
                "Smallest positive number that is evenly divisible by all of the numbers from 1 to 20 is {0}",
                lowestDividableNumberFinder.GetLowestNumberDividableWith(Enumerable.Range(1,20).ToArray()));

            var sumOfSquaresCalculator = new SumOfSquaresCalculator();
            System.Console.WriteLine(
                "The difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is {0}",
                sumOfSquaresCalculator.GetSum(Enumerable.Range(1, 100).ToArray()));

            var primeGenerator = new PrimeGenerator(new PrimeUtil());
            System.Console.WriteLine(
                "The 10001 prime is {0}",
                primeGenerator.GetPrimes(10001).Last());
            
            System.Console.ReadLine();
        }
    }
}
