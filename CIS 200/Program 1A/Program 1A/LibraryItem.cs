//Grading ID: T6278
//CIS 200-01
//Program 1A
//Due Date: 02/13/2020
// Abstract LibraryItem class, it  will be 
// the base class of library items and it keeps
// track of  library items information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1A
{
    public abstract class LibraryItem //abstract class 

    {
        private string _title;      // The book's title
        private string _publisher;  // The book's publisher
        private int _copyrightYear; // The book's year of copyright
        private string _callNumber; // The book's call number in the library
        private int _loanPeriod;  // The book's loan period 
        private bool _checkedOut;  // status of checked 

        // Precondition:  theCopyrightYear >= 0, theLoanPeriod >= 0
        //                theTitle and theCallNumber can not be not be null or empty
        // Postcondition: The constructor is initialized with title, publisher, copyright year, loan period and
        //                call number. The item is not checked out.
        public LibraryItem(string theTitle, string thePublisher,int theCopyrightYear, int loanPeriod,  string theCallNumber)
        {
            Title = theTitle;
            Publisher = thePublisher;
            CopyrightYear = theCopyrightYear;
            CallNumber = theCallNumber;
            LoanPeriod = loanPeriod;
          
         ReturnToShelf(); // Make sure book is not checked ou

        }

        public string Title
        {
            // Precondition:  None
            // Postcondition: The title has been returned
            get
            {
                return _title;
            }

            // Precondition:  value must not be null or empty
            // Postcondition: The title has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Title)}", value,
                        $"{nameof(Title)} must not be null or empty");
                else
                    _title = value.Trim();
            }
        }
        public string Publisher
        {
            // Precondition:  None
            // Postcondition: The publisher has been returned
            get
            {
                return _publisher;
            }

            // Precondition:  None
            // Postcondition: The publisher has been set to the specified value
            set
            {
                // Since empty publisher is OK, just change null to empty string
                _publisher = (value == null ? string.Empty : value.Trim());
            }
        }
        public int CopyrightYear
        {
            // Precondition:  None
            // Postcondition: The copyright year has been returned
            get
            {
                return _copyrightYear;
            }

            // Precondition:  value >= 0
            // Postcondition: The copyright year has been set to the specified value
            set
            {
                if (value >= 0)
                    _copyrightYear = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(CopyrightYear)}", value,
                        $"{nameof(CopyrightYear)} must be >= 0");
            }
        }
        public string CallNumber
        {
            // Precondition:  None
            // Postcondition: The call number has been returned
            get
            {
                return _callNumber;
            }

            // Precondition:  None
            // Postcondition: The call number has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(CallNumber)}", value,
                        $"{nameof(CallNumber)} must not be null or empty");
                else
                    _callNumber = value.Trim();
            }
        }
        public int LoanPeriod
        {
            get
            {
                return _loanPeriod;
            }

            // Precondition:  value >= 0
            // Postcondition: The loan period has been set to the specified value
            set
            {
                if (value >= 0)
                    _loanPeriod = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(LoanPeriod)}", value,
                        $"{nameof(LoanPeriod)} must be >= 0");
            }

        }
        public LibraryPatron Patron
        {
            // Precondition:  None
            // Postcondition: The book's patron has been returned
            get; // Auto-implement is fine

            
            // Precondition:  None
            // Postcondition: The book's patron has been set to the specified value
            private set; // Auto-implement is fine 
        }

        // Precondition:  Patron can't be null
        // Postcondition: The book is checked out
        public void CheckOut(LibraryPatron thePatron)
        {
            if (thePatron != null)
            Patron = thePatron;
           else
           throw new ArgumentNullException($"{nameof(thePatron)}", $"{nameof(thePatron)} must not be null");

            _checkedOut = true;
        }

        public void ReturnToShelf()
        {
            Patron = null; //  Since item is not checked yet there is no relationship yet
        }

        // Precondition:  None
        // Postcondition: true is returned if the book is checked out,
        //                otherwise false is returned
        public bool IsCheckedOut() 
        {
            return _checkedOut; // The item is checked out if there is a Patron
        }
        //Precondition:  daysLate has to be greater than or equal to 0
        // Postcondition: calculates the late fee and returns 
        public abstract decimal CalcLateFee(int daysLate); // Abstract 


        //Precondition:  None
        // Postcondition: A string is returned presenting the libary item's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut
            string checkedOutBy; // Holds checked out message

            if (IsCheckedOut()) //if it is checked out 
                checkedOutBy = $"Checked Out By: {NL}{Patron}";
            else
                checkedOutBy = "Not Checked Out";

            return $"Title: {Title}{NL}{NL}Publisher: {Publisher}{NL}" +
                $"Copyright: {CopyrightYear}{NL}Call Number: {CallNumber}{NL}{checkedOutBy} { NL} Loan Period: {LoanPeriod}" ;
        }

    }
}
