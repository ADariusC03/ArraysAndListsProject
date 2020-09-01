using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ArraysAndLists
{
    class Program
    {

        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };





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

            int i = 0;

            int x = 0;
            

            Console.WriteLine("Even Numbers :");
            for (i = 2; i < 10; i++)
            {
                Console.WriteLine(i);
                if ( i%2 == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
            Console.WriteLine("\nOdd Numbers : ");
            for  (x = 0; x < 10; x++)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(x + " ");
                }
            }
            Console.WriteLine();

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

        



        }



    }
}
