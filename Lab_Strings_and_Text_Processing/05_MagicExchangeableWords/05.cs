using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            var first = input[0];
                var second = input[1];

           int w1 = first.ToCharArray().Distinct().Count();
            int w2  = second.ToCharArray().Distinct().Count();

            if (w1==w2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
