﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            // Default value is "not-a-number" if an operation, such as division, could result in an error.
            double result = double.NaN;

            //Use a switch statement to do the match.
            switch (Console.ReadLine())
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result= num1 - num2 ;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor until they do so.
                    if(num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;

        }
    }
}
