using System;

namespace _05_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int total = FibbonacciNumbers(num);
            Console.WriteLine(total);
        }

         static int FibbonacciNumbers(int num)
        {
            int firstNum = 0;
            int secondNum = 1;
            for (int i = 0; i < num; i++)
            {
                int temp = firstNum;
                firstNum = secondNum;
                secondNum = temp + secondNum;

            }
            return secondNum;
        }
    }
}
