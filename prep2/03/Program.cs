using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split(" ,".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            Dictionary<string, Dictionary<decimal, long>> helper = new Dictionary<string, Dictionary<decimal,long>>();
            decimal digits = 0m;
            long health = 0;
            string pattern = @"[\-|\+]?\d+\.?\d*";
            string pattrnt2 = @"[^\-\.\*\-\,\ \d\+\/]+";

            foreach (var item in input)
            {
                
                digits = 0m;
                health = 0;
                var match2 = Regex.Matches(item, pattrnt2);

                foreach (Match  im in match2 )
                {
                    foreach (var a in im.Value)
                    {
                        health = health + (int)a;
                    }

                }
                var match = Regex.Matches(item, pattern);

                foreach (Match m in match)
                {
                    digits += decimal.Parse(m.Value);
                }
                foreach (var symb in item)
                {
                    if (symb =='*')
                    {
                        digits *= 2;
                    }
                    else if (symb=='/')
                    {
                        digits /= 2;
                    }
                }

                if (!helper.ContainsKey(item))
                {
                    helper.Add(item,new Dictionary<decimal, long>());
                    helper[item][digits] = health;

                }

            }
            foreach (var item in helper.OrderBy(x=>x.Key))
            {
                foreach (var pair in item.Value )
                {
                    Console.WriteLine($"{item.Key} - {pair.Value} health, {pair.Key:f2} damage");
                }
            }
        }
    }
}
