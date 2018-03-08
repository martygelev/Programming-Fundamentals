using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?:0x)?([0-9A-F]+)\b";
            string pat2 = @"\b(0x)?([0-9A-F]+)\b";

            var match = Regex.Matches(input, pattern).Cast<Match>()
                                         .Select(a => a.Value)
                                         .ToArray();

            Console.WriteLine(string.Join(" ",match));


        }
    }
}
