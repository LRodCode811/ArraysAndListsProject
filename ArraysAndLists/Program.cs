using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numbers = new int[10];
            //int x = 1;
            //for (int i = 0; i < 10; i++)
            //{
            //    numbers[i] = x;
            //    x++; 
            //}
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = i + 1;
            }

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
                   
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }                

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            foreach (var evenNumber in evens)
            {
                Console.WriteLine(evenNumber);
            }
            foreach (var oddNumber in odds)
            {
                Console.WriteLine(oddNumber);
            }
        }
    }
}
