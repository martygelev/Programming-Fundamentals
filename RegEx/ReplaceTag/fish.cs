namespace Fish_Statistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class FishStatistics
    {
        public static void Main(string[] args)
        {
            //var for input string;
            var input = Console.ReadLine();

            //var for pattern;
            var pattern = @"(>*)<(\(+?)(['\-x])>";
            //var for regex object;
            var regex = new Regex(pattern);
            //var for matches in input string;
            var matches = regex.Matches(input);

            //var for count of fishes;
            var count = 1;

            if (matches.Count == 0)
            {
                Console.WriteLine("No fish found.");
            }
            else
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine("Fish {0}: {1}", count, match.Value);

                    //var for count of tail;
                    var tailCount = match.Groups[1].Length * 2;

                    //check for tail count;
                    if (tailCount == 0)
                    {
                        Console.WriteLine("Tail type: None");
                    }
                    else
                    {
                        if (match.Groups[1].Length == 1)
                        {
                            Console.WriteLine("Tail type: Short ({0} cm)", tailCount);
                        }
                        else if (match.Groups[1].Length > 1 && match.Groups[1].Length <= 5)
                        {
                            Console.WriteLine("Tail type: Medium ({0} cm)", tailCount);
                        }
                        else if (match.Groups[1].Length > 5)
                        {
                            Console.WriteLine("Tail type: Long ({0} cm)", tailCount);
                        }
                    }//end of check for tail count;

                    //var for body lenght;
                    var bodyLength = match.Groups[2].Length * 2;

                    //check for body count;
                    if (match.Groups[2].Length <= 5)
                    {
                        Console.WriteLine("Body type: Short ({0} cm)", bodyLength);
                    }
                    else if (match.Groups[2].Length > 5 && match.Groups[2].Length <= 10)
                    {
                        Console.WriteLine("Body type: Medium ({0} cm)", bodyLength);
                    }
                    else if (match.Groups[2].Length > 10)
                    {
                        Console.WriteLine("Body type: Long ({0} cm)", bodyLength);
                    }//end of body count;

                    //var for status of the fish;
                    var status = match.Groups[3].Value;

                    //check for status;
                    if (status == "'")
                    {
                        Console.WriteLine("Status: Awake");
                    }
                    else if (status == "-")
                    {
                        Console.WriteLine("Status: Asleep");
                    }
                    else if (status == "x")
                    {
                        Console.WriteLine("Status: Dead");
                    }//end of check for status;

                    count++;
                }
            }
        }
    }
}