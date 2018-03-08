using System;
using System.Linq;
using System.Collections.Generic;
namespace _07_Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPoint = int.Parse(Console.ReadLine());
            int endPoint = int.Parse(Console.ReadLine());

            string result = string.Join(", ", FindPrimesInRange(startPoint, endPoint).ToArray());
            Console.WriteLine(result);
        }

        static List<int> FindPrimesInRange(int startPoint, int endPoint)
        {
            var result = new List<int>();
            for (int i = startPoint; i <= endPoint; i++)
            {
                bool isPrime = true;
                if (i < 2) isPrime = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    result.Add(i);
                }

            }

            return result;
        }

    }
}