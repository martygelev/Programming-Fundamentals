using System;
using System.Collections.Generic;
using System.Linq;
namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string track = Console.ReadLine();

            SortedDictionary<string, SortedDictionary<string, List<string>>> keeper = new SortedDictionary<string, SortedDictionary<string, List<string>>>();
            while (track!="Time for Code")
            {
                string[] input = track.Split(" \t".ToCharArray(), StringSplitOptions
                                           .RemoveEmptyEntries)
                                           .ToArray();

                string id = input[0];
                string eventName = input[1];

                if (!eventName.StartsWith("#"))
                {
                    track = Console.ReadLine();
                    continue;
                }

                List<string> participant = input.Skip(2).Take(input.Length).ToList();

                if (!keeper.ContainsKey(id))
                {
                    keeper.Add(id,new SortedDictionary<string, List<string>>());
                    //keeper[id][eventName] = new List<string>();
                    keeper[id][eventName]=participant;

                }
                else
                {
                    if (!keeper[id].ContainsKey(eventName))
                    {
                        track = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        keeper[id][eventName] = participant;
                    }
                }

                track = Console.ReadLine();
            }

            foreach (var res in keeper.OrderByDescending(x => x.Value.Values.Sum(y => y.Count)))
            {
                List<string> helper = new List<string>();
                foreach (var meet in res.Value)
                {
                    helper = meet.Value.Distinct().ToList();
                    helper.Sort();
                    int count = helper.Count;
                    Console.WriteLine("{0} - {1}", meet.Key.Trim('#'), count);
                }
                foreach (var help in helper)
                {
                    Console.WriteLine("{0}", help);
                }
            }

        }
    }
}
