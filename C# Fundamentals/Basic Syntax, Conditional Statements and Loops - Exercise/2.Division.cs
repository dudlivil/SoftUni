using System;

namespace _02.Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int divisinionNumber = 0;
            if (inputNumber %10==0)
            {
                divisinionNumber = 10;
            }
            else if(inputNumber %7 ==0)
            {
                divisinionNumber = 7;
            }
            else if (inputNumber % 6 == 0)
            {
                divisinionNumber = 6;
            }
            else if (inputNumber % 3 == 0)
            {
                divisinionNumber = 3;
            }
            else if (inputNumber % 2 == 0)
            {
                divisinionNumber = 2;
            }
            if(divisinionNumber==0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {divisinionNumber}");
            }
        }
    }
}
