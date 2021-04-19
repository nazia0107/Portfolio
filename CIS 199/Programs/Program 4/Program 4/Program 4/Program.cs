//Grading ID: J2089
// CIS 199-01
//Program 4
//Due Date: Dec 3, 2019
// Here 5 book objects are created and output

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Created 5 book objects using the LibraryBook class

            LibraryBook book1 = new LibraryBook("Odyssey","Homer", "Jake", 1999, "1234");
            LibraryBook book2 = new LibraryBook("War and Peace", "Tolstoy", "Pink", 2000, "2312");
            LibraryBook book3 = new LibraryBook("The Cat in the Hat", "Seuss", "Bob" , 1995, "1010" );
            LibraryBook book4 = new LibraryBook("The Girl Who Drank the Moon", "Barnhill", "Cat", 2010, "1212" );
            LibraryBook book5 = new LibraryBook("Hamlet", "Shakespeare", "AAA", 2012, "2323" );

            // Array of the book objects
            LibraryBook[] books = { book1, book2, book3, book4, book5 };
           
            //displays the current book list with all the information
            Console.WriteLine("Current Available Books" + Environment.NewLine);

            //calls the printout method to display the books
            PrintoutBook(books);

            book1.Author = "Sam";           // changing the author name for the book1
            book2.CheckOut();              // checked out book2
            book3.Publisher = "Mike";      // changing the book3 publisher's name         
            book4.Title = "Bob";          // changing the book4 title
            book5.CheckOut();            //  book5 is checked out

            Console. WriteLine("New Book List" + Environment.NewLine);   // displays a message
            PrintoutBook(books);        // Calls the Printoutbook method and print the message after the changes

            book2.ReturnToShelf();     // book2 is returned 
            book5.ReturnToShelf();     // book5 is returned


            Console.WriteLine("New Book inventory" + Environment.NewLine);  // displays a message of New book inventory
            PrintoutBook(books); // calls Printoutbook method to display current status of the inventory after the book2 and book5 retured to the shelf




        }



        //Precondition: Must use a valid array of LibraryBook objects
        //Postcondition:displays the current books with all the information
        public static void PrintoutBook(LibraryBook [] bookArray)
        {
            for (int index = 0; index<bookArray.Length; ++index)
            {
                Console.WriteLine($"Book # : {index + 1}");
                Console.WriteLine($"{bookArray[index]}");
            }
            Console.WriteLine("");
        }


    }
}
