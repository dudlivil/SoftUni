using System;

namespace _4.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
