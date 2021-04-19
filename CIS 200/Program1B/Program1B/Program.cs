//Grading ID:T6278
// Program 1B
// CIS 200-01
// Due: 2/20/2020
// File: Program.cs
// This file creates a small application that tests the LibraryItem hierarchy and uses LINQ to create and display specific queries

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryItems;
using static System.Console;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryItem hierarchy has been tested demonstrating polymorphism
    //                in CalcLateFee()
    public static void Main(string[] args)
    {
        const int DAYSLATE = 14; // Number of days late to test each object's CalcLateFee method

        List<LibraryItem> items = new List<LibraryItem>();       // List of library items
        List<LibraryPatron> patrons = new List<LibraryPatron>(); // List of patrons

        // Test data - Magic numbers allowed here
        items.Add(new LibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright"));
        items.Add(new LibraryBook("Harry Potter", "	Bloomsbury Publishing ", 1997, 14,
           "ZZ25 3G", " J. K. Rowling"));

        //Adding 2 two LibraryMovie objects to the list
        items.Add(new LibraryMovie("   Andrew's Super-Duper Movie   ", "   UofL Movies   ", 2019, 7,
            "MM33 2D", 92.5, "   Andrew L. Wright   ", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG)); // Trims?
        items.Add(new LibraryMovie("  Frozen 2 ", "   Disney   ", 2019, 7,
            "MM33 2D", 92.5, "  Jennifer Lee   ", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG));

        //Adding 2 two LibraryMusic objects to the list
        items.Add(new LibraryMusic("C# - The Album", "UofL Music", 2020, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10));
        items.Add(new LibraryMusic("Lover", "Jack Antonoff", 2019, 14,
           "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10));

        //Adding 2 two LibraryJournal objects to the list
        items.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2018, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));
        items.Add(new LibraryJournal("Physics", "UofL Journals", 2018, 14,
            "JJ12 7M", 1, 2, "Science", "XYZ"));

        //Adding 2 two LibraryMagazine objects to the list
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2017, 14,
            "MA53 9A", 16, 7));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2017, 14,
           "MA53 9A", 9, 10));



        // Adding patrons to the patrons list 
        patrons.Add(new LibraryPatron("Ima Reader", "12345"));
        patrons.Add(new LibraryPatron("Jane Doe", "11223"));
        patrons.Add(new LibraryPatron("   John Smith   ", "   654321   ")); // Trims?
        patrons.Add(new LibraryPatron("Joe John", "12003"));
        patrons.Add(new LibraryPatron("Jake", "60890"));
        patrons.Add(new LibraryPatron(" Steve ", "   70623   "));


        Console.WriteLine("List of items at start:\n");
        foreach (LibraryItem item in items)
            WriteLine($"{item}\n");
        Pause();

        // Check out some items
        items[0].CheckOut(patrons[0]); //first item is checked out by first patron
        items[2].CheckOut(patrons[2]); //second item is checked out by second patron
        items[4].CheckOut(patrons[1]); //fifth item is checked out by second patron
        items[1].CheckOut(patrons[3]); //second item is checked out by fourth patron
        items[3].CheckOut(patrons[4]); //fourth item is checked out by fifth patron


        WriteLine("List of items after checking some out:\n");
        foreach (LibraryItem item in items)
            WriteLine($"{item}\n");
        Pause();

        WriteLine($"Calculated late fees after {DAYSLATE} days late:\n");
        WriteLine($"{"Title",30} {"Call Number",11} {"Late Fee",8}"); //Column headers
        WriteLine("------------------------------ ----------- --------");

        // Caluclate and display late fees for each item
        foreach (LibraryItem item in items)
            WriteLine($"{item.Title,30} {item.CallNumber,11} {item.CalcLateFee(DAYSLATE),8:C}"); //formatted 
        Pause();

        //Holds results of LINQ to sort the Library items that are checked out
        var checkedOutItem =
            from item in items
            where item.IsCheckedOut() == true
            select item;

        WriteLine("The checked out item are:\n");
        foreach (var item in checkedOutItem)
            WriteLine($"{item}\n" );

        //Displays the count of checked out items
        WriteLine($"The total checked out items:{checkedOutItem.Count()}\n"); //Calling the helper method Count to display the count
        Pause();

        //Holds results of LINQ to sort the checkedOutItems by  media item
        var checkedOutmediaItem =
            from item in checkedOutItem
            where item is LibraryMediaItem
            select item;

        foreach (var item in checkedOutmediaItem)
            WriteLine($"{item}\n" );
        Pause();

        //Holds results of LINQ find the unique library magazine title
        var libraryMagazine =
            from item in items
            where item is LibraryMagazine
            select item.Title;

        WriteLine("The unique magazine:\n");
        foreach (var item in libraryMagazine.Distinct()) //displays the unique magazine 
            WriteLine($"{item}\n" );
        Pause();

        // Return items that are checked out
        foreach (LibraryItem item in items) //stepting through each items in the LibraryItem
        {
            if (item.IsCheckedOut())
                item.ReturnToShelf();
        }
        //Display the returned items
        WriteLine("After returning all items:\n");
        foreach (LibraryItem item in items)
            WriteLine($"{item}\n" );

        //Display the count of items that are currently checked out
        WriteLine($"The currently checked out items : { checkedOutItem.Count()}\n");
        Pause();


        //Display the libraryBooks in LibraryItems with updated loan period by adding 7 days more
        foreach (LibraryItem item in items) //stepping through each library items 
        {
            if (item is LibraryBook) //asks if an item is a library book
            {
                WriteLine(item);
                item.LoanPeriod += 7; //Adding 7 days to the loan period
                WriteLine($"The new Loan Period: {item.LoanPeriod}\n" );
            }

        }
        Pause();



    }

    // Precondition:  None
    // Postcondition: Pauses program execution until user presses Enter and
    //                then clears the screen
    public static void Pause()
    {
        WriteLine("Press Enter to Continue...");
        ReadLine();

        Clear(); // Clear screen
    }
}