using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());
            int capacityTrack = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            long maxRunners = days * capacityTrack;

            if (maxRunners > runners)
            {
                maxRunners = runners;
            }

            long totalMeters = maxRunners * laps * trackLength;
            double totalKilometers = totalMeters / 1000.0;

            double money = totalKilometers * moneyPerKm;

            Console.WriteLine($"Money raised: {money:f2}");

        }
    }
}
