namespace test01
{
    using System;

    class MainClass
    {
        public static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            if (num >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
