using System;
using System.Linq;

namespace _10_PairsbyDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();

            int difference = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int z = i; z < arr.Length; z++)
                {
                    int dif = Math.Abs(arr[i] - arr[z]);

                    if (dif == difference)
                    {
                        counter++;
                    }
                }

            }
            Console.WriteLine(counter);
        }
    }
}
