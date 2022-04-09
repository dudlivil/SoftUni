using System;

namespace _1IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            var result = ((a + b) / c) * d;
            Console.WriteLine(result);
        }
    }
}
