//Grading ID: T6278
//CIS 200-01
//Program 0
//Due Date: 1/28/2020
// File: Program.cs
// This file creates a simple test application class that creates
// A list of LibraryBook objects and tests them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryBook class has been tested
    public static void Main(string[] args)
    {
        LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
            2011, "ZZ25 3G");  // 1st test book
        LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
            2001, "AG773 ZF"); // 2nd test book
        LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
            1986, "JJ438 4T"); // 3rd test book
        LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
            2019, "ZZ24 4F");  // 4th test book
        LibraryBook book5 = new LibraryBook("The Big Book of Doughnuts", "Homer Simpson", "Doh Books",
            2004, "AE842 7A"); // 5th test book

        List <LibraryBook> theBooks = new List<LibraryBook> { book1, book2, book3, book4, book5 }; // List of books for test

        WriteLine("Original list of books");
        WriteLine("----------------------");
        PrintBooks(theBooks);
        Pause();
        LibraryPatron patronA = new LibraryPatron("Adam", "2323"); // Library patron object
        LibraryPatron patronB = new LibraryPatron("Andy", "1010");  // Library patron object
        LibraryPatron patronC = new LibraryPatron("Mike", "2020");  // Library patron object


        // Make changes
        book1.CheckOut(patronA);  //book1 checked out by patronA
        book2.Publisher = "Borrowed Books"; // publisher name of the book2 is changed
        book3.CheckOut(patronB);    //book1 checked out by patronB
        book4.CallNumber = "AB123 4A";  //call number of the book4 is changed
        book5.CheckOut(patronC);    //book1 checked out by patronA
       

        WriteLine("After changes");
        WriteLine("-------------");
        PrintBooks(theBooks);
        Pause();

        // Return the books
        book1.ReturnToShelf();  //book1 is returned to shef
        book3.ReturnToShelf();   //book3 is returned to shef
        book5.ReturnToShelf();   //book5 is returned to shef

        WriteLine("After returning the books");
        WriteLine("-------------------------");
        PrintBooks(theBooks);  // displays the change after the books are returned
    }

    // Precondition:  None
    // Postcondition: The books have been printed to the console
    public static void PrintBooks(List <LibraryBook> theBooks)  //displays all the books in Librarybook list
    {
        foreach (LibraryBook b in theBooks)  //displays from first to last
        {
            WriteLine(b);
            WriteLine();
        }
    }

    // Precondition:  None
    // Postcondition: Pauses program execution until user presses Enter and
    //                then clears the screen
    public static void Pause()  // press enter to see the change
    {
        WriteLine("Press Enter to Continue...");
        ReadLine();

        Clear(); // Clear screen
    }
}
