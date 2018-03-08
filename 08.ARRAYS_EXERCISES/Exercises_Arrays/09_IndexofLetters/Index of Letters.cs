using System;
using System.Linq;


namespace _09_IndexofLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

           var result =  word.ToCharArray();
            //#HardCoreWay
            string[] array = { "a", "b", "c", "d", "e",
                "f", "g", "h", "i", "j", "k", "l", "m", "n"
                , "o", "p", "q", "r", "s", 
                "t", "u", "v", "w", "x", "y", "z" };

            for (int z = 0; z < word.Length; z++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (word[z].ToString().Contains(array[i]))
                    {
                        Console.WriteLine($"{result[z]} -> {i}");
                    }
                   
                }
            }
          //bestway
            //char[] input = Console.ReadLine().ToCharArray();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    Console.WriteLine("{0} -> {1}", input[i], input[i] - 'a');
            //}


        }
    }
}
