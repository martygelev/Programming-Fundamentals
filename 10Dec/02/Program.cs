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
            if (donald>input.Count()-1)
            {
                donald = donald % input.Count();
            }
            if (donald<0)
            {
                donald = 0;
            }

            var counter = 0;
            for (int i = 0; i < input.Count(); i++)
            {
                input[i] = input[i] - 1;
            }
            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i] == 0 && donald ==i)
                {
                    Console.WriteLine(string.Join(" ", input));
                    Console.WriteLine(counter);
                    return;
                }
            }

             while (true)
            {
                for (int i = 0; i < input.Count(); i++)
                {
                    input[i]--;
                }
                int pos = int.Parse(Console.ReadLine());
                donald = pos;
                counter++;
                for (int i = 0; i < input.Count(); i++)
                {
                    if (input[i] == 0 && i == donald)
                    {
                        Console.WriteLine(string.Join(" ", input));
                        Console.WriteLine(counter);
                        return;
                    }
                    else if (input[i] == 0)
                    {
                        input[i] = original[i];
                    }
                }
               


               
            }
        }
    }
}
