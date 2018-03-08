using System;

namespace _09_Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstPoint = CalculateDistanceToZero(x1, y1);
            double secondPoint = CalculateDistanceToZero(x2, y2);
            double thirdPoint = CalculateDistanceToZero(x3, y3);
            double fourthPoint = CalculateDistanceToZero(x4, y4);


            double firstLine = CalculateLine(firstPoint, secondPoint);
            double secondLine = CalculateLine(thirdPoint, fourthPoint);

           

            if (firstLine > secondLine)
            {
                if (firstPoint > secondPoint)
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else if (secondPoint >= firstPoint)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }
            else if (secondLine >= firstLine)
            {
                if (thirdPoint > fourthPoint)
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else if (fourthPoint >= thirdPoint)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
               
            }
           


        }

        static double CalculateLine(double z, double h)
        {
            double result = Math.Pow(z,2) + Math.Pow(h,2);
            return result;
        }

        private static double CalculateDistanceToZero(double x, double y)
        {
            double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return result;
        }
    }
}
