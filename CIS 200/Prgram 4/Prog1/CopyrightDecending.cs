// Program 4
// CIS 200-01
// Due: 4/15/2020
// Grading ID: T6278
// File: CopyrightDecending.cs
// compares the Library Items by Copyright year and returns in descending order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    class CopyrightDecending : Comparer<LibraryItem>
    {
        // Precondition:  None
        // Postcondition: Reverses natural library items order, so they descending
        //                When LibraryItem1 < LibraryItem2, method returns positive #
        //                When LibraryItem1 == LibraryItem2, method returns zero
        //                When LibraryItem1 > LibraryItem1, method returns negative #                    
        public override int Compare(LibraryItem LibraryItem1, LibraryItem LibraryItem2)
        {
            if (LibraryItem1 == null && LibraryItem2 == null) // Both null?
                return 0;                 // Equal

            if (LibraryItem1 == null) // only t1 is null?
                return -1;  // null is less than any actual time

            if (LibraryItem2 == null) // only t2 is null?
                return 1;   // Any actual time is greater than null

            return (-1) * LibraryItem1.CopyrightYear.CompareTo(LibraryItem2.CopyrightYear); // Reverses natural order, so descending
        }
    }
}
