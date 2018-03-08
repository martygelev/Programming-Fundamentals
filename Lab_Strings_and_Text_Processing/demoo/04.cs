using System;
using System.Linq;

namespace demoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            char[] first = input[0].ToArray();
            char[] second = input[1].ToArray();
            int sum = 0;

            int bigger = Math.Max(first.Length, second.Length);
            int smaller = Math.Min(first.Length, second.Length);

            if (first.Length != second.Length)
            {
                for (int z = 0; z < smaller; z++)
                {
                    sum += first[z] * second[z];
                }
                for (int i = smaller; i < bigger; i++)
                {
                    try
                    {
                        sum += first[i];
                   }
                    catch 
                    {
                        sum += second[i];

                    }
                }
            }

            else
            {
                for (int i = 0; i < bigger; i++)
                {
                    sum += first[i] * second[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
