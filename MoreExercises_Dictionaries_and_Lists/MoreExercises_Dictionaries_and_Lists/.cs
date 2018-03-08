using System;
using System.Linq;
using System.Collections.Generic;
namespace MoreExercises_Dictionaries_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int snowballSnow = 0; 
                int snowballTime = 0;
                    int snowballQuality = 0;
            double snowballValue = 0.0;
            int bigger = 0;
            for (int i = 0; i < n; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                var res = (snowballSnow / snowballTime);
                snowballValue = Math.Pow(res, snowballQuality);

                if (snowballValue>bigger)
                {
                    bigger = snowballValue;
                }
            }
            Console.WriteLine($"{snowballSnow} : {snowballTime} = {bigger} ({snowballQuality})");
        }
    }
}
