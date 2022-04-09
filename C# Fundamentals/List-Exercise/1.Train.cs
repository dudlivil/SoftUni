using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int maxCapacityPerWagon = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while(command!="end")
            {
                string[] newcommand = command.Split();
                if(newcommand.Length==2)
                {
                    int addWagonsToList = int.Parse(newcommand[1]);
                    wagons.Add(addWagonsToList);
                }
                else 
                {
                    int AddpeopleToWagons = int.Parse(command);
                    for (int i = 0; i < wagons.Count; i++)
                    {

                        if(wagons[i]+ AddpeopleToWagons <=maxCapacityPerWagon)
                        {
                            wagons[i] += AddpeopleToWagons;
                            break;
                        }
                        
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}
