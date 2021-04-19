//Grading ID: T6278
//CIS 200-01
//Program 1A
//Due Date: 02/13/2020
//This class craetes an absaract LibraryMediaItem class derived from LibraryItem, it has abstract MediaType method 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1A
{
    public abstract class LibraryMediaItem: LibraryItem

    {
        

        private double _duration; // duration of the books

        public enum MediaType { DVD, BLURAY, VHS, CD, SACD, VINYL }; //Mediatypes 

        // Precondition:  theCopyrightYear >= 0, theLoanPeriod >= 0, theDuration >= 0
        //                theTitle and theCallNumber must not be null or empty
        // Postcondition: The library media item has been initialized with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, and duration. The item is not checked out.
        public LibraryMediaItem(string theTitle, string thePublisher, int theCopyrightYear,  string theCallNumber, int loanPeriod, double duration)
            :base(theTitle, thePublisher, theCopyrightYear, loanPeriod,theCallNumber)
        {
            Title = theTitle;
            Publisher = thePublisher;
            CopyrightYear = theCopyrightYear;
            CallNumber = theCallNumber;
            LoanPeriod = loanPeriod;
            Duration = duration;
            
        }

        public double Duration
        {// Precondition:  None
         // Postcondition: The duration has been returned
            get
            {
                return _duration;
            }

            // Precondition:  value >= 0
            // Postcondition: The duration has been set to the specified value
            set
            {
                if (value >= 0)
                    _duration = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Duration)}", value,
                        $"{nameof(Duration)} must be >= 0");
            }
        }


        public abstract MediaType Medium 
        {
        
        // Precondition:  None
        // Postcondition: The medium has been returned
        get;

         // Precondition:  don't know yet, since its an abstract method
         // Postcondition: The medium has been set to the specified value   
        set; 
        
        } 


        // Precondition:  None
        // Postcondition: A string is returned presenting the libary item's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut
            return $"Duration: {Duration}{NL}Medium: {Medium}{NL}{base.ToString()}"; //Calls the base class's ToString
        }


    }
}
