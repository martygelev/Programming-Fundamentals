using System;

namespace _06_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            bool prime = IsPrime(number);
            Console.WriteLine(prime);
        }

         static bool IsPrime(long number)
        {
            bool prime = true;
            if (number == 1)
            {
                prime = false;
            } 

            if (number == 2)
            {
                prime = true;
            }

            if (number % 2 == 0)
            {
                prime = false;
            }

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    prime = false;
                }

            }

            return prime;
        }
    }
}
