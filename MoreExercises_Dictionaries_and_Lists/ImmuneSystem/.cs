222using System;
using System.Linq;

namespace ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();

            var totalPrice = 0.0;
            var total = 0.0;
            while (input[0]!="stocked")
            {
                var product = input[0];
                var price = double.Parse(input[1]);
                var quantity = double.Parse(input[2]);
                total = price * quantity;
                    Console.WriteLine($"{product}: ${price} * {quantity} = ${total:f2}");
                totalPrice += total;
                input = Console.ReadLine().Split(' ').ToList();
                total = 0.0;
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${totalPrice:f2}");
        }
    }
}
