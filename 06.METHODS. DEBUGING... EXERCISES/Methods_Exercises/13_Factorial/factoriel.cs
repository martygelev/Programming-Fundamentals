using System;
using System.Numerics;

namespace _13_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            FactorialResult(num);

        }

         static void FactorialResult(int num)
        {
            BigInteger result = 1;

            for (int i = 1; i <=num; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
