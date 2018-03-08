using System;
using System.Collections.Generic;

namespace _03_ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = int.Parse(Console.ReadLine());

            string virus = Console.ReadLine();
            int sum = 0;
            int strength = 0;
            var time = 0;

            int final = 0;
            double left = 0.0;
            List<string> vir = new List<string>();
            while (virus!="end")
            {
                vir.Add(virus);
                foreach (char symbol in virus)
                {
                    int number = (int)symbol;
                    sum += number;
                }

                if (!vir.Contains(virus))
                {
                    strength = sum / 3;
                    time = strength * virus.Length;
                }
                else
                {
                    strength = sum / 3;
                    time = (strength * virus.Length)/3;
                }


                TimeSpan t = TimeSpan.FromSeconds(time);

                int minutes = t.Minutes;
                int seconds = t.Seconds;
               left = hp - time;

                if (minutes<=0)
                {
                    Console.WriteLine($"Virus {virus}: {strength} => {time} seconds");
                    Console.WriteLine($"{virus} defeated in {seconds}s.");
                    Console.WriteLine($"Remaining health: {left}");
                }
                else
                {
                    Console.WriteLine($"Virus {virus}: {strength} => {time} seconds");
                    Console.WriteLine($"{virus} defeated in {minutes}m {seconds}s.");
                    Console.WriteLine($"Remaining health: {left}");

                }
                left = time * 0.2;

                if (left>hp)
                {
                    left = hp;
                }
                virus = Console.ReadLine();
                left -= final;
                sum = 0;
                strength = 0;
                time = 0;

            }

            if (left>0)
            {
                Console.WriteLine($"Final Health: {left}");
            }
            else
            {
                Console.WriteLine($"Immune System Defeated.");
            }
        }
    }
}
