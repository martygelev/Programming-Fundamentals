using System;

namespace Array_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (dayNumber>=1&&dayNumber<=7)
            {
                Console.WriteLine(daysOfWeek[dayNumber-1]);
            }
            else
            {

            Console.WriteLine("Invalid Day!");
            }

        }
    }
}
