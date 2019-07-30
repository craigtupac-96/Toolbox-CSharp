/*
    Author: Craig Lawlor
    Description: A program to explore arrays
*/
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // cw tab - shortcut
            Console.Write("How many elements? ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbersArray = new int[size];

            // input for array
            for ( int i = 0; i < size; i++ )
            {
                Console.WriteLine("Enter a number");
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            // output for array
            for ( int i = 0; i < size; i++ )
            {
                Console.WriteLine((i + 1) + ": " + numbersArray[i]);
            }

            Console.WriteLine("{0}Output with a foreach", Environment.NewLine);
            foreach (int i in numbersArray)
            {
                Console.WriteLine(i);
            }

            // add a multidimensional array here
        }
    }
}
