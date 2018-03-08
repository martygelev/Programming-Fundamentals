using System;
using System.Linq;
using System.Collections.Generic;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
           
            input.RemoveAll(x=>x%2==1);
			double average = input.Average();

            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i]>average)
                {
                    input[i]++;
                }
                else if (input[i]<average)
                {
                    input[i]--;
                 }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
