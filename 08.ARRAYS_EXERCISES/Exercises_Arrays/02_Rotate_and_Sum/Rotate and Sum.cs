using System;
using System.Linq;

namespace _02_Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int step = int.Parse(Console.ReadLine());
            int[] sum = new int[arr.Length];
            while (step>0)
            {
                int[] rotate = new int[arr.Length];

                rotate[0] = arr[arr.Length - 1];

                for (int i = 1; i <arr.Length ; i++)
                {
                    rotate[i] = arr[i - 1];
                }
                step--;
                arr = rotate;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum[i] += rotate[i];

                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
