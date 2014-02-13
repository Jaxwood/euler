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
            System.Console.WriteLine("The sum of natural number between 1 1000 is {0}", 
                nat.GetAllNumbers(
                    new int[] { 3, 5 }, 
                    Enumerable.Range(1, 999).ToArray()
                ).Sum());
            
            System.Console.ReadLine();
        }
    }
}
