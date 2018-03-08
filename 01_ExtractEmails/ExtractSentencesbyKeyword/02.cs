using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace ExtractSentencesbyKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] input = Console.ReadLine().Split(".!?".ToCharArray(),
                                                      StringSplitOptions.
                                                      RemoveEmptyEntries).ToArray();
            string pattetn = $@"\b{word}\b";

            foreach (var sentance in input)
            {
                var match = Regex.Match(sentance, pattetn);

                if (match.Success)
                {
                    Console.WriteLine(sentance.Trim());
                }
            }
        }
    }
}

