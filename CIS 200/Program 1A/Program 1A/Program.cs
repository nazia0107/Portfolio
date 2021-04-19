using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_1A
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
        //    2010, "ZZ25 3G");  // 1st test book
        //    LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
        //        2000, "AG773 ZF"); // 2nd test book
        //    LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
        //        1985, "JJ438 4T"); // 3rd test book
        //    LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
        //        2016, "ZZ24 4F");    // 4th test book
        //    LibraryBook book5 = new LibraryBook("    The Big Book of Doughnuts   ", "   Homer Simpson   ", "   Doh Books   ",
        //        2001, "   AE842 7A   "); // 5th test book - Trims?

        //    LibraryPatron patron1 = new LibraryPatron("Ima Reader", "123456"); // 1st test patron
        //    LibraryPatron patron2 = new LibraryPatron("Jane Doe", "112233");  // 2nd test patron
        //    LibraryPatron patron3 = new LibraryPatron("   John Smith   ", "   654321   "); // 3rd test patron - Trims?

        //    List<LibraryBook> theBooks = new List<LibraryBook> { book1, book2, book3, book4, book5 }; // Test list of books

        //    WriteLine("Original list of books");
        //    WriteLine("----------------------");
        //    PrintBooks(theBooks);
        //    Pause();

        //    // Make changes
        //    book1.CheckOut(patron1);
        //    book2.Publisher = "Borrowed Books";
        //    try
        //    {
        //        book2.CheckOut(null); // Attempt invalid patron
        //    }
        //    catch (ArgumentNullException ex)
        //    {
        //        WriteLine("Caught invalid patron sent to CheckOut");
        //        WriteLine(ex.Message);
        //    }
        //    book3.CheckOut(patron2);
        //    book4.CallNumber = "    AB123 4A    ";
        //    book5.CheckOut(patron3);
        //    try
        //    {
        //        book5.CopyrightYear = -1234; // Attempt invalid year
        //    }
        //    catch (ArgumentOutOfRangeException ex)
        //    {
        //        WriteLine("Caught invalid CopyrightYear set:");
        //        WriteLine(ex.Message);
        //        WriteLine("Resetting to default year");
        //        book5.CopyrightYear = book5.DEFAULT_YEAR;
        //    }

        //    WriteLine("After changes");
        //    WriteLine("-------------");
        //    PrintBooks(theBooks);
        //    Pause();

        //    // Return the books
        //    book1.ReturnToShelf();
        //    book3.ReturnToShelf();
        //    book5.ReturnToShelf();

        //    WriteLine("After returning the books");
        //    WriteLine("-------------------------");
        //    PrintBooks(theBooks);
        //}

        //// Precondition:  None
        //// Postcondition: The books have been printed to the console
        //public static void PrintBooks(List<LibraryBook> books)
        //{
        //    foreach (LibraryBook b in books)
        //    {
        //        WriteLine(b);
        //        WriteLine();
        //    }
        //}

        //// Precondition:  None
        //// Postcondition: Pauses program execution until user presses Enter and
        ////                then clears the screen
        //public static void Pause()
        //{
        //    WriteLine("Press Enter to Continue...");
        //    ReadLine();

        //    Clear(); // Clear screen
        //}
    }
    }

