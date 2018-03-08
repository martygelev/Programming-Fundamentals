using System;
using System.Numerics;
namespace _14_Factorial_Trailing_Zeroes
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
            var count = 0;
            BigInteger result = 1;

            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            string sResult = result.ToString();

            for (int i = 0; i < sResult.Length; i++)
            {
                if (sResult[sResult.Length-1-i]=='0')
                {
                    count++;
                }
                if (sResult[sResult.Length-1-i]!='0')
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
