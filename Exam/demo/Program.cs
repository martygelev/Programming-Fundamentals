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

            int start = 0;
            int counter = 1;
            int bestStart = 0;
            int bestCounter = 1;

            List<int> bestSequence = new List<int>();
            int bestSeqSum = 0;
            int ListSum = 0;
            int index = 0;
            int seqSum = 0;
            while (input!="Clone them!")
            {
                List<int> sequence = input.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                index++;

                for (int i = 1; i < sequence.Count(); i++)
                {
                    if (sequence[i] == sequence[i - 1] && sequence[i]==1)
                    {
                        counter++;
                        if (counter >= bestCounter && start<bestStart)
                        {
                            bestCounter = counter;
                            bestStart = start;
                            ListSum = sequence.Sum();
                            seqSum = bestSequence.Sum();

                                bestSequence = sequence.ToList();
                                bestSeqSum = index;

                        }

                    }
                    else
                    {
                        start = i;
                        counter = 1;
                    }
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSeqSum} with sum: {bestSequence.Sum()}.");
            Console.WriteLine(string.Join(" ",bestSequence));
        }
    }
}