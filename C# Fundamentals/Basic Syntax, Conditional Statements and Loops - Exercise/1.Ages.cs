using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        if (age >= 0 && age <= 2)
        {
            Console.WriteLine("baby");
        }
        if (age >= 3 && age <= 13)
        {
            Console.WriteLine("child");
        }
        if (age >= 14 && age <= 19)
        {
            Console.WriteLine("teenager");
        }
        if (age >= 20 && age <= 65)
        {
            Console.WriteLine("adult");
        }
        if (age >= 66)
        {
            Console.WriteLine("elder");
        }
    }
}
