using System;
using System.Linq;

namespace _05_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] srr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int first = arr.Length;
            int second = srr.Length;

            int smaller = Math.Min(first, second);

            if (first > second)
            {
                Console.WriteLine(string.Join("", srr));
                Console.WriteLine(string.Join("", arr));
                return;
            }
            else if (second > first)
            {
                Console.WriteLine(string.Join("", arr));
                Console.WriteLine(string.Join("", srr));
                return;
            }
            else if (first == second)
            {
                for (int i = 0; i < smaller; i++)
                {
                    if (arr[i] >= srr[i])
                    {
                        Console.WriteLine(string.Join("", srr));
                        Console.WriteLine(string.Join("", arr));
                        return;
                    }
                    else if (arr[i]<srr[i])
                    {
                        Console.WriteLine(string.Join("", arr));
                        Console.WriteLine(string.Join("", srr));
                        return;
                    }
                    else if (arr[i]==srr[i])
                    {
                        continue;
                    }
                }
            }

        }
    }
}
