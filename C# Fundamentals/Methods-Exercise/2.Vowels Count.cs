using System;
using System.Linq;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToLower().ToCharArray();

            VowelsCheck(input);
        }

        private static void VowelsCheck(char[] vhod)
        {

            int sum = 0;
            for (int i = 0; i < vhod.Length; i++)
            {
                if (vhod[i] == 'a' || vhod[i] =='o'|| vhod[i] == 'e' || vhod[i] == 'u' || vhod[i] == 'i')
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }

}
