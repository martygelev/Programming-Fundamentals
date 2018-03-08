using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([A-Z]{2})([\d]+.[\d]+)([A-Za-z]+)\|";

            Dictionary<string, Dictionary<string, double>> result = new Dictionary<string, Dictionary<string, double>>();
            while (input != "end")
            {
                var match = Regex.Matches(input, pattern);
                if (!Regex.IsMatch(input, pattern))
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    foreach (Match weather in match)
                    {
                        string city = weather.Groups[1].Value;
                        double  temperature = double.Parse(weather.Groups[2].Value);
                       string  type = weather.Groups[3].Value;

                        if (result.ContainsKey(city))
                        {
                            result.Remove(city);

                        }
                        if (!result.ContainsKey(city))
                        {
                            result[city]= new Dictionary<string, double>();

                            result[city].Add(type,temperature);
                        }
                       
                    }
                    input = Console.ReadLine();
                }
            }
            foreach (var kvp in result.OrderBy(x=>x.Value.Values.Average()))
            {
                foreach (var pair in kvp.Value)
                {
                    Console.WriteLine($"{kvp.Key} => {pair.Value:f2} => {pair.Key}");
                }
            }
        }

    }
}
