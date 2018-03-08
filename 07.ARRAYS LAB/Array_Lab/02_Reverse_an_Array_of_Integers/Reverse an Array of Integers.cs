using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int[] arr = new int[number];
        int[] srr = new int[number];
       
        for (int i = 0; i <number; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());

        }
        for (int j = 0; j <number; j++)
        {
            srr[j] = arr[arr.Length - 1 - j];
        }
        Console.WriteLine(string.Join(" ",srr));
    }
}

