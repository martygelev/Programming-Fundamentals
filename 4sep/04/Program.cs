using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, HashSet<string>> creatures = new Dictionary<string, HashSet<string>>();
        List<string> check = new List<string>();

        string input = Console.ReadLine();

        while (input != "Blaze it!")
        {
            string[] data = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string creature = data[0];
            string squadMates = data[1];
            check.Add(squadMates + "" + creature);

            if (!creatures.ContainsKey(creature))
            { 
                creatures.Add(creature, new HashSet<string>());
            }

            if (creature == squadMates || check.Contains(creature + "" + squadMates))
            {
                creatures[squadMates].Remove(creature);
                input = Console.ReadLine();
                continue;
            }
            creatures[creature].Add(squadMates);

            input = Console.ReadLine();
        }

        foreach (var item in creatures.OrderByDescending(x => x.Value.Count))
        {
            Console.WriteLine($"{item.Key} : {item.Value.Count}");
        }
    }
}
