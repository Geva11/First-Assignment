using System;

namespace First_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter username: ");
            String username = Console.ReadLine();
            Console.Write("Enter password: ");
            String password = Console.ReadLine();
            if (username == "Admin" && password == "Admin1234!")
            {
                Console.WriteLine("You've Login Successfully!");
            }
            else
            {
                Console.WriteLine("\nIncorrect Password or Username. Try Again.");
                Console.WriteLine("You have 3 attempts");
                Console.WriteLine("(3 attempts left)");
                Console.Write("\nEnter username: ");
                username = Console.ReadLine();
                Console.Write("Enter password: ");
                password = Console.ReadLine();
                if (username == "Admin" && password == "Admin1234!")
                {
                    Console.WriteLine("You've Login Successfully!");
                }
                else
                {
                    Console.WriteLine("\nIncorrect Password or Username. Try Again.");
                    Console.WriteLine("(2 attempts left)");

                    Console.Write("\nEnter username: ");
                    username = Console.ReadLine();
                    Console.Write("Enter password: ");
                    password = Console.ReadLine();
                    if (username == "Admin" && password == "Admin1234!")
                    {
                        Console.WriteLine("You've Login Successfully!");
                    }
                    else
                    {
                        Console.WriteLine("\nIncorrect Password or Username. Try Again.");
                        Console.WriteLine("(1 attempt left)");

                        Console.Write("\nEnter username: ");
                        username = Console.ReadLine();
                        Console.Write("Enter password: ");
                        password = Console.ReadLine();
                        if (username == "Admin" && password == "Admin1234!")
                        {
                            Console.WriteLine("You've Login Successfully!");
                        }
                        else
                        {
                            Console.WriteLine("\nIncorrect Password or Username");
                            Console.WriteLine("Account locked. Try again after a minute.");
                        }
                    }
                }
            }
        }
    }
}

