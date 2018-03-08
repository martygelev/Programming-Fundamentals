using System;
using System.Collections.Generic;
using System.Linq;
namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var donald = input.Last();
            input.RemoveAt(input.Count - 1);
            List<int> original = input.ToList();

            var counter = 0;

            while (true)
            {
                for (int i = 0; i < input.Count(); i++)
                {
                    input[i]--;
                }

                if (input[donald] == 0)
                {
                    Console.WriteLine(string.Join(" ", input));
                    Console.WriteLine(counter);
                    return;
                }

                for (int i = 0; i < input.Count(); i++)
                {
                    
                    if (input[i] == 0)
                    {
                        input[i] = original[i];
                    }
                }

                donald = int.Parse(Console.ReadLine());
                counter++;

            }
        }
    }
}