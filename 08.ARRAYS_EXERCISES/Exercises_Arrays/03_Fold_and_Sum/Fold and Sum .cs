using System;
using System.Linq;

namespace _03_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(' ')
                               .Select(int.Parse)
                               .ToArray();
            int length = arr.Length;
            int[] sum = new int[length / 2];
            int counter = 0;
            for (int i = 0; i < arr.Length/4; i++)
            {
                sum[i]= arr[arr.Length/4+i] + arr[arr.Length / 4 - 1 - i];
                counter++;
            }
            for (int i = 0; i < arr.Length/4; i++)
            {
                sum[counter+i] = arr[arr.Length / 2 + i] + arr[arr.Length - 1 - i];
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
