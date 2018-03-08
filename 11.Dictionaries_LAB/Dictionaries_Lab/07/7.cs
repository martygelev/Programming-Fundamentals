using System;
using System.Linq;
using System.Collections.Generic;
namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').ToArray();

            Dictionary<string, Dictionary<string, long>> population = new Dictionary<string, Dictionary<string, long>>();

            while (input[0] != "report")
            {
                string city = input[0];
                string country = input[1];
                int quantity = int.Parse(input[2]);

                if (!population.ContainsKey(country))
                {
                    population.Add(country, new Dictionary<string, long>());

                }
                if (!population[country].ContainsKey(city))
                {
                    population[country][city] = 0;
                }

                population[country][city] += quantity;
                input = Console.ReadLine().Split('|').ToArray();
            }

            foreach (var item in population.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value.Values.Sum()})");
                foreach (var pair in item.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"=>{pair.Key}: {pair.Value}");
                }
            }
        }
    }
}
