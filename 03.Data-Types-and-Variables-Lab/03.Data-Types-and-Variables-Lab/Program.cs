using System;

namespace _03.Data_Types_and_Variables_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool specialNumber = false;


            for (int i = 1; i <=number; i++)
            {
                int sum = 0;
                int n = i;


                while (n > 0)
                {
                    int digit = n % 10;
                    sum +=digit;
                    n /= 10;
                }

               
                if (sum==5 || sum==7 || sum==11)
                {
                    specialNumber = true;
                }
                Console.WriteLine($"{i} -> {specialNumber}");
            }

        }
    }
}
