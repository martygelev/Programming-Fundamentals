using System;

namespace _05_Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
           double celsius =  ConversionToCelsius(degrees);
            Console.WriteLine($"{celsius:f2}");

        }

        private static double ConversionToCelsius(double degrees)
        {
            return (degrees - 32) * 5 / 9;
        }
    }
}
