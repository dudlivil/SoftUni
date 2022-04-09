using System;

namespace AddSubstract
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = Sum(a, b);
            int result= Substract(c, sum);
            Console.WriteLine(result);
        }

         static int Substract(int c, int sum)
        {
            int result = sum - c;
            return result;
        }

        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}
