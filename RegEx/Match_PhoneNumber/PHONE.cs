using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Match_PhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\+(?:359))([\.\-\+\ ])((?:2){1})\2(\d{3})\2(\d{4}\b)";

            MatchCollection match = Regex.Matches(input, pattern);

            var matchedPhones = match.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ",matchedPhones));
        }
    }
}
