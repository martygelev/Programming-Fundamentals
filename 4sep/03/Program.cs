using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string pattern = @"^([^\s_]{3}\.)+([^\s_]{3})*$";

        Regex regex = new Regex(pattern);

        string input = Console.ReadLine();

        while (input != "ReadMe")
        {
            if (regex.IsMatch(input) || input.Length == 3)
            {
                bool isPalindrome = true;

                for (int i = 0; i < input.Length / 2; i++)
                {
                    if (input[i] != input[input.Length - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }

                }

                if (isPalindrome)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                    input = Console.ReadLine();
                    continue;
                }
            }
            else
            {
                Console.WriteLine("NO");
            }

            input = Console.ReadLine();
        }
    }
}
