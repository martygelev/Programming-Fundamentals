using System;
using System.Linq;
using System.Collections.Generic;
namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> logs = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] inf = Console.ReadLine().Split(' ').ToArray();

                string ip = inf[0];
                string name = inf[1];
                int duration = int.Parse(inf[2]);

               
                if (!logs.ContainsKey(name))
                {
                    logs.Add(name,new Dictionary<string,int>());
                }

                if (!logs[name].ContainsKey(ip))
                {
                    logs[name][ip] = 0;

                }
                logs[name][ip] += duration;

            }

            foreach (var item in logs.OrderBy(x => x.Key))
            {
                Console.Write($"{item.Key}: {item.Value.Values.Sum()}");
                List<string> ipes = new List<string>();
                foreach (var pair in item.Value)
                {
                    ipes.Add(pair.Key);
                }
                ipes.Distinct();

                Console.WriteLine("[" + string.Join(", ", ipes.OrderBy(x => x)) +"]");
            }
        }
    }
}
