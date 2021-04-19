//Grading ID: T6278
//CIS 200-01
//Program 1A
//Due Date: 02/13/2020
//This program creates concrete LibraryJournal class from LibraryPeriodical
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1A
{
    public class LibraryJournal:LibraryPeriodical
    {
        private string _decipline; // holds Library journal decipline 
        private string _editor;    // holds Library journal editor
        public const decimal PER_DAY_FEE_JR = 0.75M;  // holds per day fee for library journal

        // Precondition:  theCopyrightYear >= 0, theLoanPeriod >= 0, theVolume >= 1,
        //                theNumber >= 1
        //                theTitle, theCallNumber, theDiscipline, and theEditor must not be null or empty
        // Postcondition: The constractor has been initialized with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, volume, number, discipline, and editor. The
        //                item is not checked out.
        public LibraryJournal(String theTitle, String thePublisher, int theCopyrightYear, int loanPeriod, String theCallNumber, int volume, int number, string decipline, string editor)
            :base(theTitle,thePublisher,theCopyrightYear,loanPeriod,theCallNumber, volume, number)
        {

            Title = theTitle;
            Publisher = thePublisher;
            CopyrightYear = theCopyrightYear;
            CallNumber = theCallNumber;
            LoanPeriod = loanPeriod;
            Volume = volume;
            Number = number;
            Editor = editor;
            Decipline = decipline;
        }

        public string Editor
        {
            // Precondition:  None
            // Postcondition: The editor has been returned
            get
            {
                return _editor;
            }

            // Precondition:  None
            // Postcondition: The editor has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Editor)}", value,
                        $"{nameof(Editor)} must not be null or empty");
                else
                    _editor = value.Trim();
            }
        }

        public string Decipline
            {
            // Precondition:  None
            // Postcondition: The decipline has been returned
            get
            {
                return _decipline;
            }

            // Precondition:  None
            // Postcondition: The decipline has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Decipline)}", value,
                        $"{nameof(Decipline)} must not be null or empty");
                else
                    _decipline = value.Trim();
            }

        }
        // Precondition:  daysLate >= 0
        // Postcondition: The fee for specified days late
        //                has been returned
        public override decimal CalcLateFee(int daysLate)
        {
            decimal lateFee = 0.0M;  //assume dayslate is 0
            if (daysLate < 0) // Making sure latedays isn't negative
            {
                throw new ArgumentOutOfRangeException($"{nameof(daysLate)}", daysLate,
                        $"{nameof(daysLate)} must be >= 0");

            }
            else
            {
                lateFee = daysLate * PER_DAY_FEE_JR;
            }
            return lateFee;
        }
        
        
        // Precondition:  None
        // Postcondition: A string is returned presenting the libary item's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut
            string checkedOutBy; // Holds checked out message

            if (IsCheckedOut())
                checkedOutBy = $"Checked Out By: {NL}{Patron}";
            else
                checkedOutBy = "Not Checked Out";

            return
                 $"{base.ToString()}{NL} Editor: { Editor}{ NL}Decipline: { Decipline}";

            
        }




























    }
}
