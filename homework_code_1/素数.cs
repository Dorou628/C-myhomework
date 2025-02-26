using System;
using System.Collections.Generic;

namespace homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入下限: ");
            int lowerLimit = int.Parse(Console.ReadLine());

            Console.Write("请输入上限: ");
            int upperLimit = int.Parse(Console.ReadLine());

            List<int> primes = GetPrimes(lowerLimit, upperLimit);

            for (int i = 0; i < primes.Count; i++)
            {
                Console.Write(primes[i] + "\t");
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        static List<int> GetPrimes(int lowerLimit, int upperLimit)
        {
            List<int> primes = new List<int>();

            for (int i = lowerLimit; i <= upperLimit; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}

