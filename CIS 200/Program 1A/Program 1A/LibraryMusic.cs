//Grading ID: T6278
//CIS 200-01
//Program 1A
//Due Date: 02/13/2020
//This program craetes concrete LibraryMusic class.It adds artist and number of tracks and demonstrated the IS-A relationship 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1A
{
    public class LibraryMusic:LibraryMediaItem
    {
        private string _artist; //Holds Library music's artist 
        private int _tracks; // holds library music's number of tracts 
        private MediaType _medium;  // holds the library music's medium 
        public const decimal PER_DAY_FEE = 0.20M;  // holds the per day fee 
       public const decimal MAXIMUM_LIMIT = 20M;  // holds the maximum fee
       
        
         
        // Precondition:  theCopyrightYear >= 0, theLoanPeriod >= 0, theDuration >= 0,
        //                theNumTracks >= 1
        //                theTitle and theCallNumber must not be null or empty
        // Postcondition: The constructor has been initialized with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, duration, director, medium, and rating. The
        //                item is not checked out.
        public LibraryMusic(string theTitle, string thePublisher, int theCopyrightYear, string theCallNumber,
         int loanPeriod, double duration, string artist, int numTracks, MediaType medium)
        :base(theTitle, thePublisher,theCopyrightYear,theCallNumber,loanPeriod,duration)
        {
            Medium = medium;
            Artist = artist;
            Tracks = numTracks;
        }

       

        public string Artist
        {
            // Precondition:  None
            // Postcondition: The call number has been returned
            get
            {
                return _artist;
            }

            // Precondition:  None
            // Postcondition: The artist has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Artist)}", value,
                        $"{nameof(Artist)} must not be null or empty");
                else
                    _artist = value.Trim();
            }
        }
        public int Tracks
        {  // Precondition:  None
            // Postcondition: The number of tracks has been returned
            get
            {
                return _tracks;
            }

            // Precondition:  value >= 0
            // Postcondition: The number of tracks has been set to the specified value
            set
            {
                if (value >= 1)
                    
                    _tracks = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Tracks)}", value,
                        $"{nameof(Tracks)} must be >= 1");
            }

        }
        //overrides the base class's abstract meth
        public override MediaType Medium
        {    
            
            // Precondition:  None
            // Postcondition: The medium has been returned
           
            get
            {
                return _medium;
            }

            // Precondition:  Must be from { DVD, BLURAY, VHS }
            // Postcondition: The medium has been set to the specified value
            set
            {
                if (Enum.IsDefined(typeof(MediaType), value))
                    _medium = value;


                else throw new ArgumentOutOfRangeException($"{nameof(Medium)}",
                      value, $"{nameof(Medium)} must be from  CD, SACD,VINYL");
            }
    }
        // Precondition:  daysLate must be >= 0
        // Postcondition: The late fee for specified days is returned
        public override decimal CalcLateFee(int daysLate)
        {
            
            decimal lateFee = 0.0M; //assume latefee is $0.0
            
            if (daysLate < 0) // making sure days late isn't negative 
            {
                throw new ArgumentOutOfRangeException($"{nameof(daysLate)}", daysLate,
                        $"{nameof(daysLate)} must be >= 0");
            }
            else 
            {
                if (lateFee <= MAXIMUM_LIMIT)
                {
                    lateFee = daysLate * PER_DAY_FEE;
                }
                else lateFee = MAXIMUM_LIMIT;

                return Math.Min(lateFee, MAXIMUM_LIMIT); //keeping the minimum value
                
            }

            

        }
        // Precondition:  None
        // Postcondition: A string is returned presenting the libary item's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"LibraryMusic{NL}Artist: {Artist}{NL}Num of Tracks: {Tracks}{NL}" +
                $"{base.ToString()}";
        }



































    }
}
