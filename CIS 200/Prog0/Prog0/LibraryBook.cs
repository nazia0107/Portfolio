//Grading ID: T6278
//CIS 200-01
//Program 0
//Due Date: 1/28/2020
// File: LibraryBook.cs
// This file creates a simple LibraryBook class capable of tracking
// the book's title, author, publisher, copyright year, call number,
// and checked out status.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryBook
{
    public readonly int DEFAULT_YEAR = DateTime.Now.Year; // Default copyright year is current year

    private string _title;      // The book's title
    private string _author;     // The book's author
    private string _publisher;  // The book's publisher
    private int _copyrightYear; // The book's year of copyright
    private string _callNumber; // The book's call number in the library
    private bool _checkedOut;   // The book's checked out status
    private LibraryPatron _patron; // book check out person, LibraryBook class having reference of library patron 

    // Precondition:  theCopyrightYear >= 0
    // Postcondition: The library book has been initialized with the specified
    //                values for title, author, publisher, copyright year, and
    //                call number. The book is not checked out.
    public LibraryBook(String theTitle, String theAuthor, String thePublisher,
        int theCopyrightYear, String theCallNumber)
    {
        Title = theTitle;       //validates title
        Author = theAuthor;     // validates author
        Publisher = thePublisher;    //validates publisher
        CopyrightYear = theCopyrightYear;    //validates copyright year
        CallNumber = theCallNumber; //validates callnumber

        ReturnToShelf(); // Make sure book is not checked out
    }

    public string Title  //the property that gets, validates and sets the title
    {
        // Precondition:  None
        // Postcondition: The title has been returned
        get
        {
            return _title;
        }

        // Precondition:  None
        // Postcondition: The title has been set to the specified value
        set
        {
           
            if (string.IsNullOrWhiteSpace(value)) // checks if null or whitespace 
                throw new ArgumentOutOfRangeException("Title", value, "title must not be empty");
            else
                _title = value.Trim(); // trims and stores if needed
        }
    }

    public string Author   //the property that gets and sets the author
    {
        // Precondition:  None
        // Postcondition: The author has been returned
        get
        {
            return _author;
        }

        // Precondition:  None
        // Postcondition: The author has been set to the specified value
        set
        {
            _author = value;
        }
    }

    public string Publisher  // the property that gets and sets the publisher
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
            _publisher = value;
        }
    }

    public int CopyrightYear  // the property that gets and sets the copyright year
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
                
                throw new ArgumentOutOfRangeException("CopyrightYear", value, " must be >=0");  //copyright year must be greater than zero
           
             
            
        }
    }

    public string CallNumber   //the property that gets and sets the call number
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
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"Enter a valid Call Number {nameof(CallNumber)}");
            }
            _callNumber = value.Trim();
        }
    }



    // Precondition:  None
    // Postcondition: The book is checked out
    public void CheckOut(LibraryPatron patron1)  // using library patron reference 
    {
        _patron = patron1; // when checked out patron name will be populated
        _checkedOut = true;
    }

    // Precondition:  None
    // Postcondition: The book is not checked out
    public void ReturnToShelf()
    {
        _patron = null; // when book is returned patron will be null
        _checkedOut = false;
    }

    // Precondition:  None
    // Postcondition: true is returned if the book is checked out,
    //                otherwise false is returned
    public bool IsCheckedOut()   //when books are checked out checked out status displays 
    {
        return _checkedOut;  // books checked out status 
    }

  

    public LibraryPatron Patron  
    {

        get      // the property that checks if checkedout then return patron
        {
            if(IsCheckedOut())

                return _patron;
            else
                return null;

        }
        
   
}

    // Precondition:  None
    // Postcondition: A string is returned representing the libary book's
    //                data on separate lines
    public override string ToString()  // retun string format of the Librarybook
    {
       
        string NL = Environment.NewLine; // Newline shortcut
        string checkoutBy;
        if (IsCheckedOut())
        {
            checkoutBy = NL + Patron.ToString();
        }
        else checkoutBy = "Not checked out";

        return $"Title: {Title}{NL}Author: {Author}{NL}Publisher: {Publisher}{NL}" +
         $"Copyright: {CopyrightYear}{NL}Call Number: {CallNumber}{NL}" +
        $"Checked Out By: {checkoutBy}";



        

    }
}
