using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBasic
{
    public class PrimeNumber
    {
        public static void CheckPrime(int num)
        {
            bool isPrime = num > 1;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime ? $"{num} is Prime" : $"{num} is not Prime");
        }
    }
}

