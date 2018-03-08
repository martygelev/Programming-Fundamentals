using System;
using System.Linq;
using System.Collections.Generic;
namespace _02_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0]!="Odd" && command[0]!="Even")
            {
                if (command[0]=="Delete")
                {
                    int num = int.Parse(command[1]);
                    numbers.RemoveAll(s=>s==num);
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);

                    numbers.Insert(position,element);
                }
                command = Console.ReadLine().Split().ToList();
            }

            if (command[0]=="Even")
            {
                numbers.RemoveAll(s=>s%2!=0);
            }
            else if (command[0]=="Odd")
            {
                numbers.RemoveAll(s=>s%2!=1);
            }

            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
