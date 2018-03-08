using System;

namespace _04_Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintHeaderRow(number);
            PrintMiddleRow(number);
            PrintHeaderRow(number);

        }

        private static void PrintMiddleRow(int number)
        {
            for (int i = 0; i < number-2; i++)
            {
                Console.Write('-');
                for (int z = 1; z < number; z++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
           
           


        }

        private static void PrintHeaderRow(int number)
        {
            Console.WriteLine(new string('-',2*number));
        }
    }
}
