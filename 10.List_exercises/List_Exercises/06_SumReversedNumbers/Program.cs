using System;
using System.Linq;
using System.Collections.Generic;
namespace _06_SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            List<int> bombNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int bomb = bombNumbers[0];
            int power = bombNumbers[1];

            while (numbers.Contains(bomb))
            {
                int position = numbers.IndexOf(bomb);
                if (position-power<0 && position+power>numbers.Count())
                {
                    numbers.Clear();
                }
                else if (position-power<0)
                {
                    numbers.RemoveRange(0,1+position+power);
                }
                else if (position+power>=numbers.Count())
                {
                    numbers.RemoveRange(position-power,power+1+numbers.Count()-1-position);
                }
                else
                {
                    numbers.RemoveRange(position-power,2*power+1);
                }
            }
           int sum= numbers.Sum();
            Console.WriteLine(sum);

        }
    }
}