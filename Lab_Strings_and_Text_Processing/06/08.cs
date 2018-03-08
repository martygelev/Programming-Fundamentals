using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"https://regexr.com
fmnkldamfklmdmfla 312321
21312
http://www.introprogramming.info/wp-content/uploads/2015/10/Intro-CSharp-Book-v2015.pdf
https://softuni.bg/trainings/resources/video/18976/video-stream-record-26-october-2017-svetlin-nakov-group-1-programming-fundamentals-septem     ber-2017";


            string pattern = @"([h-t]+)(\:\/\/[a-z0-9.\-_]+)(.*)";


            foreach (Match m  in Regex.Matches(text,pattern))
            {
                Console.WriteLine(m.Groups[1]);
                Console.WriteLine(m.Groups[2]);
                Console.WriteLine(m.Groups[3]);
            }



        }
    }
}