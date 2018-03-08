using System;

namespace _09_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
           int sum =  GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(sum);

        }

         static int GetMultipleOfEvenAndOdds(int number)
        {
           int sumOfEvens= GetEvenSum(number);
            int sumOfOdds = GetOddSum(number);
            return sumOfOdds * sumOfEvens;
        }

         static int GetOddSum(int number)
        {
            int sum = 0;
            while (number>0)
            {
                int lastDigit = number % 10;
                if (lastDigit%2!=0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }

        static int GetEvenSum(int number)
        {
            int sum = 0;

            while (number>0)
            {
                int lastDigit = number % 10;

                if (lastDigit%2==0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
