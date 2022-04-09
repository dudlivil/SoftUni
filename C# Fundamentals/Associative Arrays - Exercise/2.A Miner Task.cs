using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> mine = new Dictionary<string, decimal>();
            string userInput = Console.ReadLine();

            while (userInput != "stop")
            {
                decimal amount = decimal.Parse(Console.ReadLine());

                if (mine.ContainsKey(userInput))
                {
                    mine[userInput] += amount;
                }

                else
                {
                    mine[userInput] = amount;
                }

                userInput = Console.ReadLine();
            }
 
            foreach (string key in mine.Keys)
            {
                Console.WriteLine($"{key} -> {mine[key]}");
            }
        }
    }
}