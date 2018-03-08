using System;
using System.Linq;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(GetReversedNumber(number));
        }

         static double GetReversedNumber(double number)
        {
            return double.Parse(ReversingArray(number.ToString()));
        }

         static string ReversingArray(string v)
        {
            char[] arr = v.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
