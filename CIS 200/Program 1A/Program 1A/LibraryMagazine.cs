//Grading ID: T6278
//CIS 200-01
//Program 1A
//Due Date: 02/13/2020
//This program demonstrates IS-A relationship by creating LibraryMagazine concrete class from LibraryPeriodical
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1A
{
    public class LibraryMagazine: LibraryPeriodical
    {
        public const decimal PER_DAY_FEE_MAGAZINE = 0.25M; //per day magazine late fee
        public const decimal MAXIMUM_FEE = 20.0M; //Maximum late fee

        // Precondition:  theCopyrightYear >= 0, theLoanPeriod >= 0, theVolume >= 1,
        //                theNumber >= 1
        //                theTitle and theCallNumber must not be null or empty
        // Postcondition: The constructor is  initialized with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, volume, and number. The item is not checked out.
        public LibraryMagazine(string theTitle, string thePublisher, string theCallNumber, int theCopyrightYear, int loanPeriod, double duration, int volume,int number )
            : base(theTitle, thePublisher, theCopyrightYear, loanPeriod, theCallNumber, volume, number)
        {

            Title = theTitle;
            Publisher = thePublisher;
            CopyrightYear = theCopyrightYear;
            LoanPeriod = loanPeriod;
            Volume = volume;
            Number = number;
        }


        // Precondition:  daysLate >= 0
        // Postcondition: The late feefor specified days is returned               
        public override decimal CalcLateFee(int daysLate) //overrides base class's absract method and claculates late fee
        {
            decimal lateFee = 0.0M; // Assume magazine late fee
            if (daysLate < 0) // making sure days late isn't <0
            {
                throw new ArgumentOutOfRangeException($"{nameof(daysLate)}", daysLate,
                      $"{nameof(daysLate)} must be >= 0");
            }
            else
            {
                if (lateFee <= MAXIMUM_FEE)

                    lateFee = daysLate * PER_DAY_FEE_MAGAZINE;

                else
                    lateFee = MAXIMUM_FEE;


                return Math.Min(lateFee, MAXIMUM_FEE);
            }



        }
        // Precondition:  None
        // Postcondition: A string is returned presenting the libary item's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"LibraryMagazine:{NL}{base.ToString()}";
        }




















    }
}
