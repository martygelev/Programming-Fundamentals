using System;
using System.Collections.Generic;
using System.Linq;

namespace LabStacksandQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> sequence = new Stack<string>();

            foreach (var element in input)
            {
                if (element=='(')
                {
                    sequence.Push(element.ToString());

                }

               
            }
        }
    }
}
