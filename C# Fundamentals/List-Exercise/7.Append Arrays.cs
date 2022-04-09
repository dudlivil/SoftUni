using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split("|");
            Array.Reverse(input);
            string reversedString= string.Join(" ", input);
            string[] lastToPrint = reversedString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(" " ,lastToPrint));
        }

    }
}

