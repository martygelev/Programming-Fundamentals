using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool tripleSum = ContainsTripleSum(arr);
        if (!tripleSum)
        {
            Console.WriteLine("No");
        }
    }

     static bool ContainsTripleSum(int[] arr)
    {
        bool tripleSum = false;
        int[] sum = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            for (int z =i+1 ; z < arr.Length; z++)
            {
                sum[i] = arr[i] + arr[z];

                if (arr.Contains(sum[i]))
                {
                    tripleSum = true;
                    Console.WriteLine($"{arr[i]} + {arr[z]} == {sum[i]}");
                }
            }
        }
        return tripleSum;
    }
}
