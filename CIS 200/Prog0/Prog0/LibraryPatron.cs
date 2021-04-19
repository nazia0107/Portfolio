//Grading ID: T6278
//CIS 200-01
//Program 0
//Due Date: 1/28/2020
// File: LibraryPatron.cs
// This file creates a simple LibraryPatron class capable of tracking
// the patron's name and ID.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryPatron
{
    private string _patronName; // Name of the patron
    private string _patronID;   // ID of the patron

    // Precondition:  None
    // Postcondition: The patron has been initialized with the specified name
    //                and ID
    public LibraryPatron(string name, string id) //constructor to intialize name and id
    {
        PatronName = name; // validates patronname
        PatronID = id;  // validates id
    }

    public string PatronName  // the property that gets, validates and sets patronname 
    {
        // Precondition:  None
        // Postcondition: The patron's name has been returned
        get
        {
            return _patronName;
        }

        // Precondition:  None
        // Postcondition: The patron's name has been set to the specified value
        set
        {
            if (String.IsNullOrWhiteSpace(value)) // patron name can not be null or contain whitespace, if so throws an exception
            {
                throw new ArgumentOutOfRangeException("PatronName",
                    value, "Patron name must not be empty");
            }
            _patronName = value.Trim();
        }
    }

    public string PatronID // the property that gets, validates and sets patron ID
    {
        // Precondition:  None
        // Postcondition: The patron's ID has been returned
        get
        {
            return _patronID;
        }

        // Precondition:  None
        // Postcondition: The patron's ID has been set to the specified value
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException("PatronID",
                    value, "Patron ID must not be empty"); //throws exception when null or contain whitespace
            }

            _patronID = value.Trim();
        }
    }

    // Precondition:  None
    // Postcondition: A string is returned presenting the libary patron's data on
    //                separate lines
    public override string ToString() //converting to Librarypatron string format
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Name: {PatronName}{NL}ID: {PatronID}";
    }

}

