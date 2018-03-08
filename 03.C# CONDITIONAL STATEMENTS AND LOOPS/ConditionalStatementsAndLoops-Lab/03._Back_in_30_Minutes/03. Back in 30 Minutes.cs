using System;

namespace _03._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            m += 30;


            if (m >= 59)
            {
                h++;
                m -= 60;
            }
            if (h > 23)
            {
                h = 0;
            }
            Console.WriteLine($"{h}:{m:d2}");
        }
    }
}
