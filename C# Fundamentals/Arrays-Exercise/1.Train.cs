using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine(string.Join(" ",array));
            Console.WriteLine(sum);
        }
    }
}
