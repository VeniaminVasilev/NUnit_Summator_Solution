// See https://aka.ms/new-console-template for more information
using System;

namespace Summator
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            long sum = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6 });
            if (sum == 21)
            {
                Console.WriteLine("TEST PASS");
            } else
            {
                Console.WriteLine("TEST FAIL");
            }

            long average = Summator.Average(new int[] { 5, 10, 15 });
            if (average == 10)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }
        }
    }
}
