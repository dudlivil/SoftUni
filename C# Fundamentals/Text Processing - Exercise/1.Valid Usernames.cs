using System;
using System.Linq;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in input)
            {
                if (item.Length < 3 || item.Length>16)
                {

                    continue;
                }

                bool isValid = false;
                foreach (var currentSymbol in item)
                {
                    if (!(char.IsDigit(currentSymbol) || char.IsLetter(currentSymbol) || currentSymbol == '_' || currentSymbol == '-'))
                    {

                        isValid = false;
                        break;

                    }
                    isValid = true;
                }
                if(isValid)
                {

                    Console.WriteLine(item);
                }

            }

        }
    }
}
