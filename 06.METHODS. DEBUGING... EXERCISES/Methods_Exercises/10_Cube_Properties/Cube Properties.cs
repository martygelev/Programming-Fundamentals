using System;

namespace _10_Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if (parameter=="face")
            {
                Console.WriteLine($"{FaceOfCube(side):f2}");
            }
            else if (parameter=="space")
            {
                Console.WriteLine($"{SpaceOfCube(side):f2}");
            }
            else if (parameter=="volume")
            {
                Console.WriteLine($"{VolumeOfCube(side):f2}");
            }
            else if (parameter=="area")
            {
                Console.WriteLine($"{AreaOfCube(side):f2}");
            }
        }

         static double  AreaOfCube(double side)
        {
            double result = 6 * (side * side);
            return result;
        }

        static double VolumeOfCube(double side)
        {
            double result = Math.Pow(side, 3);
            return result;
        }

        private static double SpaceOfCube(double side)
        {
            double result = Math.Sqrt(3 * (side * side));
            return result;
        }

        static double FaceOfCube(double side)
        {
            double result= Math.Sqrt(2 * (Math.Pow(side,2)));
            return result;  
        }
    }
}
