using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBasic
{
    public class FibonacciSeries
    {
        public static void PrintFibonacci(int terms)
        {
            int first = 0, second = 1, next;

            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < terms; i++)
            {
                Console.Write(first + " ");
                next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine();
        }
    }
}
