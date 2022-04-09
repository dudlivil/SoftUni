using System;
using System.Linq;

namespace CharectersRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char a1 = char.Parse(Console.ReadLine());
            char a2 = char.Parse(Console.ReadLine());

            CharRange(a1, a2);
        }

        private static void CharRange(char a1, char a2)
        {
            int start = (int)Convert.ToChar(a1);
            int end = (int)Convert.ToChar(a2);
            if (start < end)
            { 
                for (int i = start + 1; i < end; i++)
                {
                    Console.Write((char)i + " ");

                }
            }
            else
            {
                for (int i = end + 1; i < start; i++)
                {
                    Console.Write((char)i + " ");

                }
            }
        }
    }

}
