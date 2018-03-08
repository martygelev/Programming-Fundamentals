using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaber = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double roundedLightsaber = Math.Ceiling(students+ students * 0.1);
            double freeBelt = students / 6;

            double totalPrice = lightsaber * roundedLightsaber + robes * students + belts * (students - freeBelt);

            if (totalPrice>amountMoney)
            {
                Console.WriteLine($"Ivan Cho will need {(totalPrice-amountMoney):f2}lv more.");
            }
            else if (totalPrice<=amountMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
        }
    }
}
