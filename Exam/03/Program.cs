using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var encrypted = "";
            Dictionary<string, int> attacked = new Dictionary<string, int>();
            Dictionary<string, int> destroyed = new Dictionary<string, int>();

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                var sum = 0;
                foreach (var item in input)
                {
                    if (item == 's' || item == 't' || item == 'a' || item == 'r' ||
                        item == 'S' || item == 'T' || item == 'A' || item == 'R')
                    {
                        sum++;

                    }
                }
                foreach (var item in input)
                {

                    string s = Encoding.ASCII.GetString(new byte[] { (byte)((item) - sum) });
                    encrypted = encrypted + "" + s;
                }

                string pattern = @"[^\@\-\!\:\>]*\@([A-Za-z]+)[^\@\-\!\:\>]*\:([0-9]+)[^\@\-\!\:\>]*\!(A|D)\!\-\>([0-9]+)[^\@\-\!\:\>]*";

                var match = Regex.Match(encrypted, pattern);

                if (match.Groups[3].Value == "A")
                {
                    attacked.Add(match.Groups[1].Value, 0);
                    attacked[match.Groups[1].Value]++;
                }

                else if (match.Groups[3].Value == "D")
                {
                    destroyed.Add(match.Groups[1].Value, 0);
                    destroyed[match.Groups[1].Value]++;
                }

                encrypted = "";
            }


            Console.WriteLine($"Attacked planets: {attacked.Count}");

            if (attacked.Count > 0)
            {
                foreach (var item in attacked.OrderBy(x=>x.Key))
                {
                    Console.WriteLine($"-> {item.Key}");

                }
            }


            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            if (destroyed.Count > 0)
            {
                foreach (var item in destroyed.OrderBy(x=>x.Key))
                {
                    Console.WriteLine($"-> {item.Key}");

                }
            }


        }
    }
}
