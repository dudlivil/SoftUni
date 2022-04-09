using System;
using System.Collections.Generic;
using System.Linq;

namespace CountChars_in_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string vhod = string.Join("",input);
            char[] omg = vhod.ToCharArray();
            var counts = new Dictionary<char, int>();
            foreach (var item in omg)
            {
                if(counts.ContainsKey(item))
                {

                    counts[item]++;
                        
                }
                else
                {
                    counts[item] = 1;
                }

            }
            foreach (var item in counts)
            {

                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }

    }
}
