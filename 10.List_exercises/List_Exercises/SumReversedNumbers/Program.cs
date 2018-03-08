using System;
using System.Linq;
using System.Collections.Generic;
namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ').ToList();
            int sum = 0;
           
            foreach (var num in numbers)
            {
                List<char> digits = num.ToList();
                digits.Reverse();

                sum += int.Parse(string.Join("", digits));
            }
            Console.WriteLine(sum);
        }
    }
}
