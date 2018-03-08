using System;

namespace _11._Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
             int n = int.Parse(Console.ReadLine());

            while (n % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 1)
                {
                    Console.WriteLine("The number is: {0}", n);
                    return;
                }
            }
            if (n < 0)
            {
                Console.WriteLine("The number is: {0}", -n);
                return;

            }
            Console.WriteLine("The number is: {0}", n);


        }
    }
}
