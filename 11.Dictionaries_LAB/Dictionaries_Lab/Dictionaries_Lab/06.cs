using System;
using System.Linq;
using System.Collections.Generic;
namespace Dictionaries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> userIP = new Dictionary<string, Dictionary<string, int>>();

            string[] input = Console.ReadLine().Split(' ').ToArray();

            var ip = "";
            var name = "";

            while (input[0]!="end")
            {
                var adress = input[0].Split('=').ToList();
                ip = adress[1];
                var username = input[2].Split('=').ToList();
                name = username[1];

                if (!userIP.ContainsKey(name))
                {
                    Dictionary<string, int> ipCounter = new Dictionary<string, int>();

                    ipCounter.Add(ip,1);
                    userIP.Add(name,ipCounter);

                }
                else
                {
                    if (!userIP[name].ContainsKey(ip))
                    {
                        userIP[name].Add(ip, 1);
                    }
                    else
                    {
                        userIP[name][ip]++;
                    }
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }

            foreach (var item in userIP.OrderBy(x=>x.Key))
            {
                List<string> helper = new List<string>();
                Console.WriteLine($"{item.Key}: ");
                foreach (var opa in item.Value)
                {
                    helper.Add($"{opa.Key} => {opa.Value}");
                   
                }
                Console.WriteLine(string.Join(", ", helper)+".");

            }
        }
    }
}
