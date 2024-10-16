using Microsoft.Data.SqlClient;
using System;
using System.Threading;
using static System.Console;

namespace CarPark
{
    class Program
    {
        //static string connectionString= "Server=.;Database=Parkeringshus;Integrated Security=true";
        static string connectionString = "Server=.;Initial Catalog=CarPark;Integrated Security=true";
        //static string connectionString = "Data Source=.;Initial Catalog=Parkeringshus;Integrated Security=true";
        static void Main(string[] args)
        {
            bool shouldNotExit = true;
            while (shouldNotExit)
            {
                WriteLine("1. Register arrival");
                WriteLine("2. Register departure");
                WriteLine("3. Show parking registry");
                WriteLine("4. Exit");
                ConsoleKeyInfo keyPressed = ReadKey(true);
                Clear();
                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        {
                            Write("First name: ");
                            string firstName = ReadLine();
                            Write("Last name: ");
                            string lastName = ReadLine();
                            Write("Social security number: ");
                            string socialSecurityNumber = ReadLine();
                            Write("Phone number: ");
                            string phoneNumber = ReadLine();
                            Write("E-mail: ");
                            string email = ReadLine();
                            Write("Registration number: ");
                            string registrationNumber = ReadLine();
                            Write("Notes: ");
                            string notes = ReadLine();
                            DateTime arrival = DateTime.Now;

                           
                        }
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        {
                            
                        }
                        Clear();
                        // TODO: create notice snippet
                        WriteLine("Departure registered");
                        Thread.Sleep(2000);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        {
                            break;
                        }
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        shouldNotExit = false;
                        break;
                }
                Clear();
            }
        }
        }
}