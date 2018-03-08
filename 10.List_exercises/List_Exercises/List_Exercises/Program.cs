using System;
using System.Linq;
using System.Collections.Generic;


namespace List_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int counter = 1;
            int counterMax = 1;
            int start = 0;
            int startIndex=0;

            for (int i = 1; i < numbers.Count(); i++)
            {
                if (numbers[i]==numbers[i-1])
                {
                    counter++;

                    if (counter>counterMax)
                    {
                        counterMax = counter;
                        startIndex = start;
                    }
                }
                else
                {
                    counter = 1;
                    start = i;
                }
            }
            for (int s = startIndex;s < startIndex+counterMax; s++)
            {
                Console.Write(numbers[s] + " ");
            }

        }
    }
}

