using System;
using System.Collections.Generic;
using System.Linq;


namespace _033
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').ToArray();
            Dictionary<string, Dictionary<string, int>> statistic = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "report")
            {
                string city = input[0];
                string country = input[1];
                int count = int.Parse(input[2]);

                if (!statistic.ContainsKey(country))
                {
                    statistic.Add(country, new Dictionary<string, int>());
                    statistic[country].Add(city, count);
                }
                if (!statistic[country].ContainsKey(city))
                {
                    statistic[country].Add(city, count);
                }
                input = Console.ReadLine().Split('|').ToArray();

            }
            foreach (var item in statistic.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value.Values.Sum()})");
                foreach (var pair in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{pair.Key}: {pair.Value}");
                }
            }
        }
    }
}