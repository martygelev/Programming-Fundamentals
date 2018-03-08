using System;
using System.Linq;
using System.Collections.Generic;

namespace _05_ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<string> commands = Console.ReadLine().Split(' ').ToList();

            while (commands[0]!="print")
            {
                if (commands[0] == "add")
                {
                    int index = int.Parse(commands[1]);
                    int element = int.Parse(commands[2]);
                    numbers.Insert(index, element);
                }
                else if (commands[0]=="addMany")
                {
                    int index = int.Parse(commands[1]);

                    List<string> jelper = commands.Skip(2).ToList(); 

                    numbers.InsertRange(index,jelper.Select(int.Parse));

                }
                else if (commands[0] == "contains")
                {
                    int index = int.Parse(commands[1]);

                    if (numbers.Contains(index))
                    {
                        Console.WriteLine(numbers.IndexOf(index));
                    }
                    else
                    {
                    Console.WriteLine(-1);
                    }
                }
                else if (commands[0]=="remove")
                {
                    int index = int.Parse(commands[1]);
                    numbers.RemoveAt(index);
                }
                else if (commands[0]=="shift")
                {
                    int position = int.Parse(commands[1]) % numbers.Count();
                    var helper = numbers.Skip(position).ToList();
                    for (int i = 0; i < position; i++)
                    {
                        helper.Add(numbers[i]);
                    }
                    numbers = helper;

                }
                else if (commands[0]=="sumPairs")
                {
                    int c = numbers.Count() / 2;
                    for (int i = 0; i < c; i++)
                    {
                        numbers[i] += numbers[i + 1];
                        numbers.RemoveAt(i+1);
                    }
                }
                commands = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine("["+ string.Join(", ",numbers) + "]");
        }
    }
}
