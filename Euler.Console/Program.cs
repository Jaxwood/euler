﻿using Euler.Lib;
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
                lowestDividableNumberFinder.GetLowestNumberDividableWith(Enumerable.Range(1, 20).ToArray()));

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
                pythagoreanTripletFinder.GetTriplets(1000).Aggregate(1, (a, c) => a *= c));

            var primeFinder = new PrimeFinder(new PrimeUtil());
            System.Console.WriteLine(
                "The sum of all primes below 2000000 is {0}",
                primeFinder.GetSumOfPrimes(2000000));

            var gridProductFinder = new GridProductFinder(4);
            System.Console.WriteLine(
                "Greatest adjacent product in grid is {0}",
                gridProductFinder.GetProduct(GetGrid()));

            System.Console.ReadLine();
        }

        private static int[,] GetGrid()
        {
            return new int[20, 20] 
            { 
                { 8, 2, 22, 97, 38, 15, 0, 40, 0, 75, 4, 5, 7, 78, 52, 12, 50, 77, 91, 8 },
                { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 4, 56, 62, 0 },
                { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 3, 49, 13, 36, 65 },
                {52,70,95,23,04,60,11,42,69,24,68,56,01,32,56,71,37,02,36,91},
                {22,31,16,71,51,67,63,89,41,92,36,54,22,40,40,28,66,33,13,80 },
                {24,47,32,60,99,03,45,02,44,75,33,53,78,36,84,20,35,17,12,50 },
                {32,98,81,28,64,23,67,10,26,38,40,67,59,54,70,66,18,38,64,70 },
                {67,26,20,68,02,62,12,20,95,63,94,39,63,08,40,91,66,49,94,21 },
                {24,55,58,05,66,73,99,26,97,17,78,78,96,83,14,88,34,89,63,72 },
                {21,36,23,09,75,00,76,44,20,45,35,14,00,61,33,97,34,31,33,95 },
                {78,17,53,28,22,75,31,67,15,94,03,80,04,62,16,14,09,53,56,92 },
                {16,39,05,42,96,35,31,47,55,58,88,24,00,17,54,24,36,29,85,57 },
                {86,56,00,48,35,71,89,07,05,44,44,37,44,60,21,58,51,54,17,58 },
                {19,80,81,68,05,94,47,69,28,73,92,13,86,52,17,77,04,89,55,40 },
                {04,52,08,83,97,35,99,16,07,97,57,32,16,26,26,79,33,27,98,66 },
                {88,36,68,87,57,62,20,72,03,46,33,67,46,55,12,32,63,93,53,69 },
                {04,42,16,73,38,25,39,11,24,94,72,18,08,46,29,32,40,62,76,36 },
                {20,69,36,41,72,30,23,88,34,62,99,69,82,67,59,85,74,04,36,16 },
                {20,73,35,29,78,31,90,01,74,31,49,71,48,86,81,16,23,57,05,54 },
                {01,70,54,71,83,51,54,69,16,92,33,48,61,43,52,01,89,19,67,48 }
            };
        }
    }
}
