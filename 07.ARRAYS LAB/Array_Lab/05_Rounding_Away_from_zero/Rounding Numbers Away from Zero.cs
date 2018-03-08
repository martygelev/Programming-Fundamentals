using System;
using System.Linq;

namespace _05_Rounding_Away_from_zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] st = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < st.Length; i++)
            {
                var result = Math.Round(st[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{st[i]} => {result}");
            }

        }
    }
}
