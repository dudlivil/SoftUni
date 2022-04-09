using System;
using System.Linq;

namespace _9.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            int freebelts = studentsCount / 6;
            var a = lightsabersPrice * (studentsCount + Math.Ceiling(studentsCount * 0.1));
            var b = (robesPrice * studentsCount);
            var c= beltsPrice * (studentsCount - freebelts);
            double calcullatedPrice = a + b + c;

            if(amountMoney>=calcullatedPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {calcullatedPrice:F2}lv.");
            }
           else
            {
                Console.WriteLine($"John will need {(calcullatedPrice-amountMoney):F2}lv more.");
            }
            
        }
    }
}
