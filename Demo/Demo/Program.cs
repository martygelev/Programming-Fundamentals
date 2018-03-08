using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int maxsnow = 0;
        int maxtime = 0;
        long maxqua = 0;
        BigInteger maxvalue = -9999999999999;

       
        for (int i = 0; i < n; i++)
        {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

            if (snowballValue>maxvalue)
            {
                maxvalue = snowballValue;
                maxsnow = snowballSnow;
                maxtime = snowballTime;
                maxqua = snowballQuality;
            }
        }
        Console.WriteLine($"{maxsnow} : {maxtime} = {maxvalue} ({maxqua})");
    }
}
