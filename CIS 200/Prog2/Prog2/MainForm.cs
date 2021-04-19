//Grading ID: T6278
//CIS 200-01
//Program 2
//Due Date: 3/8/2020
//This form diplays a report of  checkout item list, item list, and patron list.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class MainForm : Form
    {
        private Library _lib; // the library
        DialogResult result; //  holds dialog result
        public MainForm()
        {
            InitializeComponent();
            _lib = new Library();  // creates the library  

            //Adding library items
            _lib.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright");
            _lib.AddLibraryBook("Harry Potter", " Bloomsbury Publishing ", 1997, 14,
               "ZZ25 3G", " J. K. Rowling");

            //Adding 2 two LibraryMovie objects to the list
            _lib.AddLibraryMovie("   Andrew's Super-Duper Movie   ", "   UofL Movies   ", 2019, 7,
                "MM33 2D", 92.5, "   Andrew L. Wright   ", LibraryMediaItem.MediaType.BLURAY,
                LibraryMovie.MPAARatings.PG); // Trims?
            _lib.AddLibraryMovie("  Frozen 2 ", "   Disney   ", 2019, 7,
                "MM33 2D", 92.5, "  Jennifer Lee   ", LibraryMediaItem.MediaType.BLURAY,
                LibraryMovie.MPAARatings.PG);

            //Adding 2 two LibraryMusic objects to the list
            _lib.AddLibraryMusic("C# - The Album", "UofL Music", 2020, 14,
                "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
            _lib.AddLibraryMusic("Lover", "Jack Antonoff", 2019, 14,
               "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);

            //Adding 2 two LibraryJournal objects to the list
            _lib.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2018, 14,
                "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
            _lib.AddLibraryJournal("Physics", "UofL Journals", 2018, 14,
                "JJ12 7M", 1, 2, "Science", "XYZ");

            //Adding 2 two LibraryMagazine objects to the list
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2017, 14,
                "MA53 9A", 16, 7);
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2017, 14,
               "MA53 9A", 9, 10);

            // Adding patrons to the patrons list
            _lib.AddPatron("Ima Reader", "12345");
            _lib.AddPatron("Jane Doe", "11223");
            _lib.AddPatron("   John Smith   ", "   654321   "); // Trims?
            _lib.AddPatron("Joe John", "12003");
            _lib.AddPatron("Jake", "60890");
            _lib.AddPatron(" Steve ", "   70623   ");

        }

        // Precondition:  File, About menuItem activated
        // Postcondition: Information about author displayed in dialog box

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Grading ID: T6278\n CIS 200-01\nProgram 2\n Due Date: 03/08/2020");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Precondition:   Patron menuitem activated
        // Postcondition: The patron dialog box is displayed. If data entered
        //                are OK, a patron is created and added to the list
        //                of Patrons
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm Patron = new PatronForm(); //The dialog box form, that interacts with patronm form
            result = Patron.ShowDialog();
            string PatronName;
            string ID;
            if (result == DialogResult.OK)  //// Only update if user chose OK from dialog box
            {
                PatronName = Patron.NameValue;
                ID = Patron.IDValue;
                _lib.AddPatron(PatronName, ID);
            }
        }


        // Precondition:  Book menuItem activated
        // Postcondition: The book dialog box is displayed. If data entered
        //                are OK, a book is created and added to the list
        //                of books    
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm Book = new BookForm(); //  The dialog box form, variable that interacts with book form
            result = Book.ShowDialog();
            string Title; // holds book's title
            string Publisher; // holds book's author
            int LoanPeriod; // holds loan period
            int Copyright; // holds copyright year
            string CallNumber; // holds call number
            string Author; // holds author of the book

            if (result == DialogResult.OK)  // Only update if user chose OK from dialog box
            {
                Title = Book.TitleValue;
                Publisher = Book.PublisherValue;
                Copyright = int.Parse(Book.CopyrightValue);   //Retrieve value from dialog box
                LoanPeriod = int.Parse(Book.LoanPeriodValue);  //Retrieve value from dialog box
                CallNumber = Book.CallNumberValue;
                Author = Book.AuthorValue;
                _lib.AddLibraryBook(Title, Publisher, Copyright, LoanPeriod, CallNumber, Author);
            }
        }


        // Precondition:  None
        // Postcondition: Checkouts the items and updates the mainform.
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sends the items, and patrons list to the checkout subform
            CheckOutForm checkoutForm = new CheckOutForm(_lib._items, _lib._patrons);
            DialogResult result;           //holds the dialog result
            int itemIndx;                 //holds the item index
            int patron;                   //holds the patron index


            result = checkoutForm.ShowDialog();

            if (result == DialogResult.OK)        //  updates when checkout is selected from dialog box
            {
                itemIndx = checkoutForm.ItemIndex;
                patron = checkoutForm.PatronIndex;
                _lib.CheckOut(itemIndx, patron);
                MessageBox.Show("You just checked out a library item!");

            }
        }


        // Precondition:  None
        // Postcondition: Returns items using return form
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {


            ReturnForm retrnForm = new ReturnForm(_lib.GetItemsList());
            DialogResult result;

            result = retrnForm.ShowDialog();

            if (result == DialogResult.OK) // Checks out item based on validated user selection
            {
                _lib.ReturnToShelf(retrnForm.ItemsValue);
                MessageBox.Show("You have returned this library item!");
            }

        }

        // Precondition:  None
        // Postcondition: Displays list of patrons.
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            string results = ""; // Placeholder text
            var patronReport = new StringBuilder(); //stringbuilder that holds the count
            string NL = Environment.NewLine; // Adds a new line

            patronReport.Append($"Patrons: {_lib.GetPatronCount()} Patrons{NL}");

            foreach (var patron in _lib.GetPatronsList())
            {
                results += $"Patron Name: {patron.PatronName} Patron ID:{patron.PatronID}{NL}";
            }
            outputTextBox.Text = patronReport + results;

        }

        // Precondition:  None
        // Postcondition: Displays library items.
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            string results = ""; // Placeholder text
            string NL = Environment.NewLine; // Adds a new line
            var itemReport = new StringBuilder();

            itemReport.Append($"Items: {_lib.GetItemCount()} items {NL}");

            foreach (var item in _lib.GetItemsList())
            {
                results += $"{item}{NL}{NL}";
            }
            outputTextBox.Text = $"{itemReport}" +
                $"{results}{NL}";

        }


        
        // Precondition:  None
        // Postcondition: Displays the list of items that have been checkedout from the library.
        private void checkedOutListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            string results = ""; //Placeholder
            var checkedoutReport = new StringBuilder();
            string NL = Environment.NewLine; // Adds new line
            checkedoutReport.Append($"Checked Out Report :{_lib.GetCheckedOutCount()} items {NL}");

            foreach (var item in _lib._items)
            {
                if (item.IsCheckedOut())
                {
                    results += $"{item}{NL}{NL}";
                }
            }
            outputTextBox.Text = $"{checkedoutReport}" +
                $"{results}{NL}";

        }





    }
}
    

