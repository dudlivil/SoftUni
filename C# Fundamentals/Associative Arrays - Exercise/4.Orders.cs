using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Program
    {
        public static void Main()
        {
            Dictionary<string, double[]> shoppingList = new Dictionary<string, double[]>();
            string command = Console.ReadLine();
            while (command != "buy")
            {
                string[] input = command.Split();
                string item = input[0];
                double prize = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);
                if (!shoppingList.ContainsKey(item))
                {
                    shoppingList.Add(item, new double[2]);
                }
                double previousQty = shoppingList[item][1];
                double[] prizeQty = new double[] { prize, previousQty+quantity };
                shoppingList[item] = prizeQty;
                command = Console.ReadLine();
            }
            foreach (var productKVP in shoppingList)
            {
                double totalPrize = productKVP.Value[0] * productKVP.Value[1];
                Console.WriteLine($"{productKVP.Key} -> {totalPrize:F2}");

            }
        }
    }
}
