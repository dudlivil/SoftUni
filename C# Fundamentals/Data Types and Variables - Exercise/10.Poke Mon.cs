using System;

namespace PokeMon
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int pokeCount = 0;
            int originalValue = pokePower;
            while (pokePower >= distance)
            {
                pokePower -= distance;
                pokeCount++;
                if(pokePower==originalValue*0.5 && exhaustionFactorY!=0)
                {
                    pokePower /= exhaustionFactorY;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCount);
        }
    }
}