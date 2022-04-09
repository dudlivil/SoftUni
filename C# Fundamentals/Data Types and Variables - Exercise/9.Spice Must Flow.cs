using System;

namespace SpiceMustFlow
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int total = 0;
            while(yield>=100)
            {
                total += (yield - 26);
                yield -= 10;
                days++;               
            }
            if(total>26)
            {
                total -= 26;
                Console.WriteLine(days);
                Console.WriteLine(total);
            }
            else
            {
                total = 0;
                Console.WriteLine(days);
                Console.WriteLine(total);
            }
        }
    }
}