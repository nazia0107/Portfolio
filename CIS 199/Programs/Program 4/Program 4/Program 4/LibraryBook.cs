//Grading ID: J2089
// CIS 199-01
//Program 4
//Due Date: Dec 3, 2019
// This console application decleares LibraryBook class and one constructor with 5 parameters
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    class LibraryBook
    {

        //private string _title; 
        //private string _author; 
        //private string _publisher;
        //private string _callNumberYear; 
        //private bool _isChecked;

        bool checkedout = false;  // Assume none of the book is checked out
        public const int DEFAULT_COPYRIGHT_YEAR = 2019;  // default copyright year 
        private int _copyrightYear;  //Backing field for the copyright year


        // Precondition:  
        // Postcondition: The LibraryBook object has been initialized with title, author, publisher, copyright,callnum 
                        
        public LibraryBook(string title, string author, string publisher, int copyrightyear, string callnum)
        {
            Title = title;                      // setting the title property
            Author = author;                   // setting the author property
            Publisher = publisher;            // setting the publisher property
            CopyrightYear = copyrightyear;   // setting the copyright property
            CallNumber = callnum;           // setting the callnumber  property


        }

        public string Title
        {

            //Precondition: none
            //Postcondition: The Title is returned 
            get;


            //Precondition: none
            //Postcondition: The Title has been set
            set;
        }
        public string Author
        {
            //Precondition: none
            //Postcondition: The Author has been returned
            get;

            //Precondition: none
            //Postcondition: The Author has been set
            set;
        }

        public string Publisher
        {
            //Precondition: none
            //Postcondition: The Publisher is returned
            get;

            //Precondition: none
            //Postcondition: Publisher has been set
            set;
        }
        public string CallNumber
        {

            //Precondition: none
            //Postcondition: The Call Number has been returned
            get;

            //Precondition: none
            //Postcondition: The Call Number has been set
            set;
        }


        public int CopyrightYear
        {
            get
            {
                //Precondition: none
                //Postcondition: _copyrightYear is returned
                return _copyrightYear;
            }

            // Precondition:  0 <= value < 9999
            // Postcondition: The copyrightyear has been set to the specified value
            set
            {
                if (value >= 0 && value<9999) 
                    _copyrightYear = value;
                else
                    _copyrightYear = DEFAULT_COPYRIGHT_YEAR; // When invalid, set to 2019 instead
            }
                
        }


        //Precondition: None
        //Postcondition: It will change books checked out status to true

        public void CheckOut()
          {
            checkedout = true;
          }


        //Precondition: None
        //Postcondition: It will change books checked out status to false

        public void ReturnToShelf()
         {
            checkedout = false;
         }

        //Precondition: None
        //Postcondition: Returns the current status of the checkout books

        public bool IsCheckedOut()
         {
            return checkedout;
         }


        //Precondition: None
        //Postcondition: Books information has been returned as a formatted string 

        public override string ToString()
        {
            string result; //Builds results in steps

            result = $"Title: {Title}" + Environment.NewLine;
            result += $"Author: {Author}" + Environment.NewLine;
            result += $"Publisher: {Publisher}" + Environment.NewLine;
            result += $"Copyright Year: {CopyrightYear}" + Environment.NewLine;
            result += $"CallNumber: {CallNumber}" + Environment.NewLine;
            result += $"Is the book checked out: {checkedout}" + Environment.NewLine;

            return result;
        }






    }
}
