//Grading ID: T6278
//CIS 200-01
//Program 1A
//Due Date: 02/13/2020
//This program creates concreate libraryBook class from the LibraryItem shows IS-A relationship
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1A
{
   
    public class LibraryBook: LibraryItem
    {
        private string _author;  // Holds Library book's author 
        const decimal BOOK_PER_DAY_FINE = 0.25m;   //Holds books daily fee

        // Precondition:  theCopyrightYear >= 0, theLoanPeriod >= 0
        //                theTitle, author and theCallNumber must not be null or empty
        // Postcondition: The constructor is initialized with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, and author and  is not checked out.
        public LibraryBook(string theTitle, string author, string thePublisher, int theCopyrightYear, int loanPeriod, string theCallNumber) :
         base(theTitle, thePublisher, theCopyrightYear, loanPeriod, theCallNumber)
        {
            Author = author; 
        }
        
        // Precondition:  daysLate >= 0
        // Postcondition: The late feefor specified days is returned
                     
        public override decimal CalcLateFee(int daysLate) //Overrides the base class's method and calculates the fee
        {
           
            decimal lateFee = daysLate * BOOK_PER_DAY_FINE;  // calculates the late fee
            return lateFee;  // returs the fee
        }

        public string Author
        {
            // Precondition:  None
            // Postcondition: The Author has been returned
            get
            {
                return _author; 
            }

            // Precondition:  value must not be null or empty
            // Postcondition: The author has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Author)}", value,
                        $"{nameof(Author)} must not be null or empty");
                else
                    _author = value.Trim();
            }
           
        }
        // Precondition:  None
        // Postcondition: A string is returned presenting the libary item's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut
            
            return $"Book Author: {Author}{NL}{base.ToString()}"; //Calling the base class, LibraryItem's ToString 
            
        }
    }




   

}



