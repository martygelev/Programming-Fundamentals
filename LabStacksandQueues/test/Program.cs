using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int digitSum = 0;
            int upper = 0;
            int lower = 0;
            int other = 0;


            string digitSumMax = "";
            string upperMax = "";
            string lowerMax = "";
            string otherMax = "";

            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                if (char.IsDigit(symbol))
                {
                    digitSum += (int)symbol;

                   
                        digitSumMax += symbol;
                    
                }
                else if (char.IsUpper(symbol))
                {
                    upper += (int)symbol;
                   
                        upperMax += symbol;
                    
                }
                else if (char.IsLower(symbol))
                {
                    lower += (int)symbol;
                   
                        lowerMax += symbol;
                   
                }
                else
                {
                    other += (int)symbol;
                   
                        otherMax += symbol;

                }
            }

            int biggestSum = Math.Max(digitSum, Math.Max(upper, Math.Max(lower, other)));

            Console.WriteLine($"Biggest ASCII sum is:{biggestSum}");

            if (biggestSum==digitSum)
            {
                Console.WriteLine($"Combinations of characters ASCII sum is:{digitSumMax}");
            }
            else if (biggestSum==upper)
            {
                Console.WriteLine($"Combinations of characters ASCII sum is:{upperMax}");
            }
            else if (biggestSum==lower)
            {
                Console.WriteLine($"Combinations of characters ASCII sum is:{lowerMax}");
            }
            else
            {
                Console.WriteLine($"Combinations of characters ASCII sum is:{otherMax}");

            }
        }
    }
}
