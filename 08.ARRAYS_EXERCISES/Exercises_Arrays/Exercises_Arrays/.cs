using System;
using System.Linq;
namespace Exercises_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            string[] srr = Console.ReadLine().Split(' ').ToArray();


            int firstLength = arr.Length;
            int secondLength = srr.Length;

            int shorter = Math.Min(firstLength, secondLength);

            var counter = 0;
            if (arr[0] == srr[0])
            {


                for (int i = 0; i < shorter; i++)
                {
                    if (arr[i] == srr[i])
                    {
                        counter++;
                    }
                }
            }
            else
            {
                for (int z = 0; z < shorter; z++)
                {
                    if (arr[firstLength - 1 - z] == srr[secondLength - 1 - z])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);

        }
    }
}
