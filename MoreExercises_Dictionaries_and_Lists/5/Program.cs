using System;
using System.Collections.Generic;
using System.Linq;
namespace _5
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                var user = input[1];

                switch (input[0])
                {
                    case "register":
                        var plate = input[2];
                        if (data.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plate}");
                        }
                        else if (IsInvalidLicense(plate))
                        {
                            Console.WriteLine($"ERROR: invalid license plate {plate}");
                        }
                        else if (data.ContainsValue(plate))
                        {
                            Console.WriteLine($"ERROR: license plate {plate} is busy");
                        }
                        else
                        {
                            data[user] = plate;
                            Console.WriteLine($"{user} registered {plate} successfully");
                        }
                        break;
                    case "unregister":
                        if (!data.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }
                        else
                        {
                            data.Remove(user);
                            Console.WriteLine($"user {user} unregistered successfully");
                        }
                        break;

                }
            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }

        public static bool IsInvalidLicense(string license)
        {
            if (license.Length != 8)
            {
                return true;
            }
            for (int i = 2; i < license.Length - 2; i++)
            {
                if (!int.TryParse(license[i].ToString(), out int result))
                {
                    return true;
                }
            }
            if (license[0] < 65 || license[0] > 90) return true;
            if (license[1] < 65 || license[1] > 90) return true;
            if (license[6] < 65 || license[6] > 90) return true;
            if (license[7] < 65 || license[7] > 90) return true;
            return false;
        }
    }
}

        
        