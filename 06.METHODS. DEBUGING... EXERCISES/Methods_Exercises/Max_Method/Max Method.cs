using System;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

           int biggest =  GetMaxNumber(num1,num2,num3);
            Console.WriteLine(biggest);

        }

        static int GetMaxNumber(int num1, int num2, int num3)
        {
            var first = Math.Max(num1, num2);
            var second = Math.Max(num2, num3);
            var third = Math.Max(first, second);
            return third;
        }
    }
}
