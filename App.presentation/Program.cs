using System;
using System.ComponentModel;

namespace App.presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("############### Welcome to Akash Bank ##################");
            Console.WriteLine("Enter your credentials:");

            string username = null, password = null;

            Console.Write("Username:");
             username = System.Console.ReadLine();

            if(username != "")
            {
                 Console.Write("Password:");
                 password = System.Console.ReadLine();

            }

            if (username == "master" && password == "manager")
            {
                Console.WriteLine("\nAccess Granted !");

                // read user choice
                int menuChoice = -1;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("::::Main Menu::::");
                    Console.WriteLine("1. Account Info");
                    Console.WriteLine("2. Transfer Funds");
                    Console.WriteLine("3. Withdraw Funds");
                    Console.WriteLine("4. Apply for Loan");
                    Console.WriteLine("0. Exit");

                    Console.Write("Enter your choice:");
                    menuChoice = int.Parse(System.Console.ReadLine());
                }
                while(menuChoice != 0);
            }
            else
            {
                Console.WriteLine("\nAccess Denied !");

            }

            Console.WriteLine("\nThanks for visting Akhi Bank");
            Console.WriteLine("Visit Again!");
        }
    }
}