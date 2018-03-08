using System;
using System.Linq;
using System.Collections.Generic;
namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> nameHand = new Dictionary<string, List<string>>();
            List<string> cards = new List<string>();

            string[] input = Console.ReadLine().Split(new char[] { ':' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            int sum = 0;
            while (input[0]!="JOKER")
            {
                var name = input[0];
                 cards = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                cards=cards.Distinct().ToList();
                if (!nameHand.ContainsKey(name))
                {
                    nameHand.Add(name,cards);
                }
                else
                {
                    nameHand[name].AddRange(cards);
                    nameHand[name]=nameHand[name].Distinct().ToList();
                }
                input = Console.ReadLine().Split(new char[] { ':' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            int mainValue = 0;
            int type = 0;

            foreach (var pair in nameHand)
            {
                foreach (var card in pair.Value)
                {
                    switch (card[card.Length-1])
                    {
                        case 'S': type = 4; break;
                        case 'H': type = 3; break;
                        case 'D': type = 2; break;
                        case 'C': type = 1; break;

                    }
                    string power = card.Remove(card.Length - 1, 1);

                    switch (power)
                    {
                        case "J": mainValue = 11; break;
                        case "Q": mainValue = 12; break;
                        case "K": mainValue = 13; break;
                        case "A": mainValue = 14; break;
                        
                        default: mainValue = int.Parse(power);
                            break;
                    
                    }

                    sum += type * mainValue;
                }
                Console.WriteLine($"{pair.Key}: {sum}");
                sum = 0;
            }
           

        }
    }
}
