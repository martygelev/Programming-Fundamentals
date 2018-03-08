using System;
using System.Linq;

namespace _08_Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type =="int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
               int max= GetMax(firstNumber, secondNumber);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char firstNumber = char.Parse(Console.ReadLine());
                char secondNumber = char.Parse(Console.ReadLine());
               char max =   GetMax(firstNumber, secondNumber);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string bigger =  GetMaxString(firstString, secondString);
                Console.WriteLine(bigger);
            }
        }

     static string GetMaxString(string firstString, string secondString)
        {
            string max;
            if (firstString.CompareTo(secondString)>=0)
            {
                max = firstString;
            }
            else
            {
                max = secondString;
            }
            return max;


        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            int bigger = 0;
            if (firstNumber>=secondNumber)
            {
                 bigger = firstNumber; 
            }
            else
            {
                bigger = secondNumber;
            }
            return bigger;
        }
        static char GetMax(char firstNumber,char secondNumber)
        {
            int bigger = 0;
            if (firstNumber >=secondNumber)
            {
                bigger = firstNumber;
            }
            else
            {
                bigger = secondNumber;
            }

            return (char)bigger;
        }
    }
}
