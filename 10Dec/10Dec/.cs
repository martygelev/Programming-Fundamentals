using System;
using System.Linq;
namespace _10Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());
            decimal regionalCoefficient = 0m;
            decimal sum = 0;
            for (int i = 0; i < amount; i++)
            {
                string[] arr = Console.ReadLine().Split(' ').ToArray();

                long raindropsCount = long.Parse(arr[0]);
                long squareMeters = long.Parse(arr[1]);

                regionalCoefficient = (raindropsCount / (decimal)squareMeters);
                sum += regionalCoefficient;

            }
            if (density != 0)
            {
                  sum /= density;

            }
            Console.WriteLine($"{sum:F3}");
            


        }
    }
}