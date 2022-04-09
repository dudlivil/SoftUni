using System;

namespace TopNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n ;i++)
            {

                if(IsDivisibleby8(i) && ContainsOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

         static bool IsDivisibleby8(int number)
        {
            int sum = 0;
            while (number>0)
            {
                sum += number % 10;
                number /= 10; 
            }
            bool isDivisibleby8 = sum % 8 == 0;
            return isDivisibleby8;
        }

        static bool ContainsOddDigit(int number)
        {
            while(number>0)
            {
                int currentDigit = number % 10;
                if (currentDigit %2 ==1)
                {
                    return true;
                }
               number /= 10; 
            }
            return false;

        }
    }


}
