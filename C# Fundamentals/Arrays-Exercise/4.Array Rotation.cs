using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());
            for (int j = 0; j < rotation; j++)
            {

            
                int FirstNumber = input[0];
                for (int i = 0; i < input.Length-1; i++)
                {
                    input[i] = input[i + 1];
                }
                input[input.Length - 1] = FirstNumber;
            }
            Console.WriteLine(string.Join(" ", input));
        }


    }
}
