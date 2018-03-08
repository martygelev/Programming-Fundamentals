using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            var skip = nums[0];
            var take = nums[1];

            List<string> matched = new List<string>();
            Regex match = new Regex(@"\|<(\w{" + skip + @"})(\w{0," + take + @"})");
            var col = match.Matches(input);

            foreach (Match item in col)
            {
                matched.Add(item.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ",matched));
        }
    }
}
