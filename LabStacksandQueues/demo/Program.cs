using System;
using System.Collections.Generic;
using System.Text;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int dif1 = int.Parse(Console.ReadLine());
            int dif2 = int.Parse(Console.ReadLine());

            string start = num1.ToString();
            string start2 = num2.ToString();
            string startNumber = start + start2;

            // startValue
            int startValue = int.Parse(startNumber);

            int endf = num1 + dif1;
            int endfinish = num2 + dif2;

            string endnum = endf.ToString();
            string endnum2 = endfinish.ToString();

            string endVal = endnum + endnum2;

            int endValue = int.Parse(endVal);

            bool prime = true;
            int count = 2;
            for (int i = startValue; i <= endValue; i++)
            {
                int sqrtOfNumber = (int)Math.Sqrt(i); 
                while (prime && count <= sqrtOfNumber)
                {
                    if (i % count == 0)
                    {
                        prime = false;
                    }

                    count++;

                }
                if (prime == true && i > 1)
                {
                    Console.WriteLine(i);
                }
                else if (prime == true)
                {
                    continue;
                }
            }

        }
    }
}
