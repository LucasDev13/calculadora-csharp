﻿using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            var num1 = 0; var num2 = 3;

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            //le a string do console e converte para int.
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Ask the user to choose an options.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            //Use a switch statement to do the match.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = {(num1 + num2)}");
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = {(num1 * num2)}");
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = {(num1 / num2)}");
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();

        }
    }
}