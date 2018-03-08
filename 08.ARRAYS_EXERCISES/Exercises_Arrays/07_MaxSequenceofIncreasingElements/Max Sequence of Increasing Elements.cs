using System;
using System.Linq;

namespace _07_MaxSequenceofIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 1;
            int start = 0;

            int bestCount = 1;
            int bestStart = 0;


            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    counter++;
                    if (counter > bestCount)
                    {
                        bestCount = counter;
                        bestStart = start;
                    }
                }

                else
                {
                    start = i;
                    counter = 1;
                }



            }
            for (int i = bestStart; i < bestStart + bestCount; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
