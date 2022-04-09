using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<double>> register = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());
                if(!register.ContainsKey(studentName))
                {
                    register.Add(studentName, new List<double>());
                }
                register[studentName].Add(studentGrade);

            }
            foreach (var item in register.OrderByDescending(x => x.Value.Average())) 
            {
                if(item.Value.Average() >=4.5)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():F2}");

                }
            }
        }
    }
}
