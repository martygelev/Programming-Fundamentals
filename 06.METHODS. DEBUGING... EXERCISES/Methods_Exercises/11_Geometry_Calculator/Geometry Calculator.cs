using System;

namespace _11_Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double side = 0;
            double height = 0;

            if (figure=="triangle")
            {
               double result =  TriangleAreaResult(side,height);
                Console.WriteLine($"{result:f2}");
            }
            else if (figure =="rectangle")
            {
                double result = RectangleAreResult(side, height);
                Console.WriteLine($"{result:f2}");
            }
            else if (figure=="square")
            {
                double result = SquareAreaResult(side);
                Console.WriteLine($"{result:f2}");
            }
            else if (figure == "circle")
            {
                double result = CircleAreaResult(side);
                Console.WriteLine($"{result:f2}");
            }
        }

        private static double CircleAreaResult(double side)
        {
            side = double.Parse(Console.ReadLine());
            double area = Math.PI * side * side;
            return area;
        }

        static double SquareAreaResult(double side)
        {
            side = double.Parse(Console.ReadLine());
            double area = side * side;
            return area;
        }

        static double RectangleAreResult(double side, double height)
        {

            side = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            double area = side * height ;
            return area;
        }

        static double TriangleAreaResult(double side,double height)
        {
            side = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            double area = side * height/2;
            return area;

        }
    }
}
