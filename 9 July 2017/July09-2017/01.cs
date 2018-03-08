using System;

namespace July09_2017
{
    class Program
    {
        static void Main(string[] args)
        {
         long n = long.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int counter = 0;

            var half = n * 0.5m;
            while (n>=m)
            {
                n = n - m;
                if (half==n && y>0)
                {
						n= (int)(n / y);
                }
                counter++;
            }
            Console.WriteLine(n);
            Console.WriteLine(counter);

        }
    }
}
