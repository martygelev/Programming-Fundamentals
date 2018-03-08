using System;

namespace _03_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintLineTop(number);
            PrintLineBot(number);
        }

        private static void PrintLineBot(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int z = 1; z <=  number-i; z++)
                {
                    Console.Write(z + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintLineTop(int number)
        {
            for (int rows = 1; rows <= number; rows++)
            {
                for (int cols =1 ; cols <= rows; cols++)
                {
                    Console.Write(cols + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
