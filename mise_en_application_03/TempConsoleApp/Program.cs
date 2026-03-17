using System;
using TemperatureLib;

class Program
{
    static void Main()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("1 - Celsius to Fahrenheit");
        Console.WriteLine("2 - Fahrenheit to Celsius");

        Console.Write("Choose an option: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter temperature: ");
        double temp = double.Parse(Console.ReadLine());

        if (choice == 1)
        {
            double result = TemperatureLib.TemperatureLib.CelsiusToFahrenheit(temp);
            Console.WriteLine($"Result: {result} °F");
        }
        else if (choice == 2)
        {
            double result = TemperatureLib.TemperatureLib.FahrenheitToCelsius(temp);
            Console.WriteLine($"Result: {result} °C");
        }
        else
        {
            Console.WriteLine("Invalid option");
        }
    }
}