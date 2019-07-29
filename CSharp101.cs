/*
    Author: Craig Lawlor
    Description: A program containing data types and arrays for reference
                 As well as other basic examples
*/
using System;
using System.Collections.Generic;

namespace CSharp101
{
    class Program
    {
        static void Main(string[] args)
        {
            // primitive types
            byte number = 27;
            short amount = 12;
            int count = 43;
            long days = 7;
            float totalPrice = 20.95f;
            double length = 12.6;
            decimal price = 6.2m;
            char initial = 'L';
            bool isChecked = true;

            // non-primitive types
            string firstName = "Craig";

            // basic output
            Console.WriteLine("byte: " + number);       // can use concatination
            Console.WriteLine("short: {0}", amount);    // or format string
            Console.WriteLine("int: {0}", count);
            Console.WriteLine("long: {0}", days);
            Console.WriteLine("float: {0}", totalPrice);
            Console.WriteLine("double: {0}", length);
            Console.WriteLine("decimal: {0}", price);
            Console.WriteLine("char: {0}", initial);
            Console.WriteLine("bool: {0}", isChecked);
            Console.WriteLine("string: {0}", firstName);

            // primitive ranges
            Console.WriteLine("{0}Min & Max Data Type Values", Environment.NewLine);
            Console.WriteLine("Byte: {0} - {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Short: {0} - {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("Int: {0} - {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Long: {0} - {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("Float: {0} - {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Double: {0} - {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("Decimal: {0} - {1}", decimal.MinValue, decimal.MaxValue);

            // basic input
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine("Enter name");                        // WriteLine goes to the next line
            string name = Console.ReadLine();
            Console.WriteLine("Name: " + name);

            Console.Write("Enter an integer number: ");             // Write stays on the same line   
            string userInputInt = Console.ReadLine();
            int intVal = Convert.ToInt32(userInputInt);             // must convert the string to int
            Console.WriteLine("Your integer number: " + intVal);

            Console.Write("Enter an double number: ");
            string userInputDouble = Console.ReadLine();
            double doubleVal = Convert.ToDouble(userInputDouble);   // must convert the string to double
            Console.WriteLine("Your double number: " + doubleVal);

            // basic array 
            int[] arrayEmaple;                                      // uninitialized
            double[] doubleArray = new double[10];                  // initialized
            string[] names = { "Thierry", "Jackson", "Philips" };   // assign values at declaration
            int[] ages = new int[3] { 27, 23, 34 };                 // assign like this either

            // basic list
            List<int> listAges = new List<int>();
            List<string> listNames;
        }
    }
}