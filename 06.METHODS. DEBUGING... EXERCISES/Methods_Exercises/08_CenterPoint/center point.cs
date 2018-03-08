using System;

namespace _08_CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
           double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstPoint = CalculateDistanceToZero(x1, y1);
            double secondPoint = CalculateDistanceToZero(x2, y2);


            if (firstPoint>secondPoint)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (secondPoint>=firstPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
          
        }

        private static double CalculateDistanceToZero(double x, double y)
        {
            double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return result;
        }
    }
}