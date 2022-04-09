using System;
using System.Linq;

namespace _5.Login
{
    class Program
    {
        static void Main(string[] args)
        {

            string username = Console.ReadLine();
            string password = string.Join("", username.Reverse());

            for (int i = 0; i < 4; i++)
            {
                string inputpassword = Console.ReadLine();
                if( inputpassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                if(i==3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                if (inputpassword != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }


        }
    }
}

