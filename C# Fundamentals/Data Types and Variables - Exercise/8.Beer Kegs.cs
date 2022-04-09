using System;

namespace BeersKegs
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double maxVolume = 0;
            double volume = 0;
            string largestKeg = string.Empty;
            double largestVolume = 0;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > largestVolume)
                {
                    largestVolume = volume;
                    largestKeg = model;
                }

            }
            Console.WriteLine(largestKeg);
        }
    }
}