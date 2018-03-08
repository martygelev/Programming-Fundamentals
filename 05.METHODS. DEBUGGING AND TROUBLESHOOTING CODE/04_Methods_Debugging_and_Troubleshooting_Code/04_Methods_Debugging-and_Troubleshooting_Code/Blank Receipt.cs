using System;

namespace _04_Methods_Debugging_and_Troubleshooting_Code
{
    class Program
    {
        static void Main()
        {
            PrintReceipt();
        }

         static void PrintReceipt()
        {
            PrintReceiptHeder();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

         static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

         static void PrintReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            char symbol = '\u00A9';
            Console.WriteLine($"{symbol} SoftUni");
        }

         static void PrintReceiptHeder()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}
