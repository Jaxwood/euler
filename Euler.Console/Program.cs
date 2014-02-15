using Euler.Lib;
using System;
using System.Collections.Generic;
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

            var primeFinder = new PrimeFactorFinder(600851475143);
            System.Console.WriteLine(
                "The largest prime factor of the number 600851475143 is {0}",
                primeFinder.GetPrimeFactors().Max());

            System.Console.ReadLine();
        }
    }
}
