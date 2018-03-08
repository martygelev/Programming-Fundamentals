using System;

namespace _07_Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int powder = int.Parse(Console.ReadLine());
            RaiseToPowder(number, powder);
            Console.WriteLine(RaiseToPowder(number,powder));
           
        }

         static double RaiseToPowder(double number, int powder)
        {
            double result = 0d;
            result= Math.Pow(number, powder);
            return result;
        }
    }
}
