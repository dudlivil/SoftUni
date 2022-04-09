using System;

namespace Snowballs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double snowballValue = 0;
            double biggestsnowballValue = 0;
            int biggestsnowballSnow = 0;
            int bestsnowballTime = 0;
            int bestsnowballQuality = 0;
            for (int i = 0; i < n; i++)
            {

                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                snowballValue = Math.Pow((snowballSnow / snowballTime), snowballQuality);
                if(snowballValue>=biggestsnowballValue)
                {
                    biggestsnowballValue = snowballValue;
                    biggestsnowballSnow = snowballSnow;
                    bestsnowballTime = snowballTime;
                    bestsnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{biggestsnowballSnow} : { bestsnowballTime} = { biggestsnowballValue} ({ bestsnowballQuality})");
        }
    }
}