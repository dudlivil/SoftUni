using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGames
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> fristPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while (true)
            {
                if(fristPlayerCards[0]> secondPlayerCards[0])
                {

                    fristPlayerCards.Add(fristPlayerCards[0]);
                    fristPlayerCards.Add(secondPlayerCards[0]);
                }
                if (fristPlayerCards[0] < secondPlayerCards[0])
                {
                    secondPlayerCards.Add(secondPlayerCards[0]);
                    secondPlayerCards.Add(fristPlayerCards[0]);
                }
                fristPlayerCards.RemoveAt(0);
                secondPlayerCards.RemoveAt(0);

                if(fristPlayerCards.Count==0)
                {
                    sum = secondPlayerCards.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                if (secondPlayerCards.Count == 0)
                {
                    sum = fristPlayerCards.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}

