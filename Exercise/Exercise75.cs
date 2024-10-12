using System.Xml;
using System.Drawing;
using System.Dynamic;
using System;
namespace Exercise
{
    public static class Exercise75
    {
        public static void ASCII_VALUE_OF_GIVEN_CHAR()
        {
            Console.Write($"Enter a single Character: ");
            char givenChar = Convert.ToChar(Console.ReadLine());
            int asciiValue = Convert.ToInt32(givenChar);
            
            Console.WriteLine($"ASCII Value of {givenChar} is: {asciiValue}");
        }
    }
}