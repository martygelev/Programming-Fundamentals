using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(\d{2})([.\-\/])([A-Z][a-z]{2})\2(\d{4})\b";

            MatchCollection match = Regex.Matches(input, pattern);
            foreach (Match date in match)
            {
                Console.WriteLine($"Day: {date.Groups[1]}, Month: {date.Groups[3]}, Year: {date.Groups[4]}");
            }

        }
    }
}

