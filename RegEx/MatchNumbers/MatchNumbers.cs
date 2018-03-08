using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))-?\d+(.?\d+)?($|(?=\s))";

            var match = Regex.Matches(input, pattern);

            foreach (Match numbers in match)
            {
                Console.Write(numbers + " ");
            }
            Console.WriteLine();
        }
    }
}
