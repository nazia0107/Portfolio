// Program 4
// CIS 200-01
// Due: 4/15/2020
// Grading ID: T6278
//File: ExtraCredit.cs
// Description: It first sorts Library items by Type, then by Title in ascending order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    class ExtraCredit : Comparer<LibraryItem>
    {
        public override int Compare(LibraryItem LibraryItem1, LibraryItem LibraryItem2)
        {
            // Ensure correct handling of null values (in .NET, null less than anything)
            if (LibraryItem1 == null && LibraryItem2 == null) // Both null?
                return 0;                 // Equal

            if (LibraryItem1 == null) // only LibraryItem1 is null?
                return -1;  // null is less than any actual time

            if (LibraryItem2 == null) // only LibraryItem2 is null?
                return 1;   // Any actual time is greater than null
           
            int type = string.Compare(LibraryItem1.GetType().ToString(), LibraryItem2.GetType().ToString());//Compares the library items if they have the same type

            if (type !=0)  //if library items aren't same type
            {
                return type;
            }
            else
            {
                    return LibraryItem1.Title.CompareTo(LibraryItem2.Title); //sorts the items by Title in ascending order
                
            }

        }


    }
}
