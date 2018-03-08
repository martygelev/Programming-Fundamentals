using System;
using System.Text.RegularExpressions;

namespace REGEXMON
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternW = @"([a-z]+\-{1}[a-z]+)";

            string patternS = @"([^a-z-]+)";

            Regex bojo = new Regex(patternW);
            Regex didi = new Regex(patternS);

            while (true)
            {
                Match didimon = didi.Match(input);

                if (didimon.Success)
                {
                    Console.WriteLine(didimon.Value);
                    int didimonFirstIndex = didimon.Index;
                    input = input.Substring(didimonFirstIndex + didimon.Length);
                }
                else
                {
                    break;
                }

                Match bojomon = bojo.Match(input);
                if (bojomon.Success)
                {
                    Console.WriteLine(bojomon.Value);
                    int bojomonFirstIndex = bojomon.Index;
                    input = input.Substring(bojomonFirstIndex + bojomon.Length);
                }
                else
                {
                    break;
                }


            }

        }
    }
}
