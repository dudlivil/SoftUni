using System;

namespace WaterOverFlow
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if(capacity-liters<0)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    capacity -= liters;
                    sum += liters;
                }
            }
            Console.WriteLine($"{sum}");
        }
    }
}