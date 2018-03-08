using System;
using System.Linq;

namespace _06_Reverse_string_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
