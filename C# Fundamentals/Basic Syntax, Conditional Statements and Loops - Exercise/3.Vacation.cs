using System;

namespace _3.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string Typeofgroup = Console.ReadLine();
            string day = Console.ReadLine();
            double priceforone = 0;
            double total = 0;
            if (Typeofgroup == "Students")
            {

                if (day == "Friday")
                {
                    priceforone += 8.45;
                }
                if (day == "Saturday")
                {
                    priceforone += 9.80;
                }
                if (day == "Sunday")
                {
                    priceforone += 10.46;
                }
                if (people >= 30)
                {
                    total = (priceforone * people);
                    total = total - (total * 15 / 100);
                }
                else
                {
                    total = priceforone * people;
                }
            }
            if (Typeofgroup == "Business")
            {

                if (day == "Friday")
                {
                    priceforone += 10.90;
                }
                if (day == "Saturday")
                {
                    priceforone += 15.60;
                }
                if (day == "Sunday")
                {
                    priceforone += 16;
                }
                if (people >= 100)
                {
                    total = (priceforone * (people-10));
                    
                }
                else
                {
                    total = priceforone * people;
                }
            }
            if (Typeofgroup == "Regular")
            {

                if (day == "Friday")
                {
                    priceforone += 15;
                }
                if (day == "Saturday")
                {
                    priceforone += 20;
                }
                if (day == "Sunday")
                {
                    priceforone += 22.50;
                }
                if (people >= 10  &&  people<=20)
                {
                    total = priceforone * people;
                    total = total - (total * 5 / 100);
                }
                else
                {
                    total = priceforone * people;
                }
            }
            Console.WriteLine("Total price: {0:F2}", total);
        }
    }
}