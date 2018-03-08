using System;
using System.Collections.Generic;
using System.Linq;

namespace RianAir
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<int>> data = new Dictionary<string, List<int>>();

            while (input != "I believe I can fly!")
            {
                List<string> information = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

                string name = information[0];

                if (information[1] == "=")
                {
                    string sss = information[2];
                    data.Remove(name);
                    data[name] = data[sss].ToList();
                    input = Console.ReadLine();
                    continue;

                }
                List<int> numbers = new List<int>();
                if (!data.ContainsKey(name))
                {
                    data.Add(name, new List<int>());

                    information.RemoveAt(0);

                    foreach (var item in information)
                    {
                        numbers.Add(int.Parse(item));
                    }

                    data[name] = numbers;
                }
                else
                {

                    data[name].AddRange(information.Skip(1).Select(int.Parse).ToList());

                }
                input = Console.ReadLine();
            }


            foreach (var pair in data.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"#{pair.Key} ::: {string.Join(", ", pair.Value.OrderBy(x => x))}");
            }
        }
    }
}