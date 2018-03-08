using System;

namespace _03_English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            num = Math.Abs(num);
            GetLastDigit(num);
        }

        static void GetLastDigit(long num)
        {
            var lastDigit = num % 10;

            string[] array = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


            Console.WriteLine(array[lastDigit]);


        }
    }
}
