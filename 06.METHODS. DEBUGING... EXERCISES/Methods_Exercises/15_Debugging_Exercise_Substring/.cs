using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

         char search = 'p';
        bool hasMatch = false;

        for (int i = 0; i <= text.Length; i++)
        {
            if (text[i] == search)
            {
                hasMatch = true;

                int endIndex = jump;

                if (jump + i + 1 > text.Length)
                {
                    string matchedString = text.Substring(i);
                    Console.WriteLine(matchedString);
                }
                else
                {
                    Console.WriteLine(text.Substring(i,jump+1));
                }
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
