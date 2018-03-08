using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] indexesWithBugs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];
            for (int i = 0; i < fieldSize; i++)
            {
                if (indexesWithBugs.Contains(i))
                {
                    field[i] = 1;
                }
                else
                {
                    field[i] = 0;
                }
            }

            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "end")
            {
                int index = int.Parse(command[0]);
                int moving = int.Parse(command[2]);

                if (index < 0 || index >= field.Length)
                {
                    command = Console.ReadLine().Split();
                    continue;
                }

                else if (field[index] == 0)
                {
                    command = Console.ReadLine().Split();
                    continue;
                }

                else if (field[index] == 1)
                {
                    if (command[1] == "right")
                    {
                        index = int.Parse(command[0]);
                        moving = int.Parse(command[2]);

                        if (moving > 0)
                        {
                            MoveRight(field, index, moving);
                        }

                        else if (moving < 0)
                        {
                            MoveLeft(field, index, Math.Abs(moving));
                        }

                    }
                    else if (command[1] == "left")
                    {

                        if (moving > 0)
                        {
                            MoveLeft(field, index, moving);
                        }

                        else if (moving < 0)
                        {
                            MoveRight(field, index, Math.Abs(moving));
                        }
                    }
                    command = Console.ReadLine().Split(' ').ToArray();
                }
            }

            Console.WriteLine(string.Join(" ", field));

        }
        static void MoveRight(int[] field, int index, int moving)
        {

            if (index + moving >= field.Length)
            {
                field[index] = 0;
            }
            else
            {
                field[index] = 0;
                for (int i = index + moving; i < field.Length; i += moving)
                {
                    if (field[i] == 1)
                    {
                        continue;
                    }

                    else
                    {
                        field[i] = 1;
                        break;
                    }
                }
            }
            return;


        }
        static void MoveLeft(int[] field, int index, int moving)
        {

            if (index - moving < 0)
            {
                field[index] = 0;
            }
            else
            {
                field[index] = 0;

                for (int i = index - moving; i > -1; i -= moving)
                {

                    if (field[i] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[i] = 1;
                        break;
                    }
                }
            }
            return;
        }

    }
}