// Grading ID: J2089
// CIS 199-01
// Lab 5
// Due date: October 20, 2019
// This console application displays 4 diffent patterns using nested loops
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Pattern A"); //displays the pattern A
            const int MAX_ROW = 10; // named constant for maximum number of rows
            for (int row = 1; row <= MAX_ROW; row++) // row starts at 1 increments by 1 until maximum number of row
            {
                for (int star = 1; star <= row; star++)
                    Write("*");
                WriteLine();
            }






            WriteLine("Pattern B"); //displays the pattern B

            const int ROW_MAXB = 10; // named constant for maximum number of rows
            for (int row = ROW_MAXB; row >= 0; row--) 
            {
                for (int star = 1; star <= row; star++)
                    Write("*");
                WriteLine();
            }



            WriteLine("Pattern C"); // displays pattern C

            const int ROW_MAXC = 10; // named constant for maximum number of rows

            for (int row = 0; row <= ROW_MAXC; row++) // row starts at 0, and increments by 1
            {
                for (int c = 0; c < row; c++)
                    Write(" ");
                for (int c = 0; c < ROW_MAXC - row; c++)
                    Write("*");
                WriteLine();




            }

            WriteLine("Pattern D");  // Displays pattern D

            const int ROW_MAXD = 10; // named constant for maximum number of rows

            for (int row = 10; row> 0; row--) // row starts at 10 and decrements by 1 
            {
                for (int c = 0; c <= row; c++)
                    Write(" ");
                for (int c = 0; c <= ROW_MAXD - row; c++)
                    Write("*");
                WriteLine();

            }



        }
    }
}
