using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                string name = command[0];
                if (command.Length == 3)
                {
                    if (!guestList.Contains(name))
                    {
                        guestList.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }

            }
            foreach (var guest in guestList)
            {
                Console.WriteLine(guest);
            }

        }


    }
}
