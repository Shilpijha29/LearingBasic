using System;

namespace PracticeBasic
{
    class Program
    {
        static void Main()
        {
            PrimeNumber.CheckPrime(7); // Call different class methods
            EvenOdd.CheckEvenOdd(10);
            Console.Write("Enter the number of terms: ");
            int terms = int.Parse(Console.ReadLine());

            FibonacciSeries.PrintFibonacci(terms);


        }
    }
}

