using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(@"/\() ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            string pattern = @"(^|(?<=\s))(([A-Za-z]_*[0-9]*){3,25})\b";

            List<string> goodnames = new List<string>();
            foreach (var name in input)
            {
                var match = Regex.Matches(name, pattern);

                foreach (Match m in match)
                {
                    goodnames.Add(m.Value);
                }
            }
            int sum = 0;
            int maxsum = 0;
            var firstValidUser = "";
            var secondValidUser = "";
            for (int i = 0; i < goodnames.Count()-1; i++)
            {
                sum = goodnames[i].Count() + goodnames[i +1].Count();

                if (sum > maxsum)
                {
                    maxsum = sum;
                    firstValidUser = goodnames[i];
                    secondValidUser = goodnames[i + 1];
                }

            }
            Console.WriteLine(firstValidUser);
            Console.WriteLine(secondValidUser);


        }
    }
}