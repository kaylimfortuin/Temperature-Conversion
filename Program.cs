using System;
using System.Net;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueloopng = true;
            double result = 0;

            try
            {
                while (continueloopng)
                {
                    System.Console.WriteLine("\n ===Conversions===");
                    System.Console.WriteLine("1. Celsius to Fahrenheit");
                    System.Console.WriteLine("2. Celsius to Kelvin");
                    System.Console.WriteLine("3. Fahrenheit to Celsius");
                    System.Console.WriteLine("4. Fahrenheit to Kelvin");
                    System.Console.WriteLine("5. Kelvin to Celsius");
                    System.Console.WriteLine("6. Kelvin to Fahrenheit");
                    System.Console.WriteLine("7. Exit");
                    System.Console.Write("Enter your choice (1-7): ");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice < 1 || choice > 7)
                    {
                        System.Console.WriteLine("Enter a number between (1-7)");
                        continue;
                    }

                    if (choice == 7)
                    {
                        System.Console.WriteLine("Thank you");
                        break;
                    }
                    
                    System.Console.Write("Enter a temperature: ");
                    double temp = Convert.ToDouble(Console.ReadLine());

                    if (choice == 1)
                    {
                        result = (temp * 9 / 5) + 32;
                        System.Console.WriteLine($"{result} Fahrenheit \n");
                    }

                    else if (choice == 2)
                    {
                        result = temp + 273.15;
                        System.Console.WriteLine($"{result} Kelvin \n");
                    }

                    else if (choice == 3)
                    {
                        result = (temp - 32) * 5 / 9;
                        System.Console.WriteLine($"{result} Celsius \n");
                    }

                    else if (choice == 4)
                    {
                        result = (temp - 32) * 5 / 9 + 273.15;
                        System.Console.WriteLine($"{result} Kelvin \n");
                    }

                    else if (choice == 5)
                    {
                        result = temp - 273.15;
                        System.Console.WriteLine($"{result} Celsius \n");
                    }

                    else if (choice == 2)
                    {
                        result = (temp - 273.15) * 9 / 5 + 32;
                        System.Console.WriteLine($"{result} Fahrenheit \n");
                    }

                    
                }
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Please enter a valid number");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error {ex.Message}");
            }
        }
    }
}