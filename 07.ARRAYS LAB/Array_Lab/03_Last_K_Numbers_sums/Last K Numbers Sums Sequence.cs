using System;

namespace _03_Last_K_Numbers_sums
{
    class Program
    {
        static void Main(string[] args)
        {
            long numbers = long.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

           
            long[] arr = new long[numbers];

            long sum = 0;
            arr[0] = 1;

            for (int i =1; i < arr.Length; i++)
            {
                int start = Math.Max(0, i - step);
                for (int z = start; z < numbers; z++)
                {
                    sum += arr[z];
                }
                arr[i] = sum;
                sum = 0;
            }
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
