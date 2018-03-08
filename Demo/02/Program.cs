using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers.Count() == 1)
                {
                    return;
                }
                int attacker = i;
                int target = numbers[i];

                if (target > numbers.Count())
                {
                    target = target % numbers.Count();
                }
                int result = Math.Abs(target - attacker);
                int winner = 0;
                if (result == 0)
                {
                    List<int> num = numbers.Take(i).ToList();
                    numbers = num.ToList();
                    i = 0;
                    Console.WriteLine($"{attacker} performed harakiri");

                    continue;
                }

                if (result % 2 == 0)
                {
                    winner = attacker;
                }
                else if (result % 2 != 0)
                {
                    winner = target;
                    continue;
                }

                Console.WriteLine($"{attacker} x {target} -> {winner} wins");

            }

        }


    }
}
