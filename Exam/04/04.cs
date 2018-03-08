using System;
using System.Collections.Generic;
using System.Linq;
namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> keeper = new Dictionary<string, List<string>>();
            while (input != "Lumpawaroo")
            {
                if (input.Contains(" | "))
                {
                    AddUsersInfirstInput(input, keeper);
                }
                else if (input.Contains(" -> "))
                {
                    AddUsersInSecondInput(input, keeper);
                }

                input = Console.ReadLine();
            }

            foreach (var pair in keeper.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {

                Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.Count()}");
                foreach (var name in pair.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {name}");
                }
            }
        }

        static void AddUsersInSecondInput(string input, Dictionary<string, List<string>> keeper)
        {
            string[] getInformation = input.Split("->".ToCharArray(),
                                                 StringSplitOptions.
                                                 RemoveEmptyEntries).ToArray();

            string name = getInformation[0].Trim();
            string newSide = getInformation[1].Trim();

            List<string> names = new List<string>();

            if (!keeper.ContainsKey(newSide))
            {
                keeper.Add(newSide, names);
                keeper[newSide].Add(name);
            }
            else
            {
                foreach (var item in keeper.Values)
                {
                    foreach (var element in item)
                    {
                        if (element == name)
                        {
                            keeper.Remove(newSide);
                        }
                    }
                }

                keeper[newSide].Add(name);


            }

        }

        static void AddUsersInfirstInput(string input, Dictionary<string, List<string>> keeper)
        {
            string[] getInformation = input.Split("|".ToCharArray(),
                                                 StringSplitOptions.
                                                 RemoveEmptyEntries).ToArray();

            string side = getInformation[0].Trim();
            string name = getInformation[1].Trim();
            List<string> names = new List<string>();


            if (!keeper.ContainsKey(side))
            {
                keeper.Add(side, names);
                keeper[side].Add(name);
            }
            else
            {
                if (!keeper[side].Contains(name))
                {
                    keeper[side].Add(name);
                }
            }

        }
    }
}

