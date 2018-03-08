using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int leftSum = 0;
        int rightSum = 0;
        bool sumEqual = false;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int z = 0; z < i; z++)
            {
                leftSum+=arr[z];
            }
            for (int d = i+1; d < arr.Length; d++)
            {
                rightSum+=arr[d];
            }
            if (leftSum==rightSum)
            {
                Console.WriteLine(i);
                sumEqual = true;
                break;
            }
            leftSum = 0;
            rightSum = 0;
        }
        if (sumEqual==false)
        {Console.WriteLine("no");

        }


    }
}
