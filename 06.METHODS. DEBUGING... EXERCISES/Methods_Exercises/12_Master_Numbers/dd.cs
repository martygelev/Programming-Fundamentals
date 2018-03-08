using System;
using System.Linq;

namespace _12_Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <number ; i++)
            {
                if (IsPalindrom(i) && SumOfDigits(i)&& ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

         static bool ContainsEvenDigit(int number)
        {
            string digit = number.ToString();
            bool even = false;
            for (int i = 0; i <digit.Length; i++)
            {
                if (digit[i]%2==0)
                {
                    even = true;
                }

            }
            return even;
        }

         static bool SumOfDigits(int numb)
        {
            bool devisible = false;
            int sum = 0;

           while (numb>0)
            {
                sum += numb % 10;
                numb /= 10;
            }
            if (sum%7==0)
            {
                devisible = true;
            }
            return devisible;
        }

         static bool IsPalindrom(int number)
        {
            string n = number.ToString();
            bool palindrom = false;
            for (int i = 0; i <= n.Length/2; i++)
            {
                if (n[i] != n[n.Length - 1 - i])
                {
                    palindrom = false;
                    break;
                }
                else
                {
                    palindrom = true;

                }
            }
            return palindrom;
        }
    }
}
