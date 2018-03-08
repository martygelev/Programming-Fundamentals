using System;
using System.Linq;
namespace _08_TheMostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] counter = new int [arr.Length];
            int maxNumber = 0;
            int bestCounter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
               
                for (int z = i; z < arr.Length; z++)
                {
                   
                    if (arr[i]==arr[z])
                    {
                        counter[i]++;
                        if (counter[i] > bestCounter)
                        {
                            bestCounter=counter[i];
                            maxNumber = arr[i];

                        }
                    }

                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
