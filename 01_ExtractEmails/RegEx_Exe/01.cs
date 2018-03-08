using System;
using System.Text.RegularExpressions;

namespace RegEx_Exe
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([\.\-][a-zA-Z]*)*(\.[a-z]{2,})";

            var matches = Regex.Matches(input, pattern);

            foreach (Match email in matches)
            {
                Console.WriteLine(email.Value);
            }

        }
    }
}
