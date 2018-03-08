using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

           
            int[] bestSequence = new int[number];

            int start = 0;
            int beststart = int.MaxValue;
            int counnt = 0;
            int bestcount = 0;
            int index = 0;
            int bestIndex = 0;

            while (input != "Clone them!")
            {
                int[] sequence = input.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
               
                if (number == 1)
                {
                    index++;

                    if (sequence[0] == 1 && bestIndex == 0)
                    {
                        Console.WriteLine($"Best DNA sample {index} with sum: {1}.");
                        Console.WriteLine(1);
                        return;
                    }
                    input = Console.ReadLine();
                    continue;
                }
                index++;


                if (sequence.Length>number || sequence.Length<number)
                {
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 0; i < sequence.Length - 1; i++)
                {
                    if (sequence[i] == sequence[i + 1] && sequence[i] == 1)
                    {
                        counnt++;
                        if (counnt >= bestcount && start <= beststart)
                        {
                            if (counnt == bestcount && start == beststart)
                            {
                                if (sequence.Sum() > bestSequence.Sum())
                                {
                                    bestSequence = sequence.ToArray();
                                    bestIndex = index;

                                }
                            }
                            else
                            {
                                bestcount = counnt;
                                beststart = start;
                                bestSequence = sequence.ToArray();
                                bestIndex = index;

                            }

                        }
                    }
                    else
                    {
                        start = i;
                        counnt = 0;
                    }
                }

                input = Console.ReadLine();
                counnt = 0;
                start = 0;
            }
          
            Console.WriteLine($"Best DNA sample {bestIndex} with sum: {bestSequence.Sum()}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}

