using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {

            string typePattern = @"^Type: (Normal|Danger|Warning)$";
            string sourcePattern = @"^Source: ([A-Za-z0-9]+)$";
            string forecastPattern = @"^Forecast: ([^!.,?]+)$";

            List<string> weather = new List<string>();
            List<List<string>> vijdalsymnonqma = new List<List<string>>();
            string input = Console.ReadLine();
            string current = "type";
            var i = 3;

            while (input!="Davai Emo")
            {
                switch (current)
                {
                    case "type":
                        var type = Regex.Match(input, typePattern);
                        if (type.Success)
                        {
                            weather.Add(type.Groups[1].Value);
                            current = "source";
                        }

                        break;

                    case "source":
                        var source = Regex.Match(input, sourcePattern);
                        if (source.Success)
                        {
                            weather.Add(source.Groups[1].Value);
                            current = "forecast";
                        }

                        break;
                    
                    case "forecast":
                        var forecast = Regex.Match(input, forecastPattern);
                        if (forecast.Success)
                        {
                            weather.Add(forecast.Groups[1].Value);
                            current = "type";
                        }

                        break;
                    default:
                        break;
                } 


                input = Console.ReadLine();
                if (weather.Count()==i)
                {
                    vijdalsymnonqma.Add(weather);
                    i = i +3;
                }
            }
            var counter = 0;
            foreach (var item in vijdalsymnonqma)
            {
                
                    Console.WriteLine($"({item[0+counter]}) {item[2+counter]} ~ {item[1+counter]}");


                counter += 3;
            }
        }
    }
}
