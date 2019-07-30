/*
    Author: Craig Lawlor
    Description: A program to explore lists with a look at methods
*/
using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        public static void PrintList(List<int> numberList)
        {
            Console.WriteLine("The list contains: ");
            foreach (int num in numberList)
            {
                Console.WriteLine("{0}", num);
            }
        }

        static void Main(string[] args)
        {
            // declaration
            List<int> numbers = new List<int>();
            List<int> primeNumbers = new List<int>() { 2, 3, 5, 7, 11 }; // can be initialised like this 

            // output
            foreach ( int num in primeNumbers )
            {
                Console.Write("{0},", num);
            }
            Console.WriteLine("{0}", Environment.NewLine);

            // methods
            numbers.Add(7);
            numbers.Add(32);
            numbers.Add(12);
            Console.WriteLine("Number of elements: " + numbers.Count);

            numbers.Remove(32);
            Console.WriteLine("Number of elements: " + numbers.Count);
            PrintList(numbers);

            numbers.Add(33);
            PrintList(numbers);
            numbers.RemoveAt(1);
            

            // add array elements to a list
        }
    }
}
