//Grading ID: T6278
//CIS 200-01
//Program 1A
//Due Date: 02/12/2020
//This program creates a concrete class, LibraryMovie by adding director and rating.Shows IS-A relationship

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1A
{
    public class LibraryMovie : LibraryMediaItem
    {
        

        private string _director;  // Holds Movie's director
        private MediaType _medium;  //Holds movie's Medium 
        private MPPARatings _rating; //Holds movie's ratings
        const decimal PER_DAY_FEE_DVD_VHS = 1.0m; //per day fee for dvd and vhs
        const decimal PER_DAY_FEE_BLUERAY = 1.50m; // BluRay's daily late fee
        const decimal MAX_FEE = 25.00m;  // Maximum limit of late fee

        public enum MPPARatings { G, PG, PG13, R, NC17, U }; // MPPARatings for the library movies 


        // Precondition:  theCopyrightYear >= 0, theLoanPeriod >= 0, theDuration >= 0
        //                theTitle,theCallNumber, and theDirector must not be null or empty
        // Postcondition: The constructor is initialized with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, duration, director, medium, and rating. The
        //                item is not checked out.
        public LibraryMovie(string theTitle, string thePublisher, int theCopyrightYear, string theCallNumber, int loanPeriod,
            double duration, string director, MediaType medium, MPPARatings rating)
            : base(theTitle, thePublisher, theCopyrightYear, theCallNumber, loanPeriod, duration)
        {
            
            Director = director;
            Rating = rating;
            Medium = medium;
        }



        public MPPARatings Rating
        {
            get
            {    // Precondition:  None
                // Postcondition: The rating has been returned
                return _rating;

            }
            set
            {   //Precondition:  None
               // Postcondition: The rating has been set to the specified value
                
                if (Enum.IsDefined(typeof(MPPARatings), value))
                    _rating = value;
            }
            

        }

        public string Director
        {
            // Precondition:  None
            // Postcondition: The director has been returned
            get
            {
                return _director;
            }

            // Precondition:  None
            // Postcondition: The director has been set to the specified value
            set
            {
                // Since empty director is OK, just change null to empty string
                _director = (value == null ? string.Empty : value.Trim());
            }
        }



        public override MediaType Medium //overrides the base class's abstract method and gets and sets specified values
        {
            // Precondition:  None
            // Postcondition: The medium has been returned
            get
            {
                return _medium;
            }

            // Precondition:  Has to be from { DVD, BLURAY, VHS }
            // Postcondition: The medium has been set to the specified value
            set
            {
                 if (value == MediaType.DVD && value == MediaType.VHS)
                {
                    _medium = value; 
                }
                
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Medium)}",
                        value, $"{nameof(Medium)} must be from DVD, BLURAY, VHS");



            }
        }


        // Precondition:  daysLate must be >= 0
        // Postcondition: The late fee for specified days is returned
        public override decimal CalcLateFee(int daysLate)   //This method calculates the fines for DVD/VSH and Blueray

        {
            decimal lateFee = 0.0M; // Assume late fee for movie
            if (daysLate < 0) // making sure days late isn't <0
            {
                throw new ArgumentOutOfRangeException($"{nameof(daysLate)}", daysLate,
                      $"{nameof(daysLate)} must be >= 0");
            }
            else
            {
                if (Medium == MediaType.BLURAY)
                    lateFee = daysLate * PER_DAY_FEE_BLUERAY;
                else
                    lateFee = daysLate * PER_DAY_FEE_DVD_VHS;

                return Math.Min(lateFee, MAX_FEE);  // returns the minimum value 

            }
               
            
        }
        // Precondition:  None
        // Postcondition: A string is returned presenting the libary item's data on separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"{base.ToString()} {NL} LibraryMovie{NL}Director: {Director}{NL}Rating: {Rating}{NL}";
                
        }






    }
}
 
