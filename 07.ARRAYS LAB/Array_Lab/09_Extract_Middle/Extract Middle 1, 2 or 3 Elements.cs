using System;
using System.Linq;
namespace _09_Extract_Middle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int length = arr.Length;

            if (length==1)
            {
                Console.WriteLine("{ "+arr[0]+" }");
                return;

            }
            if (length%2==0)
            {
                int first = arr[length / 2];
                int sec = arr[length / 2 -1];

                Console.WriteLine("{ "+ (sec)+", "+ first+" }");
            }
            else
            {
                int first = arr[length / 2];
                int sec = arr[length / 2 - 1];
                int trird = arr[length / 2 + 1];
                    Console.WriteLine("{ " + (sec) + ", " + first + ", "+trird+" }");
            }
        }
    }
}
