using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while(command!="end")
            {
                string[] newCommand = command.Split();
                if (newCommand[0] == "Delete")
                {
                    Delete(numbers,newCommand);
                }
                else
                {
                    Insert(numbers, newCommand);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));


        }

         static List<int> Insert(List<int> numbers, string[] newCommand)
        {
            int numberTobeAdded= int.Parse(newCommand[1]);
            int index = int.Parse(newCommand[2]);
            numbers.Insert(index, numberTobeAdded);
            return numbers;

        }

        static List<int> Delete(List<int> numbers, string[] newCommand)
        {
            int numberTobeDeleted = int.Parse(newCommand[1]);
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i]==numberTobeDeleted)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            return numbers;
        }
    }
}
