using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            string pattern = @"([A-Za-z]+)[\|\<\\](\w+)[\|\<\\]([A-Za-z]+)";
            string start = "";
            string end = "";
            string output = "";
            List<string> list = new List<string>();
            var reg = Regex.Matches(firstLine, pattern);

            foreach (Match item in reg)
            {
                start = item.Groups[1].Value;
                end = item.Groups[3].Value;
            }

            string pattern2 =$@"({start})([A-Za-z]*?)({end})";

            var regex = Regex.Matches(secondLine, pattern2);
            if (!Regex.IsMatch(secondLine,pattern2))
            {
                Console.WriteLine("Empty result");
                return;
            }

            foreach (Match item in regex)
            {
                output = item.Groups[2].Value;
                list.Add(output);
            }

                Console.WriteLine(string.Join("",list));
            

        }
    }
}  
