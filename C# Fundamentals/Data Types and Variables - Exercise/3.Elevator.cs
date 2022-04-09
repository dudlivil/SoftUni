using System;

namespace _3.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            decimal result = Math.Ceiling(people / capacity);
            if(capacity>people)
            {
                Console.WriteLine("1");
            }
            else
            {
                if (people % capacity == 0)
                {
                    Console.WriteLine(people / capacity);
                }
                else
                {
                    Console.WriteLine(result);
                }


            }
        }
    }
}
