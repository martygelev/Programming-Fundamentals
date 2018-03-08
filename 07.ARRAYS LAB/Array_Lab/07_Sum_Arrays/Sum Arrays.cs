using System;
using System.Linq;
namespace _07_Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int lengthFirst = firstArray.Length;
            int lengthSecond = secondArray.Length;

            int bigger = Math.Max(lengthFirst, lengthSecond);

            int[] result = new int[bigger];

            for (int i = 0; i < bigger; i++)
            {
                result[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
