using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10
{
    class Program
    {
        static void Main(string[] args)
        {
            string singer;
            string venue;
            int price = 0;
            int tickets = 0;
            int income = 0;
            List<string> input = Console.ReadLine().Split(' ').ToList();

            Dictionary<string, Dictionary<string, int>> concerts = new Dictionary<string, Dictionary<string, int>>();
            while (input[0] != "End")
            {
                if (!IsValid(input))
                {
                    input = Console.ReadLine().Split(' ').ToList();
                    continue;
                }
                int currentMember = 0;
                List<string> thisSinger = new List<string>();
                while (!input[currentMember].StartsWith("@"))
                {
                    thisSinger.Add(input[currentMember]);
                    currentMember++;
                }
                singer = string.Join(" ", thisSinger);
                List<string> thisVenue = new List<string>();
                for (int i = currentMember; i < input.Count - 2; i++)
                {
                    thisVenue.Add(input[i]);
                }
                venue = string.Join(" ", thisVenue);
                venue = venue.Remove(0, 1);
                price = int.Parse(input[input.Count - 2]);
                tickets = int.Parse(input[input.Count - 1]);
                income = price * tickets;
                if (!concerts.ContainsKey(venue))
                {
                    Dictionary<string, int> currentSinger = new Dictionary<string, int>();
                    currentSinger.Add(singer, income);
                    concerts.Add(venue, currentSinger);
                }
                else
                {
                    if (!concerts[venue].ContainsKey(singer))
                    {
                        concerts[venue].Add(singer, income);
                    }
                    else
                    {
                        concerts[venue][singer] += income;
                    }
                }
                input = Console.ReadLine().Split(' ').ToList();
            }

            foreach (var pair in concerts)
            {
                Console.WriteLine($"{pair.Key}");
                foreach (var performer in pair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {performer.Key} -> {performer.Value}");
                }
            }

        }



        static bool IsValid(List<string> input)
        {
            bool hasAValidVenue = false;
            int indexOfVenueStart = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].StartsWith("@"))
                {
                    hasAValidVenue = true;
                    indexOfVenueStart = i;
                    break;
                }

            }

            if (hasAValidVenue == false)
            {
                return false;
            }

            if (indexOfVenueStart < 1 || indexOfVenueStart > 3)
            {
                return false;
            }
            if (indexOfVenueStart > input.Count - 3 || indexOfVenueStart < input.Count - 5)
            {
                return false;
            }
            try
            {
                int.Parse(input[input.Count - 2]);
                int.Parse(input[input.Count - 1]);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
