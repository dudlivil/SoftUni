using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while(command !="end")
            {
                string[] input = command.Split(" : ");
                string courseName = input[0];
                string student = input[1];
                if(!courses.ContainsKey(courseName))
                {

                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(student);

                command = Console.ReadLine();
            }
            foreach (var item in courses.OrderByDescending(x=> x.Value.Count()))              
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count()}");
                foreach (var name in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {name}");
                }


            }
        }
    }
}
