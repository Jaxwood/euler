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

            var primeFactorFinder = new PrimeFactorFinder(600851475143, new PrimeUtil());
            System.Console.WriteLine(
                "The largest prime factor of the number 600851475143 is {0}",
                primeFactorFinder.GetPrimeFactors().Max());

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

            var largestProductFinder = new LargestProductFinder(5);
            System.Console.WriteLine(
                "The largest product in the series is {0}",
                largestProductFinder.GetLargestProduct("7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450"));

            var pythagoreanTripletFinder = new PythagoreanTripletFinder();
            System.Console.WriteLine(
                "The product of a, b and c where the sum is 1000 is {0}",
                pythagoreanTripletFinder.GetTriplets(1000).Aggregate(1, (a,c) => a *= c));

            var primeFinder = new PrimeFinder(new PrimeUtil());
            System.Console.WriteLine(
                "The sum of all primes below 2000000 is {0}",
                primeFinder.GetSumOfPrimes(2000000));

            System.Console.ReadLine();
        }
    }
}
