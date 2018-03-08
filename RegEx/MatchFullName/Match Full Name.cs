using System;
using System.Text.RegularExpressions;

class MatchFullName
{
        static void Main()
    {
        string pattern = @"(\b[A-Z]{1}[a-z]{1,})+[^\n\t,](\b[A-Z]{1}[a-z]{1,})+";

        string input = Console.ReadLine();

        MatchCollection match = Regex.Matches(input, pattern);

        foreach (Match name in match)
        {
            Console.Write(name+" ");
        }
        Console.WriteLine();
    }
}

