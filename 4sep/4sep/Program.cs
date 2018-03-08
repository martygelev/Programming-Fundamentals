using System;

namespace _4sep
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                long totalLength = long.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                long wingLength = long.Parse(Console.ReadLine());

                long len = (long)Math.Pow(totalLength, 2);
                decimal width = totalWidth + 2 * wingLength;
                decimal totalYears = len * width;
           
                Console.WriteLine(totalYears);
            }

        }
    }
}
