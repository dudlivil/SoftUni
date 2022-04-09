using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string action = input[0];
                if(action=="register")
                {
                    string username = input[1];
                    string licencePlateNumber = input[2];
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, licencePlateNumber);
                        Console.WriteLine($"{username} registered {licencePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licencePlateNumber}");
                    }
                }
                else if(action=="unregister")
                {
                    string username = input[1];
                    if (!users.ContainsKey(username))
                    {

                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {

                        users.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }

                }
            }
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
