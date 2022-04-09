using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            while(command!="End")
            {
                string[] input = command.Split(" -> ");
                string companyName = input[0];
                string employeeID = input[1];
                if(!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }
                if(!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }

                command = Console.ReadLine();
            }
            foreach (var item in companies.OrderBy(x => x.Key)) 
            {
                Console.WriteLine($"{item.Key}");
                foreach (var ID in item.Value)
                {
                    Console.WriteLine($"-- {ID}");
                }
            }
        }
    }
}
