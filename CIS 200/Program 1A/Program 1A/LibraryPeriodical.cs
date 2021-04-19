//Grading ID: T6278
//CIS 200-01
//Program 1A
//Due Date: 02/13/2020
//This program creates an abstract LibraryPeriodical class. It adds library periodical and number
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1A
{
    public abstract class LibraryPeriodical: LibraryItem
    {
        private int _volume;  // periodicals Volume
        private int _number;   // perodicals number

        // Precondition:  theCopyrightYear >= 0, theLoanPeriod >= 0, theVolume >= 1, theNumber >= 1
        //theTitle and theCallNumber must not be null or empty
        // Postcondition: The library periodical has been initialized with the specified. values for title, publisher, copyright year, loan period,
        //   call number, volume, and number. The item is not checked out.              
                        
        public LibraryPeriodical(String theTitle, String thePublisher, int theCopyrightYear, int loanPeriod, String theCallNumber, int volume, int number)
            :base(theTitle,thePublisher,theCopyrightYear,loanPeriod,theCallNumber)
        {
            
            Volume = volume;
            Number = number;
        }

        public int Volume
        {
            // Precondition:  None
            // Postcondition: The volume has been returned
            get
            {
                return _volume;
            }

            // Precondition:  value >= 1
            // Postcondition: The volume has been set to the specified value
            set
            {
                if (value >= 1)
                    _volume = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Volume)}", value,
                        $"{nameof(Volume)} must be >= 1");
            }
        }
        public int Number
        {
            // Precondition:  None
            // Postcondition: The number has been returned
            get
            {
                return _number;
            }

            // Precondition:  value >= 0
            // Postcondition: The number has been set to the specified value
            set
            {
                if (value >= 1)
                    _number = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Number)}", value,
                        $"{nameof(Number)} must be >= 1");
            }
        }
        // Precondition:  None
        // Postcondition: A string is returned presenting the libary item's data on  separate lines
                       
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Volume: {Volume}{NL}Number: {Number}{NL}{base.ToString()}";
        }

    }































}

