using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> seq = Console.ReadLine().Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int index = int.Parse(Console.ReadLine());

            var counter = 1;

            string command = Console.ReadLine();

            while (command!="Supernova")
            {
                string[] read = command.Split(' ').ToArray();

                string direction = read[0];
                int position = int.Parse(read[1]);

                switch (direction)
                {
                    case"left":

                        for (int i = 1; i <= position; i++)
                        {
                            if (index<=0)
                            {
                                counter++;
                                index = seq.Count();
                            }
                            seq[index - 1] -= counter;
                            index--;

                        }
                        break;

                    case"right":
                        for (int i = 1; i <= position; i++)
                        {
                            if (index >= seq.Count()-1)
                            {
                                counter++;
                                index = -1;
                            }
                            seq[index + 1] -= counter;
                            index++;

                        }
                       
                        break;

                    
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",seq));
        }
    }
}
