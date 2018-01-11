using System;

namespace _01.Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pesho = int.Parse(Console.ReadLine());
            int Gosho = int.Parse(Console.ReadLine());

            var HPP = 100;
            var HPG = 100;

            var counter = 0;

           for (int i = 1; i <= 100; i++)
            {

                if (HPP <= 0)
                {
                    Console.WriteLine($"Gosho won in {counter}th round.");
                    return;
                }
                if (HPG <= 0)
                {
                    Console.WriteLine($"Pesho won in {counter}th round.");
                    return;
                }
                counter++;

                if (i%2==0)
                {
                    HPP = HPP - Gosho;
                    if (HPP<=0)
                    {
                        continue;
                    }

                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {HPP} health.");


                }
                else if (i%2!=0)
                {
                    HPG = HPG - Pesho;
                    if (HPG <= 0)
                    {
                        continue;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {HPG} health.");

                }

                if (i%3==0)
                {
                    HPP += 10;
                    HPG += 10;
                }


            }

        }
    }
}
