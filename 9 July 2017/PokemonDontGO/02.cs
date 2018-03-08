using System;
using System.Collections.Generic;
using System.Linq;
namespace PokemonDontGO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> list = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            long sumOfAllRemoved = 0;

            while (list.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                long currentValue = 0;

                if (index < 0)
                {
                    currentValue = list[0];
                    sumOfAllRemoved += currentValue;
                    list[0] = list[list.Count - 1];
                }
                else if (index > list.Count - 1)
                {
                    currentValue = list[list.Count - 1];
                    sumOfAllRemoved += currentValue;
                    list[list.Count - 1] = list[0];
                }
                else
                {
                    currentValue = list[index];
                    sumOfAllRemoved += currentValue;
                    list.RemoveAt(index);
                }

                for (int cycle = 0; cycle < list.Count; cycle++)
                {
                    if (list[cycle] <= currentValue)
                    {
                        list[cycle] += currentValue;
                    }
                    else
                    {
                        list[cycle] -= currentValue;
                    }
                }
            }
              
            Console.WriteLine(sumOfAllRemoved);


        }
    }
}

